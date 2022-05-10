using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishShop
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            panel2.Visible = false;
        }
        String sqlTable = "";
        Sales parentFrom;

        public ReportForm(string typereport, Sales pF)
        {
            InitializeComponent();
            panel2.Visible = false;
            Text = typereport;

            switch (typereport) 
            {
                case "Отчет о поступлении товаров":
                    sqlTable = "entranceproducts";
                    break;
                case "Отчет о продаже товаров":
                    sqlTable = "saleproducts";
                    break;
                case "Отчет о наличии товаров":
                    sqlTable = "products";
                    break;
            }
            loadReportEntranceproducts();
            parentFrom = pF;
        }
    

        private void loadReportEntranceproducts()
        {
            reportViewer1.Clear();
            panel1.Visible = true;
            List<ForReport> list;  //get list of students
            list = ForReportRepository.start();
            reportViewer1.LocalReport.DataSources.Clear(); //clear report
            reportViewer1.LocalReport.ReportEmbeddedResource = "FishShop.Report1.rdlc"; // bind reportviewer with .rdlc
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", list); // set the datasource
            reportViewer1.LocalReport.DataSources.Add(dataset);
            dataset.Value = list;
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport(); // refresh report
        }

        private void сортироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel2.Visible = true;
            //panel2.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            DateTime date = dateTimePicker1.Value;
            string onDate = $"{date.Year}-{date.Month}-{date.Day}";
            date = dateTimePicker2.Value;
            string offDate = $"{date.Year}-{date.Month}-{date.Day}";
            switch (sqlTable) 
            {
                case "entranceproducts":
                    parentFrom.reportParser1(sqlTable, comboBox2.Text,
                            comboBox1.Text, onDate, offDate);
                    break;
                case "saleproducts":
                    parentFrom.reportParser2(sqlTable, comboBox2.Text,
                            comboBox1.Text, onDate, offDate);
                    break;
                case "products":
                    parentFrom.reportParser3(sqlTable, comboBox2.Text,
                            comboBox1.Text, onDate, offDate);
                    break;
                default:
                    MessageBox.Show("Неожиданное завершение процесса обратитесь к администратору", "Ошибка");
                    break;
            }
            loadReportEntranceproducts();
        }

        private void конкретныеВидыИМаркиПоДатеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy-mm-dd";
            dateTimePicker2.CustomFormat = "yyyy-mm-dd";
            //============================
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            //============================
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            //============================
            panel2.Visible = true;
            panel2.Dock = DockStyle.Fill;
        }

        private void поДатеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //============================
            label1.Visible = false;           
            label4.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            //============================
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            //============================
            panel2.Visible = true;
            panel2.Dock = DockStyle.Fill;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
