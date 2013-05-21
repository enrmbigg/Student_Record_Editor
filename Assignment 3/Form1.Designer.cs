namespace Assignment_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lblsecondname = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblsex = new System.Windows.Forms.Label();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnprev = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.txtfile = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblmessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblpos = new System.Windows.Forms.Label();
            this.lbllen = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblfile = new System.Windows.Forms.Label();
            this.RBdob = new System.Windows.Forms.RadioButton();
            this.RBfirst = new System.Windows.Forms.RadioButton();
            this.lblSort = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblfirstname
            // 
            this.lblfirstname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblfirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblfirstname.Location = new System.Drawing.Point(9, 171);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(89, 39);
            this.lblfirstname.TabIndex = 0;
            this.lblfirstname.Text = "First Name";
            // 
            // lblsecondname
            // 
            this.lblsecondname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsecondname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsecondname.Location = new System.Drawing.Point(104, 171);
            this.lblsecondname.Name = "lblsecondname";
            this.lblsecondname.Size = new System.Drawing.Size(105, 39);
            this.lblsecondname.TabIndex = 1;
            this.lblsecondname.Text = "Middle Name";
            // 
            // lbllastname
            // 
            this.lbllastname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbllastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbllastname.Location = new System.Drawing.Point(215, 171);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(91, 39);
            this.lbllastname.TabIndex = 2;
            this.lbllastname.Text = "Last Name";
            // 
            // lbldob
            // 
            this.lbldob.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldob.Location = new System.Drawing.Point(312, 171);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(96, 39);
            this.lbldob.TabIndex = 3;
            this.lbldob.Text = "DOB";
            // 
            // lblsex
            // 
            this.lblsex.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsex.Location = new System.Drawing.Point(414, 171);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(75, 39);
            this.lblsex.TabIndex = 4;
            this.lblsex.Text = "Sex";
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(9, 236);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(75, 23);
            this.btnfirst.TabIndex = 5;
            this.btnfirst.Text = "First";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(90, 236);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(75, 23);
            this.btnlast.TabIndex = 5;
            this.btnlast.Text = "Last";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnprev
            // 
            this.btnprev.Location = new System.Drawing.Point(171, 236);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(75, 23);
            this.btnprev.TabIndex = 5;
            this.btnprev.Text = "Previous";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(252, 236);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 5;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // txtfile
            // 
            this.txtfile.Location = new System.Drawing.Point(252, 275);
            this.txtfile.Name = "txtfile";
            this.txtfile.Size = new System.Drawing.Size(156, 20);
            this.txtfile.TabIndex = 7;
            this.txtfile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfile_KeyDown);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(171, 275);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(9, 275);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblmessage
            // 
            this.lblmessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblmessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmessage.Location = new System.Drawing.Point(12, 17);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(234, 21);
            this.lblmessage.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Middle Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "D.O.B";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Gender";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(414, 236);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 62);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(495, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(374, 287);
            this.textBox1.TabIndex = 11;
            // 
            // lblpos
            // 
            this.lblpos.BackColor = System.Drawing.SystemColors.Control;
            this.lblpos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblpos.Location = new System.Drawing.Point(309, 15);
            this.lblpos.Name = "lblpos";
            this.lblpos.Size = new System.Drawing.Size(54, 23);
            this.lblpos.TabIndex = 6;
            // 
            // lbllen
            // 
            this.lbllen.BackColor = System.Drawing.SystemColors.Control;
            this.lbllen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbllen.Location = new System.Drawing.Point(414, 15);
            this.lbllen.Name = "lbllen";
            this.lbllen.Size = new System.Drawing.Size(60, 23);
            this.lbllen.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(381, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "OF";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(333, 236);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblfile
            // 
            this.lblfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblfile.Location = new System.Drawing.Point(12, 50);
            this.lblfile.Name = "lblfile";
            this.lblfile.Size = new System.Drawing.Size(462, 23);
            this.lblfile.TabIndex = 15;
            // 
            // RBdob
            // 
            this.RBdob.AutoSize = true;
            this.RBdob.Checked = true;
            this.RBdob.Location = new System.Drawing.Point(161, 92);
            this.RBdob.Name = "RBdob";
            this.RBdob.Size = new System.Drawing.Size(48, 17);
            this.RBdob.TabIndex = 16;
            this.RBdob.TabStop = true;
            this.RBdob.Text = "DOB";
            this.RBdob.UseVisualStyleBackColor = true;
            this.RBdob.CheckedChanged += new System.EventHandler(this.RBdob_CheckedChanged);
            // 
            // RBfirst
            // 
            this.RBfirst.AutoSize = true;
            this.RBfirst.Location = new System.Drawing.Point(224, 92);
            this.RBfirst.Name = "RBfirst";
            this.RBfirst.Size = new System.Drawing.Size(75, 17);
            this.RBfirst.TabIndex = 17;
            this.RBfirst.Text = "First Name";
            this.RBfirst.UseVisualStyleBackColor = true;
            this.RBfirst.CheckedChanged += new System.EventHandler(this.RBfirst_CheckedChanged);
            // 
            // lblSort
            // 
            this.lblSort.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSort.Location = new System.Drawing.Point(9, 88);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(129, 21);
            this.lblSort.TabIndex = 19;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(90, 275);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(882, 310);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.RBfirst);
            this.Controls.Add(this.RBdob);
            this.Controls.Add(this.lblfile);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfile);
            this.Controls.Add(this.lbllen);
            this.Controls.Add(this.lblpos);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.lblsex);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.lblsecondname);
            this.Controls.Add(this.lblfirstname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Record Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lblsecondname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.TextBox txtfile;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblpos;
        private System.Windows.Forms.Label lbllen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblfile;
        private System.Windows.Forms.RadioButton RBdob;
        private System.Windows.Forms.RadioButton RBfirst;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Button btnNew;
    }
}

