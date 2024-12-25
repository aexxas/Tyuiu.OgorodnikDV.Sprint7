namespace Tyuiu.OgorodnikDV.Sprint7.V13
{
    partial class FormMain_ODV
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_ODV));
            menuStrip_MAIN_odv = new MenuStrip();
            работаСДаннымиToolStripMenuItem = new ToolStripMenuItem();
            загпрузитьФайлToolStripMenuItem_ODV = new ToolStripMenuItem();
            РаботаСфайломToolStripMenuItem_odv = new ToolStripMenuItem();
            выходToolStripMenuItem_ODV = new ToolStripMenuItem();
            анализДанныхToolStripMenuItem_ODV = new ToolStripMenuItem();
            руководствоToolStripMenuItem_ODV = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem_ODV = new ToolStripMenuItem();
            panel1 = new Panel();
            groupBox_Info_Data_ODV = new GroupBox();
            button_info_EditFail_ODV = new Button();
            button_info_DIagram_ODV = new Button();
            button_info_WorkInProgr_ODV = new Button();
            groupBox_filter_sq_ODV = new GroupBox();
            buttonFilterByArea_ODV = new Button();
            textBoxMinArea_ODV = new TextBox();
            groupBox_SR_POPUL_ODV = new GroupBox();
            textBoxResultSr_ODV = new TextBox();
            buttonCalculateAveragePopulation_ODV = new Button();
            groupBox_Filter_popul_ODV = new GroupBox();
            buttonSortByPopulationDesc_ODV = new Button();
            buttonSortByPopulationAsc_ODV = new Button();
            groupBoxMain_ODV = new GroupBox();
            button_search_ODV = new Button();
            textBoxSearch_ODV = new TextBox();
            labelFilt_sq_ODV = new Label();
            textBox2 = new TextBox();
            panel2 = new Panel();
            dataGridViewCountries_ODV = new DataGridView();
            splitter1 = new Splitter();
            buttonFilt_sq_ODV = new Button();
            toolTip_mainform_ODV = new ToolTip(components);
            menuStrip_MAIN_odv.SuspendLayout();
            panel1.SuspendLayout();
            groupBox_Info_Data_ODV.SuspendLayout();
            groupBox_filter_sq_ODV.SuspendLayout();
            groupBox_SR_POPUL_ODV.SuspendLayout();
            groupBox_Filter_popul_ODV.SuspendLayout();
            groupBoxMain_ODV.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountries_ODV).BeginInit();
            SuspendLayout();
            // 
            // menuStrip_MAIN_odv
            // 
            menuStrip_MAIN_odv.BackColor = Color.FromArgb(192, 255, 255);
            menuStrip_MAIN_odv.ImageScalingSize = new Size(20, 20);
            menuStrip_MAIN_odv.Items.AddRange(new ToolStripItem[] { работаСДаннымиToolStripMenuItem, анализДанныхToolStripMenuItem_ODV, руководствоToolStripMenuItem_ODV });
            menuStrip_MAIN_odv.Location = new Point(0, 0);
            menuStrip_MAIN_odv.Name = "menuStrip_MAIN_odv";
            menuStrip_MAIN_odv.Padding = new Padding(8, 3, 0, 3);
            menuStrip_MAIN_odv.Size = new Size(1350, 33);
            menuStrip_MAIN_odv.TabIndex = 0;
            menuStrip_MAIN_odv.Text = "menuStrip1";
            // 
            // работаСДаннымиToolStripMenuItem
            // 
            работаСДаннымиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { загпрузитьФайлToolStripMenuItem_ODV, РаботаСфайломToolStripMenuItem_odv, выходToolStripMenuItem_ODV });
            работаСДаннымиToolStripMenuItem.Name = "работаСДаннымиToolStripMenuItem";
            работаСДаннымиToolStripMenuItem.Size = new Size(115, 27);
            работаСДаннымиToolStripMenuItem.Text = "Программа";
            // 
            // загпрузитьФайлToolStripMenuItem_ODV
            // 
            загпрузитьФайлToolStripMenuItem_ODV.Name = "загпрузитьФайлToolStripMenuItem_ODV";
            загпрузитьФайлToolStripMenuItem_ODV.Size = new Size(229, 28);
            загпрузитьФайлToolStripMenuItem_ODV.Text = "Загрузить файл";
            загпрузитьФайлToolStripMenuItem_ODV.Click += загпрузитьФайлToolStripMenuItem_ODV_Click;
            // 
            // РаботаСфайломToolStripMenuItem_odv
            // 
            РаботаСфайломToolStripMenuItem_odv.Name = "РаботаСфайломToolStripMenuItem_odv";
            РаботаСфайломToolStripMenuItem_odv.Size = new Size(229, 28);
            РаботаСфайломToolStripMenuItem_odv.Text = "Работа с файлом";
            РаботаСфайломToolStripMenuItem_odv.Click += РаботаСфайломToolStripMenuItem_odv_Click;
            // 
            // выходToolStripMenuItem_ODV
            // 
            выходToolStripMenuItem_ODV.Name = "выходToolStripMenuItem_ODV";
            выходToolStripMenuItem_ODV.Size = new Size(229, 28);
            выходToolStripMenuItem_ODV.Text = "Выход";
            выходToolStripMenuItem_ODV.Click += выходToolStripMenuItem_ODV_Click;
            // 
            // анализДанныхToolStripMenuItem_ODV
            // 
            анализДанныхToolStripMenuItem_ODV.Name = "анализДанныхToolStripMenuItem_ODV";
            анализДанныхToolStripMenuItem_ODV.Size = new Size(144, 27);
            анализДанныхToolStripMenuItem_ODV.Text = "Анализ данных";
            анализДанныхToolStripMenuItem_ODV.Click += анализДанныхToolStripMenuItem_ODV_Click;
            // 
            // руководствоToolStripMenuItem_ODV
            // 
            руководствоToolStripMenuItem_ODV.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem_ODV });
            руководствоToolStripMenuItem_ODV.Name = "руководствоToolStripMenuItem_ODV";
            руководствоToolStripMenuItem_ODV.Size = new Size(122, 27);
            руководствоToolStripMenuItem_ODV.Text = "Руководство";
            // 
            // оПрограммеToolStripMenuItem_ODV
            // 
            оПрограммеToolStripMenuItem_ODV.Name = "оПрограммеToolStripMenuItem_ODV";
            оПрограммеToolStripMenuItem_ODV.Size = new Size(201, 28);
            оПрограммеToolStripMenuItem_ODV.Text = "О программе";
            оПрограммеToolStripMenuItem_ODV.Click += оПрограммеToolStripMenuItem_ODV_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(groupBox_Info_Data_ODV);
            panel1.Controls.Add(groupBox_filter_sq_ODV);
            panel1.Controls.Add(groupBox_SR_POPUL_ODV);
            panel1.Controls.Add(groupBox_Filter_popul_ODV);
            panel1.Controls.Add(groupBoxMain_ODV);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 33);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 772);
            panel1.TabIndex = 1;
            // 
            // groupBox_Info_Data_ODV
            // 
            groupBox_Info_Data_ODV.Controls.Add(button_info_EditFail_ODV);
            groupBox_Info_Data_ODV.Controls.Add(button_info_DIagram_ODV);
            groupBox_Info_Data_ODV.Controls.Add(button_info_WorkInProgr_ODV);
            groupBox_Info_Data_ODV.Dock = DockStyle.Bottom;
            groupBox_Info_Data_ODV.Location = new Point(0, 632);
            groupBox_Info_Data_ODV.Margin = new Padding(4, 5, 4, 5);
            groupBox_Info_Data_ODV.Name = "groupBox_Info_Data_ODV";
            groupBox_Info_Data_ODV.Padding = new Padding(4, 5, 4, 5);
            groupBox_Info_Data_ODV.Size = new Size(374, 140);
            groupBox_Info_Data_ODV.TabIndex = 5;
            groupBox_Info_Data_ODV.TabStop = false;
            groupBox_Info_Data_ODV.Text = "Руководтсво";
            // 
            // button_info_EditFail_ODV
            // 
            button_info_EditFail_ODV.Cursor = Cursors.Help;
            button_info_EditFail_ODV.Image = (Image)resources.GetObject("button_info_EditFail_ODV.Image");
            button_info_EditFail_ODV.Location = new Point(252, 34);
            button_info_EditFail_ODV.Margin = new Padding(4, 5, 4, 5);
            button_info_EditFail_ODV.Name = "button_info_EditFail_ODV";
            button_info_EditFail_ODV.Size = new Size(93, 89);
            button_info_EditFail_ODV.TabIndex = 6;
            toolTip_mainform_ODV.SetToolTip(button_info_EditFail_ODV, "Работа с файлом");
            button_info_EditFail_ODV.UseVisualStyleBackColor = true;
            button_info_EditFail_ODV.Click += button_info_EditFail_ODV_Click;
            // 
            // button_info_DIagram_ODV
            // 
            button_info_DIagram_ODV.Cursor = Cursors.Help;
            button_info_DIagram_ODV.Image = (Image)resources.GetObject("button_info_DIagram_ODV.Image");
            button_info_DIagram_ODV.Location = new Point(144, 32);
            button_info_DIagram_ODV.Margin = new Padding(4, 5, 4, 5);
            button_info_DIagram_ODV.Name = "button_info_DIagram_ODV";
            button_info_DIagram_ODV.Size = new Size(93, 89);
            button_info_DIagram_ODV.TabIndex = 5;
            toolTip_mainform_ODV.SetToolTip(button_info_DIagram_ODV, "Анализ данных");
            button_info_DIagram_ODV.UseVisualStyleBackColor = true;
            button_info_DIagram_ODV.Click += button_info_DIagram_ODV_Click;
            // 
            // button_info_WorkInProgr_ODV
            // 
            button_info_WorkInProgr_ODV.Cursor = Cursors.Help;
            button_info_WorkInProgr_ODV.Image = (Image)resources.GetObject("button_info_WorkInProgr_ODV.Image");
            button_info_WorkInProgr_ODV.Location = new Point(35, 32);
            button_info_WorkInProgr_ODV.Margin = new Padding(4, 5, 4, 5);
            button_info_WorkInProgr_ODV.Name = "button_info_WorkInProgr_ODV";
            button_info_WorkInProgr_ODV.Size = new Size(93, 89);
            button_info_WorkInProgr_ODV.TabIndex = 4;
            toolTip_mainform_ODV.SetToolTip(button_info_WorkInProgr_ODV, "Работа с данными");
            button_info_WorkInProgr_ODV.UseVisualStyleBackColor = true;
            button_info_WorkInProgr_ODV.Click += button_info_WorkInProgr_ODV_Click;
            // 
            // groupBox_filter_sq_ODV
            // 
            groupBox_filter_sq_ODV.Controls.Add(buttonFilterByArea_ODV);
            groupBox_filter_sq_ODV.Controls.Add(textBoxMinArea_ODV);
            groupBox_filter_sq_ODV.Location = new Point(15, 121);
            groupBox_filter_sq_ODV.Margin = new Padding(4, 5, 4, 5);
            groupBox_filter_sq_ODV.Name = "groupBox_filter_sq_ODV";
            groupBox_filter_sq_ODV.Padding = new Padding(4, 5, 4, 5);
            groupBox_filter_sq_ODV.Size = new Size(351, 158);
            groupBox_filter_sq_ODV.TabIndex = 4;
            groupBox_filter_sq_ODV.TabStop = false;
            groupBox_filter_sq_ODV.Text = "Фильтрация по площади";
            // 
            // buttonFilterByArea_ODV
            // 
            buttonFilterByArea_ODV.Cursor = Cursors.Hand;
            buttonFilterByArea_ODV.Enabled = false;
            buttonFilterByArea_ODV.Image = (Image)resources.GetObject("buttonFilterByArea_ODV.Image");
            buttonFilterByArea_ODV.Location = new Point(257, 43);
            buttonFilterByArea_ODV.Margin = new Padding(4, 5, 4, 5);
            buttonFilterByArea_ODV.Name = "buttonFilterByArea_ODV";
            buttonFilterByArea_ODV.Size = new Size(72, 75);
            buttonFilterByArea_ODV.TabIndex = 2;
            toolTip_mainform_ODV.SetToolTip(buttonFilterByArea_ODV, "Выполнить фильтрацию");
            buttonFilterByArea_ODV.UseVisualStyleBackColor = true;
            buttonFilterByArea_ODV.Click += buttonFilterByArea_ODV_Click;
            // 
            // textBoxMinArea_ODV
            // 
            textBoxMinArea_ODV.Anchor = AnchorStyles.None;
            textBoxMinArea_ODV.Enabled = false;
            textBoxMinArea_ODV.Location = new Point(31, 66);
            textBoxMinArea_ODV.Margin = new Padding(4, 5, 4, 5);
            textBoxMinArea_ODV.Name = "textBoxMinArea_ODV";
            textBoxMinArea_ODV.Size = new Size(189, 30);
            textBoxMinArea_ODV.TabIndex = 2;
            toolTip_mainform_ODV.SetToolTip(textBoxMinArea_ODV, "Введите минимальную площадь");
            // 
            // groupBox_SR_POPUL_ODV
            // 
            groupBox_SR_POPUL_ODV.Controls.Add(textBoxResultSr_ODV);
            groupBox_SR_POPUL_ODV.Controls.Add(buttonCalculateAveragePopulation_ODV);
            groupBox_SR_POPUL_ODV.Location = new Point(15, 288);
            groupBox_SR_POPUL_ODV.Margin = new Padding(4, 5, 4, 5);
            groupBox_SR_POPUL_ODV.Name = "groupBox_SR_POPUL_ODV";
            groupBox_SR_POPUL_ODV.Padding = new Padding(4, 5, 4, 5);
            groupBox_SR_POPUL_ODV.Size = new Size(351, 153);
            groupBox_SR_POPUL_ODV.TabIndex = 3;
            groupBox_SR_POPUL_ODV.TabStop = false;
            groupBox_SR_POPUL_ODV.Text = "Вычесление среднего населения";
            // 
            // textBoxResultSr_ODV
            // 
            textBoxResultSr_ODV.Enabled = false;
            textBoxResultSr_ODV.Location = new Point(31, 72);
            textBoxResultSr_ODV.Margin = new Padding(4, 5, 4, 5);
            textBoxResultSr_ODV.Name = "textBoxResultSr_ODV";
            textBoxResultSr_ODV.ReadOnly = true;
            textBoxResultSr_ODV.Size = new Size(189, 30);
            textBoxResultSr_ODV.TabIndex = 7;
            // 
            // buttonCalculateAveragePopulation_ODV
            // 
            buttonCalculateAveragePopulation_ODV.Cursor = Cursors.Hand;
            buttonCalculateAveragePopulation_ODV.Enabled = false;
            buttonCalculateAveragePopulation_ODV.Image = (Image)resources.GetObject("buttonCalculateAveragePopulation_ODV.Image");
            buttonCalculateAveragePopulation_ODV.Location = new Point(257, 52);
            buttonCalculateAveragePopulation_ODV.Margin = new Padding(4, 5, 4, 5);
            buttonCalculateAveragePopulation_ODV.Name = "buttonCalculateAveragePopulation_ODV";
            buttonCalculateAveragePopulation_ODV.Size = new Size(69, 72);
            buttonCalculateAveragePopulation_ODV.TabIndex = 4;
            toolTip_mainform_ODV.SetToolTip(buttonCalculateAveragePopulation_ODV, "Выполнить вычесление");
            buttonCalculateAveragePopulation_ODV.UseVisualStyleBackColor = true;
            buttonCalculateAveragePopulation_ODV.Click += buttonCalculateAveragePopulation_ODV_Click;
            // 
            // groupBox_Filter_popul_ODV
            // 
            groupBox_Filter_popul_ODV.Controls.Add(buttonSortByPopulationDesc_ODV);
            groupBox_Filter_popul_ODV.Controls.Add(buttonSortByPopulationAsc_ODV);
            groupBox_Filter_popul_ODV.Location = new Point(15, 451);
            groupBox_Filter_popul_ODV.Margin = new Padding(4, 5, 4, 5);
            groupBox_Filter_popul_ODV.Name = "groupBox_Filter_popul_ODV";
            groupBox_Filter_popul_ODV.Padding = new Padding(4, 5, 4, 5);
            groupBox_Filter_popul_ODV.Size = new Size(351, 167);
            groupBox_Filter_popul_ODV.TabIndex = 2;
            groupBox_Filter_popul_ODV.TabStop = false;
            groupBox_Filter_popul_ODV.Text = "Фильтрация по населению";
            // 
            // buttonSortByPopulationDesc_ODV
            // 
            buttonSortByPopulationDesc_ODV.Cursor = Cursors.Hand;
            buttonSortByPopulationDesc_ODV.Enabled = false;
            buttonSortByPopulationDesc_ODV.Image = (Image)resources.GetObject("buttonSortByPopulationDesc_ODV.Image");
            buttonSortByPopulationDesc_ODV.Location = new Point(64, 54);
            buttonSortByPopulationDesc_ODV.Margin = new Padding(4, 5, 4, 5);
            buttonSortByPopulationDesc_ODV.Name = "buttonSortByPopulationDesc_ODV";
            buttonSortByPopulationDesc_ODV.Size = new Size(93, 89);
            buttonSortByPopulationDesc_ODV.TabIndex = 3;
            toolTip_mainform_ODV.SetToolTip(buttonSortByPopulationDesc_ODV, "Выполнить фильтрацию по убыванию");
            buttonSortByPopulationDesc_ODV.UseVisualStyleBackColor = true;
            buttonSortByPopulationDesc_ODV.Click += buttonSortByPopulationDesc_ODV_Click;
            // 
            // buttonSortByPopulationAsc_ODV
            // 
            buttonSortByPopulationAsc_ODV.Cursor = Cursors.Hand;
            buttonSortByPopulationAsc_ODV.Enabled = false;
            buttonSortByPopulationAsc_ODV.Image = (Image)resources.GetObject("buttonSortByPopulationAsc_ODV.Image");
            buttonSortByPopulationAsc_ODV.Location = new Point(183, 54);
            buttonSortByPopulationAsc_ODV.Margin = new Padding(4, 5, 4, 5);
            buttonSortByPopulationAsc_ODV.Name = "buttonSortByPopulationAsc_ODV";
            buttonSortByPopulationAsc_ODV.Size = new Size(93, 89);
            buttonSortByPopulationAsc_ODV.TabIndex = 2;
            toolTip_mainform_ODV.SetToolTip(buttonSortByPopulationAsc_ODV, "Вычислить фильтрацию по возрастанию ");
            buttonSortByPopulationAsc_ODV.UseVisualStyleBackColor = true;
            buttonSortByPopulationAsc_ODV.Click += buttonSortByPopulationAsc_ODV_Click;
            // 
            // groupBoxMain_ODV
            // 
            groupBoxMain_ODV.Controls.Add(button_search_ODV);
            groupBoxMain_ODV.Controls.Add(textBoxSearch_ODV);
            groupBoxMain_ODV.Location = new Point(18, 0);
            groupBoxMain_ODV.Margin = new Padding(6, 8, 6, 8);
            groupBoxMain_ODV.Name = "groupBoxMain_ODV";
            groupBoxMain_ODV.Padding = new Padding(4, 5, 4, 5);
            groupBoxMain_ODV.Size = new Size(350, 109);
            groupBoxMain_ODV.TabIndex = 0;
            groupBoxMain_ODV.TabStop = false;
            groupBoxMain_ODV.Text = "Поиск";
            // 
            // button_search_ODV
            // 
            button_search_ODV.Cursor = Cursors.Hand;
            button_search_ODV.Enabled = false;
            button_search_ODV.Image = (Image)resources.GetObject("button_search_ODV.Image");
            button_search_ODV.Location = new Point(255, 25);
            button_search_ODV.Margin = new Padding(4, 5, 4, 5);
            button_search_ODV.Name = "button_search_ODV";
            button_search_ODV.Size = new Size(72, 75);
            button_search_ODV.TabIndex = 1;
            toolTip_mainform_ODV.SetToolTip(button_search_ODV, "Выполнить поиск");
            button_search_ODV.UseVisualStyleBackColor = true;
            button_search_ODV.Click += button_search_ODV_Click;
            // 
            // textBoxSearch_ODV
            // 
            textBoxSearch_ODV.Enabled = false;
            textBoxSearch_ODV.Location = new Point(28, 48);
            textBoxSearch_ODV.Margin = new Padding(4, 5, 4, 5);
            textBoxSearch_ODV.Name = "textBoxSearch_ODV";
            textBoxSearch_ODV.Size = new Size(189, 30);
            textBoxSearch_ODV.TabIndex = 0;
            toolTip_mainform_ODV.SetToolTip(textBoxSearch_ODV, "Введите страну");
            // 
            // labelFilt_sq_ODV
            // 
            labelFilt_sq_ODV.AutoSize = true;
            labelFilt_sq_ODV.Location = new Point(8, 48);
            labelFilt_sq_ODV.Name = "labelFilt_sq_ODV";
            labelFilt_sq_ODV.Size = new Size(91, 15);
            labelFilt_sq_ODV.TabIndex = 6;
            labelFilt_sq_ODV.Text = "Мин. площадь:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(76, 30);
            textBox2.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridViewCountries_ODV);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(374, 33);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(976, 772);
            panel2.TabIndex = 2;
            // 
            // dataGridViewCountries_ODV
            // 
            dataGridViewCountries_ODV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCountries_ODV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCountries_ODV.BackgroundColor = Color.FromArgb(192, 255, 255);
            dataGridViewCountries_ODV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCountries_ODV.Location = new Point(0, 0);
            dataGridViewCountries_ODV.Margin = new Padding(4, 5, 4, 5);
            dataGridViewCountries_ODV.Name = "dataGridViewCountries_ODV";
            dataGridViewCountries_ODV.ReadOnly = true;
            dataGridViewCountries_ODV.RowHeadersVisible = false;
            dataGridViewCountries_ODV.RowHeadersWidth = 51;
            dataGridViewCountries_ODV.Size = new Size(976, 772);
            dataGridViewCountries_ODV.TabIndex = 0;
            dataGridViewCountries_ODV.CellContentClick += dataGridViewCountries_ODV_CellContentClick;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(374, 33);
            splitter1.Margin = new Padding(4, 5, 4, 5);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 772);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // buttonFilt_sq_ODV
            // 
            buttonFilt_sq_ODV.Location = new Point(198, 32);
            buttonFilt_sq_ODV.Name = "buttonFilt_sq_ODV";
            buttonFilt_sq_ODV.Size = new Size(54, 47);
            buttonFilt_sq_ODV.TabIndex = 5;
            buttonFilt_sq_ODV.Text = "button1";
            buttonFilt_sq_ODV.UseVisualStyleBackColor = true;
            // 
            // toolTip_mainform_ODV
            // 
            toolTip_mainform_ODV.IsBalloon = true;
            toolTip_mainform_ODV.ToolTipIcon = ToolTipIcon.Info;
            // 
            // FormMain_ODV
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 805);
            Controls.Add(splitter1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip_MAIN_odv);
            IsMdiContainer = true;
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1023, 665);
            Name = "FormMain_ODV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная";
            Load += FormMain_ODV_Load;
            menuStrip_MAIN_odv.ResumeLayout(false);
            menuStrip_MAIN_odv.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox_Info_Data_ODV.ResumeLayout(false);
            groupBox_filter_sq_ODV.ResumeLayout(false);
            groupBox_filter_sq_ODV.PerformLayout();
            groupBox_SR_POPUL_ODV.ResumeLayout(false);
            groupBox_SR_POPUL_ODV.PerformLayout();
            groupBox_Filter_popul_ODV.ResumeLayout(false);
            groupBoxMain_ODV.ResumeLayout(false);
            groupBoxMain_ODV.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountries_ODV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_MAIN_odv;
        private ToolStripMenuItem работаСДаннымиToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem анализДанныхToolStripMenuItem_ODV;
        private ToolStripMenuItem руководствоToolStripMenuItem_ODV;
        private ToolStripMenuItem оПрограммеToolStripMenuItem_ODV;
        private Panel panel2;
        private Splitter splitter1;
        private ToolStripMenuItem загпрузитьФайлToolStripMenuItem_ODV;
        private ToolStripMenuItem РаботаСфайломToolStripMenuItem_odv;
        private GroupBox groupBoxMain_ODV;
        private Button button_search_ODV;
        private TextBox textBoxSearch_ODV;
        private DataGridView dataGridViewCountries_ODV;
        private GroupBox groupBox_Filter_ODV;
        private Label labelSort_ODV;
        private Label label1;
        private TextBox textBox2;
        private Label label_sr_popul_ODV;
        private Label labelFilt_sq_ODV;
        private GroupBox groupBox_Filter_popul_ODV;
        private Button buttonSortByPopulationDesc_ODV;
        private Button buttonSortByPopulationAsc_ODV;
        private GroupBox groupBox_SR_POPUL_ODV;
        private TextBox textBoxResultSr_ODV;
        private Button button_sr_populat_ODV;
        private Button buttonFilt_sq_ODV;
        private GroupBox groupBox_filter_sq_ODV;
        private Button buttonFilterByArea_ODV;
        private TextBox textBoxMinArea_ODV;
        private GroupBox groupBox_Info_Data_ODV;
        private Button button_info_WorkInProgr_ODV;
        private Button button_info_EditFail_ODV;
        private Button button_info_DIagram_ODV;
        private ToolTip toolTip_mainform_ODV;
        private ToolStripMenuItem выходToolStripMenuItem_ODV;
        private Button buttonCalculateAveragePopulation_ODV;
    }
}
