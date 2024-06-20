using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Collections.Generic;

namespace hot_beverage_machine
{
    public partial class Form1 : Form
    {
        XmlDocument xmlDocument;
        string rootElement = "hotDrinkData";
        string filename = "hotDrinkData.xml";
        string pathname = Directory.GetCurrentDirectory() + "\\hotDrinkData.xml";
        List<DrinkDTO> drinkList = new List<DrinkDTO>();
        public Form1()
        {
            InitializeComponent();

            // create xml if not exists
            xmlDocument = new XmlDocument();
            if (File.Exists(pathname))
            {
                xmlDocument.Load(pathname);
            }
            else
            {
                XmlNode root = xmlDocument.CreateElement("hotDrinkData");
                xmlDocument.AppendChild(root);
            }

            seedDGV();
        }

        private void seedDGV()
        {
            dataGridView1.Rows.Clear();

            // read xml and add to drinks list
            XmlNodeList drinkNodes = xmlDocument.GetElementsByTagName("drink");
            foreach (XmlNode drinkNode in drinkNodes)
            {
                string name = drinkNode["name"].InnerText;
                string price = drinkNode["price"].InnerText;
                string sugar = drinkNode["sugar"].InnerText;
                string milk = drinkNode["milk"].InnerText;
                string cocoa = drinkNode["cocoa"].InnerText;
                string coffee = drinkNode["coffee"].InnerText;
                DrinkDTO drink = new DrinkDTO(name, price, sugar, milk, cocoa, coffee);
                drinkList.Add(drink);
                dataGridView1.Rows.Add(drink.Name, drink.Price, drink.Sugar, drink.Milk, drink.Cocoa, drink.Coffee);
            }
        }

        private void button_DrinkRemove_Click(object sender, EventArgs e)
        {
            MessageBox.Show(xmlDocument.InnerXml);
        }

        private void button_saveData_Click(object sender, EventArgs e)
        {
            xmlDocument.Save(pathname);
            MessageBox.Show("Data saved successfully!");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private XmlNode GetXmlRoot()
        {
            return xmlDocument.GetElementsByTagName("hotDrinkData")[0];
        }

        private XmlNode createNodeWithText(string name, string context)
        {
            XmlNode node = xmlDocument.CreateElement(name);
            node.InnerText = context;
            return node;
        }

        private void button_DrinkAdd_Click(object sender, EventArgs e)
        {
            XmlNode root = GetXmlRoot();
            XmlNode drink = xmlDocument.CreateElement("drink");
            XmlNode name = createNodeWithText("name", textBox_drinkName.Text);
            // רכיבים
            XmlNode sugar = createNodeWithText("sugar", comboboxSugar.Text);
            XmlNode milk = createNodeWithText("milk", comboboxMilk.Text);
            XmlNode cocoa = createNodeWithText("cocoa", comboboxCocoa.Text);
            XmlNode coffee = createNodeWithText("coffee", comboboxCoffee.Text);
            // מחיר
            XmlNode price = createNodeWithText("price", textBox_price.Text);

            root.AppendChild(drink);
            drink.AppendChild(name);
            drink.AppendChild(sugar);
            drink.AppendChild(milk);
            drink.AppendChild(cocoa);
            drink.AppendChild(coffee);
            drink.AppendChild(price);

        }

        private void textBox_drinkName_TextChanged(object sender, EventArgs e)
        {

            if (GetDrinkByName(textBox_drinkName.Text) == null) return;
            var showDialog = MessageBox.Show(
                "האם אתה רוצה לעדכן",
                "עדכון משקה",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (showDialog == DialogResult.Yes)
            {
                MessageBox.Show("YES?");
            }
        }

        private XmlNode GetDrinkByName(string name)
        {

            //XmlNodeList drinkNodes = xmlDocument.GetElementsByTagName("drink");
            //foreach (XmlNode drinkNode in drinkNodes)
            //{
            //    if (drinkNode["name"].InnerText == name) {
            //        return drinkNode;
            //    }
            //}
            //return null;
            XmlNodeList drinksNames = xmlDocument.GetElementsByTagName("name");
            foreach (XmlNode drinkName in drinksNames)
            {
                if (drinkName.InnerText == name)
                {
                    return drinkName.ParentNode;
                }
            }
            return null;
        }
    }
}
