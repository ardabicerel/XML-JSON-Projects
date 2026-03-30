using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML_Sample___READXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DirectoryInfo inf = new DirectoryInfo(Environment.CurrentDirectory);
            ofd.InitialDirectory = inf.Parent.Parent.FullName;
            ofd.Filter = "XML Dosyaları|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataSet ds = new DataSet();
                ds.ReadXml(ofd.FileName);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
