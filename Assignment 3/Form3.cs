using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Assignment_3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            textBox2.Text = "To ensure that file can be used properly,\r\nPlease use the following format for each record\r\n\r\nLasts,First,Middle,DOB,Sex\r\nFor example; \r\n\r\nBloggs,Joe,Bill,1991/08/13,M \r\n\r\nNote:Each record must be on a seperate line";
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd1 = new SaveFileDialog();
            sd1.FileName = "Newfile.txt";
            sd1.Filter = "Text File | *.txt";
            if (sd1.ShowDialog() == DialogResult.OK)
            {

                using (StreamWriter sw1 = new StreamWriter(sd1.OpenFile()))
                {
                    sw1.Write(textBox1.Text);
                    sw1.Flush();
                    sw1.Close();
                }

            } 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
