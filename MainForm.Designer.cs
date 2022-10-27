namespace RakiyaTime
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MainText = new System.Windows.Forms.Label();
            this.affirmationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ракиено време ли е?";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(0, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(784, 97);
            this.button3.TabIndex = 0;
            this.button3.Text = "Ракиено време ли е?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainText
            // 
            this.MainText.AutoSize = true;
            this.MainText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainText.Location = new System.Drawing.Point(306, 135);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(65, 28);
            this.MainText.TabIndex = 1;
            this.MainText.Text = "label2";
            // 
            // affirmationLabel
            // 
            this.affirmationLabel.AutoSize = true;
            this.affirmationLabel.Location = new System.Drawing.Point(306, 95);
            this.affirmationLabel.Name = "affirmationLabel";
            this.affirmationLabel.Size = new System.Drawing.Size(125, 20);
            this.affirmationLabel.TabIndex = 2;
            this.affirmationLabel.Text = "Разбира се, че е!";
            this.affirmationLabel.Visible = false;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 447);
            this.Controls.Add(this.affirmationLabel);
            this.Controls.Add(this.MainText);
            this.Controls.Add(this.button3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rakiya Time!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Label MainText;
        private Label affirmationLabel;
    }
}