using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsertionSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void bt_Sort_Click(object sender, EventArgs e)
        {
            int length = int.Parse(txt_num.Text);
            int limit = int.Parse(txt_limit.Text);
            int[] dizi = new int[length];
            Random random = new Random();
            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < length; i++)
                dizi[i] = random.Next(1, limit);

            if (length <= 20)
            {
                for (int i = 0; i < length; i++)
                    lbl_UnSorted.Text += (dizi[i].ToString() + " ");
            }

            sw.Start();
            insertion_sort(dizi);
            sw.Stop();
            TimeSpan time = sw.Elapsed;
            lbl_Time.Text = Convert.ToString(time);

            if (length <= 20)
            {
                for (int i = 0; i < length; i++)
                    lbl_Sorted.Text += (dizi[i].ToString() + " ");
            }

            dizi_reverse(dizi);

            if (length <= 20)
            {
                for (int i = 0; i < length; i++)
                    lbl_Reversed.Text += (dizi[i].ToString() + " ");
            }



        }

        public void insertion_sort(int[] dizi)
        {
            //for (int i = 1; i < dizi.Length; i++)
            //{
            //    int sakla = dizi[i];
            //    j = i;
            //    while (j > 0 && sakla < dizi[j - 1])
            //    {
            //        dizi[j] = dizi[j - 1];
            //        j--;
            //    }
            //    dizi[j] = sakla;
            //}
            for (int j = 1; j < dizi.Length; j++)
            {
                int key = dizi[j];
                int i = j - 1;
                while (i >= 0 && dizi[i] > key)
                {
                    dizi[i + 1] = dizi[i];
                    i = i - 1;
                }
                dizi[i + 1] = key;
            }
        }

        public void dizi_reverse(int[] dizi)
        {
            Array.Reverse(dizi);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_num.Clear();
            txt_limit.Clear();
            lbl_Sorted.ResetText();
            lbl_UnSorted.ResetText();
        }

        private void btn_Reverse_Click(object sender, EventArgs e)
        {

        }
    }

}
