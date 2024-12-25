namespace Tyuiu.OgorodnikDV.Sprint7.V13
{
    partial class FormInfProgram_ODV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfProgram_ODV));
            pictureBoxOgorodnik_ODV = new PictureBox();
            labelOgorodnik_ODV = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOgorodnik_ODV).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxOgorodnik_ODV
            // 
            pictureBoxOgorodnik_ODV.BackColor = Color.White;
            pictureBoxOgorodnik_ODV.Dock = DockStyle.Left;
            pictureBoxOgorodnik_ODV.Image = (Image)resources.GetObject("pictureBoxOgorodnik_ODV.Image");
            pictureBoxOgorodnik_ODV.InitialImage = null;
            pictureBoxOgorodnik_ODV.Location = new Point(0, 0);
            pictureBoxOgorodnik_ODV.Name = "pictureBoxOgorodnik_ODV";
            pictureBoxOgorodnik_ODV.Size = new Size(256, 261);
            pictureBoxOgorodnik_ODV.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxOgorodnik_ODV.TabIndex = 0;
            pictureBoxOgorodnik_ODV.TabStop = false;
            // 
            // labelOgorodnik_ODV
            // 
            labelOgorodnik_ODV.AutoSize = true;
            labelOgorodnik_ODV.Location = new Point(294, 61);
            labelOgorodnik_ODV.Name = "labelOgorodnik_ODV";
            labelOgorodnik_ODV.Size = new Size(303, 105);
            labelOgorodnik_ODV.TabIndex = 1;
            labelOgorodnik_ODV.Text = "Разработчик: Огородник Д.В.\r\nгруппа ИСПб-24-1\r\n\r\nПрограмма разработана в рамках изучения языка С#\r\n\r\nТюменский индустриальный университет (с)2024\r\nВысшая школа цифровых технологий (с)2024";
            // 
            // FormInfProgram_ODV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(634, 261);
            Controls.Add(labelOgorodnik_ODV);
            Controls.Add(pictureBoxOgorodnik_ODV);
            MaximumSize = new Size(650, 350);
            MinimumSize = new Size(650, 300);
            Name = "FormInfProgram_ODV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInfProgram";
            ((System.ComponentModel.ISupportInitialize)pictureBoxOgorodnik_ODV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxOgorodnik_ODV;
        private Label labelOgorodnik_ODV;
    }
}