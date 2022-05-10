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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string typereport)
        {
            InitializeComponent();
            switch (typereport) 
            {
                case "поступило":
                    loadReportEntranceproducts();
                break;
            }
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
    }
}
