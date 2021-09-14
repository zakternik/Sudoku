using System.Windows.Forms;

namespace Sudoku
{
    class SudokuCell : Button
    {
        public int Value;
        public bool isLocked;
        public int X;
        public int Y;

        public void Clear()
        {
            this.Text = string.Empty;
            this.isLocked = false;
        }
    }
}
