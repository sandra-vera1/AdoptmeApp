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
            lblUpdate.Location = new Point(367, 33);
            lblUpdate.Margin = new Padding(2, 0, 2, 0);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(462, 46);
            lblUpdate.TabIndex = 49;
            lblUpdate.Text = "Update Animal Information";
            // 
            // cboSize
            // 
            cboSize.FormattingEnabled = true;
            cboSize.Items.AddRange(new object[] { "Small", "Medium\t", "Large", "Extra Large" });
            cboSize.Location = new Point(751, 349);
            cboSize.Margin = new Padding(2, 2, 2, 2);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(125, 28);
            cboSize.TabIndex = 68;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(652, 396);
            lblCategory.Margin = new Padding(2, 0, 2, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(73, 20);
            lblCategory.TabIndex = 67;
            lblCategory.Text = "Category";
            // 
            // cboLocality
            // 
            cboLocality.FormattingEnabled = true;
            cboLocality.Items.AddRange(new object[] { "Acadia", "Country Hills", "Downtown", "Elbow Park", "GlenBrook", "Greenview", "Highwood", "Medicine Hill", "Sage Hill", "Tuscany", "Willow Park", "Yorkville" });
            cboLocality.Location = new Point(751, 441);
            cboLocality.Margin = new Padding(2, 2, 2, 2);
            cboLocality.Name = "cboLocality";
            cboLocality.Size = new Size(125, 28);
            cboLocality.TabIndex = 66;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Available", "Adopted" });
            cboStatus.Location = new Point(751, 484);
            cboStatus.Margin = new Padding(2, 2, 2, 2);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(125, 28);
            cboStatus.TabIndex = 65;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Dog", "Cat", "Rabbit" });
            cboCategory.Location = new Point(751, 391);
            cboCategory.Margin = new Padding(2, 2, 2, 2);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(125, 28);
            cboCategory.TabIndex = 64;
            // 
            // cboSex
            // 
            cboSex.FormattingEnabled = true;
            cboSex.Items.AddRange(new object[] { "Female", "Male" });
            cboSex.Location = new Point(751, 257);
            cboSex.Margin = new Padding(2, 2, 2, 2);
            cboSex.Name = "cboSex";
            cboSex.Size = new Size(125, 28);
            cboSex.TabIndex = 63;
            // 
            // txtBreed
            // 
            txtBreed.Location = new Point(751, 302);
            txtBreed.Margin = new Padding(2, 2, 2, 2);
            txtBreed.Name = "txtBreed";
            txtBreed.Size = new Size(125, 27);
            txtBreed.TabIndex = 62;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(751, 212);
            txtAge.Margin = new Padding(2, 2, 2, 2);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 61;
            // 
            // txtName
            // 
            txtName.Location = new Point(751, 168);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 60;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(655, 491);
            lblStatus.Margin = new Padding(2, 0, 2, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(53, 20);
            lblStatus.TabIndex = 59;
            lblStatus.Text = "Status";
            // 
            // lblLocality
            // 
            lblLocality.AutoSize = true;
            lblLocality.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocality.Location = new Point(655, 446);
            lblLocality.Margin = new Padding(2, 0, 2, 0);
            lblLocality.Name = "lblLocality";
            lblLocality.Size = new Size(63, 20);
            lblLocality.TabIndex = 58;
            lblLocality.Text = "Locality";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.Location = new Point(655, 351);
            lblSize.Margin = new Padding(2, 0, 2, 0);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(36, 20);
            lblSize.TabIndex = 57;
            lblSize.Text = "Size";
            // 
            // lblBreed
            // 
            lblBreed.AutoSize = true;
            lblBreed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBreed.Location = new Point(655, 306);
            lblBreed.Margin = new Padding(2, 0, 2, 0);
            lblBreed.Name = "lblBreed";
            lblBreed.Size = new Size(50, 20);
            lblBreed.TabIndex = 56;
            lblBreed.Text = "Breed";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSex.Location = new Point(655, 262);
            lblSex.Margin = new Padding(2, 0, 2, 0);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(33, 20);
            lblSex.TabIndex = 55;
            lblSex.Text = "Sex";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(652, 217);
            lblAge.Margin = new Padding(2, 0, 2, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(37, 20);
            lblAge.TabIndex = 54;
            lblAge.Text = "Age";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(652, 172);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(55, 20);
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
            btnSaveChange.GradientBottomColor = SystemColors.ActiveBorder;
            btnSaveChange.GradientTopColor = Color.LightSlateGray;
            btnSaveChange.Location = new Point(706, 552);
            btnSaveChange.Margin = new Padding(2, 2, 2, 2);
            btnSaveChange.Name = "btnSaveChange";
            btnSaveChange.Size = new Size(125, 33);
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
            btnUploadPhoto.GradientBottomColor = SystemColors.ActiveBorder;
            btnUploadPhoto.GradientTopColor = Color.LightSlateGray;
            btnUploadPhoto.Location = new Point(260, 138);
            btnUploadPhoto.Margin = new Padding(2, 2, 2, 2);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(125, 33);
            btnUploadPhoto.TabIndex = 72;
            btnUploadPhoto.Text = "Upload Photo";
            btnUploadPhoto.UseVisualStyleBackColor = false;
            btnUploadPhoto.Click += btnUploadPhoto_Click;
            // 
            // picAnimal
            // 
            picAnimal.BorderStyle = BorderStyle.FixedSingle;
            picAnimal.Location = new Point(151, 187);
            picAnimal.Margin = new Padding(2, 2, 2, 2);
            picAnimal.Name = "picAnimal";
            picAnimal.Size = new Size(362, 345);
            picAnimal.SizeMode = PictureBoxSizeMode.Zoom;
            picAnimal.TabIndex = 73;
            picAnimal.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, -29);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(207, 171);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 74;
            pictureBox2.TabStop = false;
            // 
            // EditAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1031, 621);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "EditAnimal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Animal";
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