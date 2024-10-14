namespace AdoptmeApplication
{
    partial class CreateAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAnimal));
            btnSave = new ModelButton();
            lblAnimalId = new Label();
            lblName = new Label();
            lblAge = new Label();
            lblSex = new Label();
            lblBreed = new Label();
            lblSize = new Label();
            lblLocality = new Label();
            lblStatus = new Label();
            txtAnimalId = new TextBox();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtBreed = new TextBox();
            label10 = new Label();
            btnUploadPhoto = new ModelButton();
            pictureBox1 = new PictureBox();
            cboSex = new ComboBox();
            cboCategory = new ComboBox();
            cboStatus = new ComboBox();
            cboLocality = new ComboBox();
            lblCategory = new Label();
            pictureBox2 = new PictureBox();
            cboSize = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.BorderRadius = 41;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.GradientAngle = 90F;
            btnSave.GradientBottomColor = Color.MediumPurple;
            btnSave.GradientTopColor = Color.SlateBlue;
            btnSave.Location = new Point(1115, 874);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(175, 53);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // lblAnimalId
            // 
            lblAnimalId.AutoSize = true;
            lblAnimalId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnimalId.Location = new Point(1009, 204);
            lblAnimalId.Name = "lblAnimalId";
            lblAnimalId.Size = new Size(132, 32);
            lblAnimalId.TabIndex = 1;
            lblAnimalId.Text = "Animal Id:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(1014, 272);
            lblName.Name = "lblName";
            lblName.Size = new Size(88, 32);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(1014, 343);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(59, 32);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSex.Location = new Point(1019, 415);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(53, 32);
            lblSex.TabIndex = 4;
            lblSex.Text = "Sex";
            // 
            // lblBreed
            // 
            lblBreed.AutoSize = true;
            lblBreed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBreed.Location = new Point(1019, 486);
            lblBreed.Name = "lblBreed";
            lblBreed.Size = new Size(80, 32);
            lblBreed.TabIndex = 5;
            lblBreed.Text = "Breed";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.Location = new Point(1019, 557);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(59, 32);
            lblSize.TabIndex = 6;
            lblSize.Text = "Size";
            // 
            // lblLocality
            // 
            lblLocality.AutoSize = true;
            lblLocality.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocality.Location = new Point(1019, 709);
            lblLocality.Name = "lblLocality";
            lblLocality.Size = new Size(102, 32);
            lblLocality.TabIndex = 8;
            lblLocality.Text = "Locality";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(1019, 781);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(83, 32);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Status";
            // 
            // txtAnimalId
            // 
            txtAnimalId.Location = new Point(1175, 194);
            txtAnimalId.Name = "txtAnimalId";
            txtAnimalId.ReadOnly = true;
            txtAnimalId.Size = new Size(200, 39);
            txtAnimalId.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(1175, 265);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 39);
            txtName.TabIndex = 11;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(1175, 336);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(200, 39);
            txtAge.TabIndex = 12;
            // 
            // txtBreed
            // 
            txtBreed.Location = new Point(1175, 479);
            txtBreed.Name = "txtBreed";
            txtBreed.Size = new Size(200, 39);
            txtBreed.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(638, 46);
            label10.Name = "label10";
            label10.Size = new Size(503, 71);
            label10.TabIndex = 19;
            label10.Text = "Register a New Pet";
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
            btnUploadPhoto.Location = new Point(377, 214);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(175, 53);
            btnUploadPhoto.TabIndex = 20;
            btnUploadPhoto.Text = "Upload Photo";
            btnUploadPhoto.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(191, 318);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(587, 551);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // cboSex
            // 
            cboSex.FormattingEnabled = true;
            cboSex.Items.AddRange(new object[] { "Female", "Male" });
            cboSex.Location = new Point(1175, 407);
            cboSex.Name = "cboSex";
            cboSex.Size = new Size(200, 40);
            cboSex.TabIndex = 22;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Dog", "Cat", "Rabbit" });
            cboCategory.Location = new Point(1175, 621);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(200, 40);
            cboCategory.TabIndex = 23;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Available", "Adopted" });
            cboStatus.Location = new Point(1175, 771);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(200, 40);
            cboStatus.TabIndex = 24;
            // 
            // cboLocality
            // 
            cboLocality.FormattingEnabled = true;
            cboLocality.Items.AddRange(new object[] { "Acadia\t", "Country Hills", "Downtown", "Elbow Park", "GlenBrook", "Greenview", "Highwood", "Medicine Hill", "Sage Hill", "Tuscany", "Willow Park", "Yorkville" });
            cboLocality.Location = new Point(1175, 701);
            cboLocality.Name = "cboLocality";
            cboLocality.Size = new Size(200, 40);
            cboLocality.TabIndex = 25;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(1014, 629);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(118, 32);
            lblCategory.TabIndex = 26;
            lblCategory.Text = "Category";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(34, -54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(337, 274);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // cboSize
            // 
            cboSize.FormattingEnabled = true;
            cboSize.Items.AddRange(new object[] { "Small", "Medium\t", "Large", "Extra Large" });
            cboSize.Location = new Point(1175, 554);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(200, 40);
            cboSize.TabIndex = 28;
            // 
            // CreateAnimal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1676, 993);
            Controls.Add(cboSize);
            Controls.Add(pictureBox2);
            Controls.Add(lblCategory);
            Controls.Add(cboLocality);
            Controls.Add(cboStatus);
            Controls.Add(cboCategory);
            Controls.Add(cboSex);
            Controls.Add(pictureBox1);
            Controls.Add(btnUploadPhoto);
            Controls.Add(label10);
            Controls.Add(txtBreed);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(txtAnimalId);
            Controls.Add(lblStatus);
            Controls.Add(lblLocality);
            Controls.Add(lblSize);
            Controls.Add(lblBreed);
            Controls.Add(lblSex);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(lblAnimalId);
            Controls.Add(btnSave);
            Name = "CreateAnimal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateAnimal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ModelButton btnSave;
        private Label lblAnimalId;
        private Label lblName;
        private Label lblAge;
        private Label lblSex;
        private Label lblBreed;
        private Label lblSize;
        private Label lblLocality;
        private Label lblStatus;
        private TextBox txtAnimalId;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtBreed;
        private Label label10;
        private ModelButton btnUploadPhoto;
        private PictureBox pictureBox1;
        private ComboBox cboSex;
        private ComboBox cboCategory;
        private ComboBox cboStatus;
        private ComboBox cboLocality;
        private Label lblCategory;
        private PictureBox pictureBox2;
        private ComboBox cboSize;
    }
}