using System;
using System.Collections;
using System.Collections.Generic;
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
            panel3.Visible = false;
            dataGridView2.Enabled = false;
            panel5.Visible = false;
        }

        Form parentForm;
        MySqlConnection conSales;

        public MySqlConnection ConSales { get => conSales; set => conSales = value; }

        public Sales(MySqlConnection con, Form form)
        {
            InitializeComponent();
            ConSales = con;
            panel3.Visible = false;
            parentForm = form;
            dataGridView2.Enabled = false;
            panel5.Visible = false;
            comboBox2.Visible = false;
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

        String table;
        String tableLike;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (table == "products") 
            {
                MySqlDataAdapter data = new MySqlDataAdapter($"SELECT ID_PRODUCT, NAME_PRODUCT, QUANTITY, SUM, TYPE_PRODUCT, MARKA_PRODUCT FROM {table} WHERE {tableLike} LIKE '%{textBox1.Text}%'", conSales);
                DataSet dstFish_Shop = new DataSet("fish_shop");
                data.Fill(dstFish_Shop, $"{table}");
                DataTable dataTable;
                dataTable = dstFish_Shop.Tables[$"{table}"];
                dataGridView1.DataSource = dataTable;
            }
            else 
            {
                MySqlDataAdapter data = new MySqlDataAdapter($"SELECT * FROM {table} WHERE {tableLike} LIKE '%{textBox1.Text}%'", conSales);
                DataSet dstFish_Shop = new DataSet("fish_shop");
                data.Fill(dstFish_Shop, $"{table}");
                DataTable dataTable;
                dataTable = dstFish_Shop.Tables[$"{table}"];
                dataGridView1.DataSource = dataTable;
            }
           
        }

        private void Sales_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Text = "Главное меню";
            conSales.Close();
        }

        int numberProducts = 0;

        ArrayList dataSale = new ArrayList();
        ArrayList PK_PRODUCTS = new ArrayList();
        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = true;
            int kolvo = 0;
            if (comboBox1.SelectedIndex == -1) {
                kolvo = 1;
            }
            else {
                kolvo = comboBox1.SelectedIndex + 1;
            }

            dataGridView2.Rows.Add(new Object[] { dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value,
                                                    kolvo});
            numberProducts++;
            dataSale.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value);
            dataSale.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value);
            dataSale.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value);
            PK_PRODUCTS.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            typeMenu = "Выбрать";
            panel4.Visible = false;
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Dock = DockStyle.Fill;
            table = "PRODUCTS";
            tableLike = "NAME_PRODUCT";
            comboBox2.Visible = true;
            loadProducts();
        }

        private void loadProducts() {
            MySqlDataAdapter data = new MySqlDataAdapter("SELECT ID_PRODUCT, NAME_PRODUCT, QUANTITY, SUM, TYPE_PRODUCT, MARKA_PRODUCT " +
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
            dataGridView1.Columns[4].HeaderText = "Тип";
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[5].HeaderText = "Марка";
            dataGridView1.Columns[5].Width = 90;
            //dataGridView1.Columns[6].HeaderText = "Дата";

            dataGridView1.Width = 550;
            Width = 740;
            textBox1.Location = new System.Drawing.Point(565, 3);
            textBox1.Width = 140;
            button2.Location = new System.Drawing.Point(565, 315);
            panel4.Location = new System.Drawing.Point(565, 28);
            panel5.Location = new System.Drawing.Point(565, 28);
            comboBox2.Location = new System.Drawing.Point(565, 250);
            comboBox2.Width = 140;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            typeMenu = "";
            Width = 600;
            comboBox2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Dock = DockStyle.Fill;
            table = "PARTNERS";
            tableLike = "NAME_PARTNERS";
            loadPartners();
        }

        private void loadPartners()
        {
            MySqlDataAdapter data = new MySqlDataAdapter($"SELECT * FROM {table}", conSales);
            DataSet dstFish_Shop = new DataSet("fish_shop");
            data.Fill(dstFish_Shop, $"{table}");
            DataTable dataTable;
            dataTable = dstFish_Shop.Tables[$"{table}"];
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns[0].HeaderText = "НОМЕР";
            dataGridView1.Columns[1].HeaderText = "Имя партнера";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Width = 400;
            textBox1.Location = new System.Drawing.Point(420, 3);
            panel4.Location = new System.Drawing.Point(420, 28);
            button2.Location = new System.Drawing.Point(420, 315);
            panel5.Location = new System.Drawing.Point(420, 28);
            textBox1.Width = 140;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Dock = DockStyle.Fill;
            table = "buyer";
            tableLike = "fio";
            //ДОДЕЛАЙ 
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
            textBox1.Location = new System.Drawing.Point(420, 3);
            panel4.Location = new System.Drawing.Point(420, 28);
            button2.Location = new System.Drawing.Point(420, 315);
            panel5.Location = new System.Drawing.Point(420, 28);
            textBox1.Width = 140;
        }

        String typeData = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.ColumnCount = 2;
            dataGridView2.Columns[0].HeaderText = "Наименование товара";
            dataGridView2.Columns[0].Width = 90;
            dataGridView2.Columns[1].HeaderText = "Количество штук";
            dataGridView2.Columns[1].Width = 90;

            switch (typeMenu)
            {
                case "Удаление":
                    panel5.Visible = true;
                    label5.Text = $"Вы выбрали {typeData}";
                    label6.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                    break;

                case "Выбрать":
                    comboBox1.Items.Clear();
                    panel4.Visible = true;
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();

                    label2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                    try
                    {
                        int quantity = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString());
                        for (int j = 0; j < quantity; j++)
                        {
                            comboBox1.Items.Add(j + 1);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Вы выбрали пустую строку! В следующий раз будьте отснорожнее.", "Упс...");
                    }
                    break;
                case "Изменить":
                    panel5.Visible = true;

                    label5.Text = $"Вы выбрали {typeData}";
                    button8.Text = "Изменить";
                    label6.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                    break;
            }
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
                //String nameProducts = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                // String quantityProducts = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                String nameProducts = dataGridView2.Rows[k].Cells[0].Value.ToString();
                String quantityProducts = dataGridView2.Rows[k].Cells[1].Value.ToString();


                //==============================================

                String querySQL = $"SELECT QUANTITY " +
                               $"FROM PRODUCTS " +
                               $"WHERE ID_PRODUCT = {PK_PRODUCTS[k].ToString()}";
                MySqlCommand command = new MySqlCommand(querySQL, conSales);
                int oldQuantity = Convert.ToInt32(command.ExecuteScalar().ToString());
                int buyerQuantity = Convert.ToInt32(quantityProducts);
                //==============================================

                if (oldQuantity < buyerQuantity)
                {
                    MessageBox.Show($"Извините, покупка товара {nameProducts} в количестве: {buyerQuantity} штук невозможна. " +
                        $"Так как на складу находится лишь: {oldQuantity} штук", "Ошибочка вышла...");
                }
                else
                {
                    String queryUpdateQuantity = $"UPDATE PRODUCTS SET QUANTITY = {oldQuantity - buyerQuantity} " +
                                    $"WHERE ID_PRODUCT = {PK_PRODUCTS[k].ToString()}";
                    MySqlCommand commandUpdate = new MySqlCommand(queryUpdateQuantity, conSales);
                    commandUpdate.ExecuteNonQuery();

                    if (oldQuantity == buyerQuantity) // если равны по удаляем
                    {
                        String queryDelete = $"DELETE FROM PRODUCTS WHERE (ID_PRODUCT = {PK_PRODUCTS[k].ToString()})";
                        commandUpdate = new MySqlCommand(queryDelete, conSales);
                        commandUpdate.ExecuteNonQuery();
                    }
                    //======================================
                    String kolvo = dataGridView2.Rows[k].Cells[1].Value.ToString();
                    String date = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}";
                    String name_product = dataSale[k * 3].ToString();
                    String type_product = dataSale[k * 3 + 1].ToString();
                    String marka_product = dataSale[k * 3 + 2].ToString();
                    String insertQuery = $"INSERT INTO SALEPRODUCTS  (name_product, type_product, marka_product, data_sale, kolvo_saleproduct) " +
                        $"VALUES ('{name_product}', '{type_product}', '{marka_product}', '{date}', {kolvo});";
                    commandUpdate = new MySqlCommand(insertQuery, conSales);
                    commandUpdate.ExecuteNonQuery();
                    //======================================
                }
            }
            updateTable();
            //ВЕРНИСЬ
            Width = 600;
            dataGridView2.Rows.Clear();
            panel3.Visible = false;
            numberProducts = 0;
        }

        private void добавитьТоварToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InteractionDB interactionDB = new InteractionDB("Наименование товара",
                                                            "Количество",
                                                            "Цена за штуку", conSales);
            interactionDB.ShowDialog();
        }

        private void добавитьПартнераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InteractionDB interactionDB = new InteractionDB("Наименование партнера", conSales);
            interactionDB.ShowDialog();
        }

        private void добавитьПокупателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InteractionDB interactionDB = new InteractionDB("ФИО",
                                                            "Номер телефона",
                                                            conSales);
            interactionDB.ShowDialog();
        }

        String typeMenu = "";
        private void удалитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeData = "товар";
            typeDeleteData = "данный товар";
            button8.Text = "Удалить";
            panel4.Visible = false;
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Dock = DockStyle.Fill;
            table = "PRODUCTS";
            tableLike = "NAME_PRODUCT";
            loadProducts();
            typeMenu = "Удаление";
            //panel5.Visible = true;
        }

        String typeUpdateData = "";
        String typeDeleteData = "";

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "Удалить")
            {
                var result = MessageBox.Show($"Вы уверены что хотите удалить {typeDeleteData}?", "Проверка на удаление",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                var id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                String nameColums = tableSelection();

                if (result == DialogResult.Yes)
                {
                    String SQLScript = $"DELETE FROM {table} WHERE({nameColums} = {id})";
                    MySqlCommand commandDelete = new MySqlCommand(SQLScript, conSales);
                    commandDelete.ExecuteNonQuery();
                    updateTable();
                    panel5.Visible = false;
                }
            }
            else if (button8.Text == "Изменить")
            {
                var result = MessageBox.Show($"Вы уверены что хотите изменить информацию о данном {typeUpdateData}?", "Проверка на изменение",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                var id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                String nameColums = tableSelection();

                //=======================ПЕРЕДЕЛАТЬ ПОД ИЗМЕНЕНИЕ
                if (result == DialogResult.Yes)
                {
                    updateInformation();
                    updateTable();
                    panel5.Visible = false;
                }
                //===============================================================

            }
        }

        private void updateInformation()
        {
            ArrayList list = new ArrayList();
            InteractionDB interactionDB;
            //===========================
            switch (table)
            {
                case "PRODUCTS":
                    list.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                    list.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString());
                    list.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString());
                    list.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString());
                    list.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString());
                    list.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString());

                    interactionDB = new InteractionDB("Наименование товара",
                                                            "Количество",
                                                            "Цена за штуку",
                                                            list, conSales);
                    interactionDB.ShowDialog();
                    break;

                case "BUYER":
                    list.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                    list.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString());
                    list.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString());

                    interactionDB = new InteractionDB("ФИО", "Номер телефона", list, conSales);
                    interactionDB.ShowDialog();
                    break;

                case "PARTNERS":
                    list.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                    list.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString());

                    interactionDB = new InteractionDB("Наименование партнера",
                                                            list, conSales);
                    interactionDB.ShowDialog();
                    break;

                default:
                    MessageBox.Show("Непонятное завершение процесса. Обрабитесь к администратору", "ERROR");
                    //код, выполняемый если выражение не имеет ни одно из выше указанных значений
                    break;

            }
        }

        private string tableSelection()
        {
            String nameColums = "";
            switch (table)
            {
                case "PRODUCTS":
                    nameColums = "ID_PRODUCT";
                    break;

                case "BUYER":
                    nameColums = "ID_BUYER";
                    break;

                case "PARTNERS":
                    nameColums = "ID_PARTNER";
                    break;

                default:
                    MessageBox.Show("Непонятное завершение процесса. Обрабитесь к администратору", "ERROR");
                    //код, выполняемый если выражение не имеет ни одно из выше указанных значений
                    break;

            }

            return nameColums;
        }

        private void updateTable()
        {
            switch (table)
            {
                case "PRODUCTS":
                    updateTableProducts();
                    break;

                case "BUYER":
                    updateTableBUYER();
                    break;

                case "PARTNERS":
                    updateTablePARTNERS();
                    break;

                default:
                    MessageBox.Show("Непонятное завершение процесса. Обрабитесь к администратору", "ERROR");
                    //код, выполняемый если выражение не имеет ни одно из выше указанных значений
                    break;

            }
        }

        private void updateTablePARTNERS()
        {
            loadPartners();
        }

        private void updateTableBUYER()
        {
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
            textBox1.Location = new System.Drawing.Point(420, 3);
            panel4.Location = new System.Drawing.Point(420, 28);
            button2.Location = new System.Drawing.Point(420, 315);
            panel5.Location = new System.Drawing.Point(420, 28);
            textBox1.Width = 140;
        }

        private void updateTableProducts()
        {
            loadProducts();
        }

        private void изменитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeData = "товар";
            typeUpdateData = "товаре";
            typeMenu = "Изменить";
            table = "PRODUCTS";
            panel2.Visible = true;
            loadProducts();
        }

        private void удалитьПартнераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeData = "партнера";
            typeDeleteData = "данного партнера";
            button8.Text = "Удалить";
            panel4.Visible = false;
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Dock = DockStyle.Fill;
            table = "PARTNERS";
            //======================================
            loadPartners();
            //=================================================
            typeMenu = "Удаление";
        }

        private void изменитьИнформациюОПартнереToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeData = "партнера";
            typeUpdateData = "партнере";
            typeMenu = "Изменить";
            table = "PARTNERS";
            panel2.Visible = true;
            //======================================
            loadPartners();
        }

        private void изменитьИнформациюОПокупателеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeData = "покупателя";
            typeUpdateData = "покупателе";
            typeMenu = "Изменить";
            table = "BUYER";
            panel2.Visible = true;
            //======================================
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
            textBox1.Location = new System.Drawing.Point(420, 3);
            panel4.Location = new System.Drawing.Point(420, 28);
            button2.Location = new System.Drawing.Point(420, 315);
            panel5.Location = new System.Drawing.Point(420, 28);
            textBox1.Width = 140;
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String sqlTable = "entranceproducts";
            loadReport(sqlTable, 1, 2, 3, 4, 5);

            ReportForm form1 = new ReportForm("Отчет о поступлении товаров");
            form1.Show();
        }

        private void отчетПоПродажеТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String sqlTable = "saleproducts";
            loadReport(sqlTable,1, 2, 3, 4, 5);

            ReportForm form1 = new ReportForm("Отчет о продаже товаров");
            form1.Show();
        }

        private void loadReport(string sqlTable, int first, int second, int third, int fourth, int fifth) 
        {
            MySqlDataAdapter data = new MySqlDataAdapter($"SELECT * FROM {sqlTable}", conSales);
            DataSet dstFish_Shop = new DataSet("fish_shop");
            data.Fill(dstFish_Shop, $"{sqlTable}");
            DataTable dataTable;
            dataTable = dstFish_Shop.Tables[$"{sqlTable}"];
            dataGridView1.DataSource = dataTable;

            //////////
            String querySQL = $"SELECT COUNT(*) FROM {sqlTable}";
            MySqlCommand command = new MySqlCommand(querySQL, conSales);
            int count = Convert.ToInt32(command.ExecuteScalar().ToString());
            /////////
            ForReportRepository.Clear();
            for (int i = 0; i < count; i++)
            {
                int ID = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                string Name = dataGridView1.Rows[i].Cells[first].Value.ToString();
                string TYPE = dataGridView1.Rows[i].Cells[second].Value.ToString();
                string Marka = dataGridView1.Rows[i].Cells[third].Value.ToString();
                string Date = dataGridView1.Rows[i].Cells[fourth].Value.ToString();
                int Kolvo = Convert.ToInt32(dataGridView1.Rows[i].Cells[fifth].Value);
                ForReportRepository.GetForReports(ID, Name, TYPE, Marka, Date, Kolvo);
            }
        }

        private void отчетПоНаличиюТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String sqlTable = "products";
            loadReport(sqlTable,3,4,5,6,2);

            ReportForm form1 = new ReportForm("Отчет о наличии товаров");
            form1.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter data = new MySqlDataAdapter($"SELECT ID_PRODUCT, NAME_PRODUCT, QUANTITY, SUM, TYPE_PRODUCT, MARKA_PRODUCT FROM {table} WHERE TYPE_PRODUCT LIKE '%{comboBox2.Text}%'", conSales);
            DataSet dstFish_Shop = new DataSet("fish_shop");
            data.Fill(dstFish_Shop, $"{table}");
            DataTable dataTable;
            dataTable = dstFish_Shop.Tables[$"{table}"];
            dataGridView1.DataSource = dataTable;
        }

        private void просмотрПоступленийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            dataGridView1.Width = 670;
            Width = 800;
            button2.Location = new System.Drawing.Point(700, 310);
            MySqlDataAdapter data = new MySqlDataAdapter($"SELECT * FROM entranceproducts", conSales);
            DataSet dstFish_Shop = new DataSet("fish_shop");
            data.Fill(dstFish_Shop, $"entranceproducts");
            DataTable dataTable;
            dataTable = dstFish_Shop.Tables[$"entranceproducts"];
            dataGridView1.DataSource = dataTable;

            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].HeaderText = "Наименование";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].HeaderText = "Вид";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].HeaderText = "Марка";
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].HeaderText = "Дата поступления";
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[5].HeaderText = "Количество";
            dataGridView1.Columns[5].Width = 90;
        }
    }
}
