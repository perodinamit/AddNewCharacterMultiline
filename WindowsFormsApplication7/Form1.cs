using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = textBox1.Lines;
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i] + @" \";
                
            }
            //iz zadnjeg reda brišem zadnji znak backspacea koji ne treba
            lines[lines.Length - 1] = lines[lines.Length - 1].Substring(0, lines[lines.Length - 1].Length - 1);

            textBox1.Lines = lines;
            string noviSring = lines[lines.Length - 1].Substring(0, lines[lines.Length - 1].Length-1);

            MessageBox.Show(noviSring);
        }
    }
}
