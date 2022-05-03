using System;
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
            label4.Visible = false;
            textBox4.Visible = false;
            dateTimePicker1.Visible = false;
            button1.Text = "Добавить";
            button2.Text = "Отменить";
            conFish_Shop = connection;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Text)
            {
                case "Добавить товар":
                    String queryUpdateQuantity = $"INSERT INTO PRODUCTS (ID_PRODUCT, NAME_PRODUCT, QUANTITY, SUM) " +
                                                $"VALUES ({parser.parsPrimaryKey("products")+1},'{textBox1.Text}', {textBox2.Text}, {textBox3.Text})";
                    MySqlCommand commandUpdate = new MySqlCommand(queryUpdateQuantity, conFish_Shop);
                    commandUpdate.ExecuteNonQuery();
                    break;
      
                default:
                    MessageBox.Show("Непонятное завершение процесса. Обрабитесь к администратору", "ERROR");
                    //код, выполняемый если выражение не имеет ни одно из выше указанных значений
                break;
            }
        }
    }
}
