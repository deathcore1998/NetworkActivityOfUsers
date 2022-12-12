using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DmitrievaKursach
{
    public partial class MainMenu : Form
    {
        FileController fileController;
        Dictionary<int, List<string>> inputData;
        List<string> corporateData;
        public MainMenu()
        {
            InitializeComponent();
            fileController = new FileController();

            ClearTables();
            FillCorporateTable();
        }

        private void importMenuButton_Click(object sender, EventArgs e)
        {
            inputData = fileController.GetInputData();
            ClearInputDataTable();

            for (int i = 0; i < inputData[Constants.USER_IP_ADRESS].Count; i++)
            {
                inputDataTable.Rows.Add();
                inputDataTable.Rows[i].HeaderCell.Value = (i + 1).ToString();
                inputDataTable.Rows[i].Cells[0].Value = inputData[Constants.USER_IP_ADRESS][i];
                inputDataTable.Rows[i].Cells[1].Value = inputData[Constants.WEB_SITE_TIME][i];
                inputDataTable.Rows[i].Cells[2].Value = inputData[Constants.WEB_SITE_URL][i];
            }
        }

        private void ClearTables()
        {
            corporateUrlTextField.Text = "http://";
            ClearInputDataTable();
            ClearCorporateDataTable();
        }

        private void ClearInputDataTable()
        {
            inputDataTable.Rows.Clear();
            inputDataTable.ReadOnly = true;
            inputDataTable.RowCount = 1;
            inputDataTable.ColumnCount = 3;

            inputDataTable.Columns[0].HeaderText = "IP";
            inputDataTable.Columns[1].HeaderText = "Время посещения";
            inputDataTable.Columns[2].HeaderText = "URL";
            inputDataTable.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ClearCorporateDataTable()
        {
            corporateDataTable.Rows.Clear();
            corporateDataTable.ReadOnly = true;
            corporateDataTable.RowCount = 1;
            corporateDataTable.ColumnCount = 1;
            corporateDataTable.MultiSelect = false;


            corporateDataTable.RowHeadersWidth = 50;
            corporateDataTable.Columns[0].HeaderText = "URL";
            corporateDataTable.Columns[0].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FillCorporateTable()
        {
            ClearCorporateDataTable();
            corporateData = fileController.GetCorporateServicesData();
            if (corporateData == null) return;

            for (int i = 0; i < corporateData.Count; i++)
            {
                corporateDataTable.Rows.Add();
                corporateDataTable.Rows[i].HeaderCell.Value = (i + 1).ToString();
                corporateDataTable.Rows[i].Cells[0].Value = corporateData[i];
            }
        }

        private void corporateUrlAdd_Click(object sender, EventArgs e)
        {
            if (corporateData == null) ClearCorporateDataTable();
            string corporateUrl = corporateUrlTextField.Text;

            if (corporateUrlTextField.Text.Length == 0 || !corporateUrlTextField.Text.Contains("http://"))
            {
                MessageBox.Show("Введите корректные данные!");
                return;
            }

            fileController.addCorporateDataItem(corporateUrlTextField.Text);
            FillCorporateTable();
            
            corporateUrlTextField.Text = "http://";
        }

        private void corporateUrlDelete_Click(object sender, EventArgs e)
        {
            if (corporateDataTable.CurrentRow == null) return;

            fileController.deleteCorporateDataItem(corporateDataTable.CurrentRow.Index);
            FillCorporateTable();

            corporateUrlTextField.Text = "http://";
        }

        private void analyzeMenuButton_Click(object sender, EventArgs e)
        {
            if (inputData == null || inputData[Constants.USER_IP_ADRESS].Count == 0)
            {
                MessageBox.Show("Входные данные пусты!");
                return;
            }

            if (corporateData == null || corporateData.Count == 0)
            {
                MessageBox.Show("Данные о корпоративных ресурсах отсутствуют! Заполните таблицу!");
                return;
            }

            AnalyzeController controller = new AnalyzeController(inputData, corporateData);
            List<Statistic> statisticInfo = controller.Analyze();
            if (statisticInfo.Count > 0)
            {
                foreach (var element in statisticInfo)
                {
                    resultText.Text += "Пользователь (IP): " + element.UserIp + Environment.NewLine;
                    resultText.Text += "    Веб-сайт: " + element.WebSite + Environment.NewLine;
                    resultText.Text += "    Количество посещений: " + element.Counter.ToString() + Environment.NewLine;
                    resultText.Text += "    Сайт корпоративный? - " + (element.IsCorporateWebSite ? "Да" : "Нет") + Environment.NewLine;
                    resultText.Text += Environment.NewLine;
                }
            }
            else MessageBox.Show("Отсутствуют данные для исследования!");
        }

        private void faqMenuButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнила студент УГНТУ СФ Дмитриева Полина", "Справка о разработчике");
        }
    }
}
