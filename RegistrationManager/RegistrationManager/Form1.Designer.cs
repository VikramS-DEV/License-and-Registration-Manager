
namespace RegistrationManager
{
    partial class RgistrationManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RgistrationManager));
            this.RgistrationKey = new System.Windows.Forms.Label();
            this.RegistrationKey = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.SoftwareValidity = new System.Windows.Forms.GroupBox();
            this.Numbertext = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.Label();
            this.ProductCode = new System.Windows.Forms.GroupBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.GenerateLicense = new System.Windows.Forms.Button();
            this.SoftwareValidity.SuspendLayout();
            this.ProductCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // RgistrationKey
            // 
            this.RgistrationKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RgistrationKey.AutoSize = true;
            this.RgistrationKey.BackColor = System.Drawing.Color.Transparent;
            this.RgistrationKey.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RgistrationKey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RgistrationKey.Location = new System.Drawing.Point(199, 118);
            this.RgistrationKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RgistrationKey.Name = "RgistrationKey";
            this.RgistrationKey.Size = new System.Drawing.Size(130, 19);
            this.RgistrationKey.TabIndex = 0;
            this.RgistrationKey.Text = "Registration Key";
            // 
            // RegistrationKey
            // 
            this.RegistrationKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegistrationKey.BackColor = System.Drawing.SystemColors.Info;
            this.RegistrationKey.Location = new System.Drawing.Point(348, 110);
            this.RegistrationKey.Margin = new System.Windows.Forms.Padding(4);
            this.RegistrationKey.Name = "RegistrationKey";
            this.RegistrationKey.ReadOnly = true;
            this.RegistrationKey.Size = new System.Drawing.Size(373, 27);
            this.RegistrationKey.TabIndex = 1;
            // 
            // Browse
            // 
            this.Browse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Browse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Browse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Browse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Browse.Location = new System.Drawing.Point(770, 109);
            this.Browse.Margin = new System.Windows.Forms.Padding(4);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(96, 29);
            this.Browse.TabIndex = 2;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = false;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // SoftwareValidity
            // 
            this.SoftwareValidity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SoftwareValidity.BackColor = System.Drawing.Color.Transparent;
            this.SoftwareValidity.Controls.Add(this.Numbertext);
            this.SoftwareValidity.Controls.Add(this.Number);
            this.SoftwareValidity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SoftwareValidity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SoftwareValidity.Location = new System.Drawing.Point(678, 224);
            this.SoftwareValidity.Margin = new System.Windows.Forms.Padding(4);
            this.SoftwareValidity.Name = "SoftwareValidity";
            this.SoftwareValidity.Padding = new System.Windows.Forms.Padding(4);
            this.SoftwareValidity.Size = new System.Drawing.Size(264, 88);
            this.SoftwareValidity.TabIndex = 3;
            this.SoftwareValidity.TabStop = false;
            this.SoftwareValidity.Text = "Software Validity ";
            // 
            // Numbertext
            // 
            this.Numbertext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Numbertext.BackColor = System.Drawing.SystemColors.Info;
            this.Numbertext.Location = new System.Drawing.Point(160, 40);
            this.Numbertext.Margin = new System.Windows.Forms.Padding(4);
            this.Numbertext.Name = "Numbertext";
            this.Numbertext.Size = new System.Drawing.Size(67, 27);
            this.Numbertext.TabIndex = 1;
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Number.Location = new System.Drawing.Point(8, 43);
            this.Number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(132, 19);
            this.Number.TabIndex = 0;
            this.Number.Text = "Number of Days";
            // 
            // ProductCode
            // 
            this.ProductCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductCode.BackColor = System.Drawing.Color.Transparent;
            this.ProductCode.Controls.Add(this.ProductName);
            this.ProductCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductCode.Location = new System.Drawing.Point(82, 224);
            this.ProductCode.Margin = new System.Windows.Forms.Padding(4);
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.Padding = new System.Windows.Forms.Padding(4);
            this.ProductCode.Size = new System.Drawing.Size(267, 88);
            this.ProductCode.TabIndex = 4;
            this.ProductCode.TabStop = false;
            this.ProductCode.Text = "Product Name";
            // 
            // ProductName
            // 
            this.ProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductName.BackColor = System.Drawing.SystemColors.Info;
            this.ProductName.Location = new System.Drawing.Point(27, 35);
            this.ProductName.Margin = new System.Windows.Forms.Padding(4);
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Size = new System.Drawing.Size(208, 27);
            this.ProductName.TabIndex = 6;
            // 
            // GenerateLicense
            // 
            this.GenerateLicense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenerateLicense.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GenerateLicense.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GenerateLicense.Location = new System.Drawing.Point(410, 433);
            this.GenerateLicense.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateLicense.Name = "GenerateLicense";
            this.GenerateLicense.Size = new System.Drawing.Size(266, 40);
            this.GenerateLicense.TabIndex = 5;
            this.GenerateLicense.Text = "Generate Licence";
            this.GenerateLicense.UseVisualStyleBackColor = false;
            this.GenerateLicense.Click += new System.EventHandler(this.GenerateLicense_Click);
            // 
            // RgistrationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistrationManager.Properties.Resources.Untitled_design__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 514);
            this.Controls.Add(this.GenerateLicense);
            this.Controls.Add(this.ProductCode);
            this.Controls.Add(this.SoftwareValidity);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.RegistrationKey);
            this.Controls.Add(this.RgistrationKey);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RgistrationManager";
            this.Text = "Registration Manager";
            this.SoftwareValidity.ResumeLayout(false);
            this.SoftwareValidity.PerformLayout();
            this.ProductCode.ResumeLayout(false);
            this.ProductCode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RgistrationKey;
        private System.Windows.Forms.TextBox RegistrationKey;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.GroupBox SoftwareValidity;
        private System.Windows.Forms.TextBox Numbertext;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.GroupBox ProductCode;
        private System.Windows.Forms.Button GenerateLicense;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ProductName;
    }
}

