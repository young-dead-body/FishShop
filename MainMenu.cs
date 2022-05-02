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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            
            
        }

        private void aboutTheProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This software is designed for the operation of a fishing accessories store. " +
                "Thank you for using this software. " +
                "For support questions, please follow the link: https://github.com/young-dead-body", "About the program",
                MessageBoxButtons.OK, MessageBoxIcon.None);
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ДЛЯ ПООДКЛЮЧЕНИЯ К БД
            login login = new login(this);
            login.Show();
         
        }
  
    }
}
