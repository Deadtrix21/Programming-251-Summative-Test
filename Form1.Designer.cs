
namespace PRG251_ST_Shane_Bekker_
{
    partial class frmbind1
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
            this.lb1 = new System.Windows.Forms.Label();
            this.dbgrid1 = new System.Windows.Forms.DataGridView();
            this.btn1 = new System.Windows.Forms.Button();
            this.grBox1 = new System.Windows.Forms.GroupBox();
            this.btnBus = new System.Windows.Forms.Button();
            this.btnSuv = new System.Windows.Forms.Button();
            this.btnall = new System.Windows.Forms.Button();
            this.grpBox2 = new System.Windows.Forms.GroupBox();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnprior = new System.Windows.Forms.Button();
            this.btnf = new System.Windows.Forms.Button();
            this.grpBox3 = new System.Windows.Forms.GroupBox();
            this.grpBox4 = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nlble = new System.Windows.Forms.Label();
            this.prlble = new System.Windows.Forms.Label();
            this.lbletype = new System.Windows.Forms.Label();
            this.lblediscount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrid1)).BeginInit();
            this.grBox1.SuspendLayout();
            this.grpBox2.SuspendLayout();
            this.grpBox3.SuspendLayout();
            this.grpBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(181, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(133, 26);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Car Registry";
            // 
            // dbgrid1
            // 
            this.dbgrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrid1.Location = new System.Drawing.Point(18, 55);
            this.dbgrid1.Name = "dbgrid1";
            this.dbgrid1.Size = new System.Drawing.Size(493, 306);
            this.dbgrid1.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(564, 62);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Exit";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // grBox1
            // 
            this.grBox1.Controls.Add(this.btnBus);
            this.grBox1.Controls.Add(this.btnSuv);
            this.grBox1.Controls.Add(this.btnall);
            this.grBox1.Location = new System.Drawing.Point(517, 91);
            this.grBox1.Name = "grBox1";
            this.grBox1.Size = new System.Drawing.Size(169, 115);
            this.grBox1.TabIndex = 3;
            this.grBox1.TabStop = false;
            this.grBox1.Text = "Display";
            // 
            // btnBus
            // 
            this.btnBus.Location = new System.Drawing.Point(20, 80);
            this.btnBus.Name = "btnBus";
            this.btnBus.Size = new System.Drawing.Size(126, 23);
            this.btnBus.TabIndex = 2;
            this.btnBus.Text = "Show all busses";
            this.btnBus.UseVisualStyleBackColor = true;
            this.btnBus.Click += new System.EventHandler(this.btnBus_Click);
            // 
            // btnSuv
            // 
            this.btnSuv.Location = new System.Drawing.Point(20, 51);
            this.btnSuv.Name = "btnSuv";
            this.btnSuv.Size = new System.Drawing.Size(126, 23);
            this.btnSuv.TabIndex = 1;
            this.btnSuv.Text = "Show all Suv";
            this.btnSuv.UseVisualStyleBackColor = true;
            this.btnSuv.Click += new System.EventHandler(this.btnSuv_Click);
            // 
            // btnall
            // 
            this.btnall.Location = new System.Drawing.Point(20, 21);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(126, 23);
            this.btnall.TabIndex = 0;
            this.btnall.Text = "Show all";
            this.btnall.UseVisualStyleBackColor = true;
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // grpBox2
            // 
            this.grpBox2.Controls.Add(this.btnlast);
            this.grpBox2.Controls.Add(this.btnnext);
            this.grpBox2.Controls.Add(this.btnprior);
            this.grpBox2.Controls.Add(this.btnf);
            this.grpBox2.Location = new System.Drawing.Point(18, 491);
            this.grpBox2.Name = "grpBox2";
            this.grpBox2.Size = new System.Drawing.Size(668, 70);
            this.grpBox2.TabIndex = 4;
            this.grpBox2.TabStop = false;
            this.grpBox2.Text = "Navigation";
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(570, 24);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(75, 23);
            this.btnlast.TabIndex = 3;
            this.btnlast.Text = ">|";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(418, 24);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 2;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnprior
            // 
            this.btnprior.Location = new System.Drawing.Point(221, 24);
            this.btnprior.Name = "btnprior";
            this.btnprior.Size = new System.Drawing.Size(75, 23);
            this.btnprior.TabIndex = 1;
            this.btnprior.Text = "<";
            this.btnprior.UseVisualStyleBackColor = true;
            this.btnprior.Click += new System.EventHandler(this.btnprior_Click);
            // 
            // btnf
            // 
            this.btnf.Location = new System.Drawing.Point(51, 24);
            this.btnf.Name = "btnf";
            this.btnf.Size = new System.Drawing.Size(75, 23);
            this.btnf.TabIndex = 0;
            this.btnf.Text = "|<";
            this.btnf.UseVisualStyleBackColor = true;
            this.btnf.Click += new System.EventHandler(this.btnf_Click);
            // 
            // grpBox3
            // 
            this.grpBox3.Controls.Add(this.lblediscount);
            this.grpBox3.Controls.Add(this.lbletype);
            this.grpBox3.Controls.Add(this.prlble);
            this.grpBox3.Controls.Add(this.nlble);
            this.grpBox3.Controls.Add(this.label4);
            this.grpBox3.Controls.Add(this.label3);
            this.grpBox3.Controls.Add(this.label2);
            this.grpBox3.Controls.Add(this.label1);
            this.grpBox3.Location = new System.Drawing.Point(18, 368);
            this.grpBox3.Name = "grpBox3";
            this.grpBox3.Size = new System.Drawing.Size(668, 117);
            this.grpBox3.TabIndex = 5;
            this.grpBox3.TabStop = false;
            this.grpBox3.Text = "Searched Car details";
            // 
            // grpBox4
            // 
            this.grpBox4.Controls.Add(this.txtbx);
            this.grpBox4.Controls.Add(this.btnsearch);
            this.grpBox4.Location = new System.Drawing.Point(518, 235);
            this.grpBox4.Name = "grpBox4";
            this.grpBox4.Size = new System.Drawing.Size(168, 77);
            this.grpBox4.TabIndex = 6;
            this.grpBox4.TabStop = false;
            this.grpBox4.Text = "Search";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(46, 45);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 0;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtbx
            // 
            this.txtbx.Location = new System.Drawing.Point(6, 19);
            this.txtbx.Name = "txtbx";
            this.txtbx.Size = new System.Drawing.Size(156, 20);
            this.txtbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of car";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type Car";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Discrount";
            // 
            // nlble
            // 
            this.nlble.AutoSize = true;
            this.nlble.Location = new System.Drawing.Point(22, 33);
            this.nlble.Name = "nlble";
            this.nlble.Size = new System.Drawing.Size(35, 13);
            this.nlble.TabIndex = 4;
            this.nlble.Text = "label5";
            // 
            // prlble
            // 
            this.prlble.AutoSize = true;
            this.prlble.Location = new System.Drawing.Point(350, 33);
            this.prlble.Name = "prlble";
            this.prlble.Size = new System.Drawing.Size(35, 13);
            this.prlble.TabIndex = 5;
            this.prlble.Text = "label6";
            // 
            // lbletype
            // 
            this.lbletype.AutoSize = true;
            this.lbletype.Location = new System.Drawing.Point(22, 78);
            this.lbletype.Name = "lbletype";
            this.lbletype.Size = new System.Drawing.Size(35, 13);
            this.lbletype.TabIndex = 6;
            this.lbletype.Text = "label7";
            // 
            // lblediscount
            // 
            this.lblediscount.AutoSize = true;
            this.lblediscount.Location = new System.Drawing.Point(350, 78);
            this.lblediscount.Name = "lblediscount";
            this.lblediscount.Size = new System.Drawing.Size(35, 13);
            this.lblediscount.TabIndex = 7;
            this.lblediscount.Text = "label8";
            // 
            // frmbind1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 576);
            this.Controls.Add(this.grpBox4);
            this.Controls.Add(this.grpBox3);
            this.Controls.Add(this.grpBox2);
            this.Controls.Add(this.grBox1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.dbgrid1);
            this.Controls.Add(this.lb1);
            this.Name = "frmbind1";
            this.Text = "Car System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbgrid1)).EndInit();
            this.grBox1.ResumeLayout(false);
            this.grpBox2.ResumeLayout(false);
            this.grpBox3.ResumeLayout(false);
            this.grpBox3.PerformLayout();
            this.grpBox4.ResumeLayout(false);
            this.grpBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.DataGridView dbgrid1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.GroupBox grBox1;
        private System.Windows.Forms.Button btnBus;
        private System.Windows.Forms.Button btnSuv;
        private System.Windows.Forms.Button btnall;
        private System.Windows.Forms.GroupBox grpBox2;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnprior;
        private System.Windows.Forms.Button btnf;
        private System.Windows.Forms.GroupBox grpBox3;
        private System.Windows.Forms.GroupBox grpBox4;
        private System.Windows.Forms.TextBox txtbx;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label lblediscount;
        private System.Windows.Forms.Label lbletype;
        private System.Windows.Forms.Label prlble;
        private System.Windows.Forms.Label nlble;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

