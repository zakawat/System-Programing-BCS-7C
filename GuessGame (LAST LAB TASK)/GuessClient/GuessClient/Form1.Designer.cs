namespace GuessClient
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
            this.lblServerWelcomeMessage = new System.Windows.Forms.Label();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblGuessQuestion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblServerWelcomeMessage
            // 
            this.lblServerWelcomeMessage.AutoSize = true;
            this.lblServerWelcomeMessage.Location = new System.Drawing.Point(12, 9);
            this.lblServerWelcomeMessage.Name = "lblServerWelcomeMessage";
            this.lblServerWelcomeMessage.Size = new System.Drawing.Size(35, 13);
            this.lblServerWelcomeMessage.TabIndex = 0;
            this.lblServerWelcomeMessage.Text = "label1";
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSendCommand.Location = new System.Drawing.Point(12, 125);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(223, 38);
            this.btnSendCommand.TabIndex = 1;
            this.btnSendCommand.Text = "Send Command";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox1.Location = new System.Drawing.Point(12, 97);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 22);
            this.textBox1.TabIndex = 2;
            // 
            // lblGuessQuestion
            // 
            this.lblGuessQuestion.AutoSize = true;
            this.lblGuessQuestion.Location = new System.Drawing.Point(9, 67);
            this.lblGuessQuestion.Name = "lblGuessQuestion";
            this.lblGuessQuestion.Size = new System.Drawing.Size(35, 13);
            this.lblGuessQuestion.TabIndex = 3;
            this.lblGuessQuestion.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "© 2019 - Syed Zakawat - All Rights Reserved";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 264);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGuessQuestion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSendCommand);
            this.Controls.Add(this.lblServerWelcomeMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServerWelcomeMessage;
        private System.Windows.Forms.Button btnSendCommand;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblGuessQuestion;
        private System.Windows.Forms.Label label1;
    }
}

