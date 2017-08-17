using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalindromikSayilar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PalindromikSayilar_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            string[] metin_parcalari = metin.Split(' ');

            foreach (string parca in metin_parcalari)
            {
                char[] yeni = parca.ToCharArray();

                Array.Reverse(yeni);

                if (string.Compare(parca, new string(yeni)).ToString() == "0")
                {
                    listBox1.Items.Add(parca);
                }
            }
        }
               
    }
}
