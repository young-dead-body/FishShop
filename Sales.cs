using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace FishShop
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            panel1.Visible = false;            
        }

        Form parentForm;
        MySqlConnection conSales;

        public MySqlConnection ConSales { get => conSales; set => conSales = value; }

        public Sales(MySqlConnection con, Form form)
        {
            InitializeComponent();
            ConSales = con;
            panel1.Visible = false;
            parentForm = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Dock = DockStyle.Fill;
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter data = new MySqlDataAdapter("SELECT * FROM PRODUCTS", conSales);
            DataSet dstFish_Shop = new DataSet("fish_shop");
            data.Fill(dstFish_Shop, "products");
            DataTable dataTable;
            dataTable = dstFish_Shop.Tables["products"];
            dataGridView1.DataSource = dataTable;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fish_shopDataSet.products". При необходимости она может быть перемещена или удалена.
            //this.productsTableAdapter.Fill(this.fish_shopDataSet.products);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Text = "Главное меню";
            conSales.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter data = new MySqlDataAdapter($"SELECT * FROM PRODUCTS WHERE NAME_PRODUCT LIKE '%{textBox2.Text}%'", conSales);
            DataSet dstFish_Shop = new DataSet("fish_shop");
            data.Fill(dstFish_Shop, "products");
            DataTable dataTable;
            dataTable = dstFish_Shop.Tables["products"];
            dataGridView1.DataSource = dataTable;
        }

        private void Sales_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Text = "Главное меню";
            conSales.Close();
        }
    }
}
