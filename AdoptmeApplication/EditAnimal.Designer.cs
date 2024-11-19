namespace AdoptmeApplication
{
    partial class EditAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAnimal));
            lblUpdate = new Label();
            cboSize = new ComboBox();
            lblCategory = new Label();
            cboLocality = new ComboBox();
            cboStatus = new ComboBox();
            cboCategory = new ComboBox();
            cboSex = new ComboBox();
            txtBreed = new TextBox();
            txtAge = new TextBox();
            txtName = new TextBox();
            lblStatus = new Label();
            lblLocality = new Label();
            lblSize = new Label();
            lblBreed = new Label();
            lblSex = new Label();
            lblAge = new Label();
            lblName = new Label();
            btnSaveChange = new ModelButton();
            btnUploadPhoto = new ModelButton();
            picAnimal = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picAnimal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdate.ForeColor = Color.DarkGreen;
            lblUpdate.Location = new Point(596, 53);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(624, 71);
            lblUpdate.TabIndex = 49;
            lblUpdate.Text = "Update Pet Information";
            // 
            // cboSize
            // 
            cboSize.FormattingEnabled = true;
            cboSize.Items.AddRange(new object[] { "Small", "Medium\t", "Large", "Extra Large" });
            cboSize.Location = new Point(1220, 558);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(200, 40);
            cboSize.TabIndex = 68;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(1059, 633);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(118, 32);
            lblCategory.TabIndex = 67;
            lblCategory.Text = "Category";
            // 
            // cboLocality
            // 
            cboLocality.FormattingEnabled = true;
            cboLocality.Items.AddRange(new object[] { "Acadia", "Country Hills", "Downtown", "Elbow Park", "GlenBrook", "Greenview", "Highwood", "Medicine Hill", "Sage Hill", "Tuscany", "Willow Park", "Yorkville" });
            cboLocality.Location = new Point(1220, 705);
            cboLocality.Name = "cboLocality";
            cboLocality.Size = new Size(200, 40);
            cboLocality.TabIndex = 66;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Available", "Adopted" });
            cboStatus.Location = new Point(1220, 775);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(200, 40);
            cboStatus.TabIndex = 65;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Dog", "Cat", "Rabbit" });
            cboCategory.Location = new Point(1220, 625);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(200, 40);
            cboCategory.TabIndex = 64;
            // 
            // cboSex
            // 
            cboSex.FormattingEnabled = true;
            cboSex.Items.AddRange(new object[] { "Female", "Male" });
            cboSex.Location = new Point(1220, 411);
            cboSex.Name = "cboSex";
            cboSex.Size = new Size(200, 40);
            cboSex.TabIndex = 63;
            // 
            // txtBreed
            // 
            txtBreed.Location = new Point(1220, 483);
            txtBreed.Name = "txtBreed";
            txtBreed.Size = new Size(200, 39);
            txtBreed.TabIndex = 62;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(1220, 340);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(200, 39);
            txtAge.TabIndex = 61;
            // 
            // txtName
            // 
            txtName.Location = new Point(1220, 269);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 39);
            txtName.TabIndex = 60;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(1064, 785);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(83, 32);
            lblStatus.TabIndex = 59;
            lblStatus.Text = "Status";
            // 
            // lblLocality
            // 
            lblLocality.AutoSize = true;
            lblLocality.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocality.Location = new Point(1064, 713);
            lblLocality.Name = "lblLocality";
            lblLocality.Size = new Size(102, 32);
            lblLocality.TabIndex = 58;
            lblLocality.Text = "Locality";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.Location = new Point(1064, 561);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(59, 32);
            lblSize.TabIndex = 57;
            lblSize.Text = "Size";
            // 
            // lblBreed
            // 
            lblBreed.AutoSize = true;
            lblBreed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBreed.Location = new Point(1064, 490);
            lblBreed.Name = "lblBreed";
            lblBreed.Size = new Size(80, 32);
            lblBreed.TabIndex = 56;
            lblBreed.Text = "Breed";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSex.Location = new Point(1064, 419);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(53, 32);
            lblSex.TabIndex = 55;
            lblSex.Text = "Sex";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(1059, 347);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(59, 32);
            lblAge.TabIndex = 54;
            lblAge.Text = "Age";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(1059, 276);
            lblName.Name = "lblName";
            lblName.Size = new Size(88, 32);
            lblName.TabIndex = 53;
            lblName.Text = "Name:";
            // 
            // btnSaveChange
            // 
            btnSaveChange.BackColor = Color.White;
            btnSaveChange.BorderRadius = 41;
            btnSaveChange.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveChange.ForeColor = Color.White;
            btnSaveChange.GradientAngle = 90F;
            btnSaveChange.GradientBottomColor = Color.MediumPurple;
            btnSaveChange.GradientTopColor = Color.SlateBlue;
            btnSaveChange.Location = new Point(1148, 884);
            btnSaveChange.Name = "btnSaveChange";
            btnSaveChange.Size = new Size(175, 53);
            btnSaveChange.TabIndex = 52;
            btnSaveChange.Text = "Save";
            btnSaveChange.UseVisualStyleBackColor = false;
            btnSaveChange.Click += btnSaveChange_Click;
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.BackColor = Color.White;
            btnUploadPhoto.BorderRadius = 41;
            btnUploadPhoto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUploadPhoto.ForeColor = Color.White;
            btnUploadPhoto.GradientAngle = 90F;
            btnUploadPhoto.GradientBottomColor = Color.MediumPurple;
            btnUploadPhoto.GradientTopColor = Color.SlateBlue;
            btnUploadPhoto.Location = new Point(423, 220);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(175, 53);
            btnUploadPhoto.TabIndex = 72;
            btnUploadPhoto.Text = "Upload Photo";
            btnUploadPhoto.UseVisualStyleBackColor = false;
            btnUploadPhoto.Click += btnUploadPhoto_Click;
            // 
            // picAnimal
            // 
            picAnimal.BorderStyle = BorderStyle.FixedSingle;
            picAnimal.Location = new Point(246, 299);
            picAnimal.Name = "picAnimal";
            picAnimal.Size = new Size(587, 551);
            picAnimal.SizeMode = PictureBoxSizeMode.Zoom;
            picAnimal.TabIndex = 73;
            picAnimal.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(37, -46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(337, 274);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 74;
            pictureBox2.TabStop = false;
            // 
            // EditAnimal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1676, 993);
            Controls.Add(pictureBox2);
            Controls.Add(picAnimal);
            Controls.Add(btnUploadPhoto);
            Controls.Add(cboSize);
            Controls.Add(lblCategory);
            Controls.Add(cboLocality);
            Controls.Add(cboStatus);
            Controls.Add(cboCategory);
            Controls.Add(cboSex);
            Controls.Add(txtBreed);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(lblStatus);
            Controls.Add(lblLocality);
            Controls.Add(lblSize);
            Controls.Add(lblBreed);
            Controls.Add(lblSex);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(btnSaveChange);
            Controls.Add(lblUpdate);
            Name = "EditAnimal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateAnimal";
            ((System.ComponentModel.ISupportInitialize)picAnimal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUpdate;
        private ModelButton btnAdoptMe;
        private ComboBox cboSize;
        private Label lblCategory;
        private ComboBox cboLocality;
        private ComboBox cboStatus;
        private ComboBox cboCategory;
        private ComboBox cboSex;
        private TextBox txtBreed;
        private TextBox txtAge;
        private TextBox txtName;
        private Label lblStatus;
        private Label lblLocality;
        private Label lblSize;
        private Label lblBreed;
        private Label lblSex;
        private Label lblAge;
        private Label lblName;
        private ModelButton btnSaveChange;
        private ModelButton btnUploadPhoto;
        private PictureBox picAnimal;
        private PictureBox pictureBox2;
    }
}