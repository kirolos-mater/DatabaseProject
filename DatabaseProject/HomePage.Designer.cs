
namespace DatabaseProject
{
    partial class HomePage
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
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCountryHome = new System.Windows.Forms.ComboBox();
            this.txtPasswordHome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailHome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameHome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblWelcomeName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.Location = new System.Drawing.Point(145, 384);
            this.btnUpdateInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(240, 35);
            this.btnUpdateInfo.TabIndex = 18;
            this.btnUpdateInfo.Text = "Update My Account Info";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 338);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Country:";
            // 
            // txtCountryHome
            // 
            this.txtCountryHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountryHome.FormattingEnabled = true;
            this.txtCountryHome.Items.AddRange(new object[] {
            "Pakistan",
            "India",
            "USA",
            "UK",
            "France"});
            this.txtCountryHome.Location = new System.Drawing.Point(145, 331);
            this.txtCountryHome.Margin = new System.Windows.Forms.Padding(2);
            this.txtCountryHome.Name = "txtCountryHome";
            this.txtCountryHome.Size = new System.Drawing.Size(240, 30);
            this.txtCountryHome.TabIndex = 16;
            this.txtCountryHome.SelectedIndexChanged += new System.EventHandler(this.txtCountry_SelectedIndexChanged);
            // 
            // txtPasswordHome
            // 
            this.txtPasswordHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordHome.Location = new System.Drawing.Point(145, 279);
            this.txtPasswordHome.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswordHome.Name = "txtPasswordHome";
            this.txtPasswordHome.Size = new System.Drawing.Size(240, 28);
            this.txtPasswordHome.TabIndex = 15;
            this.txtPasswordHome.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password:";
            // 
            // txtEmailHome
            // 
            this.txtEmailHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailHome.Location = new System.Drawing.Point(145, 224);
            this.txtEmailHome.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailHome.Name = "txtEmailHome";
            this.txtEmailHome.Size = new System.Drawing.Size(240, 28);
            this.txtEmailHome.TabIndex = 13;
            this.txtEmailHome.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email:";
            // 
            // txtNameHome
            // 
            this.txtNameHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameHome.Location = new System.Drawing.Point(145, 172);
            this.txtNameHome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameHome.Name = "txtNameHome";
            this.txtNameHome.Size = new System.Drawing.Size(240, 28);
            this.txtNameHome.TabIndex = 11;
            this.txtNameHome.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl.Location = new System.Drawing.Point(20, 113);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(365, 33);
            this.lbl.TabIndex = 19;
            this.lbl.Text = "Change Account Settings";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(528, 172);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 247);
            this.button1.TabIndex = 20;
            this.button1.Text = "Delete My Account ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblWelcomeName
            // 
            this.lblWelcomeName.AutoSize = true;
            this.lblWelcomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWelcomeName.Location = new System.Drawing.Point(244, 27);
            this.lblWelcomeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcomeName.Name = "lblWelcomeName";
            this.lblWelcomeName.Size = new System.Drawing.Size(291, 33);
            this.lblWelcomeName.TabIndex = 21;
            this.lblWelcomeName.Text = "Welcome username";
            this.lblWelcomeName.Click += new System.EventHandler(this.label1_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 518);
            this.Controls.Add(this.lblWelcomeName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCountryHome);
            this.Controls.Add(this.txtPasswordHome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmailHome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameHome);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtCountryHome;
        private System.Windows.Forms.TextBox txtPasswordHome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblWelcomeName;
    }
}