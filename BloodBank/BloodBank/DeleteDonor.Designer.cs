namespace BloodBank
{
    partial class DeleteDonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteDonor));
            this.ERASEDONOR = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDonorID = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFather = new System.Windows.Forms.TextBox();
            this.txtMother = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.DateTimePicker();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.txtBloodGroup = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.SuspendLayout();
            // 
            // ERASEDONOR
            // 
            this.ERASEDONOR.AutoSize = true;
            this.ERASEDONOR.BackColor = System.Drawing.Color.DarkRed;
            this.ERASEDONOR.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ERASEDONOR.ForeColor = System.Drawing.Color.White;
            this.ERASEDONOR.Location = new System.Drawing.Point(189, 9);
            this.ERASEDONOR.Name = "ERASEDONOR";
            this.ERASEDONOR.Size = new System.Drawing.Size(265, 49);
            this.ERASEDONOR.TabIndex = 4;
            this.ERASEDONOR.Text = "ERASE DONOR";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(470, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 37);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDonorID
            // 
            this.txtDonorID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonorID.Location = new System.Drawing.Point(40, 76);
            this.txtDonorID.Name = "txtDonorID";
            this.txtDonorID.Size = new System.Drawing.Size(424, 37);
            this.txtDonorID.TabIndex = 8;
            this.txtDonorID.TextChanged += new System.EventHandler(this.txtDonorID_TextChanged);
            // 
            // txtGender
            // 
            this.txtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtGender.Location = new System.Drawing.Point(276, 342);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(301, 28);
            this.txtGender.TabIndex = 40;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(276, 429);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(301, 67);
            this.txtAddress.TabIndex = 39;
            // 
            // txtFather
            // 
            this.txtFather.Location = new System.Drawing.Point(276, 220);
            this.txtFather.Multiline = true;
            this.txtFather.Name = "txtFather";
            this.txtFather.Size = new System.Drawing.Size(301, 39);
            this.txtFather.TabIndex = 38;
            // 
            // txtMother
            // 
            this.txtMother.Location = new System.Drawing.Point(276, 261);
            this.txtMother.Multiline = true;
            this.txtMother.Name = "txtMother";
            this.txtMother.Size = new System.Drawing.Size(301, 39);
            this.txtMother.TabIndex = 37;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(276, 302);
            this.txtMobile.Multiline = true;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(301, 39);
            this.txtMobile.TabIndex = 36;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(276, 177);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(301, 26);
            this.txtDOB.TabIndex = 35;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(276, 383);
            this.txtCity.Multiline = true;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(301, 39);
            this.txtCity.TabIndex = 34;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(276, 139);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(301, 34);
            this.txtName.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 425);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 29);
            this.label12.TabIndex = 32;
            this.label12.Text = "ADDRESS:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 29);
            this.label11.TabIndex = 31;
            this.label11.Text = "CITY:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 29);
            this.label8.TabIndex = 30;
            this.label8.Text = "GENDER:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "MOBILE NUMBER:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "MOTHER\'S NAME:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "FATHER\'S NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "BIRTHDATE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "NAME:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Size = new System.Drawing.Size(698, 616);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(460, 567);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 81);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "CLOSE";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(328, 567);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 81);
            this.btnReset.TabIndex = 42;
            this.btnReset.Text = "RESET";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnErase
            // 
            this.btnErase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnErase.Image = ((System.Drawing.Image)(resources.GetObject("btnErase.Image")));
            this.btnErase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnErase.Location = new System.Drawing.Point(198, 567);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(105, 81);
            this.btnErase.TabIndex = 41;
            this.btnErase.Text = "ERASE";
            this.btnErase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer1";
            this.shapeContainer2.Size = new System.Drawing.Size(698, 616);
            this.shapeContainer2.TabIndex = 1;
            this.shapeContainer2.TabStop = false;
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBloodGroup.FormattingEnabled = true;
            this.txtBloodGroup.Items.AddRange(new object[] {
            "A+",
            "B+",
            "AB+",
            "O+",
            "O-",
            "A-",
            "B-",
            "AB-"});
            this.txtBloodGroup.Location = new System.Drawing.Point(276, 511);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Size = new System.Drawing.Size(301, 28);
            this.txtBloodGroup.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 511);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 29);
            this.label10.TabIndex = 44;
            this.label10.Text = "BLOOD TYPE:";
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer1";
            this.shapeContainer3.Size = new System.Drawing.Size(698, 616);
            this.shapeContainer3.TabIndex = 1;
            this.shapeContainer3.TabStop = false;
            // 
            // DeleteDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(597, 684);
            this.Controls.Add(this.txtBloodGroup);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFather);
            this.Controls.Add(this.txtMother);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDonorID);
            this.Controls.Add(this.ERASEDONOR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteDonor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteDonor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ERASEDONOR;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDonorID;
        private System.Windows.Forms.ComboBox txtGender;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFather;
        private System.Windows.Forms.TextBox txtMother;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.DateTimePicker txtDOB;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnErase;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.ComboBox txtBloodGroup;
        private System.Windows.Forms.Label label10;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
    }
}