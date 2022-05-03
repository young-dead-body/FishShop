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
    public partial class InteractionDB : Form
    {
        public InteractionDB()
        {
            InitializeComponent();
        }

        public InteractionDB(string labelNameProduct, string labelQuantity, string labelSum)
        {
            InitializeComponent();
            Text = "Добавить товар";
            label1.Text = labelNameProduct;
            label2.Text = labelQuantity;
            label3.Text = labelSum;
            label4.Visible = false;
            textBox4.Visible = false;
            dateTimePicker1.Visible = false;
            button1.Text = "Добавить";
            button2.Text = "Отменить";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
