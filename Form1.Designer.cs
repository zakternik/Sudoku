namespace Sudoku
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblSecondHorizontal = new System.Windows.Forms.Label();
            this.lvlFirstHorizontal = new System.Windows.Forms.Label();
            this.lblSecondVertical = new System.Windows.Forms.Label();
            this.lblFirstVertical = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateSudoku = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.rbExtremelyEasy = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rbSolver = new System.Windows.Forms.RadioButton();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lblSecondHorizontal);
            this.panelMain.Controls.Add(this.lvlFirstHorizontal);
            this.panelMain.Controls.Add(this.lblSecondVertical);
            this.panelMain.Controls.Add(this.lblFirstVertical);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Location = new System.Drawing.Point(12, 32);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(452, 452);
            this.panelMain.TabIndex = 0;
            // 
            // lblSecondHorizontal
            // 
            this.lblSecondHorizontal.BackColor = System.Drawing.Color.Black;
            this.lblSecondHorizontal.Enabled = false;
            this.lblSecondHorizontal.Location = new System.Drawing.Point(0, 298);
            this.lblSecondHorizontal.Name = "lblSecondHorizontal";
            this.lblSecondHorizontal.Size = new System.Drawing.Size(452, 4);
            this.lblSecondHorizontal.TabIndex = 14;
            this.lblSecondHorizontal.Text = "asd";
            // 
            // lvlFirstHorizontal
            // 
            this.lvlFirstHorizontal.BackColor = System.Drawing.Color.Black;
            this.lvlFirstHorizontal.Enabled = false;
            this.lvlFirstHorizontal.Location = new System.Drawing.Point(0, 149);
            this.lvlFirstHorizontal.Name = "lvlFirstHorizontal";
            this.lvlFirstHorizontal.Size = new System.Drawing.Size(452, 4);
            this.lvlFirstHorizontal.TabIndex = 13;
            this.lvlFirstHorizontal.Text = "asd";
            // 
            // lblSecondVertical
            // 
            this.lblSecondVertical.BackColor = System.Drawing.Color.Black;
            this.lblSecondVertical.Enabled = false;
            this.lblSecondVertical.Location = new System.Drawing.Point(298, 0);
            this.lblSecondVertical.Name = "lblSecondVertical";
            this.lblSecondVertical.Size = new System.Drawing.Size(4, 450);
            this.lblSecondVertical.TabIndex = 12;
            this.lblSecondVertical.Text = "asd";
            // 
            // lblFirstVertical
            // 
            this.lblFirstVertical.BackColor = System.Drawing.Color.Black;
            this.lblFirstVertical.Enabled = false;
            this.lblFirstVertical.Location = new System.Drawing.Point(149, 0);
            this.lblFirstVertical.Name = "lblFirstVertical";
            this.lblFirstVertical.Size = new System.Drawing.Size(4, 450);
            this.lblFirstVertical.TabIndex = 11;
            this.lblFirstVertical.Text = "asd";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(448, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(4, 450);
            this.label4.TabIndex = 10;
            this.label4.Text = "asd";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(0, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(4, 450);
            this.label3.TabIndex = 9;
            this.label3.Text = "asd";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 4);
            this.label1.TabIndex = 7;
            this.label1.Text = "asd";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(2, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 4);
            this.label2.TabIndex = 8;
            this.label2.Text = "asd";
            // 
            // btnGenerateSudoku
            // 
            this.btnGenerateSudoku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenerateSudoku.Location = new System.Drawing.Point(186, 490);
            this.btnGenerateSudoku.Name = "btnGenerateSudoku";
            this.btnGenerateSudoku.Size = new System.Drawing.Size(88, 61);
            this.btnGenerateSudoku.TabIndex = 4;
            this.btnGenerateSudoku.Text = "Start";
            this.btnGenerateSudoku.UseVisualStyleBackColor = true;
            this.btnGenerateSudoku.Click += new System.EventHandler(this.btnGenerateSudoku_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCheck.Location = new System.Drawing.Point(374, 490);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(90, 61);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Check ";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnHint
            // 
            this.btnHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHint.Location = new System.Drawing.Point(280, 490);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(88, 61);
            this.btnHint.TabIndex = 10;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimeElapsed.Location = new System.Drawing.Point(211, 8);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(54, 20);
            this.lblTimeElapsed.TabIndex = 11;
            this.lblTimeElapsed.Text = "00:00";
            // 
            // rbExtremelyEasy
            // 
            this.rbExtremelyEasy.AutoSize = true;
            this.rbExtremelyEasy.Checked = true;
            this.rbExtremelyEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbExtremelyEasy.Location = new System.Drawing.Point(12, 490);
            this.rbExtremelyEasy.Name = "rbExtremelyEasy";
            this.rbExtremelyEasy.Size = new System.Drawing.Size(119, 20);
            this.rbExtremelyEasy.TabIndex = 13;
            this.rbExtremelyEasy.TabStop = true;
            this.rbExtremelyEasy.Text = "Extremely Easy";
            this.rbExtremelyEasy.UseVisualStyleBackColor = true;
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbEasy.Location = new System.Drawing.Point(12, 509);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(57, 20);
            this.rbEasy.TabIndex = 14;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbMedium.Location = new System.Drawing.Point(12, 529);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(74, 20);
            this.rbMedium.TabIndex = 15;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rbSolver
            // 
            this.rbSolver.AutoSize = true;
            this.rbSolver.Location = new System.Drawing.Point(13, 9);
            this.rbSolver.Name = "rbSolver";
            this.rbSolver.Size = new System.Drawing.Size(55, 17);
            this.rbSolver.TabIndex = 16;
            this.rbSolver.TabStop = true;
            this.rbSolver.Text = "Solver";
            this.rbSolver.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 561);
            this.Controls.Add(this.rbSolver);
            this.Controls.Add(this.rbMedium);
            this.Controls.Add(this.rbEasy);
            this.Controls.Add(this.rbExtremelyEasy);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnGenerateSudoku);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnGenerateSudoku;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSecondHorizontal;
        private System.Windows.Forms.Label lvlFirstHorizontal;
        private System.Windows.Forms.Label lblSecondVertical;
        private System.Windows.Forms.Label lblFirstVertical;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Label lblTimeElapsed;
        private System.Windows.Forms.RadioButton rbExtremelyEasy;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rbSolver;
    }
}

