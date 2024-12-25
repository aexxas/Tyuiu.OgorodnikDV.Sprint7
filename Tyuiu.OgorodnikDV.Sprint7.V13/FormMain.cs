using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.OgorodnikDV.Sprint7.Lib;

namespace Tyuiu.OgorodnikDV.Sprint7.V13
{
    public partial class FormMain_ODV : Form
    {
        private CountryManager _manager; // �������� ������


        public FormMain_ODV()
        {
            InitializeComponent();
            _manager = new CountryManager(); // ������������� ���������
        }

        private void �������������ToolStripMenuItem_odv_Click(object sender, EventArgs e)
        {
            // ������� ������ ����� FormFile
            FormFile_Odv formFile = new FormFile_Odv();

            // ���������� ����� ��� ��������� ����
            formFile.ShowDialog();


        }

        private void ������������ToolStripMenuItem_ODV_Click(object sender, EventArgs e)
        {
            FormChart_Odv formChart = new FormChart_Odv();

            // ���������� ����� ��� ��������� ����
            formChart.ShowDialog();
        }

        private void ��������������ToolStripMenuItem_ODV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "�������� ���� � �������"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // �������� ������ ����� ����� �� CSVHelper
                    var countries = CSVHelper.LoadFromCsv(openFileDialog.FileName);

                    // ������� ������� ������ � ���������
                    _manager.Countries.Clear();

                    // ���������� ����������� ������ � ��������
                    foreach (var country in countries)
                    {
                        _manager.Countries.Add(country);
                    }

                    // ����������� ������ � DataGridView
                    dataGridViewCountries_ODV.DataSource = null;
                    dataGridViewCountries_ODV.DataSource = _manager.Countries;

                    // ������ ������ ����������
                    button_search_ODV.Enabled = true;
                    buttonFilterByArea_ODV.Enabled = true;
                    buttonCalculateAveragePopulation_ODV.Enabled = true;
                    buttonSortByPopulationDesc_ODV.Enabled = true;
                    buttonSortByPopulationAsc_ODV.Enabled = true;
                    textBoxSearch_ODV.Enabled = true;
                    textBoxMinArea_ODV.Enabled = true;
                    textBoxResultSr_ODV.Enabled = true;



                    MessageBox.Show("���� ������� ��������!", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"������ ��� �������� �����: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        

        private void button_search_ODV_Click(object sender, EventArgs e)
        {

            // �������� ����� ��� ������
            var searchName = textBoxSearch_ODV.Text.Trim();

            // ��������� ����� �����
            var results = _manager.SearchByName(searchName);

            if (results.Any()) // ���� ������� ����������
            {
                // ����������� ��������� � DataGridView ��������
                dataGridViewCountries_ODV.DataSource = results;
            }
            else
            {
                // ���� ������ �� �������, ������� ���������
                MessageBox.Show("������ �� �������!", "��������� ������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonFilterByArea_ODV_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxMinArea_ODV.Text, out double minArea))
            {
                var filteredCountries = _manager.FilterByMinArea(minArea);

                dataGridViewCountries_ODV.DataSource = null;
                dataGridViewCountries_ODV.DataSource = filteredCountries;
            }
            else
            {
                MessageBox.Show("������� ���������� �������� ����������� �������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCalculateAveragePopulation_ODV_Click(object sender, EventArgs e)
        {
            {
                // �������� ������� �������� ���������
                var averagePopulation = _manager.CalculateAveragePopulation();

                // ���������, ���� �� ������
                if (averagePopulation > 0)
                {
                    // ������� ��������� � ��������� 
                    textBoxResultSr_ODV.Text = averagePopulation.ToString("N0"); // ����������� ����� � �������������; 
                }
                else
                {
                    // ���� ������ ���, ���������� ��������� �� ������
                    MessageBox.Show("��� ������ ��� ������� �������� �������� ���������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        private void buttonSortByPopulationDesc_ODV_Click(object sender, EventArgs e)
        {
            // ���������� �� �������� ��������� (descending = true)
            var sortedCountries = _manager.SortByPopulation(descending: true);

            // �������� ������ � �������
            dataGridViewCountries_ODV.DataSource = null;
            dataGridViewCountries_ODV.DataSource = sortedCountries;
        }

        private void buttonSortByPopulationAsc_ODV_Click(object sender, EventArgs e)
        {
            // ���������� �� ����������� ��������� (descending = false)
            var sortedCountries = _manager.SortByPopulation(descending: false);

            // �������� ������ � �������
            dataGridViewCountries_ODV.DataSource = null;
            dataGridViewCountries_ODV.DataSource = sortedCountries;
        }

        

        private void button_info_WorkInProgr_ODV_Click(object sender, EventArgs e)
        {
            FormInfMain_ODV forminfMain = new FormInfMain_ODV();

            // ���������� ����� ��� ��������� ����
            forminfMain.ShowDialog();
        }

        private void button_info_EditFail_ODV_Click(object sender, EventArgs e)
        {
            FormFileEDIT_ODV formfileeditinf = new FormFileEDIT_ODV();
            formfileeditinf.ShowDialog();
        }

        private void �����ToolStripMenuItem_ODV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ����������ToolStripMenuItem_ODV_Click(object sender, EventArgs e)
        {

            FormInfProgram_ODV forminfOprogram = new FormInfProgram_ODV();
            forminfOprogram.ShowDialog();
        }

        private void button_info_DIagram_ODV_Click(object sender, EventArgs e)
        {
            FormFileChartInf_ODV formfileinf = new FormFileChartInf_ODV();
            formfileinf.ShowDialog();
        }

        
    }
}



    

