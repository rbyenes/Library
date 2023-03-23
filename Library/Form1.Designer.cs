namespace Library
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
            this.dgwUser = new System.Windows.Forms.DataGridView();
            this.dgwBook = new System.Windows.Forms.DataGridView();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxSelectTheBook = new System.Windows.Forms.ComboBox();
            this.tbxUserNumber = new System.Windows.Forms.TextBox();
            this.tbxUserSurname = new System.Windows.Forms.TextBox();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.lblSelectTheBook = new System.Windows.Forms.Label();
            this.lblUserNumber = new System.Windows.Forms.Label();
            this.lblUserSurname = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwUser
            // 
            this.dgwUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUser.Location = new System.Drawing.Point(12, 300);
            this.dgwUser.Name = "dgwUser";
            this.dgwUser.Size = new System.Drawing.Size(977, 213);
            this.dgwUser.TabIndex = 0;
            // 
            // dgwBook
            // 
            this.dgwBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBook.Location = new System.Drawing.Point(12, 533);
            this.dgwBook.Name = "dgwBook";
            this.dgwBook.Size = new System.Drawing.Size(977, 213);
            this.dgwBook.TabIndex = 1;
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.cbxSelectTheBook);
            this.gbxAdd.Controls.Add(this.tbxUserNumber);
            this.gbxAdd.Controls.Add(this.tbxUserSurname);
            this.gbxAdd.Controls.Add(this.tbxUserName);
            this.gbxAdd.Controls.Add(this.lblSelectTheBook);
            this.gbxAdd.Controls.Add(this.lblUserNumber);
            this.gbxAdd.Controls.Add(this.lblUserSurname);
            this.gbxAdd.Controls.Add(this.lblUserName);
            this.gbxAdd.Location = new System.Drawing.Point(12, 39);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(977, 238);
            this.gbxAdd.TabIndex = 2;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add User";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAdd.Location = new System.Drawing.Point(742, 171);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 52);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxSelectTheBook
            // 
            this.cbxSelectTheBook.FormattingEnabled = true;
            this.cbxSelectTheBook.Location = new System.Drawing.Point(703, 129);
            this.cbxSelectTheBook.Name = "cbxSelectTheBook";
            this.cbxSelectTheBook.Size = new System.Drawing.Size(200, 21);
            this.cbxSelectTheBook.TabIndex = 7;
            // 
            // tbxUserNumber
            // 
            this.tbxUserNumber.Location = new System.Drawing.Point(703, 61);
            this.tbxUserNumber.Name = "tbxUserNumber";
            this.tbxUserNumber.Size = new System.Drawing.Size(200, 20);
            this.tbxUserNumber.TabIndex = 6;
            // 
            // tbxUserSurname
            // 
            this.tbxUserSurname.Location = new System.Drawing.Point(145, 129);
            this.tbxUserSurname.Name = "tbxUserSurname";
            this.tbxUserSurname.Size = new System.Drawing.Size(198, 20);
            this.tbxUserSurname.TabIndex = 5;
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(145, 61);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(198, 20);
            this.tbxUserName.TabIndex = 4;
            // 
            // lblSelectTheBook
            // 
            this.lblSelectTheBook.AutoSize = true;
            this.lblSelectTheBook.Location = new System.Drawing.Point(555, 132);
            this.lblSelectTheBook.Name = "lblSelectTheBook";
            this.lblSelectTheBook.Size = new System.Drawing.Size(87, 13);
            this.lblSelectTheBook.TabIndex = 3;
            this.lblSelectTheBook.Text = "Select The Book";
            // 
            // lblUserNumber
            // 
            this.lblUserNumber.AutoSize = true;
            this.lblUserNumber.Location = new System.Drawing.Point(555, 64);
            this.lblUserNumber.Name = "lblUserNumber";
            this.lblUserNumber.Size = new System.Drawing.Size(103, 13);
            this.lblUserNumber.TabIndex = 2;
            this.lblUserNumber.Text = "User Phone Number";
            // 
            // lblUserSurname
            // 
            this.lblUserSurname.AutoSize = true;
            this.lblUserSurname.Location = new System.Drawing.Point(43, 132);
            this.lblUserSurname.Name = "lblUserSurname";
            this.lblUserSurname.Size = new System.Drawing.Size(74, 13);
            this.lblUserSurname.TabIndex = 1;
            this.lblUserSurname.Text = "User Surname";
            this.lblUserSurname.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(43, 64);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 793);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwBook);
            this.Controls.Add(this.dgwUser);
            this.Name = "Form1";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUser;
        private System.Windows.Forms.DataGridView dgwBook;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.ComboBox cbxSelectTheBook;
        private System.Windows.Forms.TextBox tbxUserNumber;
        private System.Windows.Forms.TextBox tbxUserSurname;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label lblSelectTheBook;
        private System.Windows.Forms.Label lblUserNumber;
        private System.Windows.Forms.Label lblUserSurname;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnAdd;
    }
}

