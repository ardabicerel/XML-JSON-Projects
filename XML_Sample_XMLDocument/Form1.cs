using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace XML_Sample_XMLDocument
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DirectoryInfo info = new DirectoryInfo(Environment.CurrentDirectory);

            ofd.Filter = "XML Dosyaları|*.xml";
            
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                XmlDocument XMLDoc = new XmlDocument();
                XMLDoc.Load(ofd.FileName);
                XmlNodeList nod = XMLDoc.DocumentElement.ChildNodes;
                
                StringBuilder stringBuilder = new StringBuilder();

                foreach(XmlNode item in nod)
                {
                    for(int i = 0; i < item.ChildNodes.Count; i++)
                    {
                        stringBuilder.Append(item.ChildNodes[i].InnerText + "-");
                        
                    }
                        string temizMetin = stringBuilder.ToString().TrimEnd('-');
                        
                        comboBox1.Items.Add(temizMetin);
                        stringBuilder.Clear();
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = $"Kişi Bilgi: {comboBox1.SelectedItem}";
        }
    }
}
