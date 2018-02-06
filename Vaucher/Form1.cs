using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaucher
{

    public partial class Vaucher : Form
    {

        const string Key_Chars = "0123456789";


        public Vaucher()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
       

        private bool DecodeKey(string number, string v)
        {
            throw new NotImplementedException();
        }

        string Generatekey()
        {
            
            string result = "";
            for (int i = 1; i <= 9; i++) result += Key_Chars[rnd.Next(0, Key_Chars.Length)];
            return result;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbkeys.Clear();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            string i = "Program was created for Ketchup Koyalty Marketing Company.";
            string j = "Made by: Aleksandr Kucherenko.";
            MessageBox.Show(i + "\n" + j);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (firstnumber.TextLength < 6)
            
            {
                
                    MessageBox.Show("ERROR: you did not enter the first 6 digits");
            }
            else
            {
                for (int i = 1; i <= number.Value; i++)
                    tbkeys.Text += firstnumber.Text + Generatekey() + "0" + "\r\n";
            }
            
        }

        private void Vaucher_Load(object sender, EventArgs e)
        {
            
        }

        private void numeric_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            firstnumber.MaxLength = 6;
            



        }

        private void firstnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
            // e.Handled = true;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;


        }

        
    }
}
