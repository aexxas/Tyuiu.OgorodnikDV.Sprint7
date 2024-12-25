namespace Tyuiu.OgorodnikDV.Sprint7.V13
{
    partial class FormFileEDIT_ODV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileEDIT_ODV));
            pictureBoxWorkFile_ODV = new PictureBox();
            labelWorkFile_ODV = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWorkFile_ODV).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxWorkFile_ODV
            // 
            pictureBoxWorkFile_ODV.Dock = DockStyle.Left;
            pictureBoxWorkFile_ODV.Image = (Image)resources.GetObject("pictureBoxWorkFile_ODV.Image");
            pictureBoxWorkFile_ODV.Location = new Point(0, 0);
            pictureBoxWorkFile_ODV.Margin = new Padding(4, 5, 4, 5);
            pictureBoxWorkFile_ODV.Name = "pictureBoxWorkFile_ODV";
            pictureBoxWorkFile_ODV.Size = new Size(375, 638);
            pictureBoxWorkFile_ODV.TabIndex = 0;
            pictureBoxWorkFile_ODV.TabStop = false;
            // 
            // labelWorkFile_ODV
            // 
            labelWorkFile_ODV.AutoSize = true;
            labelWorkFile_ODV.Location = new Point(383, 136);
            labelWorkFile_ODV.Margin = new Padding(4, 0, 4, 0);
            labelWorkFile_ODV.Name = "labelWorkFile_ODV";
            labelWorkFile_ODV.Size = new Size(299, 276);
            labelWorkFile_ODV.TabIndex = 1;
            labelWorkFile_ODV.Text = resources.GetString("labelWorkFile_ODV.Text");
            // 
            // FormFileEDIT_ODV
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 638);
            Controls.Add(labelWorkFile_ODV);
            Controls.Add(pictureBoxWorkFile_ODV);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormFileEDIT_ODV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство по работе c файлом";
            ((System.ComponentModel.ISupportInitialize)pictureBoxWorkFile_ODV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxWorkFile_ODV;
        private Label labelWorkFile_ODV;
    }
}