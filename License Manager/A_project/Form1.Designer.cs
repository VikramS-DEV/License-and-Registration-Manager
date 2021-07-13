
namespace License_Manager
{
    partial class LicenseMgm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseMgm));
            this.CompanyName = new System.Windows.Forms.TextBox();
            this.ContactName = new System.Windows.Forms.TextBox();
            this.EmailId = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ErrorMsg = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ZipCode = new System.Windows.Forms.TextBox();
            this.State = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.numberofusers = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RegLicButton = new System.Windows.Forms.Button();
            this.productinformation = new System.Windows.Forms.GroupBox();
            this.enterlicensekey = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.regiter = new System.Windows.Forms.Button();
            this.browse = new System.Windows.Forms.Button();
            this.filebrowse = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.productinformation.SuspendLayout();
            this.enterlicensekey.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompanyName
            // 
            this.CompanyName.Location = new System.Drawing.Point(152, 30);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(214, 27);
            this.CompanyName.TabIndex = 0;
            // 
            // ContactName
            // 
            this.ContactName.Location = new System.Drawing.Point(152, 66);
            this.ContactName.Name = "ContactName";
            this.ContactName.Size = new System.Drawing.Size(214, 27);
            this.ContactName.TabIndex = 1;
            // 
            // EmailId
            // 
            this.EmailId.Location = new System.Drawing.Point(152, 103);
            this.EmailId.Name = "EmailId";
            this.EmailId.Size = new System.Drawing.Size(214, 27);
            this.EmailId.TabIndex = 2;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(152, 142);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(214, 27);
            this.PhoneNumber.TabIndex = 3;
            // 
            // ProductName
            // 
            this.ProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductName.BackColor = System.Drawing.Color.White;
            this.ProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductName.FormattingEnabled = true;
            this.ProductName.Items.AddRange(new object[] {
            "product1",
            "product2",
            "product3"});
            this.ProductName.Location = new System.Drawing.Point(538, 30);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(146, 27);
            this.ProductName.TabIndex = 4;
            this.ProductName.Tag = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(405, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Company Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contact Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ErrorMsg);
            this.groupBox1.Controls.Add(this.Country);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ZipCode);
            this.groupBox1.Controls.Add(this.State);
            this.groupBox1.Controls.Add(this.City);
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.CompanyName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ContactName);
            this.groupBox1.Controls.Add(this.PhoneNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EmailId);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 240);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // ErrorMsg
            // 
            this.ErrorMsg.AutoSize = true;
            this.ErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.ErrorMsg.Location = new System.Drawing.Point(30, 207);
            this.ErrorMsg.Name = "ErrorMsg";
            this.ErrorMsg.Size = new System.Drawing.Size(106, 19);
            this.ErrorMsg.TabIndex = 22;
            this.ErrorMsg.Text = "Fill all details";
            // 
            // Country
            // 
            this.Country.Location = new System.Drawing.Point(501, 180);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(159, 27);
            this.Country.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(418, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(418, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Zip Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(418, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(418, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(418, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Address";
            // 
            // ZipCode
            // 
            this.ZipCode.Location = new System.Drawing.Point(501, 142);
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.Size = new System.Drawing.Size(149, 27);
            this.ZipCode.TabIndex = 14;
            // 
            // State
            // 
            this.State.Location = new System.Drawing.Point(501, 102);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(183, 27);
            this.State.TabIndex = 13;
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(501, 66);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(100, 27);
            this.City.TabIndex = 12;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(501, 24);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(206, 27);
            this.Address.TabIndex = 11;
            // 
            // numberofusers
            // 
            this.numberofusers.Location = new System.Drawing.Point(172, 30);
            this.numberofusers.Name = "numberofusers";
            this.numberofusers.Size = new System.Drawing.Size(141, 27);
            this.numberofusers.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(30, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Number of users";
            // 
            // RegLicButton
            // 
            this.RegLicButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegLicButton.BackColor = System.Drawing.Color.White;
            this.RegLicButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegLicButton.Location = new System.Drawing.Point(281, 357);
            this.RegLicButton.Name = "RegLicButton";
            this.RegLicButton.Size = new System.Drawing.Size(218, 30);
            this.RegLicButton.TabIndex = 10;
            this.RegLicButton.Text = "Request for license key";
            this.RegLicButton.UseVisualStyleBackColor = false;
            this.RegLicButton.Click += new System.EventHandler(this.RegLicButton_Click);
            // 
            // productinformation
            // 
            this.productinformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productinformation.BackColor = System.Drawing.Color.Transparent;
            this.productinformation.Controls.Add(this.numberofusers);
            this.productinformation.Controls.Add(this.label11);
            this.productinformation.Controls.Add(this.ProductName);
            this.productinformation.Controls.Add(this.label1);
            this.productinformation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productinformation.ForeColor = System.Drawing.Color.Yellow;
            this.productinformation.Location = new System.Drawing.Point(32, 258);
            this.productinformation.Name = "productinformation";
            this.productinformation.Size = new System.Drawing.Size(756, 80);
            this.productinformation.TabIndex = 24;
            this.productinformation.TabStop = false;
            this.productinformation.Text = "Product Information";
            // 
            // enterlicensekey
            // 
            this.enterlicensekey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enterlicensekey.BackColor = System.Drawing.Color.Transparent;
            this.enterlicensekey.Controls.Add(this.label12);
            this.enterlicensekey.Controls.Add(this.regiter);
            this.enterlicensekey.Controls.Add(this.browse);
            this.enterlicensekey.Controls.Add(this.filebrowse);
            this.enterlicensekey.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterlicensekey.ForeColor = System.Drawing.Color.Yellow;
            this.enterlicensekey.Location = new System.Drawing.Point(32, 393);
            this.enterlicensekey.Name = "enterlicensekey";
            this.enterlicensekey.Size = new System.Drawing.Size(756, 95);
            this.enterlicensekey.TabIndex = 25;
            this.enterlicensekey.TabStop = false;
            this.enterlicensekey.Text = "Enter License Key";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(65, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "License Key";
            // 
            // regiter
            // 
            this.regiter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regiter.BackColor = System.Drawing.Color.White;
            this.regiter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.regiter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regiter.Location = new System.Drawing.Point(300, 61);
            this.regiter.Name = "regiter";
            this.regiter.Size = new System.Drawing.Size(80, 28);
            this.regiter.TabIndex = 2;
            this.regiter.Text = "Register";
            this.regiter.UseVisualStyleBackColor = false;
            this.regiter.Click += new System.EventHandler(this.regiter_Click);
            // 
            // browse
            // 
            this.browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.browse.BackColor = System.Drawing.Color.White;
            this.browse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browse.Location = new System.Drawing.Point(557, 26);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(83, 29);
            this.browse.TabIndex = 1;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // filebrowse
            // 
            this.filebrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.filebrowse.Location = new System.Drawing.Point(181, 28);
            this.filebrowse.Name = "filebrowse";
            this.filebrowse.ReadOnly = true;
            this.filebrowse.Size = new System.Drawing.Size(327, 27);
            this.filebrowse.TabIndex = 0;
            // 
            // LicenseMgm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::License_Manager.Properties.Resources.Untitled_design__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.enterlicensekey);
            this.Controls.Add(this.RegLicButton);
            this.Controls.Add(this.productinformation);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LicenseMgm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "License Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.productinformation.ResumeLayout(false);
            this.productinformation.PerformLayout();
            this.enterlicensekey.ResumeLayout(false);
            this.enterlicensekey.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox CompanyName;
        private System.Windows.Forms.TextBox ContactName;
        private System.Windows.Forms.TextBox EmailId;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.ComboBox ProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RegLicButton;
        private System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ZipCode;
        private System.Windows.Forms.TextBox State;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox numberofusers;
        private System.Windows.Forms.GroupBox productinformation;
        private System.Windows.Forms.GroupBox enterlicensekey;
        private System.Windows.Forms.Button regiter;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.TextBox filebrowse;
        private System.Windows.Forms.Label ErrorMsg;
        private System.Windows.Forms.Label label12;
    }
}

