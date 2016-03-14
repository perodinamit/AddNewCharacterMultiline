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
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] lines = textBox1.Lines;
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Substring(0, lines[i].Length - 1);
            }
            textBox1.Lines = lines;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Copy();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text)==true)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to paste over current selection?","Cut", MessageBoxButtons.YesNo);
                textBox1.Text = "";
                if (dialogResult == DialogResult.Yes)
                    {
                        textBox1.SelectionStart = textBox1.SelectionStart + textBox1.SelectionLength;
                    }
                    textBox1.Paste();
            }
        }
    }
}
