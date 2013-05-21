using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Windows.Forms;


namespace Assignment_3
{
   
     public partial class Form1 : Form
    {
         
        Student myself;                         //New instance of struct.
        SortedList sList = new SortedList();    //New Sorted list to sort the file records
        string textrow;                         //Line of text, read from the file.
        Student[] pArray = new Student[10];     //Setup's up the Array to hold records
        int i = 0;                              //Used to cycle through
        int length = 0;                         //Length is to hold the amount of records that are in the file
        int y = 0;                              //Used to check posisition within the program
        
        string infile = "text.txt";             //Default File
        

        public struct Student                   //Struct which we split are records into
        {
            public string LastName;
            public string FirstName;
            public string MiddleName;
            public DateTime Dob;
            public string Gender;
        }

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Next allows the user to scroll through the records in asceneding order\r\n\r\nPrevious allows the user to scroll through the records in desending order\r\n\r\nLast shows the last record\r\n\r\nFirst shows the first record\r\n\r\nEdit allows the user to load and edit the current record and also save as a seperate file\r\n\r\nLoad allows the user to load a different set of records by typing the location of the file and its file name \r\n\r\nRefresh is used to reload the text file once updated\r\n\r\nNew allows for a new file to be created from scratch\r\n\r\nSort, to sort check the corresponding radio button to change how the file is sorted by ";
           /* OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open the text file you wish";
            //ofd.InitialDirectory = "c:\\";
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Read(ofd.FileName);
                infile = ofd.FileName;  
                this.Show();
            }
            else
            {
                MessageBox.Show("Failed File Load, Loading Default....");
                Read("text.txt");
            }*/
            Read(infile);
            DisplayRecord(0);                   //Display's the first record so that upon load there is a record to view
            lblmessage.Text = "Welcome To The Record Reader + Editor!!";
      
        }
        public void LoadFile(string file)       //Function that loads up the file
        {
            sList.Clear();
            string ss;
            try
            {
                FileStream fs1 = new FileStream(file, FileMode.Open);
                StreamReader sr1 = new StreamReader(fs1);
            
                    while ((textrow = sr1.ReadLine()) != null)
                    {
                        string[] split = textrow.Split(',');
                        if (split[0]=="")              // error checking to ensure that the file can be loaded if there are missing records        
                        {
                            myself.LastName = "N/A";
                        }
                        else
                        {
                            myself.LastName = split[0];
                
                        }
                        if (split[1] == "")
                        {
                            myself.FirstName = "N/A";
                        }
                        else
                        {
                            myself.FirstName = split[1];
                        }
                        if (split[2] == "")
                        {
                            myself.MiddleName = "N/A";
                        }
                        else
                        {
                            myself.MiddleName = split[2];
                        }
                        if (split[3] == "")
                        {
                            myself.Dob = DateTime.Parse("1000/01/01");
                        }
                        else
                        {
                            myself.Dob = DateTime.Parse(split[3]);
                        }
                        if (split[4] == "")
                        {
                            myself.Gender = "N/A";
                        }
                        else
                        {
                            myself.Gender = Convert.ToString(split[4][0]);     //first char of split[4]
                        }
                        if (RBdob.Checked == true)
                        {
                            ss = myself.Dob.ToString("s");
                            sList.Add(ss, myself);
                            lblSort.Text = "Sorted By DOB";
                        }
                        if (RBfirst.Checked == true)
                        {
                            ss = myself.FirstName;
                            sList.Add(ss, myself);
                            lblSort.Text = "Sorted By First Name";
                        }
                    }
   
                    
            sr1.Close();
            fs1.Close();
                }
            catch                           //If at any point during that sequence it fails this will catch it and load up the file so that 
                                            //they can edit the file and try and sort out the problem
            {
                MessageBox.Show("Encountered A Error, File Incorrect","Try editing the format of the file to ensure that it is correct");
                Form2 edit = new Form2();
                if (file == "")
                {
                    edit.IntefaceForfile = "text.txt";
                }
                else
                {
                    edit.IntefaceForfile = file;
                }
                edit.Show();
            }
                    
        }
        public void Read(string file)//Reads File use "file" as the read file
        {
            
            infile = file; 
            //Read's data from the file
            try
            {
                LoadFile(infile);
            }
            catch
            {
                           
                MessageBox.Show("Failed File Load, Try A Different File....");
                
                OpenFileDialog ofd = new OpenFileDialog(); 
                ofd.Title = "Open the text file you wish" ;
                //ofd.InitialDirectory = "c:\\";
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" ;
                
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        LoadFile(ofd.FileName);
                    }
                    else
                    {
                        MessageBox.Show("Failed File Load, Loading Default....");
                        LoadFile("text.txt");
                    }
            }

            //Setup's the array
            int len = sList.Count;
            length = len;
            if (len > 10) { this.Close(); }
            string[] keys = new string[len];

            i = 0;

            foreach (DictionaryEntry d in sList)
            {
                keys[i] = (string)d.Key;
                pArray[i] = (Student)d.Value;
                i++;
            }

            i = 0; //Reset i
            y = 0;
            
        }
        public void DisplayRecord(int i)
        {

            y = i;
            if (i > 9) { i = 9; lblmessage.Text = "Reached Maximum"; }  // warns user of max
            if (i <= 0) { i = 0; lblmessage.Text = "Reached Minimum"; } // warns user of min
            y++;
            if (y > 10) { y = 10; }                                     //ensures the posistion is never more then 10
            this.Text = "Record Reader -- " + infile;
            lblfile.Text = infile;
            lbllen.Text = " "+length.ToString();
            lblpos.Text = y.ToString();
            lbllastname.Text = pArray[i].LastName;
            lblfirstname.Text = pArray[i].FirstName;
            lblsecondname.Text = pArray[i].MiddleName;
            if (pArray[i].Dob == DateTime.Parse("1000/01/01"))
            {
                lbldob.Text = "N/A";
            }
            else
            {
                lbldob.Text = pArray[i].Dob.ToString("d");
            }
            lblsex.Text = pArray[i].Gender;
            y = i;
        }
        public void btnlast_Click(object sender, EventArgs e)       //Shows last record
        {
            i = pArray.Length;
            DisplayRecord(i);
        }
      
        private void btnnext_Click(object sender, EventArgs e)      //Shows next record in sequence
        {
            lblmessage.Text = "Next Record";
            if (i < length) { i++; }
            DisplayRecord(i); 
        }

        private void btnprev_Click(object sender, EventArgs e)      //Shows previous record in sequence
        {
            lblmessage.Text = "Previous Record";
            if (i > 0) { i--; }
            DisplayRecord(i);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Leave blank
        }

        private void btnLoad_Click(object sender, EventArgs e)      //Loads up a new file for the user to cycle through or edit if so wish
        { //loads new file
            OpenFileDialog ofd = new OpenFileDialog(); 
            ofd.Title = "Open the text file you wish" ;
            //ofd.InitialDirectory = "c:\\";
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" ;
            //string infile2 = infile;
           
            //infile = infile2;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Student[] pArray = new Student[10];
                    Read(ofd.FileName);
                    DisplayRecord(0);
                    lblmessage.Text = "New Data Loaded";
                   
                }
           
            
             
        }

        private void btnEdit_Click(object sender, EventArgs e)      //Shows the edit form and passes through the current loaded file
        {
            Form2 edit = new Form2(); //Show's the edit form
            
            /*edit.txtLName0.Text = lbllastname.Text;
            edit.txtFName0.Text = lblfirstname.Text;
            edit.txtmName0.Text = lblsecondname.Text;
            edit.txtDob0.Text = lbldob.Text;
            edit.txtGender0.Text = lblsex.Text;*/
            edit.IntefaceForfile = infile;      //Used to send over the file location and name for the edit form
            edit.Show();
            lblmessage.Text = "Editing form";
            btnRefresh_Click(null, null);
        }
       
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();                       //Closes Program
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            
            DisplayRecord(0);               //Displays First Record
        }

        private void label5_Click(object sender, EventArgs e)
        {
                                            //Leave Blank
        }

        private void txtfile_KeyDown(object sender, KeyEventArgs e)         //If The File Text box is focused and the user presses enter then the text within that box is used to load up an exsisting file
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                string NewFileName = txtfile.Text;

                
                    Student[] pArray = new Student[10];
                    Read(NewFileName);
                    DisplayRecord(0);
                    MessageBox.Show(NewFileName + " Was Loaded!!",NewFileName);
                    infile = NewFileName;
            }
        }

               private void btnRefresh_Click(object sender, EventArgs e)        // Used to refresh the code once the user comes back from editing the form
                {
                    Read(infile);
                    DisplayRecord(i);
                }

               private void Form1_KeyPress(object sender, KeyPressEventArgs e)
               {
                   //Form key presses which for each key press activates the corresponding button
                   if (txtfile.Focused == true)//if the  text box has focus then do not recongnize key presses
                   {
                   }
                   else
                   {
                       switch (e.KeyChar)
                       {
                           case (char)110://n
                           case (char)78://N
                               btnnext_Click(null, null);
                               break;
                           case (char)112://p
                           case (char)80://P
                               btnprev_Click(null, null);
                               break;
                           case (char)108://l
                           case (char)76://L
                               btnlast_Click(null, null);
                               break;
                           case (char)102://F
                           case (char)70://f
                               btnfirst_Click(null, null);
                               break;
                           case (char)12://ctrl+l
                               btnLoad_Click(null, null);
                               break;
                           case (char)101://e
                           case (char)69://E
                               btnEdit_Click(null, null);
                               break;
                           case (char)114://r
                           case (char)82://R
                               btnRefresh_Click(null, null);
                               break;


                       }
                   }
               }

               private void Form1_KeyDown(object sender, KeyEventArgs e)
               {    //if at anypoint the esc key is pressed then close the program
                   if (e.KeyCode == Keys.Escape)
                   {
                       btnExit_Click_1(null,null);
                   }
               }

               private void RBdob_CheckedChanged(object sender, EventArgs e)
               {
                   btnRefresh_Click(null, null);
                   lblmessage.Text = "Welcome To The Record Reader + Editor!!";
               }

               private void RBfirst_CheckedChanged(object sender, EventArgs e)
               {
                   btnRefresh_Click(null, null);
                   lblmessage.Text = "Welcome To The Record Reader + Editor!!";
               }

               private void btnNew_Click(object sender, EventArgs e)
               {
                   Form3 New = new Form3(); //Show's the New form
                   New.Show();
               }

               


       
           

        

       
    }
}

       
