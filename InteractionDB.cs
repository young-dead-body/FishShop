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

            dateTimePicker1.Visible = false;
            button1.Text = "Изменить";
            button2.Text = "Отменить";
            conFish_Shop = connection;
            dataTable = list;
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

            button1.Text = "Добавить";
            button2.Text = "Отменить";
            conFish_Shop = connection;
            dataTable = list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String queryUpdateQuantity;
            MySqlCommand commandInsert;
            if (button1.Text == "Изменить")
            {
                MySqlCommand commandUpdate;
                String SQLScript;
                switch (Text)
                {
                    case "Изменить товар":
                        SQLScript = $"UPDATE PRODUCTS SET " +
                                       $"SUM = {textBox3.Text}, QUANTITY = {textBox2.Text}, " +
                                       $"NAME_PRODUCT = '{textBox1.Text}'" +
                                       $"WHERE(ID_PRODUCT = {dataTable[0].ToString()})";
                        commandUpdate = new MySqlCommand(SQLScript, conFish_Shop);
                        commandUpdate.ExecuteNonQuery();
                        break;
                    case "Изменить партнера":
                        SQLScript = $"UPDATE PARTNERS SET " +
                                       $"NAME_PARTNERS = '{textBox1.Text}'"+
                                       $"WHERE(ID_PARTNER = {dataTable[0].ToString()})";
                        commandUpdate = new MySqlCommand(SQLScript, conFish_Shop);
                        commandUpdate.ExecuteNonQuery();
                        break;
                    case "Изменить покупателя":
                        SQLScript = $"UPDATE PRODUCTS SET " +
                                      $"SUM = {textBox3.Text}, QUANTITY = {textBox2.Text}, " +
                                      $"NAME_PRODUCT = '{textBox1.Text}'" +
                                      $"WHERE(ID_PRODUCT = {dataTable[0].ToString()})";
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
                switch (Text)
                {
                    case "Добавить товар":
                        queryUpdateQuantity = $"INSERT INTO PRODUCTS (NAME_PRODUCT, QUANTITY, SUM) " +
                                                    $"VALUES ('{parser.parserText(textBox1.Text)}', {textBox2.Text}, {textBox3.Text})";
                        commandInsert = new MySqlCommand(queryUpdateQuantity, conFish_Shop);
                        commandInsert.ExecuteNonQuery();
                        break;
                    case "Добавить партнера":
                        queryUpdateQuantity = $"INSERT INTO PARTNERS (NAME_PARTNERS) " +
                                                    $"VALUES ('{parser.parserText(textBox1.Text)}')";
                        commandInsert = new MySqlCommand(queryUpdateQuantity, conFish_Shop);
                        commandInsert.ExecuteNonQuery();
                        break;
                    case "Добавить покупателя":
                        String date = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}";

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
    }
}
