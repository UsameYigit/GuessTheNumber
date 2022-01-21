
namespace GuessTheNumber
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
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.lblGuessResult = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(130, 111);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 20);
            this.txtGuess.TabIndex = 0;
            this.txtGuess.Visible = false;
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInformation.Location = new System.Drawing.Point(64, 43);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(392, 24);
            this.lblInformation.TabIndex = 1;
            this.lblInformation.Text = "Please put a number between 1 and 100.";
            // 
            // lblGuessResult
            // 
            this.lblGuessResult.AutoSize = true;
            this.lblGuessResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuessResult.Location = new System.Drawing.Point(90, 179);
            this.lblGuessResult.Name = "lblGuessResult";
            this.lblGuessResult.Size = new System.Drawing.Size(0, 20);
            this.lblGuessResult.TabIndex = 2;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(276, 111);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "Start";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 307);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblGuessResult);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.txtGuess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lblGuessResult;
        private System.Windows.Forms.Button btnGuess;
    }
}

