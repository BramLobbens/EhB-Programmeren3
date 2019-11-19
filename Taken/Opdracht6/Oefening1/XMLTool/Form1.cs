using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLTool
{
    public partial class Form1 : Form
    {
        public XmlDocument doc;
        public string file;

        public Form1()
        {
            InitializeComponent();
            doc = new XmlDocument();
            file = @"C:\Test\gegevens.xml";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            // Create <Merken>
            XmlNode headNode = doc.CreateElement("Merken");
            doc.AppendChild(headNode);

            XmlNode merkNode1 = GetMerkInfo("D", "Opel", new string[] { "Astra", "Vectra" });
            XmlNode merkNode2 = GetMerkInfo("F", "Peugeot", new string[] { "407", "407SW" });
            XmlNode merkNode3 = GetMerkInfo("S", "Volvo", new string[] { "S40", "V50", "V70" });

            headNode.AppendChild(merkNode1);
            headNode.AppendChild(merkNode2);
            headNode.AppendChild(merkNode3);

            doc.Save(file);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(file);
        }

        private XmlNode GetMerkInfo(string country, string name, string[] types)
        {
            XmlNode merkNode = doc.CreateElement("Merk");

            XmlAttribute countryAttr = doc.CreateAttribute("LandHerkomst");
            countryAttr.Value = country;

            XmlAttribute nameAttr = doc.CreateAttribute("Naam");
            nameAttr.Value = name;

            merkNode.Attributes.Append(countryAttr);
            merkNode.Attributes.Append(nameAttr);

            foreach (string type in types)
            {
                XmlNode typeNode = doc.CreateElement("Type");
                typeNode.InnerText = type;
                merkNode.AppendChild(typeNode);
            }

            return merkNode;
        }
    }
}
