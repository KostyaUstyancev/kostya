using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace секретный_замок
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public bool sravnenie(int[] s)
        {
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (i + 1 < s.Length - 1 || i + 2 < s.Length - 1)
                {
                    if (s[i + 1] + s[i] + s[i + 2] == 10)
                    {
                        return true;

                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string[] mas1 = new string[10] {Box1.Text, Box2.Text, Box3.Text, Box4.Text,
                                     Box5.Text, Box6.Text, Box7.Text, Box8.Text, Box9.Text, Box10.Text};
            int[] mas = new int[10];
            for (int i = 0; i <= 9; i++)
            {
                mas[i] = Convert.ToInt32(mas1[i]);
            }


=======
                int[] mas = new int[10] {Convert.ToInt32(Box1.Text), Convert.ToInt32(Box2.Text), Convert.ToInt32(Box3.Text), Convert.ToInt32(Box4.Text),
                                     Convert.ToInt32(Box5.Text), Convert.ToInt32(Box6.Text), Convert.ToInt32(Box7.Text), Convert.ToInt32(Box8.Text),
                                     Convert.ToInt32(Box9.Text), Convert.ToInt32(Box10.Text)};

            
>>>>>>> 350fd03e549527f9804031aa6132631a24b3407e
            bool res = sravnenie(mas);
            if (res == true)
            {
                text1.BackColor = Color.GreenYellow;
            }
            else
            {
                text1.BackColor = Color.Red;
            }
                
        }
       
    }
   
}
