namespace Tyuiu.OgorodnikDV.Sprint7.V13
{
    partial class FormInfMain_ODV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfMain_ODV));
            groupBoxInfoMain_ODV = new GroupBox();
            textBoxInfoMain_ODV = new TextBox();
            pictureBoxInfMain_ODV = new PictureBox();
            groupBoxInfoMain_ODV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfMain_ODV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInfoMain_ODV
            // 
            groupBoxInfoMain_ODV.Controls.Add(textBoxInfoMain_ODV);
            groupBoxInfoMain_ODV.Dock = DockStyle.Bottom;
            groupBoxInfoMain_ODV.Location = new Point(0, 282);
            groupBoxInfoMain_ODV.Margin = new Padding(4, 5, 4, 5);
            groupBoxInfoMain_ODV.Name = "groupBoxInfoMain_ODV";
            groupBoxInfoMain_ODV.Padding = new Padding(4, 5, 4, 5);
            groupBoxInfoMain_ODV.Size = new Size(652, 259);
            groupBoxInfoMain_ODV.TabIndex = 0;
            groupBoxInfoMain_ODV.TabStop = false;
            groupBoxInfoMain_ODV.Text = "Описание";
            // 
            // textBoxInfoMain_ODV
            // 
            textBoxInfoMain_ODV.Enabled = false;
            textBoxInfoMain_ODV.Location = new Point(15, 34);
            textBoxInfoMain_ODV.Margin = new Padding(4, 5, 4, 5);
            textBoxInfoMain_ODV.Multiline = true;
            textBoxInfoMain_ODV.Name = "textBoxInfoMain_ODV";
            textBoxInfoMain_ODV.ReadOnly = true;
            textBoxInfoMain_ODV.Size = new Size(622, 214);
            textBoxInfoMain_ODV.TabIndex = 0;
            textBoxInfoMain_ODV.Text = resources.GetString("textBoxInfoMain_ODV.Text");
            // 
            // pictureBoxInfMain_ODV
            // 
            pictureBoxInfMain_ODV.Dock = DockStyle.Fill;
            pictureBoxInfMain_ODV.Image = (Image)resources.GetObject("pictureBoxInfMain_ODV.Image");
            pictureBoxInfMain_ODV.Location = new Point(0, 0);
            pictureBoxInfMain_ODV.Margin = new Padding(4, 5, 4, 5);
            pictureBoxInfMain_ODV.Name = "pictureBoxInfMain_ODV";
            pictureBoxInfMain_ODV.Size = new Size(652, 282);
            pictureBoxInfMain_ODV.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxInfMain_ODV.TabIndex = 1;
            pictureBoxInfMain_ODV.TabStop = false;
            // 
            // FormInfMain_ODV
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 541);
            Controls.Add(pictureBoxInfMain_ODV);
            Controls.Add(groupBoxInfoMain_ODV);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(670, 588);
            MinimumSize = new Size(670, 588);
            Name = "FormInfMain_ODV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство по работе на главной";
            groupBoxInfoMain_ODV.ResumeLayout(false);
            groupBoxInfoMain_ODV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfMain_ODV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxInfoMain_ODV;
        private PictureBox pictureBoxInfMain_ODV;
        private TextBox textBoxInfoMain_ODV;
    }
}