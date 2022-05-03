using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;

namespace FishShop
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
           
        }

        Form parentForm;
        public login(Form form)
        {
            InitializeComponent();
            parentForm = form;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                String login = textBox1.Text;
                String password = textBox2.Text;

                bool start = parser.pars(login,password);

                if (start) 
                {
                    //=======================================
                    String connection = $"Database=fish_shop;Data Source=localhost;User Id={login};Password={password}";
                    MySqlConnection con = new MySqlConnection(connection);
                    con.Open();

                    /*String query = "UPDATE products SET SUM = 300 WHERE ID_PRODUCT = 1";
                    MySqlCommand update_table = new MySqlCommand(query, con);
                    update_table.ExecuteNonQuery();*/


                    //=======================================
                    Handler.closeLoginForm(login, parentForm);
                    //========================================
                    Sales sales = new Sales(con, parentForm);
                    sales.Show();
                    //========================================
                    parentForm.WindowState = FormWindowState.Minimized;
                    Close();
                }
                else
                {
                    MessageBox.Show("Error login/password", "error");
                }
            }

                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }

    }
}
