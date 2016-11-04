using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;


namespace ReadJsonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string s = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TestData\ResposeTimeTestData1.txt");

            string s = "TestData/ResposeTimeTestData1.txt";
            string d = File.ReadAllText(s);
            string[] data = d.Split(',');
            List<int> numList = new List<int>();
            string[] data2 = new string[data.Length];
            for (int z = 1; z != data.Length - 1; z++ )
            {
                listBox1.Items.Add(data[z]);
                if (data[z] != null)
                {
                    numList.Add(Int32.Parse(data[z]));
                }
                
                data2[z] = data[z];

            }
            string m = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string json = @"{ 'firstname': 'Neftali', 'lastname': 'Reyes'}";
            
        }
    }
}
