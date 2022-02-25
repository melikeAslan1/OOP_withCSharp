using SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WndText_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, ISDK> efektler = new Dictionary<string, ISDK>();




        private void button1_Click(object sender, EventArgs e)
        {
            ISDK efekt = efektler[LstEfektler.SelectedItem.ToString()];

            lblSonuc.Text = efekt.Islem(txtMesaj.Text);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string dosya in Directory.GetFiles(@"C:\Users\303MELİKE_SABAH\Desktop\SDK\WndText_Shop\bin\Debug\Plugin"))
            {
               //  MessageBox.Show(dosya);

                Assembly asm = Assembly.LoadFrom(dosya);
                foreach (Type type in asm.GetTypes())
                {
                    //MessageBox.Show(type.Name);
                    //if (type is ISDK)
                    //{
                        object obj = Activator.CreateInstance(type);
                        ISDK efekt = (ISDK)obj;
                        efektler.Add(efekt.EklentiAdi, efekt);
                        LstEfektler.Items.Add(efekt.EklentiAdi);
                    //}

                }
            }

        }
    }
}
