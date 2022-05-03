using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FishShop
{
    class parser
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


        public static int parsPrimaryKey(String nameTable)
        {
            var filepath = "PrimaryKey.xml";

            // Объявляем и забиваем файл в документ  
            XmlDocument doc = new XmlDocument();
            FileStream fs = new FileStream(filepath, FileMode.Open);
            doc.Load(fs);
            int result = 0;
            //XmlNodeList list = doc.GetElementsByTagName(nameTable); // Создаем и заполняем лист по тегу "user"  

            XmlNodeList xmlNodeList = doc.GetElementsByTagName("primarykey");

            for (int i = 0; i < xmlNodeList.Count; i++)
            {
                XmlElement pk = (XmlElement)doc.GetElementsByTagName("products")[i];      // Забиваем login в переменную  
                result = Convert.ToInt32(pk.InnerText);
            }
            // Закрываем поток  
            fs.Close();
            return result;
        }


        public static void parsWritePK(int a, String nameTable) 
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("PrimaryKey.xml");
            foreach (XmlNode xn in doc.GetElementsByTagName("primarykey"))
            {
                    XmlNode PK = doc.CreateElement(nameTable);
                    PK.InnerText = a.ToString();
                    xn.AppendChild(PK);
                    break;
            }
            doc.Save("PrimaryKey.xml");
        }
    }
}
