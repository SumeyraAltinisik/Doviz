using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Doviz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public decimal kur = 0;
        public decimal kur2 = 0;
        public decimal hesap = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            DateTime dateTime = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            if (radioButton1.Checked == true)
            {
                if (Mevcut.SelectedItem == "Dolar")
                {
                    string USD = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
                    label1.Text = string.Format("Tarih {0} USD; {1}", dateTime.ToShortDateString(), USD);
                    kur = Convert.ToDecimal(USD);
                }
                if (Mevcut.SelectedItem == "Pound")
                {
                    string GBP = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
                    label1.Text = string.Format("Tarih {0} GBP; {1}", dateTime.ToShortDateString(), GBP);
                    kur = Convert.ToDecimal(GBP);
                }
                if (Mevcut.SelectedItem == "Euro")
                {
                    string EUR = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
                    label1.Text = string.Format("Tarih {0} EUR; {1}", dateTime.ToShortDateString(), EUR);
                    kur = Convert.ToDecimal(EUR);
                }

                if (cevirilecek.SelectedItem == "Dolar")
                {
                    string USD = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
                    kur2 = Convert.ToDecimal(USD);
                }
                if (cevirilecek.SelectedItem == "Pound")
                {
                    string GBP = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
                    kur2 = Convert.ToDecimal(GBP);
                }
                if (cevirilecek.SelectedItem == "Euro")
                {
                    string EUR = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
                    kur2 = Convert.ToDecimal(EUR);
                }
            }

            if (radioButton2.Checked == true)
            {
                if (Mevcut.SelectedItem == "Dolar")
                {
                    string USD = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
                    label1.Text = string.Format("Tarih {0} USD; {1}", dateTime.ToShortDateString(), USD);
                    kur = Convert.ToDecimal(USD);
                }
                if (Mevcut.SelectedItem == "Pound")
                {
                    string GBP = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
                    label1.Text = string.Format("Tarih {0} GBP; {1}", dateTime.ToShortDateString(), GBP);
                    kur = Convert.ToDecimal(GBP);
                }
                if (Mevcut.SelectedItem == "Euro")
                {
                    string EUR = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
                    label1.Text = string.Format("Tarih {0} EUR; {1}", dateTime.ToShortDateString(), EUR);
                    kur = Convert.ToDecimal(EUR);
                }

                if (cevirilecek.SelectedItem == "Dolar")
                {
                    string USD = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
                    kur2 = Convert.ToDecimal(USD);
                }
                if (cevirilecek.SelectedItem == "Pound")
                {
                    string GBP = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
                    kur2 = Convert.ToDecimal(GBP);
                }
                if (cevirilecek.SelectedItem == "Euro")
                {
                    string EUR = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
                    kur2 = Convert.ToDecimal(EUR);
                }
            }

            decimal adet = Convert.ToDecimal(cevirilendoviz.Text);
            hesap = (kur / kur2) * adet;
            label2.Text = hesap.ToString();
        }

        private void Mevcut_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cevirilecek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cevirilendoviz_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
