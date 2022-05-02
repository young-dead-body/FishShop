using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishShop
{
    class Handler
    {
        public static void closeLoginForm(String userName, Form form)
        {
            form.Text = $"Главное меню [{userName}]";
        }
    }
}
