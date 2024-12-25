namespace Tyuiu.OgorodnikDV.Sprint7.V13
{
    partial class FormFile_Odv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFile_Odv));
            panelUPFile_ODV = new Panel();
            ButtonInfoFile_ODV = new Button();
            buttonCloseFormFile_ODV = new Button();
            buttonSaveToCsv_ODV = new Button();
            buttonLoadFile2_ODV = new Button();
            dataGridViewFileCountries_ODV = new DataGridView();
            panelLeft_ODV = new Panel();
            groupBoxFileWork_ODV = new GroupBox();
            buttonRemoveCountry_ODV = new Button();
            buttonEditCountry_ODV = new Button();
            buttonAddCountry_ODV = new Button();
            groupBoxFile_ODV = new GroupBox();
            checkBoxIsDeveloped_ODV = new CheckBox();
            buttonClearFields_ODV = new Button();
            textBoxNationality_ODV = new TextBox();
            textBoxPopulation_ODV = new TextBox();
            textBoxArea_ODV = new TextBox();
            textBoxCapital_ODV = new TextBox();
            textBoxCountryName_ODV = new TextBox();
            labelraz_ODV = new Label();
            label_PR_Popul_ODV = new Label();
            labelPopulation_ODV = new Label();
            labelArea_ODV = new Label();
            labelCountry_ODV = new Label();
            label_name_cou_ODV = new Label();
            toolTip_Form_file_ODV = new ToolTip(components);
            openFileDialog_File_ODV = new OpenFileDialog();
            saveFileDialog_File_ODV = new SaveFileDialog();
            panel1 = new Panel();
            splitter1 = new Splitter();
            panelUPFile_ODV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFileCountries_ODV).BeginInit();
            panelLeft_ODV.SuspendLayout();
            groupBoxFileWork_ODV.SuspendLayout();
            groupBoxFile_ODV.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelUPFile_ODV
            // 
            panelUPFile_ODV.BackColor = Color.FromArgb(192, 255, 255);
            panelUPFile_ODV.Controls.Add(ButtonInfoFile_ODV);
            panelUPFile_ODV.Controls.Add(buttonCloseFormFile_ODV);
            panelUPFile_ODV.Controls.Add(buttonSaveToCsv_ODV);
            panelUPFile_ODV.Controls.Add(buttonLoadFile2_ODV);
            panelUPFile_ODV.Dock = DockStyle.Top;
            panelUPFile_ODV.Location = new Point(0, 0);
            panelUPFile_ODV.Margin = new Padding(4, 5, 4, 5);
            panelUPFile_ODV.Name = "panelUPFile_ODV";
            panelUPFile_ODV.Size = new Size(1047, 144);
            panelUPFile_ODV.TabIndex = 1;
            // 
            // ButtonInfoFile_ODV
            // 
            ButtonInfoFile_ODV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonInfoFile_ODV.Cursor = Cursors.Help;
            ButtonInfoFile_ODV.Image = (Image)resources.GetObject("ButtonInfoFile_ODV.Image");
            ButtonInfoFile_ODV.Location = new Point(928, 34);
            ButtonInfoFile_ODV.Margin = new Padding(4, 5, 4, 5);
            ButtonInfoFile_ODV.Name = "ButtonInfoFile_ODV";
            ButtonInfoFile_ODV.Size = new Size(82, 80);
            ButtonInfoFile_ODV.TabIndex = 6;
            toolTip_Form_file_ODV.SetToolTip(ButtonInfoFile_ODV, "Руководтсво по работе на форме");
            ButtonInfoFile_ODV.UseVisualStyleBackColor = true;
            ButtonInfoFile_ODV.Click += ButtonInfoFile_ODV_Click;
            // 
            // buttonCloseFormFile_ODV
            // 
            buttonCloseFormFile_ODV.Cursor = Cursors.Hand;
            buttonCloseFormFile_ODV.Image = (Image)resources.GetObject("buttonCloseFormFile_ODV.Image");
            buttonCloseFormFile_ODV.Location = new Point(609, 34);
            buttonCloseFormFile_ODV.Margin = new Padding(4, 5, 4, 5);
            buttonCloseFormFile_ODV.Name = "buttonCloseFormFile_ODV";
            buttonCloseFormFile_ODV.Size = new Size(82, 80);
            buttonCloseFormFile_ODV.TabIndex = 5;
            toolTip_Form_file_ODV.SetToolTip(buttonCloseFormFile_ODV, "Закрыть форму");
            buttonCloseFormFile_ODV.UseVisualStyleBackColor = true;
            buttonCloseFormFile_ODV.Click += buttonCloseFormFile_ODV_Click;
            // 
            // buttonSaveToCsv_ODV
            // 
            buttonSaveToCsv_ODV.Cursor = Cursors.Hand;
            buttonSaveToCsv_ODV.Enabled = false;
            buttonSaveToCsv_ODV.Image = (Image)resources.GetObject("buttonSaveToCsv_ODV.Image");
            buttonSaveToCsv_ODV.Location = new Point(508, 34);
            buttonSaveToCsv_ODV.Margin = new Padding(4, 5, 4, 5);
            buttonSaveToCsv_ODV.Name = "buttonSaveToCsv_ODV";
            buttonSaveToCsv_ODV.Size = new Size(78, 80);
            buttonSaveToCsv_ODV.TabIndex = 1;
            toolTip_Form_file_ODV.SetToolTip(buttonSaveToCsv_ODV, "Сохранить файл");
            buttonSaveToCsv_ODV.UseVisualStyleBackColor = true;
            buttonSaveToCsv_ODV.Click += buttonSaveToCsv_ODV_Click;
            // 
            // buttonLoadFile2_ODV
            // 
            buttonLoadFile2_ODV.Cursor = Cursors.Hand;
            buttonLoadFile2_ODV.Image = (Image)resources.GetObject("buttonLoadFile2_ODV.Image");
            buttonLoadFile2_ODV.Location = new Point(409, 34);
            buttonLoadFile2_ODV.Margin = new Padding(4, 5, 4, 5);
            buttonLoadFile2_ODV.Name = "buttonLoadFile2_ODV";
            buttonLoadFile2_ODV.Size = new Size(78, 80);
            buttonLoadFile2_ODV.TabIndex = 0;
            toolTip_Form_file_ODV.SetToolTip(buttonLoadFile2_ODV, "Загрузить файл");
            buttonLoadFile2_ODV.UseVisualStyleBackColor = true;
            buttonLoadFile2_ODV.Click += buttonLoadFile2_ODV_Click;
            // 
            // dataGridViewFileCountries_ODV
            // 
            dataGridViewFileCountries_ODV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFileCountries_ODV.BackgroundColor = Color.FromArgb(192, 255, 255);
            dataGridViewFileCountries_ODV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFileCountries_ODV.Dock = DockStyle.Fill;
            dataGridViewFileCountries_ODV.Location = new Point(0, 0);
            dataGridViewFileCountries_ODV.Margin = new Padding(4, 5, 4, 5);
            dataGridViewFileCountries_ODV.Name = "dataGridViewFileCountries_ODV";
            dataGridViewFileCountries_ODV.RowHeadersVisible = false;
            dataGridViewFileCountries_ODV.RowHeadersWidth = 51;
            dataGridViewFileCountries_ODV.Size = new Size(661, 640);
            dataGridViewFileCountries_ODV.TabIndex = 0;
            // 
            // panelLeft_ODV
            // 
            panelLeft_ODV.BackColor = Color.White;
            panelLeft_ODV.Controls.Add(groupBoxFileWork_ODV);
            panelLeft_ODV.Controls.Add(groupBoxFile_ODV);
            panelLeft_ODV.Dock = DockStyle.Left;
            panelLeft_ODV.Location = new Point(0, 144);
            panelLeft_ODV.Margin = new Padding(4, 5, 4, 5);
            panelLeft_ODV.Name = "panelLeft_ODV";
            panelLeft_ODV.Size = new Size(386, 640);
            panelLeft_ODV.TabIndex = 3;
            // 
            // groupBoxFileWork_ODV
            // 
            groupBoxFileWork_ODV.BackColor = Color.White;
            groupBoxFileWork_ODV.Controls.Add(buttonRemoveCountry_ODV);
            groupBoxFileWork_ODV.Controls.Add(buttonEditCountry_ODV);
            groupBoxFileWork_ODV.Controls.Add(buttonAddCountry_ODV);
            groupBoxFileWork_ODV.Dock = DockStyle.Bottom;
            groupBoxFileWork_ODV.Enabled = false;
            groupBoxFileWork_ODV.Location = new Point(0, 481);
            groupBoxFileWork_ODV.Margin = new Padding(4, 5, 4, 5);
            groupBoxFileWork_ODV.Name = "groupBoxFileWork_ODV";
            groupBoxFileWork_ODV.Padding = new Padding(4, 5, 4, 5);
            groupBoxFileWork_ODV.Size = new Size(386, 159);
            groupBoxFileWork_ODV.TabIndex = 1;
            groupBoxFileWork_ODV.TabStop = false;
            groupBoxFileWork_ODV.Text = "Работа с таблицей";
            // 
            // buttonRemoveCountry_ODV
            // 
            buttonRemoveCountry_ODV.Cursor = Cursors.Hand;
            buttonRemoveCountry_ODV.Image = (Image)resources.GetObject("buttonRemoveCountry_ODV.Image");
            buttonRemoveCountry_ODV.Location = new Point(252, 48);
            buttonRemoveCountry_ODV.Margin = new Padding(4, 5, 4, 5);
            buttonRemoveCountry_ODV.Name = "buttonRemoveCountry_ODV";
            buttonRemoveCountry_ODV.Size = new Size(82, 87);
            buttonRemoveCountry_ODV.TabIndex = 4;
            toolTip_Form_file_ODV.SetToolTip(buttonRemoveCountry_ODV, "Удалить страну");
            buttonRemoveCountry_ODV.UseVisualStyleBackColor = true;
            buttonRemoveCountry_ODV.Click += buttonRemoveCountry_ODV_Click;
            // 
            // buttonEditCountry_ODV
            // 
            buttonEditCountry_ODV.Cursor = Cursors.Hand;
            buttonEditCountry_ODV.Image = (Image)resources.GetObject("buttonEditCountry_ODV.Image");
            buttonEditCountry_ODV.Location = new Point(148, 48);
            buttonEditCountry_ODV.Margin = new Padding(4, 5, 4, 5);
            buttonEditCountry_ODV.Name = "buttonEditCountry_ODV";
            buttonEditCountry_ODV.Size = new Size(82, 87);
            buttonEditCountry_ODV.TabIndex = 3;
            toolTip_Form_file_ODV.SetToolTip(buttonEditCountry_ODV, "Редактировать страну");
            buttonEditCountry_ODV.UseVisualStyleBackColor = true;
            buttonEditCountry_ODV.Click += buttonEditCountry_ODV_Click;
            // 
            // buttonAddCountry_ODV
            // 
            buttonAddCountry_ODV.Cursor = Cursors.Hand;
            buttonAddCountry_ODV.Image = (Image)resources.GetObject("buttonAddCountry_ODV.Image");
            buttonAddCountry_ODV.Location = new Point(36, 48);
            buttonAddCountry_ODV.Margin = new Padding(4, 5, 4, 5);
            buttonAddCountry_ODV.Name = "buttonAddCountry_ODV";
            buttonAddCountry_ODV.Size = new Size(82, 87);
            buttonAddCountry_ODV.TabIndex = 2;
            toolTip_Form_file_ODV.SetToolTip(buttonAddCountry_ODV, "Добавить страну");
            buttonAddCountry_ODV.UseVisualStyleBackColor = true;
            buttonAddCountry_ODV.Click += buttonAddCountry_ODV_Click;
            // 
            // groupBoxFile_ODV
            // 
            groupBoxFile_ODV.BackColor = Color.White;
            groupBoxFile_ODV.Controls.Add(checkBoxIsDeveloped_ODV);
            groupBoxFile_ODV.Controls.Add(buttonClearFields_ODV);
            groupBoxFile_ODV.Controls.Add(textBoxNationality_ODV);
            groupBoxFile_ODV.Controls.Add(textBoxPopulation_ODV);
            groupBoxFile_ODV.Controls.Add(textBoxArea_ODV);
            groupBoxFile_ODV.Controls.Add(textBoxCapital_ODV);
            groupBoxFile_ODV.Controls.Add(textBoxCountryName_ODV);
            groupBoxFile_ODV.Controls.Add(labelraz_ODV);
            groupBoxFile_ODV.Controls.Add(label_PR_Popul_ODV);
            groupBoxFile_ODV.Controls.Add(labelPopulation_ODV);
            groupBoxFile_ODV.Controls.Add(labelArea_ODV);
            groupBoxFile_ODV.Controls.Add(labelCountry_ODV);
            groupBoxFile_ODV.Controls.Add(label_name_cou_ODV);
            groupBoxFile_ODV.Enabled = false;
            groupBoxFile_ODV.Location = new Point(15, 9);
            groupBoxFile_ODV.Margin = new Padding(4, 5, 4, 5);
            groupBoxFile_ODV.Name = "groupBoxFile_ODV";
            groupBoxFile_ODV.Padding = new Padding(4, 5, 4, 5);
            groupBoxFile_ODV.Size = new Size(350, 475);
            groupBoxFile_ODV.TabIndex = 0;
            groupBoxFile_ODV.TabStop = false;
            groupBoxFile_ODV.Text = "Данные о стране";
            // 
            // checkBoxIsDeveloped_ODV
            // 
            checkBoxIsDeveloped_ODV.AutoSize = true;
            checkBoxIsDeveloped_ODV.Location = new Point(253, 333);
            checkBoxIsDeveloped_ODV.Margin = new Padding(4, 5, 4, 5);
            checkBoxIsDeveloped_ODV.Name = "checkBoxIsDeveloped_ODV";
            checkBoxIsDeveloped_ODV.Size = new Size(18, 17);
            checkBoxIsDeveloped_ODV.TabIndex = 14;
            checkBoxIsDeveloped_ODV.UseVisualStyleBackColor = true;
            // 
            // buttonClearFields_ODV
            // 
            buttonClearFields_ODV.Cursor = Cursors.Hand;
            buttonClearFields_ODV.Image = (Image)resources.GetObject("buttonClearFields_ODV.Image");
            buttonClearFields_ODV.Location = new Point(132, 373);
            buttonClearFields_ODV.Margin = new Padding(4, 5, 4, 5);
            buttonClearFields_ODV.Name = "buttonClearFields_ODV";
            buttonClearFields_ODV.Size = new Size(82, 80);
            buttonClearFields_ODV.TabIndex = 2;
            toolTip_Form_file_ODV.SetToolTip(buttonClearFields_ODV, "Очистка полей");
            buttonClearFields_ODV.UseVisualStyleBackColor = true;
            buttonClearFields_ODV.Click += buttonClearFields_ODV_Click;
            // 
            // textBoxNationality_ODV
            // 
            textBoxNationality_ODV.Location = new Point(202, 281);
            textBoxNationality_ODV.Margin = new Padding(4, 5, 4, 5);
            textBoxNationality_ODV.Name = "textBoxNationality_ODV";
            textBoxNationality_ODV.Size = new Size(127, 30);
            textBoxNationality_ODV.TabIndex = 13;
            // 
            // textBoxPopulation_ODV
            // 
            textBoxPopulation_ODV.Location = new Point(202, 221);
            textBoxPopulation_ODV.Margin = new Padding(4, 5, 4, 5);
            textBoxPopulation_ODV.Name = "textBoxPopulation_ODV";
            textBoxPopulation_ODV.Size = new Size(127, 30);
            textBoxPopulation_ODV.TabIndex = 12;
            // 
            // textBoxArea_ODV
            // 
            textBoxArea_ODV.Location = new Point(202, 169);
            textBoxArea_ODV.Margin = new Padding(4, 5, 4, 5);
            textBoxArea_ODV.Name = "textBoxArea_ODV";
            textBoxArea_ODV.Size = new Size(127, 30);
            textBoxArea_ODV.TabIndex = 11;
            // 
            // textBoxCapital_ODV
            // 
            textBoxCapital_ODV.Location = new Point(202, 109);
            textBoxCapital_ODV.Margin = new Padding(4, 5, 4, 5);
            textBoxCapital_ODV.Name = "textBoxCapital_ODV";
            textBoxCapital_ODV.Size = new Size(127, 30);
            textBoxCapital_ODV.TabIndex = 10;
            // 
            // textBoxCountryName_ODV
            // 
            textBoxCountryName_ODV.Location = new Point(202, 49);
            textBoxCountryName_ODV.Margin = new Padding(4, 5, 4, 5);
            textBoxCountryName_ODV.Name = "textBoxCountryName_ODV";
            textBoxCountryName_ODV.Size = new Size(127, 30);
            textBoxCountryName_ODV.TabIndex = 9;
            // 
            // labelraz_ODV
            // 
            labelraz_ODV.AutoSize = true;
            labelraz_ODV.Location = new Point(21, 331);
            labelraz_ODV.Margin = new Padding(4, 0, 4, 0);
            labelraz_ODV.Name = "labelraz_ODV";
            labelraz_ODV.Size = new Size(154, 23);
            labelraz_ODV.TabIndex = 8;
            labelraz_ODV.Text = "Развита ли страна";
            // 
            // label_PR_Popul_ODV
            // 
            label_PR_Popul_ODV.AutoSize = true;
            label_PR_Popul_ODV.Location = new Point(21, 270);
            label_PR_Popul_ODV.Margin = new Padding(4, 0, 4, 0);
            label_PR_Popul_ODV.Name = "label_PR_Popul_ODV";
            label_PR_Popul_ODV.Size = new Size(148, 46);
            label_PR_Popul_ODV.TabIndex = 4;
            label_PR_Popul_ODV.Text = "Преобладающая \r\nнациональность";
            // 
            // labelPopulation_ODV
            // 
            labelPopulation_ODV.AutoSize = true;
            labelPopulation_ODV.Location = new Point(21, 233);
            labelPopulation_ODV.Margin = new Padding(4, 0, 4, 0);
            labelPopulation_ODV.Name = "labelPopulation_ODV";
            labelPopulation_ODV.Size = new Size(95, 23);
            labelPopulation_ODV.TabIndex = 3;
            labelPopulation_ODV.Text = "Население";
            // 
            // labelArea_ODV
            // 
            labelArea_ODV.AutoSize = true;
            labelArea_ODV.Location = new Point(21, 181);
            labelArea_ODV.Margin = new Padding(4, 0, 4, 0);
            labelArea_ODV.Name = "labelArea_ODV";
            labelArea_ODV.Size = new Size(126, 23);
            labelArea_ODV.TabIndex = 2;
            labelArea_ODV.Text = "Площадь (км2)";
            // 
            // labelCountry_ODV
            // 
            labelCountry_ODV.AutoSize = true;
            labelCountry_ODV.Location = new Point(21, 121);
            labelCountry_ODV.Margin = new Padding(4, 0, 4, 0);
            labelCountry_ODV.Name = "labelCountry_ODV";
            labelCountry_ODV.Size = new Size(76, 23);
            labelCountry_ODV.TabIndex = 1;
            labelCountry_ODV.Text = "Столица";
            // 
            // label_name_cou_ODV
            // 
            label_name_cou_ODV.AutoSize = true;
            label_name_cou_ODV.Location = new Point(21, 61);
            label_name_cou_ODV.Margin = new Padding(4, 0, 4, 0);
            label_name_cou_ODV.Name = "label_name_cou_ODV";
            label_name_cou_ODV.Size = new Size(147, 23);
            label_name_cou_ODV.TabIndex = 0;
            label_name_cou_ODV.Text = "Название страны";
            // 
            // toolTip_Form_file_ODV
            // 
            toolTip_Form_file_ODV.IsBalloon = true;
            toolTip_Form_file_ODV.ToolTipIcon = ToolTipIcon.Info;
            // 
            // openFileDialog_File_ODV
            // 
            openFileDialog_File_ODV.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(dataGridViewFileCountries_ODV);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(386, 144);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 640);
            panel1.TabIndex = 4;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(386, 144);
            splitter1.Margin = new Padding(4, 5, 4, 5);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 640);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // FormFile_Odv
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 784);
            Controls.Add(splitter1);
            Controls.Add(panel1);
            Controls.Add(panelLeft_ODV);
            Controls.Add(panelUPFile_ODV);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1062, 818);
            Name = "FormFile_Odv";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Работа с файлом";
            Load += FormFile_Odv_Load;
            panelUPFile_ODV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFileCountries_ODV).EndInit();
            panelLeft_ODV.ResumeLayout(false);
            groupBoxFileWork_ODV.ResumeLayout(false);
            groupBoxFile_ODV.ResumeLayout(false);
            groupBoxFile_ODV.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelUPFile_ODV;
        private Button buttonSaveToCsv_ODV;
        private Button buttonLoadFile2_ODV;
        private Panel panelLeft_ODV;
        private GroupBox groupBoxFile_ODV;
        private Label label_name_cou_ODV;
        private Button buttonAddCountry_ODV;
        private Label label_PR_Popul_ODV;
        private Label labelPopulation_ODV;
        private Label labelArea_ODV;
        private Label labelCountry_ODV;
        private DataGridView dataGridViewFileCountries_ODV;
        private TextBox textBoxCapital_ODV;
        private TextBox textBoxCountryName_ODV;
        private Label labelraz_ODV;
        private GroupBox groupBoxFileWork_ODV;
        private Button buttonRemoveCountry_ODV;
        private TextBox textBoxNationality_ODV;
        private TextBox textBoxPopulation_ODV;
        private TextBox textBoxArea_ODV;
        private ToolTip toolTip_Form_file_ODV;
        private Button buttonClearFields_ODV;
        private OpenFileDialog openFileDialog_File_ODV;
        private SaveFileDialog saveFileDialog_File_ODV;
        private Button buttonCloseFormFile_ODV;
        private Button ButtonInfoFile_ODV;
        private Button buttonEditCountry_ODV;
        private CheckBox checkBoxIsDeveloped_ODV;
        private Panel panel1;
        private Splitter splitter1;
    }
}