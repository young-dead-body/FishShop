using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FishShop
{
    public partial class InteractionDB : Form
    {
        public InteractionDB()
        {
            InitializeComponent();
        }

        MySqlConnection conFish_Shop;
        

        public InteractionDB(string label1Text, string label2Text, string label3Text, MySqlConnection connection)
        {
            InitializeComponent();
            Text = "Добавить товар";
            label1.Text = label1Text;
            label2.Text = label2Text;
            label3.Text = label3Text;
            dateTimePicker1.Visible = false;
            button1.Text = "Добавить";
            button2.Text = "Отменить";
            conFish_Shop = connection;
            label4.Text = "Тип товара";
            label5.Text = "Марка товара";
        }

        ArrayList dataTable;

        public InteractionDB(string label1Text, string label2Text, string label3Text, 
                                        ArrayList list, MySqlConnection connection)
        {
            InitializeComponent();
            Text = "Изменить товар";

            label1.Text = label1Text;
            label2.Text = label2Text;
            label3.Text = label3Text;

            textBox1.Text = list[1].ToString();
            textBox2.Text = list[2].ToString();
            textBox3.Text = list[3].ToString();
            comboBox1.Text = list[4].ToString();
            comboBox2.Text = list[5].ToString();

            dateTimePicker1.Visible = false;
            button1.Text = "Изменить";
            button2.Text = "Отменить";
            conFish_Shop = connection;
            dataTable = list;
            label4.Text = "Тип товара";
            label5.Text = "Марка товара";
        }

        public InteractionDB(string label1Text, string label2Text, MySqlConnection connection)
        {
            InitializeComponent();
            Text = "Добавить покупателя";
            label1.Text = label1Text;
            label2.Text = label2Text;
            label3.Visible = false;
            textBox3.Visible = false;
            dateTimePicker1.Visible = false;
            button1.Text = "Добавить";
            button2.Text = "Отменить";
            conFish_Shop = connection;
            label4.Visible = false;
            label5.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
        }

        public InteractionDB(string label1Text, string label2Text, ArrayList list, MySqlConnection connection)
        {
            InitializeComponent();
            Text = "Изменить покупателя";
            label1.Text = label1Text;
            textBox1.Text = list[1].ToString();
            label2.Text = label2Text;
            textBox2.Text = list[2].ToString();
            label3.Visible = false;
            textBox3.Visible = false;
            dateTimePicker1.Visible = false;
            button1.Text = "Изменить";
            button2.Text = "Отменить";
            conFish_Shop = connection;
            dataTable = list;
            label4.Visible = false;
            label5.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
        }

        public InteractionDB(string label1Text, MySqlConnection connection)
        {
            InitializeComponent();
            Text = "Добавить партнера";
            label1.Text = label1Text;

            label2.Visible = false;
            textBox2.Visible = false;
            
            label3.Visible = false;
            textBox3.Visible = false;
            
            dateTimePicker1.Visible = false;

            button1.Text = "Добавить";
            button2.Text = "Отменить";
            conFish_Shop = connection;
            label4.Visible = false;
            label5.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
        }

        public InteractionDB(string label1Text, ArrayList list,MySqlConnection connection)
        {
            InitializeComponent();
            Text = "Изменить партнера";
            label1.Text = label1Text;
            textBox1.Text = list[1].ToString();

            label2.Visible = false;
            textBox2.Visible = false;

            label3.Visible = false;
            textBox3.Visible = false;

            dateTimePicker1.Visible = false;

            button1.Text = "Изменить";
            button2.Text = "Отменить";
            conFish_Shop = connection;
            dataTable = list;
            label4.Visible = false;
            label5.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String date = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}";
            if (button1.Text == "Изменить")
            {
                MySqlCommand commandUpdate;
                String SQLScript;

                switch (Text)
                {
                    case "Изменить товар":
                        SQLScript = $"UPDATE PRODUCTS SET " +
                                       $"SUM = {textBox3.Text}, QUANTITY = {textBox2.Text}, " +
                                       $"NAME_PRODUCT = '{textBox1.Text}', TYPE_PRODUCT = '{comboBox1.SelectedItem}', " +
                                       $"MARKA_PRODUCT = '{comboBox2.SelectedItem}', DATE_PRODUCT = '{date}' " +
                                       $"WHERE(ID_PRODUCT = {dataTable[0].ToString()})";
                        commandUpdate = new MySqlCommand(SQLScript, conFish_Shop);
                        commandUpdate.ExecuteNonQuery();
                        insertEntranceproducts();
                        break;
                    case "Изменить партнера":
                        SQLScript = $"UPDATE PARTNERS SET " +
                                       $"NAME_PARTNERS = '{textBox1.Text}'"+
                                       $"WHERE(ID_PARTNER = {dataTable[0].ToString()})";
                        commandUpdate = new MySqlCommand(SQLScript, conFish_Shop);
                        commandUpdate.ExecuteNonQuery();
                        break;
                    case "Изменить покупателя":
                        SQLScript = $"UPDATE BUYER SET " +
                                      $"FIO = '{textBox1.Text}', " +
                                      $"PHONE_NUMBER = '{textBox2.Text}', " +
                                      $"DATE_BUYER = '{date}'" +
                                      $"WHERE(ID_BUYER = {dataTable[0].ToString()})";
                        commandUpdate = new MySqlCommand(SQLScript, conFish_Shop);
                        commandUpdate.ExecuteNonQuery();
                        break;
                    default:
                        MessageBox.Show("Непонятное завершение процесса. Обрабитесь к администратору", "ERROR");
                        //код, выполняемый если выражение не имеет ни одно из выше указанных значений
                        break;
                }
            }
            else
            {
                String queryUpdateQuantity;
                MySqlCommand commandInsert;
                switch (Text)
                {
                    case "Добавить товар":
                        queryUpdateQuantity = $"INSERT INTO PRODUCTS (NAME_PRODUCT, QUANTITY, SUM, TYPE_PRODUCT, MARKA_PRODUCT, DATE_PRODUCT) " +
                                                    $"VALUES ('{parser.parserText(textBox1.Text)}', {textBox2.Text}, " +
                                                    $"{textBox3.Text}, '{comboBox1.SelectedItem}', '{comboBox2.SelectedItem}', '{date}')";
                        commandInsert = new MySqlCommand(queryUpdateQuantity, conFish_Shop);
                        commandInsert.ExecuteNonQuery();
                        insertEntranceproducts();
                        break;
                    case "Добавить партнера":
                        queryUpdateQuantity = $"INSERT INTO PARTNERS (NAME_PARTNERS) " +
                                                    $"VALUES ('{parser.parserText(textBox1.Text)}')";
                        commandInsert = new MySqlCommand(queryUpdateQuantity, conFish_Shop);
                        commandInsert.ExecuteNonQuery();
                        break;
                    case "Добавить покупателя":

                        queryUpdateQuantity = $"INSERT INTO BUYER (FIO, PHONE_NUMBER, DATE_BUYER) " +
                                                    $"VALUES ('{textBox1.Text}', " +
                                                    $"'{textBox2.Text}', " +
                                                    $"'{date}')";
                        commandInsert = new MySqlCommand(queryUpdateQuantity, conFish_Shop);
                        commandInsert.ExecuteNonQuery();
                        break;
                    default:
                        MessageBox.Show("Непонятное завершение процесса. Обрабитесь к администратору", "ERROR");
                        //код, выполняемый если выражение не имеет ни одно из выше указанных значений
                        break;
                }
            }
            
            Close();
        }

        private void insertEntranceproducts() //ДОРАБОТАТЬ
        {
            String date = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}";
            String name_product = textBox1.Text;
            String type_product = comboBox1.Text;
            String marka_product = comboBox2.Text;
            int kolvo_entranceproduct = 0;
            if (Text == "Добавить товар")
            {
                kolvo_entranceproduct = Convert.ToInt32(textBox2.Text);
            }
            else 
            {
                // сделай скрипт для проверки прошлого значения
                // из текущего вычти прошлое 
                // проверку тоже сделай все таки продавец дурачок <3
            }
            String insertQuery = $"INSERT INTO entranceproducts (name_product, type_product, marka_product, data_entrance, kolvo_entranceproduct) " +
                $"VALUES ('{name_product}', '{type_product}', '{marka_product}', '{date}', {kolvo_entranceproduct});";
            MySqlCommand commandUpdate = new MySqlCommand(insertQuery, conFish_Shop);
            commandUpdate.ExecuteNonQuery();
        }
    }
}
