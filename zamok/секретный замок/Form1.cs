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

        private void button1_Click(object sender, EventArgs e)
        {
            
                int[] mas = new int[10] {Convert.ToInt32(Box1.Text), Convert.ToInt32(Box2.Text), Convert.ToInt32(Box3.Text), Convert.ToInt32(Box4.Text),
                                     Convert.ToInt32(Box5.Text), Convert.ToInt32(Box6.Text), Convert.ToInt32(Box7.Text), Convert.ToInt32(Box8.Text),
                                     Convert.ToInt32(Box9.Text), Convert.ToInt32(Box10.Text)};
            
            
            for (int i = 0;i<=mas.Length-1;i++)
            {
                if (i + 1 < mas.Length-1 || i + 2 < mas.Length-1)
                {
                   
                        if (mas[i + 1] + mas[i] + mas[i + 2] == 10)
                        {
                            text1.Text = "Замок открыт";
                            text1.BackColor = Color.GreenYellow;
                            break;
                        }
                  
                    
                    
                }
                else
                {
                    text1.Text = "Замок закрыт";
                    text1.BackColor = Color.Red;
                    break;
                }
              
            }
        }
    }
}
