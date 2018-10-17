namespace Ch14_TS
{
    partial class GuessGame
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.highOrLowLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.newGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(12, 9);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(593, 50);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "I have a number between 1 and 1000--Can you guess my number?\r\nPlease enter your f" +
    "irst guess.";
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(15, 89);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(129, 22);
            this.userInput.TabIndex = 1;
            this.userInput.Text = "Enter # here";
            // 
            // highOrLowLabel
            // 
            this.highOrLowLabel.AutoSize = true;
            this.highOrLowLabel.Location = new System.Drawing.Point(199, 89);
            this.highOrLowLabel.Name = "highOrLowLabel";
            this.highOrLowLabel.Size = new System.Drawing.Size(0, 17);
            this.highOrLowLabel.TabIndex = 2;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(15, 140);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(88, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(288, 140);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // newGame
            // 
            this.newGame.Location = new System.Drawing.Point(497, 140);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(108, 23);
            this.newGame.TabIndex = 5;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // GuessGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(671, 173);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.highOrLowLabel);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.mainLabel);
            this.Name = "GuessGame";
            this.Text = "Guess The Number";
            this.Load += new System.EventHandler(this.GuessGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Label highOrLowLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button newGame;
    }
}

