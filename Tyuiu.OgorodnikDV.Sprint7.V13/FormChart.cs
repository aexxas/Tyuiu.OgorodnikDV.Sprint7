using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.OgorodnikDV.Sprint7.Lib;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.OgorodnikDV.Sprint7.V13
{
    public partial class FormChart_Odv : Form
    {
        // Поля
        private CountryManager _countryManager = new CountryManager();
        private Chart _chart; // Только диаграмма

        public FormChart_Odv()
        {
            InitializeComponent(); // Инициализация формы

            // Добавляем диаграмму на форму
            InitializeChart();
        }

        // Инициализация диаграммы
        private void InitializeChart()
        {
            // Создаем диаграмму
            _chart = new Chart
            {
                Width = this.ClientSize.Width / 2 - 20, // Правая сторона
                Height = this.ClientSize.Height - 80,
                Top = 80,
                Left = this.ClientSize.Width / 2 + 10,
                Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom
            };

            // Добавляем область диаграммы
            var chartArea = new ChartArea("MainArea");
            _chart.ChartAreas.Add(chartArea);
            _chart.Legends.Add(new Legend("Legend") { Docking = Docking.Top });

            // Добавляем диаграмму на форму
            this.Controls.Add(_chart);

            // Автоматическая подстройка размеров при изменении формы
            this.Resize += (s, e) =>
            {
                _chart.Width = this.ClientSize.Width / 2 - 20;
                _chart.Height = this.ClientSize.Height - 80;
                _chart.Left = this.ClientSize.Width / 2 + 10;
            };
        }

        private void btnLoadFileChart_ODV_Click_1(object sender, EventArgs e)

        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "CSV Files|*.csv",
                Title = "Выберите CSV файл"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Загружаем данные
                    var countries = CSVHelper.LoadFromCsv(openFileDialog.FileName);
                    _countryManager.Countries.Clear();
                    foreach (var country in countries)
                    {
                        _countryManager.Countries.Add(country);
                    }

                    // Привязываем данные к существующему DataGridView
                    dataGridView_chart_ODV.DataSource = null; // dataGridView1 — ваша таблица на форме
                    dataGridView_chart_ODV.DataSource = _countryManager.Countries;


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
                }
            }
        }

        private void btnPopulationChart_ODV_Click_1(object sender, EventArgs e)
        {
            _chart.Series.Clear(); // Очищаем диаграмму

            if (_countryManager.Countries == null || !_countryManager.Countries.Any())
            {
                MessageBox.Show("Данные не загружены. Пожалуйста, загрузите данные из файла.");
                return;
            }

            var series = new Series("Население")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Int32
            };

            foreach (var country in _countryManager.Countries)
            {
                series.Points.AddXY(country.Name, country.Population);
            }

            _chart.Series.Add(series);
            _chart.ChartAreas["MainArea"].AxisX.Title = "Страны";
            _chart.ChartAreas["MainArea"].AxisY.Title = "Население";
            _chart.ChartAreas["MainArea"].RecalculateAxesScale();
        }

        private void btnAreaChart_ODV_Click_1(object sender, EventArgs e)
        {

            _chart.Series.Clear(); // Очищаем диаграмму

            if (_countryManager.Countries == null || !_countryManager.Countries.Any())
            {
                MessageBox.Show("Данные не загружены. Пожалуйста, загрузите данные из файла.");
                return;
            }

            var series = new Series("Площадь")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Int32
            };

            foreach (var country in _countryManager.Countries)
            {
                series.Points.AddXY(country.Name, country.Area);
            }

            _chart.Series.Add(series);
            _chart.ChartAreas["MainArea"].AxisX.Title = "Страны";
            _chart.ChartAreas["MainArea"].AxisY.Title = "Площадь";
            _chart.ChartAreas["MainArea"].RecalculateAxesScale();

        }



        private void button_info_DIagram_ODV_Click(object sender, EventArgs e)
        {
            FormFileChartInf_ODV formfileinf = new FormFileChartInf_ODV();
            formfileinf.ShowDialog();
        }

        private void panelUpChartt_ODV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCloseFormChart_ODV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormChart_Odv_Load(object sender, EventArgs e)
        {

        }
    }
}

    