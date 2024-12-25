using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.OgorodnikDV.Sprint7.Lib;

namespace Tyuiu.OgorodnikDV.Sprint7.V13
{
    public partial class FormMain_ODV : Form
    {
        private CountryManager _manager; // Менеджер данных


        public FormMain_ODV()
        {
            InitializeComponent();
            _manager = new CountryManager(); // Инициализация менеджера
        }

        private void РаботаСфайломToolStripMenuItem_odv_Click(object sender, EventArgs e)
        {
            // Создаем объект формы FormFile
            FormFile_Odv formFile = new FormFile_Odv();

            // Показываем форму как отдельное окно
            formFile.ShowDialog();


        }

        private void анализДанныхToolStripMenuItem_ODV_Click(object sender, EventArgs e)
        {
            FormChart_Odv formChart = new FormChart_Odv();

            // Показываем форму как отдельное окно
            formChart.ShowDialog();
        }

        private void загпрузитьФайлToolStripMenuItem_ODV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "Выберите файл с данными"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Загрузка данных через метод из CSVHelper
                    var countries = CSVHelper.LoadFromCsv(openFileDialog.FileName);

                    // Очистка текущих данных в менеджере
                    _manager.Countries.Clear();

                    // Добавление загруженных данных в менеджер
                    foreach (var country in countries)
                    {
                        _manager.Countries.Add(country);
                    }

                    // Привязываем данные к DataGridView
                    dataGridViewCountries_ODV.DataSource = null;
                    dataGridViewCountries_ODV.DataSource = _manager.Countries;

                    // Делаем кнопки доступными
                    button_search_ODV.Enabled = true;
                    buttonFilterByArea_ODV.Enabled = true;
                    buttonCalculateAveragePopulation_ODV.Enabled = true;
                    buttonSortByPopulationDesc_ODV.Enabled = true;
                    buttonSortByPopulationAsc_ODV.Enabled = true;
                    textBoxSearch_ODV.Enabled = true;
                    textBoxMinArea_ODV.Enabled = true;
                    textBoxResultSr_ODV.Enabled = true;



                    MessageBox.Show("Файл успешно загружен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        

        private void button_search_ODV_Click(object sender, EventArgs e)
        {

            // Получаем текст для поиска
            var searchName = textBoxSearch_ODV.Text.Trim();

            // Выполняем поиск стран
            var results = _manager.SearchByName(searchName);

            if (results.Any()) // Если найдены совпадения
            {
                // Привязываем результат к DataGridView напрямую
                dataGridViewCountries_ODV.DataSource = results;
            }
            else
            {
                // Если ничего не найдено, выводим сообщение
                MessageBox.Show("Страна не найдена!", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Введите корректное значение минимальной площади!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCalculateAveragePopulation_ODV_Click(object sender, EventArgs e)
        {
            {
                // Получаем среднее значение населения
                var averagePopulation = _manager.CalculateAveragePopulation();

                // Проверяем, есть ли данные
                if (averagePopulation > 0)
                {
                    // Выводим результат в текстбокс 
                    textBoxResultSr_ODV.Text = averagePopulation.ToString("N0"); // Форматируем число с разделителями; 
                }
                else
                {
                    // Если данных нет, показываем сообщение об ошибке
                    MessageBox.Show("Нет данных для расчёта среднего значения населения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        private void buttonSortByPopulationDesc_ODV_Click(object sender, EventArgs e)
        {
            // Сортировка по убыванию населения (descending = true)
            var sortedCountries = _manager.SortByPopulation(descending: true);

            // Привязка данных к таблице
            dataGridViewCountries_ODV.DataSource = null;
            dataGridViewCountries_ODV.DataSource = sortedCountries;
        }

        private void buttonSortByPopulationAsc_ODV_Click(object sender, EventArgs e)
        {
            // Сортировка по возрастанию населения (descending = false)
            var sortedCountries = _manager.SortByPopulation(descending: false);

            // Привязка данных к таблице
            dataGridViewCountries_ODV.DataSource = null;
            dataGridViewCountries_ODV.DataSource = sortedCountries;
        }

        

        private void button_info_WorkInProgr_ODV_Click(object sender, EventArgs e)
        {
            FormInfMain_ODV forminfMain = new FormInfMain_ODV();

            // Показываем форму как отдельное окно
            forminfMain.ShowDialog();
        }

        private void button_info_EditFail_ODV_Click(object sender, EventArgs e)
        {
            FormFileEDIT_ODV formfileeditinf = new FormFileEDIT_ODV();
            formfileeditinf.ShowDialog();
        }

        private void выходToolStripMenuItem_ODV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_ODV_Click(object sender, EventArgs e)
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



    

