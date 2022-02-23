using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subat23_6
{
    //EKSİK KOD BUNU TAMAMLA FLASH DİSK ALINCA TAMAMLA.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();

                btn.Width = 60; // butonun genişliği 20 de arasındaki mesafe.
                btn.Left += 20 + (i * 60);
                btn.Text = i.ToString();

                panel1.Controls.Add(btn);

                btn.Click += Btn_Click;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tiklandi." + ((Button)sender).Text);
            TextBox1.Text+=
                    }
    }
}
