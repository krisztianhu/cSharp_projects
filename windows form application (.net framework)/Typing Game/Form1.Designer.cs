namespace Typing_Game
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
            this.correctLbl = new System.Windows.Forms.Label();
            this.incorrectLbl = new System.Windows.Forms.Label();
            this.wordLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // correctLbl
            // 
            this.correctLbl.AutoSize = true;
            this.correctLbl.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.correctLbl.Location = new System.Drawing.Point(12, 9);
            this.correctLbl.Name = "correctLbl";
            this.correctLbl.Size = new System.Drawing.Size(276, 64);
            this.correctLbl.TabIndex = 0;
            this.correctLbl.Text = "Correct : 0";
            // 
            // incorrectLbl
            // 
            this.incorrectLbl.AutoSize = true;
            this.incorrectLbl.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.incorrectLbl.Location = new System.Drawing.Point(356, 9);
            this.incorrectLbl.Name = "incorrectLbl";
            this.incorrectLbl.Size = new System.Drawing.Size(316, 64);
            this.incorrectLbl.TabIndex = 1;
            this.incorrectLbl.Text = "Incorrect : 0";
            // 
            // wordLbl
            // 
            this.wordLbl.AutoSize = true;
            this.wordLbl.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordLbl.Location = new System.Drawing.Point(258, 121);
            this.wordLbl.Name = "wordLbl";
            this.wordLbl.Size = new System.Drawing.Size(153, 59);
            this.wordLbl.TabIndex = 2;
            this.wordLbl.Text = "Word";
            this.wordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(627, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Press Enter to check the text wodt word";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(657, 64);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.checkGame);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wordLbl);
            this.Controls.Add(this.incorrectLbl);
            this.Controls.Add(this.correctLbl);
            this.Name = "Form1";
            this.Text = "Typing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label correctLbl;
        private System.Windows.Forms.Label incorrectLbl;
        private System.Windows.Forms.Label wordLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

