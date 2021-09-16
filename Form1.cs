using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Sudoku
{
    public partial class Form1 : Form
    {

        const int N = 9;
        public Form1()
        {
            InitializeComponent();

            createCells();
        }

        SudokuCell[,] cells = new SudokuCell[N, N];

        private void createCells()
        {
            // Creates 9x9 grid 
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    cells[i, j] = new SudokuCell();
                    cells[i, j].Size = new Size(50, 50);
                    cells[i, j].Location = new Point(i * 50, j * 50);
                    cells[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 28);
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    cells[i, j].FlatAppearance.BorderColor = Color.Black;
                    cells[i, j].X = i;
                    cells[i, j].Y = j;
                    cells[i, j].KeyPress += cell_KeyPress;
                    panelMain.Controls.Add(cells[i, j]);
                }
            }
        }

        private void cell_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cell = sender as SudokuCell;

            // Check if cell is starting cell, if it is you cant change it.
            if (cell.isLocked)
                return;

            // Check if input is digit
            if (char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar == '0')
                    cell.Clear();
                else
                    cell.Text = e.KeyChar.ToString();

                cell.ForeColor = Color.DimGray;
            }
            else if(e.KeyChar == (char)Keys.Back)
            {
                cell.Clear();
            }
        }

        private void fillCells()
        {
            // Clear all cells
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    cells[i, j].Clear();
                    cells[i, j].Value = 0;
                    cells[i, j].ForeColor = Color.Black;
                    cells[i, j].BackColor = SystemColors.Control;
                }
            }
            // Recursive function call until it finds suitable values for each cell
            findValueForCell(-1, 0);
        }

        Random rnd = new Random();
        private bool findValueForCell(int x, int y)
        {
            // Increment x and y value to move to the next cell
            if(++x > 8)
            {
                x = 0;
                if (++y > 8)
                    return true;
            }

            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int nextNumber;

            // Select random valid number that is left to fill the row and check if it is safe for it to be placed there
            do
            {
                // If there is no more numbers in list, return to previous cell and try with a different number
                if(numbers.Count < 1)
                {
                    cells[x, y].Value = 0;
                    return false;
                }


                // Take a random number from the list and assign it to cell
                nextNumber = numbers[rnd.Next(0, numbers.Count)];
                cells[x, y].Value = nextNumber;
                cells[x, y].Text = nextNumber.ToString();
                // Remove assigned number from the list
                numbers.Remove(nextNumber);

            } while (!isSafe(nextNumber, x, y) || !findValueForCell(x, y));

            return true;
        }

        private bool isSafe(int value, int x, int y)
        {
            for (int i = 0; i < N; i++)
            {
                // Check all cells in vertical direction
                if (i != y && cells[x, i].Value == value) 
                    return false;

                // Check all cells in horizontal direction
                if (i != x && cells[i, y].Value == value)
                    return false;
            }

            // Specific block check
            // Block is allways 3x3 so we substract the remainder of division by 3 from x
            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
                // Same as the function above, but this time we substract the remainder of y
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                    if (i != x && j != y && cells[i, j].Value == value)
                        return false;
            return true;
        }

        private void removeCells(int numberOfCells)
        {
            int removedNumbersCount = 0;
            int valueOfSelectedCell;

            // Create list of all cells
            var allCells = new List<int>();
            for (int i = 0; i < 81; i++)
                allCells.Add(i);

            // Loop until all cells have been checked or enough cells have been removed
            while (allCells.Count != 0)
            {
                if (numberOfCells != removedNumbersCount)
                {
                    // Select random cell and get X and Y values of that cell than remove cell from list
                    int randomCell = allCells[rnd.Next(0, allCells.Count)];
                    int rX = randomCell % 9;
                    int rY = randomCell / 9;
                    allCells.Remove(randomCell);

                    // Save the value of selected cell so we can replace it if we find new solution
                    valueOfSelectedCell = cells[rX, rY].Value;

                    // Clear value from the cell
                    cells[rX, rY].Clear();
                    cells[rX, rY].Value = 0;

                    removedNumbersCount++;

                    // Check if number different than value of previously selected cell can solve sudoku
                    // If it can, than we can not remove that cell because sudoko would be ambiguous
                    // If we find new solution we set value of that cell as it was before.
                    if (isNewSolution(rX, rY, valueOfSelectedCell))
                    {
                        cells[rX, rY].Value = valueOfSelectedCell;
                        cells[rX, rY].Text = valueOfSelectedCell.ToString();
                        removedNumbersCount--;
                    }
                }
                else if (numberOfCells - removedNumbersCount > allCells.Count)
                    break;
                else
                    break;
            }

            // If we cant remove enough cells for selected difficulty, we generate new sudoku
            if (removedNumbersCount < numberOfCells)
            {
                int counter1 = 0;
                foreach (var cell in cells)
                {
                    cell.Value = arrayOfCells[counter1];
                    cell.Text = arrayOfCells[counter1].ToString();
                    counter1++;
                }
                removeCells(numberOfCells);
            }
            else
            {
                foreach (var cell in cells)
                {
                    if (cell.Text != string.Empty)
                    {
                        cell.isLocked = true;
                        cell.BackColor = Color.Silver;
                    }
                }
            }
        }

        private bool solveSudoku()
        {
            // Loop through all cells and check if their value is 0 (not set yet)
            for(int x = 0; x < N; x++)
            {
                for(int y = 0; y < N; y++)
                {
                    if(cells[x, y].Value == 0)
                    {
                        // Loop through all possible sudoku numbers (1-9)
                        for(int number = 1; number <= 9; number++)
                        {
                            // Check if it safe to place number from loop in that cell
                            if (isSafe(number, x, y))
                            {
                                cells[x, y].Value = number;
                                if (solveSudoku())
                                    return true;
                                else
                                {
                                    cells[x, y].Clear();
                                    cells[x, y].Value = 0;
                                }
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }
 
       
        // Function to check if another value can solve sudoku
        private bool isNewSolution(int x, int y, int value)
        {
            for (int number = 1; number <= 9; number++)
                if (number != value)
                    if (isSafe(number, x, y))
                        return true;
            return false;
        }

        // Function to check if sudoku is fully solved
        private bool isGridFull()
        {
            foreach (var cell in cells)
                if (cell.Text == String.Empty)
                    return false;
            return true;
        }

        
        private bool checkResult()
        {
            bool isSolved = true;

            // Check if grid is full
            if (isGridFull())
            {
                // Loop through all cells and check if value of the cell is equal to the number entered by the player
                foreach (var cell in cells)
                {
                    if (cell.Value != Convert.ToInt32(cell.Text))
                    {
                        //cell.Text = string.Empty;
                        cell.ForeColor = Color.Red;
                        isSolved = false;
                    }
                    else
                        cell.isLocked = true;
                }
                if (isSolved)
                {
                    timer1.Enabled = false;
                    stopWatch.Stop();
                    isGameRunning = false;
                    MessageBox.Show("Congratulations, you solved Sudoku in " + stopWatch.Elapsed.Seconds + " seconds!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Sudoku is not solved correctly.", "Sudoku", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Grid is not fully solved.", "Sudoku", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }


        int[] arrayOfCells = new int[81];
        private void saveCellsInArray()
        {
            int counter = 0;
            fillCells();
            foreach (var cell in cells)
            {
                arrayOfCells[counter] = cell.Value;
                counter++;
            }
        }

        Stopwatch stopWatch = new Stopwatch();
        bool isGameRunning = false;
        private void btnGenerateSudoku_Click(object sender, EventArgs e)
        {
            if (!rbSolver.Checked)
            {
                if (!isGameRunning)
                {
                    saveCellsInArray();
                    isGameRunning = true;
                    lblTimeElapsed.Text = "0";
                    hintCounter = 0;
                    int numberOfCells;
                    if (rbExtremelyEasy.Checked)
                        numberOfCells = 33;
                    else if (rbEasy.Checked)
                        numberOfCells = 39;
                    else
                        numberOfCells = 43;
                    removeCells(numberOfCells);
                    solveSudoku();
                }
                else
                {
                    DialogResult dresult = MessageBox.Show("Game is already running. Are you sure you want to start new game?", "Sudoku"
                                , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dresult == DialogResult.OK)
                    {
                        saveCellsInArray();
                        lblTimeElapsed.Text = "0";
                        hintCounter = 0;
                        int numberOfCells;
                        if (rbExtremelyEasy.Checked)
                            numberOfCells = 33;
                        else if (rbEasy.Checked)
                            numberOfCells = 39;
                        else
                            numberOfCells = 43;
                        removeCells(numberOfCells);
                        solveSudoku();
                    }
                }
                timer1.Enabled = true;
                stopWatch.Reset();
                stopWatch.Start();
            }
            else
            {
                foreach (var cell in cells)
                { 
                    if (cell.Text != string.Empty)
                        cell.Value = Convert.ToInt32(cell.Text);
                }
                if (solveSudoku())
                {
                    foreach (var cell in cells)
                        cell.Text = cell.Value.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid sudoku!");
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {   if (isGameRunning)
                checkResult();
            else
                MessageBox.Show("Game is not running yet.", "Sudoku", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public int hintCounter = 0;

        private void btnHint_Click(object sender, EventArgs e)
        {
            if (isGameRunning)
            {
                int x;
                int y;
                if (isGridFull() == false && hintCounter < 3)
                {
                    do
                    {
                        x = rnd.Next(0, 9);
                        y = rnd.Next(0, 9);
                    } while (cells[x, y].Text != string.Empty);
                    cells[x, y].Text = cells[x, y].Value.ToString();
                    cells[x, y].ForeColor = Color.Blue;
                    cells[x, y].isLocked = true;
                    hintCounter++;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string time = String.Format("{0:00}:{1:00}", stopWatch.Elapsed.Minutes, stopWatch.Elapsed.Seconds);
            lblTimeElapsed.Text = time;
        }
    }
}