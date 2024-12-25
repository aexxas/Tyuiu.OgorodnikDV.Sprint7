namespace Tyuiu.OgorodnikDV.Sprint7.V13
{
    partial class FormFileChartInf_ODV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileChartInf_ODV));
            pictureBoxWorkFile_ODV = new PictureBox();
            textBoxFileChart_odv = new TextBox();
            groupBoxInfoWfile_ODV = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWorkFile_ODV).BeginInit();
            groupBoxInfoWfile_ODV.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxWorkFile_ODV
            // 
            pictureBoxWorkFile_ODV.Dock = DockStyle.Top;
            pictureBoxWorkFile_ODV.Image = (Image)resources.GetObject("pictureBoxWorkFile_ODV.Image");
            pictureBoxWorkFile_ODV.Location = new Point(0, 0);
            pictureBoxWorkFile_ODV.Margin = new Padding(4, 5, 4, 5);
            pictureBoxWorkFile_ODV.Name = "pictureBoxWorkFile_ODV";
            pictureBoxWorkFile_ODV.Size = new Size(703, 561);
            pictureBoxWorkFile_ODV.TabIndex = 1;
            pictureBoxWorkFile_ODV.TabStop = false;
            // 
            // textBoxFileChart_odv
            // 
            textBoxFileChart_odv.Enabled = false;
            textBoxFileChart_odv.Location = new Point(15, 34);
            textBoxFileChart_odv.Margin = new Padding(4, 5, 4, 5);
            textBoxFileChart_odv.Multiline = true;
            textBoxFileChart_odv.Name = "textBoxFileChart_odv";
            textBoxFileChart_odv.ReadOnly = true;
            textBoxFileChart_odv.Size = new Size(680, 151);
            textBoxFileChart_odv.TabIndex = 0;
            textBoxFileChart_odv.Text = resources.GetString("textBoxFileChart_odv.Text");
            // 
            // groupBoxInfoWfile_ODV
            // 
            groupBoxInfoWfile_ODV.BackColor = Color.White;
            groupBoxInfoWfile_ODV.Controls.Add(textBoxFileChart_odv);
            groupBoxInfoWfile_ODV.Dock = DockStyle.Bottom;
            groupBoxInfoWfile_ODV.Location = new Point(0, 571);
            groupBoxInfoWfile_ODV.Margin = new Padding(4, 5, 4, 5);
            groupBoxInfoWfile_ODV.MinimumSize = new Size(703, 277);
            groupBoxInfoWfile_ODV.Name = "groupBoxInfoWfile_ODV";
            groupBoxInfoWfile_ODV.Padding = new Padding(4, 5, 4, 5);
            groupBoxInfoWfile_ODV.Size = new Size(703, 277);
            groupBoxInfoWfile_ODV.TabIndex = 0;
            groupBoxInfoWfile_ODV.TabStop = false;
            groupBoxInfoWfile_ODV.Text = "Описание";
            // 
            // FormFileChartInf_ODV
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 848);
            Controls.Add(pictureBoxWorkFile_ODV);
            Controls.Add(groupBoxInfoWfile_ODV);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1023, 895);
            MinimumSize = new Size(702, 895);
            Name = "FormFileChartInf_ODV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство по работе с анализом данных";
            ((System.ComponentModel.ISupportInitialize)pictureBoxWorkFile_ODV).EndInit();
            groupBoxInfoWfile_ODV.ResumeLayout(false);
            groupBoxInfoWfile_ODV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBoxWorkFile_ODV;
        private GroupBox groupBox2;
        private TextBox textBoxFileChart_odv;
        private GroupBox groupBoxInfoWfile_ODV;
    }
}