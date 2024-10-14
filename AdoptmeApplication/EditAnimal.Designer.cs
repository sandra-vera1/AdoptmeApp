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
            txtAnimalId = new TextBox();
            lblAnimalId = new Label();
            btnUploadPhoto = new ModelButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            cboSize.Location = new Point(1219, 593);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(200, 40);
            cboSize.TabIndex = 68;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(1058, 668);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(118, 32);
            lblCategory.TabIndex = 67;
            lblCategory.Text = "Category";
            // 
            // cboLocality
            // 
            cboLocality.FormattingEnabled = true;
            cboLocality.Items.AddRange(new object[] { "Acadia\t", "Country Hills", "Downtown", "Elbow Park", "GlenBrook", "Greenview", "Highwood", "Medicine Hill", "Sage Hill", "Tuscany", "Willow Park", "Yorkville" });
            cboLocality.Location = new Point(1219, 740);
            cboLocality.Name = "cboLocality";
            cboLocality.Size = new Size(200, 40);
            cboLocality.TabIndex = 66;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Available", "Adopted" });
            cboStatus.Location = new Point(1219, 810);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(200, 40);
            cboStatus.TabIndex = 65;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Dog", "Cat", "Rabbit" });
            cboCategory.Location = new Point(1219, 660);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(200, 40);
            cboCategory.TabIndex = 64;
            // 
            // cboSex
            // 
            cboSex.FormattingEnabled = true;
            cboSex.Items.AddRange(new object[] { "Female", "Male" });
            cboSex.Location = new Point(1219, 446);
            cboSex.Name = "cboSex";
            cboSex.Size = new Size(200, 40);
            cboSex.TabIndex = 63;
            // 
            // txtBreed
            // 
            txtBreed.Location = new Point(1219, 518);
            txtBreed.Name = "txtBreed";
            txtBreed.Size = new Size(200, 39);
            txtBreed.TabIndex = 62;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(1219, 375);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(200, 39);
            txtAge.TabIndex = 61;
            // 
            // txtName
            // 
            txtName.Location = new Point(1219, 304);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 39);
            txtName.TabIndex = 60;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(1063, 820);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(83, 32);
            lblStatus.TabIndex = 59;
            lblStatus.Text = "Status";
            // 
            // lblLocality
            // 
            lblLocality.AutoSize = true;
            lblLocality.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocality.Location = new Point(1063, 748);
            lblLocality.Name = "lblLocality";
            lblLocality.Size = new Size(102, 32);
            lblLocality.TabIndex = 58;
            lblLocality.Text = "Locality";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.Location = new Point(1063, 596);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(59, 32);
            lblSize.TabIndex = 57;
            lblSize.Text = "Size";
            // 
            // lblBreed
            // 
            lblBreed.AutoSize = true;
            lblBreed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBreed.Location = new Point(1063, 525);
            lblBreed.Name = "lblBreed";
            lblBreed.Size = new Size(80, 32);
            lblBreed.TabIndex = 56;
            lblBreed.Text = "Breed";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSex.Location = new Point(1063, 454);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(53, 32);
            lblSex.TabIndex = 55;
            lblSex.Text = "Sex";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(1058, 382);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(59, 32);
            lblAge.TabIndex = 54;
            lblAge.Text = "Age";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(1058, 311);
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
            btnSaveChange.Location = new Point(1141, 903);
            btnSaveChange.Name = "btnSaveChange";
            btnSaveChange.Size = new Size(175, 53);
            btnSaveChange.TabIndex = 52;
            btnSaveChange.Text = "Save";
            btnSaveChange.UseVisualStyleBackColor = false;
            // 
            // txtAnimalId
            // 
            txtAnimalId.Location = new Point(1219, 234);
            txtAnimalId.Name = "txtAnimalId";
            txtAnimalId.ReadOnly = true;
            txtAnimalId.Size = new Size(200, 39);
            txtAnimalId.TabIndex = 71;
            // 
            // lblAnimalId
            // 
            lblAnimalId.AutoSize = true;
            lblAnimalId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnimalId.Location = new Point(1053, 244);
            lblAnimalId.Name = "lblAnimalId";
            lblAnimalId.Size = new Size(132, 32);
            lblAnimalId.TabIndex = 70;
            lblAnimalId.Text = "Animal Id:";
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
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(246, 299);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(587, 551);
            pictureBox1.TabIndex = 73;
            pictureBox1.TabStop = false;
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
            Controls.Add(pictureBox1);
            Controls.Add(btnUploadPhoto);
            Controls.Add(txtAnimalId);
            Controls.Add(lblAnimalId);
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
            Text = "UpdateAnimal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox txtAnimalId;
        private Label lblAnimalId;
        private ModelButton btnUploadPhoto;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}