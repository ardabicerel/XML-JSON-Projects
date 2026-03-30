using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLandADO.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            string baglantiCumlesi = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

            SqlDataAdapter adp = new SqlDataAdapter("Select * From Employees", baglantiCumlesi);

            DataSet ds = new DataSet();

            adp.Fill(ds);

            ds.WriteXml("Employees.xml");

            MessageBox.Show("Yazma Tamamlandı.");
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            if (File.Exists("Employees.xml"))
            {
                ds.ReadXml("Employees.xml");

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("XML dosyası bulunamadı. Önce XML Oluştur butonuna basın.");
            }
        }
    }
}
