namespace Tyuiu.OgorodnikDV.Sprint7.V13
{
    partial class FormChart_Odv
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChart_Odv));
            panelUpChartt_ODV = new Panel();
            buttonCloseFormChart_ODV = new Button();
            btnLoadFileChart_ODV = new Button();
            button_info_DIagram_ODV = new Button();
            btnAreaChart_ODV = new Button();
            btnPopulationChart_ODV = new Button();
            toolTipChek_ODV = new ToolTip(components);
            openFileDialog_chek_ODV = new OpenFileDialog();
            panel2 = new Panel();
            dataGridView_chart_ODV = new DataGridView();
            splitter1 = new Splitter();
            panelUpChartt_ODV.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_chart_ODV).BeginInit();
            SuspendLayout();
            // 
            // panelUpChartt_ODV
            // 
            panelUpChartt_ODV.BackColor = Color.FromArgb(192, 255, 255);
            panelUpChartt_ODV.Controls.Add(buttonCloseFormChart_ODV);
            panelUpChartt_ODV.Controls.Add(btnLoadFileChart_ODV);
            panelUpChartt_ODV.Controls.Add(button_info_DIagram_ODV);
            panelUpChartt_ODV.Controls.Add(btnAreaChart_ODV);
            panelUpChartt_ODV.Controls.Add(btnPopulationChart_ODV);
            panelUpChartt_ODV.Dock = DockStyle.Top;
            panelUpChartt_ODV.Location = new Point(0, 0);
            panelUpChartt_ODV.Margin = new Padding(4, 5, 4, 5);
            panelUpChartt_ODV.Name = "panelUpChartt_ODV";
            panelUpChartt_ODV.Size = new Size(1446, 204);
            panelUpChartt_ODV.TabIndex = 0;
            panelUpChartt_ODV.Paint += panelUpChartt_ODV_Paint;
            // 
            // buttonCloseFormChart_ODV
            // 
            buttonCloseFormChart_ODV.Cursor = Cursors.Hand;
            buttonCloseFormChart_ODV.Image = (Image)resources.GetObject("buttonCloseFormChart_ODV.Image");
            buttonCloseFormChart_ODV.Location = new Point(809, 75);
            buttonCloseFormChart_ODV.Margin = new Padding(4, 5, 4, 5);
            buttonCloseFormChart_ODV.Name = "buttonCloseFormChart_ODV";
            buttonCloseFormChart_ODV.Size = new Size(89, 86);
            buttonCloseFormChart_ODV.TabIndex = 8;
            toolTipChek_ODV.SetToolTip(buttonCloseFormChart_ODV, "Закрыть форму");
            buttonCloseFormChart_ODV.UseVisualStyleBackColor = true;
            buttonCloseFormChart_ODV.Click += buttonCloseFormChart_ODV_Click;
            // 
            // btnLoadFileChart_ODV
            // 
            btnLoadFileChart_ODV.Cursor = Cursors.Hand;
            btnLoadFileChart_ODV.Image = (Image)resources.GetObject("btnLoadFileChart_ODV.Image");
            btnLoadFileChart_ODV.Location = new Point(32, 48);
            btnLoadFileChart_ODV.Margin = new Padding(4, 5, 4, 5);
            btnLoadFileChart_ODV.Name = "btnLoadFileChart_ODV";
            btnLoadFileChart_ODV.Size = new Size(93, 89);
            btnLoadFileChart_ODV.TabIndex = 7;
            toolTipChek_ODV.SetToolTip(btnLoadFileChart_ODV, "Загрузить файл");
            btnLoadFileChart_ODV.UseVisualStyleBackColor = true;
            btnLoadFileChart_ODV.Click += btnLoadFileChart_ODV_Click_1;
            // 
            // button_info_DIagram_ODV
            // 
            button_info_DIagram_ODV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_info_DIagram_ODV.Cursor = Cursors.Help;
            button_info_DIagram_ODV.Image = (Image)resources.GetObject("button_info_DIagram_ODV.Image");
            button_info_DIagram_ODV.Location = new Point(1342, 48);
            button_info_DIagram_ODV.Margin = new Padding(4, 5, 4, 5);
            button_info_DIagram_ODV.Name = "button_info_DIagram_ODV";
            button_info_DIagram_ODV.Size = new Size(89, 86);
            button_info_DIagram_ODV.TabIndex = 6;
            toolTipChek_ODV.SetToolTip(button_info_DIagram_ODV, "Руководство по работе на форме");
            button_info_DIagram_ODV.UseVisualStyleBackColor = true;
            button_info_DIagram_ODV.Click += button_info_DIagram_ODV_Click;
            // 
            // btnAreaChart_ODV
            // 
            btnAreaChart_ODV.Cursor = Cursors.Hand;
            btnAreaChart_ODV.Image = (Image)resources.GetObject("btnAreaChart_ODV.Image");
            btnAreaChart_ODV.Location = new Point(712, 75);
            btnAreaChart_ODV.Margin = new Padding(4, 5, 4, 5);
            btnAreaChart_ODV.Name = "btnAreaChart_ODV";
            btnAreaChart_ODV.Size = new Size(89, 86);
            btnAreaChart_ODV.TabIndex = 1;
            toolTipChek_ODV.SetToolTip(btnAreaChart_ODV, "Гистограмма по площади");
            btnAreaChart_ODV.UseVisualStyleBackColor = true;
            btnAreaChart_ODV.Click += btnAreaChart_ODV_Click_1;
            // 
            // btnPopulationChart_ODV
            // 
            btnPopulationChart_ODV.Cursor = Cursors.Hand;
            btnPopulationChart_ODV.Image = (Image)resources.GetObject("btnPopulationChart_ODV.Image");
            btnPopulationChart_ODV.Location = new Point(616, 75);
            btnPopulationChart_ODV.Margin = new Padding(4, 5, 4, 5);
            btnPopulationChart_ODV.Name = "btnPopulationChart_ODV";
            btnPopulationChart_ODV.Size = new Size(89, 86);
            btnPopulationChart_ODV.TabIndex = 0;
            toolTipChek_ODV.SetToolTip(btnPopulationChart_ODV, "Гистограмма по населению");
            btnPopulationChart_ODV.UseVisualStyleBackColor = true;
            btnPopulationChart_ODV.Click += btnPopulationChart_ODV_Click_1;
            // 
            // toolTipChek_ODV
            // 
            toolTipChek_ODV.IsBalloon = true;
            toolTipChek_ODV.ToolTipIcon = ToolTipIcon.Info;
            // 
            // openFileDialog_chek_ODV
            // 
            openFileDialog_chek_ODV.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(dataGridView_chart_ODV);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 204);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(752, 644);
            panel2.TabIndex = 1;
            // 
            // dataGridView_chart_ODV
            // 
            dataGridView_chart_ODV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_chart_ODV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_chart_ODV.BackgroundColor = Color.FromArgb(192, 255, 255);
            dataGridView_chart_ODV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_chart_ODV.Location = new Point(0, 0);
            dataGridView_chart_ODV.Margin = new Padding(4, 5, 4, 5);
            dataGridView_chart_ODV.Name = "dataGridView_chart_ODV";
            dataGridView_chart_ODV.ReadOnly = true;
            dataGridView_chart_ODV.RowHeadersVisible = false;
            dataGridView_chart_ODV.RowHeadersWidth = 51;
            dataGridView_chart_ODV.Size = new Size(752, 644);
            dataGridView_chart_ODV.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(752, 204);
            splitter1.Margin = new Padding(4, 5, 4, 5);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(13, 644);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // FormChart_Odv
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1446, 848);
            Controls.Add(splitter1);
            Controls.Add(panel2);
            Controls.Add(panelUpChartt_ODV);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1538, 895);
            MinimumSize = new Size(1281, 895);
            Name = "FormChart_Odv";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Анализ данных";
            Load += FormChart_Odv_Load;
            panelUpChartt_ODV.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_chart_ODV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUpChartt_ODV;
        private ToolTip toolTipChek_ODV;
        private OpenFileDialog openFileDialog_chek_ODV;
        private Panel panel2;
        private Splitter splitter1;
        private Button btnPopulationChart_ODV;
        private DataGridView dataGridView_chart_ODV;
        private Button btnAreaChart_ODV;
        private Button button_info_DIagram_ODV;
        private Button btnLoadFileChart_ODV;
        private Button buttonCloseFormChart_ODV;
    }
}