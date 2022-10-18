using AngleSharp;
using AngleSharp.Dom;
using System.Net.Http;
using System.Windows.Forms;
using System.Xml;

namespace Spider
{
    public partial class XML_Study_Form : Form
    {
        public XML_Study_Form()
        {
            InitializeComponent();
        }

        private void Run_ClickAsync(object sender, EventArgs e)
        {
            XmlDelete();
            XmlUpdate();
            XmlPreview();
        }

        private void Select_Location_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Multiselect = false,
                Filter = "XML Documents (.xml)|*.xml"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string ConstString_Path = dialog.FileName;
                Path.Text = ConstString_Path;
            }
        }

        private void XmlDelete()
        {
            XmlDocument xmlDoc = new();
            xmlDoc.Load(Path.Text);
            foreach (XmlNode xmlNode in xmlDoc.SelectNodes("Check/Value"))
            {
                if (xmlNode.SelectSingleNode("Type").InnerText == "Value")
                {
                    xmlNode.ParentNode.RemoveChild(xmlNode);
                }
            }
            xmlDoc.Save(Path.Text);
            StateList.Items.Add("資料已變動(移除)");
            StateList.TopIndex = StateList.Items.Count - 1;
        }
        private void XmlUpdate()
        {
            XmlDocument xmlDoc = new();
            xmlDoc.Load(Path.Text);
            foreach (XmlNode xmlNode in xmlDoc.SelectNodes("Check"))
            {
                XmlNode NodeValue = xmlDoc.CreateElement("Value");
                XmlNode NodeType = xmlDoc.CreateElement("Type");
                XmlNode D200 = xmlDoc.CreateElement("D200");
                XmlNode D201 = xmlDoc.CreateElement("D201");
                XmlNode D202 = xmlDoc.CreateElement("D202");
                XmlNode D203 = xmlDoc.CreateElement("D203");
                NodeType.InnerText = "Value";
                D200.InnerText = TB_Value_200.Text;
                D201.InnerText = TB_Value_201.Text;
                D202.InnerText = TB_Value_202.Text;
                D203.InnerText = TB_Value_203.Text;
                NodeValue.AppendChild(NodeType);
                NodeValue.AppendChild(D200);
                NodeValue.AppendChild(D201);
                NodeValue.AppendChild(D202);
                NodeValue.AppendChild(D203);
                xmlDoc.DocumentElement.AppendChild(NodeValue);
                xmlDoc.Save(Path.Text);
            }
            StateList.Items.Add("資料已變動(新增)");
            StateList.TopIndex = StateList.Items.Count - 1;
        }
        private void XmlPreview()
        {
            XmlDocument xmlDoc = new();
            xmlDoc.Load(Path.Text);
            foreach (XmlNode xmlNode in xmlDoc.SelectNodes("//Check/Value"))
            {
                Value_200.Text = xmlNode.SelectSingleNode("D200").InnerText;
                Value_201.Text = xmlNode.SelectSingleNode("D201").InnerText;
                Value_202.Text = xmlNode.SelectSingleNode("D202").InnerText;
                Value_203.Text = xmlNode.SelectSingleNode("D203").InnerText;
            }
            StateList.Items.Add("資料已顯示(WinForm)");
            StateList.TopIndex = StateList.Items.Count - 1;
        }

    }
}