using System;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.OgorodnikDV.Sprint7.Lib;

namespace Tyuiu.OgorodnikDV.Sprint7.V13
{
    public partial class FormFile_Odv : Form
    {
        private CountryManager _countryManager;

        public FormFile_Odv()
        {
            InitializeComponent();
            _countryManager = new CountryManager(); // Инициализация менеджера
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // Привязка BindingList к DataGridView
            dataGridViewFileCountries_ODV.DataSource = _countryManager.Countries;
        }

        private void buttonLoadFile2_ODV_Click(object sender, EventArgs e)
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
                    // Загрузка данных из CSV
                    var countries = CSVHelper.LoadFromCsv(openFileDialog.FileName);

                    // Очистка текущих данных
                    _countryManager.Countries.Clear();

                    // Добавление загруженных стран
                    foreach (var country in countries)
                    {
                        _countryManager.Countries.Add(country);
                    }

                    // Привязка данных снова
                    dataGridViewFileCountries_ODV.DataSource = null; // Сбрасываем привязку
                    dataGridViewFileCountries_ODV.DataSource = _countryManager.Countries;
                    groupBoxFileWork_ODV.Enabled = true;
                    groupBoxFile_ODV.Enabled = true;
                    buttonSaveToCsv_ODV.Enabled = true;

                    MessageBox.Show("Файл успешно загружен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void buttonAddCountry_ODV_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем заполнение полей
                if (string.IsNullOrWhiteSpace(textBoxCountryName_ODV.Text) ||
                string.IsNullOrWhiteSpace(textBoxCapital_ODV.Text) ||
                string.IsNullOrWhiteSpace(textBoxArea_ODV.Text) ||
                string.IsNullOrWhiteSpace(textBoxPopulation_ODV.Text) ||
                string.IsNullOrWhiteSpace(textBoxNationality_ODV.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Проверяем корректность числовых значений
                if (!double.TryParse(textBoxArea_ODV.Text, out double area))
                {
                    MessageBox.Show("Площадь должна быть числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!long.TryParse(textBoxPopulation_ODV.Text, out long population))
                {
                    MessageBox.Show("Население должно быть числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Создаем новую страну
                var newCountry = new Country
                {
                    Name = textBoxCountryName_ODV.Text,
                    Capital = textBoxCapital_ODV.Text,
                    Area = area,
                    Population = population,
                    PredominantNationality = textBoxNationality_ODV.Text,
                    IsDeveloped = checkBoxIsDeveloped_ODV.Checked
                };

                // Добавляем страну в список
                _countryManager.Countries.Add(newCountry);

                MessageBox.Show("Страна успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении страны: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonEditCountry_ODV_Click(object sender, EventArgs e)
        {
            try
            {
                // Ищем страну по названию
                var countryToEdit = _countryManager.Countries.FirstOrDefault(c => c.Name == textBoxCountryName_ODV.Text);

                if (countryToEdit == null)
                {
                    MessageBox.Show("Страна не найдена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Обновляем данные страны
                countryToEdit.Capital = textBoxCapital_ODV.Text;
                countryToEdit.Area = double.Parse(textBoxArea_ODV.Text);
                countryToEdit.Population = long.Parse(textBoxPopulation_ODV.Text);
                countryToEdit.PredominantNationality = textBoxNationality_ODV.Text;
                countryToEdit.IsDeveloped = checkBoxIsDeveloped_ODV.Checked;

                // Обновляем DataGridView
                _countryManager.Countries.ResetBindings();

                MessageBox.Show("Страна успешно обновлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при редактировании страны: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveCountry_ODV_Click(object sender, EventArgs e)
        {
            try
            {
                // Удаляем страну по названию
                var success = _countryManager.RemoveCountry(textBoxCountryName_ODV.Text);

                if (success)
                {
                    MessageBox.Show("Страна успешно удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Страна не найдена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении страны: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonUpdateTable_ODV_Click(object sender, EventArgs e)
        {

            dataGridViewFileCountries_ODV.Refresh();
        }

        private void buttonSaveToCsv_ODV_Click(object sender, EventArgs e)
        {
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                    Title = "Сохранить данные в CSV"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Сохраняем данные из BindingList с помощью метода из библиотеки
                        CSVHelper.SaveToCsv(_countryManager.Countries.ToList(), saveFileDialog.FileName);

                        MessageBox.Show("Файл успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonCloseFormFile_ODV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonInfoFile_ODV_Click(object sender, EventArgs e)
        {
            FormFileEDIT_ODV formfileeditinf = new FormFileEDIT_ODV();
            formfileeditinf.ShowDialog();
        }

        private void buttonClearFields_ODV_Click(object sender, EventArgs e)
        {
            {
                textBoxCountryName_ODV.Text = string.Empty; // Очистка названия страны
                textBoxCapital_ODV.Text = string.Empty; // Очистка столицы
                textBoxArea_ODV.Text = string.Empty; // Очистка площади
                textBoxPopulation_ODV.Text = string.Empty; // Очистка населения
                textBoxNationality_ODV.Text = string.Empty; // Очистка национальности
                checkBoxIsDeveloped_ODV.Checked = false; // Сброс чекбокса
            }
        }

        private void FormFile_Odv_Load(object sender, EventArgs e)
        {

        }
    }
}

