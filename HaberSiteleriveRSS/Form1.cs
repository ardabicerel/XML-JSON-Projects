using System;
using System.Xml;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsWebsite_and_RSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        XmlDocument xdoc = new XmlDocument();
        XmlNodeList nodeListesi;
        private void Form1_Load(object sender, EventArgs e)
        {
            xdoc.Load("https://www.hurriyet.com.tr/rss/anasayfa");

            nodeListesi = xdoc.SelectNodes("//item");
            
            foreach(XmlNode dugum in nodeListesi)
            {
                lBoxHaber.Items.Add(dugum["title"].InnerText);
            }
        }

        private void lBoxHaber_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilenIndeks = lBoxHaber.SelectedIndex;
            if(secilenIndeks != -1)
            {
                linkLabelHaber.Text = "Haberin devamı için tıklayın...";
                linkLabelHaber.Tag = nodeListesi[secilenIndeks]["link"].InnerText;
            }
        }
        private void linkLabelHaber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabelHaber.Tag != null && !string.IsNullOrEmpty(linkLabelHaber.Tag.ToString()))
            {
                string url = linkLabelHaber.Tag.ToString();

                try
                {
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tarayıcı açılırken bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce listeden bir haber seçin!");
            }
        }

    }
}
