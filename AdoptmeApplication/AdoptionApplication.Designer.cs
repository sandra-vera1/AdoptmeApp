namespace AdoptmeApplication
{
    partial class AdoptionApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdoptionApplication));
            lblAdoptionApplication = new Label();
            pictureBox2 = new PictureBox();
            txtAnimalId = new TextBox();
            lblAnimalId = new Label();
            lblNumPets = new Label();
            cboTimeHome = new ComboBox();
            cboOutdoorAv = new ComboBox();
            cboNumAdult = new ComboBox();
            txtAddress = new TextBox();
            txtFullName = new TextBox();
            lblOutdoorAv = new Label();
            lblTimeHome = new Label();
            lblNumChildren = new Label();
            lblNumAdult = new Label();
            lblAddress = new Label();
            lblFullName = new Label();
            btnSendApplication = new ModelButton();
            label1 = new Label();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            label2 = new Label();
            cboNumChildren = new ComboBox();
            cboNumPets = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblAdoptionApplication
            // 
            lblAdoptionApplication.AutoSize = true;
            lblAdoptionApplication.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdoptionApplication.ForeColor = Color.DarkGreen;
            lblAdoptionApplication.Location = new Point(205, 35);
            lblAdoptionApplication.Margin = new Padding(2, 0, 2, 0);
            lblAdoptionApplication.Name = "lblAdoptionApplication";
            lblAdoptionApplication.Size = new Size(366, 46);
            lblAdoptionApplication.TabIndex = 50;
            lblAdoptionApplication.Text = "Adoption Application";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(59, -32);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 189);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 75;
            pictureBox2.TabStop = false;
            // 
            // txtAnimalId
            // 
            txtAnimalId.Location = new Point(343, 104);
            txtAnimalId.Margin = new Padding(2);
            txtAnimalId.Name = "txtAnimalId";
            txtAnimalId.ReadOnly = true;
            txtAnimalId.Size = new Size(125, 27);
            txtAnimalId.TabIndex = 93;
            // 
            // lblAnimalId
            // 
            lblAnimalId.AutoSize = true;
            lblAnimalId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnimalId.Location = new Point(241, 110);
            lblAnimalId.Margin = new Padding(2, 0, 2, 0);
            lblAnimalId.Name = "lblAnimalId";
            lblAnimalId.Size = new Size(77, 20);
            lblAnimalId.TabIndex = 92;
            lblAnimalId.Text = "Animal Id";
            // 
            // lblNumPets
            // 
            lblNumPets.AutoSize = true;
            lblNumPets.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumPets.Location = new Point(25, 485);
            lblNumPets.Margin = new Padding(2, 0, 2, 0);
            lblNumPets.Name = "lblNumPets";
            lblNumPets.Size = new Size(184, 20);
            lblNumPets.TabIndex = 90;
            lblNumPets.Text = "Number of Pets at Home";
            // 
            // cboTimeHome
            // 
            cboTimeHome.FormattingEnabled = true;
            cboTimeHome.Items.AddRange(new object[] { "Less 15 hours per week", "Between 15 and 30 hours per week", "Between 31 and 50 hours per week", "More than 50 hours per week" });
            cboTimeHome.Location = new Point(217, 567);
            cboTimeHome.Margin = new Padding(2);
            cboTimeHome.Name = "cboTimeHome";
            cboTimeHome.Size = new Size(263, 28);
            cboTimeHome.TabIndex = 89;
            // 
            // cboOutdoorAv
            // 
            cboOutdoorAv.FormattingEnabled = true;
            cboOutdoorAv.Items.AddRange(new object[] { "Yard", "Access to parks", "Balcony", "Two space (Yard, Access to parks, Balcony)", "All (Yard, Access to parks, Balcony)", "None" });
            cboOutdoorAv.Location = new Point(217, 611);
            cboOutdoorAv.Margin = new Padding(2);
            cboOutdoorAv.Name = "cboOutdoorAv";
            cboOutdoorAv.Size = new Size(263, 28);
            cboOutdoorAv.TabIndex = 88;
            // 
            // cboNumAdult
            // 
            cboNumAdult.FormattingEnabled = true;
            cboNumAdult.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "More than 10" });
            cboNumAdult.Location = new Point(217, 397);
            cboNumAdult.Margin = new Padding(2);
            cboNumAdult.Name = "cboNumAdult";
            cboNumAdult.Size = new Size(113, 28);
            cboNumAdult.TabIndex = 86;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(392, 234);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(266, 27);
            txtAddress.TabIndex = 84;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(113, 231);
            txtFullName.Margin = new Padding(2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(171, 27);
            txtFullName.TabIndex = 83;
            // 
            // lblOutdoorAv
            // 
            lblOutdoorAv.AutoSize = true;
            lblOutdoorAv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutdoorAv.Location = new Point(25, 619);
            lblOutdoorAv.Margin = new Padding(2, 0, 2, 0);
            lblOutdoorAv.Name = "lblOutdoorAv";
            lblOutdoorAv.Size = new Size(176, 20);
            lblOutdoorAv.TabIndex = 82;
            lblOutdoorAv.Text = "Outdoor space available";
            // 
            // lblTimeHome
            // 
            lblTimeHome.AutoSize = true;
            lblTimeHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimeHome.Location = new Point(25, 575);
            lblTimeHome.Margin = new Padding(2, 0, 2, 0);
            lblTimeHome.Name = "lblTimeHome";
            lblTimeHome.Size = new Size(152, 20);
            lblTimeHome.TabIndex = 81;
            lblTimeHome.Text = "Time spend at home";
            // 
            // lblNumChildren
            // 
            lblNumChildren.AutoSize = true;
            lblNumChildren.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumChildren.Location = new Point(25, 440);
            lblNumChildren.Margin = new Padding(2, 0, 2, 0);
            lblNumChildren.Name = "lblNumChildren";
            lblNumChildren.Size = new Size(148, 20);
            lblNumChildren.TabIndex = 80;
            lblNumChildren.Text = "Number of Children";
            // 
            // lblNumAdult
            // 
            lblNumAdult.AutoSize = true;
            lblNumAdult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumAdult.Location = new Point(25, 397);
            lblNumAdult.Margin = new Padding(2, 0, 2, 0);
            lblNumAdult.Name = "lblNumAdult";
            lblNumAdult.Size = new Size(129, 20);
            lblNumAdult.TabIndex = 78;
            lblNumAdult.Text = "Number of Adult";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(305, 237);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(66, 20);
            lblAddress.TabIndex = 77;
            lblAddress.Text = "Address";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(25, 234);
            lblFullName.Margin = new Padding(2, 0, 2, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(80, 20);
            lblFullName.TabIndex = 76;
            lblFullName.Text = "Full Name";
            // 
            // btnSendApplication
            // 
            btnSendApplication.BackColor = Color.White;
            btnSendApplication.BorderRadius = 41;
            btnSendApplication.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendApplication.ForeColor = Color.White;
            btnSendApplication.GradientAngle = 90F;
            btnSendApplication.GradientBottomColor = SystemColors.ActiveBorder;
            btnSendApplication.GradientTopColor = Color.LightSlateGray;
            btnSendApplication.Location = new Point(263, 668);
            btnSendApplication.Margin = new Padding(2);
            btnSendApplication.Name = "btnSendApplication";
            btnSendApplication.Size = new Size(108, 43);
            btnSendApplication.TabIndex = 94;
            btnSendApplication.Text = "Send";
            btnSendApplication.UseVisualStyleBackColor = false;
            btnSendApplication.Click += btnSendApplication_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(11, 176);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 28);
            label1.TabIndex = 95;
            label1.Text = "Personal Information:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(159, 280);
            txtPhoneNumber.Margin = new Padding(2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(125, 27);
            txtPhoneNumber.TabIndex = 97;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(25, 283);
            lblPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(115, 20);
            lblPhoneNumber.TabIndex = 96;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(392, 283);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(266, 27);
            txtEmail.TabIndex = 99;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(305, 286);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 20);
            lblEmail.TabIndex = 98;
            lblEmail.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(11, 344);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(237, 28);
            label2.TabIndex = 100;
            label2.Text = "Household Information:";
            // 
            // cboNumChildren
            // 
            cboNumChildren.FormattingEnabled = true;
            cboNumChildren.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "More than 10" });
            cboNumChildren.Location = new Point(217, 437);
            cboNumChildren.Margin = new Padding(2);
            cboNumChildren.Name = "cboNumChildren";
            cboNumChildren.Size = new Size(113, 28);
            cboNumChildren.TabIndex = 101;
            // 
            // cboNumPets
            // 
            cboNumPets.FormattingEnabled = true;
            cboNumPets.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "More than 10" });
            cboNumPets.Location = new Point(217, 477);
            cboNumPets.Margin = new Padding(2);
            cboNumPets.Name = "cboNumPets";
            cboNumPets.Size = new Size(113, 28);
            cboNumPets.TabIndex = 102;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(11, 523);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(243, 28);
            label3.TabIndex = 103;
            label3.Text = "Lifestyle Considerations:";
            // 
            // AdoptionApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(691, 732);
            Controls.Add(label3);
            Controls.Add(cboNumPets);
            Controls.Add(cboNumChildren);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(label1);
            Controls.Add(btnSendApplication);
            Controls.Add(txtAnimalId);
            Controls.Add(lblAnimalId);
            Controls.Add(lblNumPets);
            Controls.Add(cboTimeHome);
            Controls.Add(cboOutdoorAv);
            Controls.Add(cboNumAdult);
            Controls.Add(txtAddress);
            Controls.Add(txtFullName);
            Controls.Add(lblOutdoorAv);
            Controls.Add(lblTimeHome);
            Controls.Add(lblNumChildren);
            Controls.Add(lblNumAdult);
            Controls.Add(lblAddress);
            Controls.Add(lblFullName);
            Controls.Add(pictureBox2);
            Controls.Add(lblAdoptionApplication);
            Name = "AdoptionApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adoption Application Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdoptionApplication;
        private PictureBox pictureBox2;
        private TextBox txtAnimalId;
        private Label lblAnimalId;
        private ComboBox cboSize;
        private Label lblNumPets;
        private ComboBox cboTimeHome;
        private ComboBox cboOutdoorAv;
        private ComboBox cboNumAdult;
        private TextBox txtBreed;
        private TextBox txtAddress;
        private TextBox txtFullName;
        private Label lblOutdoorAv;
        private Label lblTimeHome;
        private Label lblNumChildren;
        private Label lblBreed;
        private Label lblNumAdult;
        private Label lblAddress;
        private Label lblFullName;
        private ModelButton btnSendApplication;
        private Label label1;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumber;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label label2;
        private ComboBox cboNumChildren;
        private ComboBox cboNumPets;
        private Label label3;
    }
}