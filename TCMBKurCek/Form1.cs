using System;
using System.Net;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCMB_Get_Exchange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int gun = dateTimePicker1.Value.Day;
            int ay = dateTimePicker1.Value.Month;
            int yil = dateTimePicker1.Value.Year;

            dataGridView1.DataSource = source(new DateTime(yil, ay, gun));
        }

        public DataTable source(DateTime Tarih)
        {
            DataTable dt = new DataTable();
            DataRow dRow;
            string[] sutunlar =
            {
                "DovizCinsi", "DovizAdi", "DovizAlis",
                "DovizSatis", "EfektifAlis", "EfektifSatis"
            };

            foreach (string item in sutunlar)
            {
                dt.Columns.Add(new DataColumn(item, typeof(string)));
            }

            string gun = Tarih.Day.ToString("00");
            string ay = Tarih.Month.ToString("00");
            string yil = Tarih.Year.ToString();

            string adres = "http://tcmb.gov.tr/kurlar/";

            string dovizXml = adres + "/" + yil + ay + "/" + gun + ay + yil + ".xml";

            XmlDocument xmlDoc = new XmlDocument();

            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; // TLS 1.2 standardını zorunlu kılar

            try
            {
                xmlDoc.Load(dovizXml);

                for(int i = 0; i <= 17; i++)
                {
                    string taki = "/Tarih_Date/Currency";
                    dRow = dt.NewRow();

                    dRow[sutunlar[0]] = xmlDoc.SelectNodes(taki + "/Isim").Item(i).InnerText;
                    dRow[sutunlar[1]] = xmlDoc.SelectNodes(taki + "/@Kod").Item(i).InnerText;
                    dRow[sutunlar[2]] = xmlDoc.SelectNodes(taki + "/ForexBuying").Item(i).InnerText;
                    dRow[sutunlar[3]] = xmlDoc.SelectNodes(taki + "/ForexSelling").Item(i).InnerText;
                    dRow[sutunlar[4]] = xmlDoc.SelectNodes(taki + "/BanknoteBuying").Item(i).InnerText;
                    dRow[sutunlar[5]] = xmlDoc.SelectNodes(taki + "/BanknoteSelling").Item(i).InnerText;
                    dt.Rows.Add(dRow);
                }
            }
            catch
            {
                MessageBox.Show(dateTimePicker1.Value + "\nGününe ait kur açıklanmamış");
            }
            return dt;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int gun = dateTimePicker1.Value.Day;
            int ay = dateTimePicker1.Value.Month;
            int yil = dateTimePicker1.Value.Year;

            dataGridView1.DataSource = source(new DateTime(yil, ay, gun));
        }
    }
}
