﻿using System;
using System.Collections;
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
            //  panel3.Visible = false;
        }

        Form parentForm;
        MySqlConnection conSales;

        public MySqlConnection ConSales { get => conSales; set => conSales = value; }

        public Sales(MySqlConnection con, Form form)
        {
            InitializeComponent();
            ConSales = con;
            // panel3.Visible = false;
            parentForm = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Dock = DockStyle.Fill;
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fish_shopDataSet1.partners". При необходимости она может быть перемещена или удалена.
            //this.partnersTableAdapter.Fill(this.fish_shopDataSet1.partners);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "fish_shopDataSet.products". При необходимости она может быть перемещена или удалена.
            //this.productsTableAdapter.Fill(this.fish_shopDataSet.products);

        }



        /*private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Text = "Главное меню";
            conSales.Close();
        }*/
        String table;
        String tableLike;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter data = new MySqlDataAdapter($"SELECT * FROM {table} WHERE {tableLike} LIKE '%{textBox1.Text}%'", conSales);
            DataSet dstFish_Shop = new DataSet("fish_shop");
            data.Fill(dstFish_Shop, $"{table}");
            DataTable dataTable;
            dataTable = dstFish_Shop.Tables[$"{table}"];
            dataGridView1.DataSource = dataTable;
        }

        private void Sales_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Text = "Главное меню";
            conSales.Close();
        }

        int numberProducts = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            dataGridView2.Rows.Add(new Object[] { dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value,
                                                comboBox1.SelectedItem});
            numberProducts++;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Dock = DockStyle.Fill;
            table = "PRODUCTS";
            tableLike = "NAME_PRODUCT";
            MySqlDataAdapter data = new MySqlDataAdapter("SELECT ID_PRODUCT, NAME_PRODUCT, QUANTITY, SUM " +
                                                        $"FROM {table}", conSales);
            DataSet dstFish_Shop = new DataSet("fish_shop");
            data.Fill(dstFish_Shop, $"{table}");
            DataTable dataTable;
            dataTable = dstFish_Shop.Tables[$"{table}"];
            dataGridView1.DataSource = dataTable;
            //=================================================
            dataGridView1.Columns[0].HeaderText = "НОМЕР";
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].HeaderText = "Имя товара";
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].HeaderText = "Количество";
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[3].HeaderText = "Сумма";
            dataGridView1.Columns[3].Width = 70;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Dock = DockStyle.Fill;
            table = "PARTNERS";
            tableLike = "NAME_PARTNERS";
            MySqlDataAdapter data = new MySqlDataAdapter($"SELECT * FROM {table}", conSales);
            DataSet dstFish_Shop = new DataSet("fish_shop");
            data.Fill(dstFish_Shop, $"{table}");
            DataTable dataTable;
            dataTable = dstFish_Shop.Tables[$"{table}"];
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns[0].HeaderText = "НОМЕР";
            dataGridView1.Columns[1].HeaderText = "Имя партнера";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Dock = DockStyle.Fill;
            table = "buyer";
            tableLike = "fio";
            MySqlDataAdapter data = new MySqlDataAdapter($"SELECT * FROM {table}", conSales);
            DataSet dstFish_Shop = new DataSet("fish_shop");
            data.Fill(dstFish_Shop, $"{table}");
            DataTable dataTable;
            dataTable = dstFish_Shop.Tables[$"{table}"];
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns[0].HeaderText = "НОМЕР";
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].HeaderText = "ФИО";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].HeaderText = "Номер телефона";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].HeaderText = "Дата регистрации";
            dataGridView1.Columns[3].Width = 90;
        }

        ArrayList shopping = new ArrayList();

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.ColumnCount = 2;
            dataGridView2.Columns[0].HeaderText = "Наименование товара";
            dataGridView2.Columns[0].Width = 90;
            dataGridView2.Columns[1].HeaderText = "Количество штук";
            dataGridView2.Columns[1].Width = 90;

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            panel4.Visible = true;
            /*for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                sb.Append(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[i].Value + " ");          
            }*/
            label2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            int quantity = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString());
            for (int j = 0; j < quantity; j++) 
            {
                comboBox1.Items.Add(j+1);
            }
          
            //MessageBox.Show(sb.ToString());
            
        
        }
        int rowsCount;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowsCount = dataGridView2.CurrentRow.Index;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.RemoveAt(rowsCount);
        }         

        private void button7_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < numberProducts; k++)
            {
                String nameProducts = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                String quntityProducts = dataGridView2.CurrentRow.Cells[1].Value.ToString();

                //==============================================

                String querySQL = $"SELECT QUANTITY " +
                               $"FROM PRODUCTS " +
                               $"WHERE NAME_PRODUCT = '{nameProducts}'";
                MySqlCommand command = new MySqlCommand(querySQL, conSales);
                int oldQuantity = Convert.ToInt32(command.ExecuteScalar().ToString());
                //==============================================

                String queryUpdateQuantity = $"UPDATE PRODUCTS SET QUANTITY = {oldQuantity - Convert.ToInt32(quntityProducts)} " +
                                $"WHERE NAME_PRODUCT = '{nameProducts}'";
                MySqlCommand commandUpdate = new MySqlCommand(queryUpdateQuantity, conSales);
                commandUpdate.ExecuteNonQuery();
            }
            dataGridView2.ClearSelection();
        }

        private void добавитьТоварToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InteractionDB interactionDB = new InteractionDB("Наименование товара",
                                                            "Количество",
                                                            "Цена за штуку");
            interactionDB.ShowDialog();
        }
    }
}
