using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishShop
{
    public class ForReport
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string TYPE { get; set; }

        public string Marka { get; set; }

        public string Date { get; set; }

        public int Kolvo { get; set; }
    }

    public class ForReportRepository
    {
        public static List<ForReport> list = new List<ForReport> { };

        public static List<ForReport> GetForReports(int id, string name, string type, string marka, string date, int kolvo)
        {
            list.Add(new ForReport
            {
                ID = id,
                Name = name,
                TYPE = type,
                Marka = marka,
                Date = date,
                Kolvo = kolvo
            }
            );
            return list;

        }

        public static List<ForReport> start()
        {
            return list;
        }

        public static void Clear() 
        {
            list.Clear();
        }
    }
}

