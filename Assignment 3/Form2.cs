using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Assignment_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
           
        }
        private string file2;// create a property
        public string IntefaceForfile
        {
                get
            {
                return file2;
            }
                set
            {
                file2 = value;
            }
        }
       
        

       
        public void Read(string file)//Reads File use "file" as the read file
        {
            
                        
            //Read's data from the file
           
                FileStream fs1 = new FileStream(file, FileMode.Open);
                StreamReader sr1 = new StreamReader(fs1);
                textBox1.Text = sr1.ReadToEnd();
                sr1.Close();
                fs1.Close();
                this.Text = "Record Editor -- " + file;

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

        private void Form2_Load(object sender, EventArgs e)
        {
            Read(file2);
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
            FileStream fsout;
	        fsout = new FileStream(file2,FileMode.Create);
          
            using (StreamWriter sw1 = new StreamWriter(fsout))
            {
               
                sw1.Write(textBox1.Text);
                sw1.Flush();
                sw1.Close();
                fsout.Close();
            }
            MessageBox.Show(file2+ " Has Been Saved!!");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open the text file you wish";
            //ofd.InitialDirectory = "c:\\";
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                Read(ofd.FileName);
                
            }
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Focused == true) //if the editing text box has focus then do not recongnize key presses
            {
            }
            else
            {

                switch (e.KeyChar)
                {
                    case (char)117:
                    case (char)85:
                        btnUpdate_Click(null, null);
                        break;
                    case (char)98:
                    case (char)66:
                        btnBack_Click(null, null);
                        break;
                    case (char)115:
                    case (char)83:
                        btnSave_Click(null, null);
                        break;
                    case (char)108:
                    case (char)76:
                        btnLoad_Click(null, null);
                        break;

                }
            }
        }

       
    }
}
