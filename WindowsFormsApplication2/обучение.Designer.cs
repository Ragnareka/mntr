namespace WindowsFormsApplication2
{
    partial class обучение
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
            this.welcoming = new System.Windows.Forms.Label();
            this.Далее = new System.Windows.Forms.Button();
            this.Пропустить = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcoming
            // 
            this.welcoming.AutoSize = true;
            this.welcoming.Location = new System.Drawing.Point(63, 90);
            this.welcoming.Name = "welcoming";
            this.welcoming.Size = new System.Drawing.Size(379, 102);
            this.welcoming.TabIndex = 0;
            this.welcoming.Text = "Добро Пожаловать\r\n\r\n\r\nПодсказки помогут вам познакомиться с инструментом.\r\nДля сл" +
                "едующей подсказки нажмите \"Далее\", \r\nдля закрытия обучения нажмите \"Пропустить\" " +
                "";
            // 
            // Далее
            // 
            this.Далее.Location = new System.Drawing.Point(88, 268);
            this.Далее.Name = "Далее";
            this.Далее.Size = new System.Drawing.Size(94, 40);
            this.Далее.TabIndex = 1;
            this.Далее.Text = "Далее";
            this.Далее.UseVisualStyleBackColor = true;
            // 
            // Пропустить
            // 
            this.Пропустить.Location = new System.Drawing.Point(348, 268);
            this.Пропустить.Name = "Пропустить";
            this.Пропустить.Size = new System.Drawing.Size(94, 40);
            this.Пропустить.TabIndex = 2;
            this.Пропустить.Text = "Пропустить";
            this.Пропустить.UseVisualStyleBackColor = true;
            // 
            // обучение
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 357);
            this.Controls.Add(this.Пропустить);
            this.Controls.Add(this.Далее);
            this.Controls.Add(this.welcoming);
            this.Name = "обучение";
            this.Text = "обучение";
            this.Load += new System.EventHandler(this.обучение_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcoming;
        private System.Windows.Forms.Button Далее;
        private System.Windows.Forms.Button Пропустить;
    }
}