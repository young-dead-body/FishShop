using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace FishShop
{
    public class parser
    {
        public static bool parsLoader(String login, String password) 
        {
            var filepath = "loader.xml";
            var pid = "3";
            string name, pwd; // Новые переменные имени и пароля  

            // Объявляем и забиваем файл в документ  
            XmlDocument xd = new XmlDocument();
            FileStream fs = new FileStream(filepath, FileMode.Open);
            xd.Load(fs);

            XmlNodeList list = xd.GetElementsByTagName("user"); // Создаем и заполняем лист по тегу "user"  
            for (int i = 0; i < list.Count; i++)
            {
               // XmlElement id = (XmlElement)xd.GetElementsByTagName("user")[i];         // Забиваем id в переменную  
                XmlElement user = (XmlElement)xd.GetElementsByTagName("login")[i];      // Забиваем login в переменную  
                XmlElement pass = (XmlElement)xd.GetElementsByTagName("password")[i];   // Забиваем password в переменную  

                name = user.InnerText;
                if (name == login)
                {
                    pwd = pass.InnerText;
                    if (pwd == password)
                    {
                        fs.Close();
                        return true;
                    }
                }
            }
            // Закрываем поток  
            fs.Close();
            return false;
        }


        public static String parserText(String str1)
        {
            String str2 = "";
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == '\'')
                {
                    str2 += "\\\"";
                }
                else
                {
                    str2 += str1[i];
                }
            }
            return str2;
        }
    }
}
