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
            lblName = new Label();
            lblAge = new Label();
            lblSex = new Label();
            lblBreed = new Label();
            lblSize = new Label();
            lblLocality = new Label();
            lblStatus = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtBreed = new TextBox();
            label10 = new Label();
            btnUploadPhoto = new ModelButton();
            picAnimal = new PictureBox();
            cboSex = new ComboBox();
            cboCategory = new ComboBox();
            cboStatus = new ComboBox();
            cboLocality = new ComboBox();
            lblCategory = new Label();
            pictureBox2 = new PictureBox();
            cboSize = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picAnimal).BeginInit();
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
            btnSave.GradientBottomColor = SystemColors.ActiveBorder;
            btnSave.GradientTopColor = Color.LightSlateGray;
            btnSave.Location = new Point(672, 546);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 33);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(624, 170);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(55, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(624, 214);
            lblAge.Margin = new Padding(2, 0, 2, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(37, 20);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSex.Location = new Point(627, 259);
            lblSex.Margin = new Padding(2, 0, 2, 0);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(33, 20);
            lblSex.TabIndex = 4;
            lblSex.Text = "Sex";
            // 
            // lblBreed
            // 
            lblBreed.AutoSize = true;
            lblBreed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBreed.Location = new Point(627, 304);
            lblBreed.Margin = new Padding(2, 0, 2, 0);
            lblBreed.Name = "lblBreed";
            lblBreed.Size = new Size(50, 20);
            lblBreed.TabIndex = 5;
            lblBreed.Text = "Breed";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.Location = new Point(627, 348);
            lblSize.Margin = new Padding(2, 0, 2, 0);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(36, 20);
            lblSize.TabIndex = 6;
            lblSize.Text = "Size";
            // 
            // lblLocality
            // 
            lblLocality.AutoSize = true;
            lblLocality.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocality.Location = new Point(627, 443);
            lblLocality.Margin = new Padding(2, 0, 2, 0);
            lblLocality.Name = "lblLocality";
            lblLocality.Size = new Size(63, 20);
            lblLocality.TabIndex = 8;
            lblLocality.Text = "Locality";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(627, 488);
            lblStatus.Margin = new Padding(2, 0, 2, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(53, 20);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Status";
            // 
            // txtName
            // 
            txtName.Location = new Point(723, 166);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 11;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(723, 210);
            txtAge.Margin = new Padding(2, 2, 2, 2);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 12;
            // 
            // txtBreed
            // 
            txtBreed.Location = new Point(723, 299);
            txtBreed.Margin = new Padding(2, 2, 2, 2);
            txtBreed.Name = "txtBreed";
            txtBreed.Size = new Size(125, 27);
            txtBreed.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(393, 29);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(381, 46);
            label10.TabIndex = 19;
            label10.Text = "Register a New Animal";
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
            btnUploadPhoto.Location = new Point(220, 157);
            btnUploadPhoto.Margin = new Padding(2, 2, 2, 2);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(122, 33);
            btnUploadPhoto.TabIndex = 20;
            btnUploadPhoto.Text = "Upload Photo";
            btnUploadPhoto.UseVisualStyleBackColor = false;
            btnUploadPhoto.Click += btnUploadPhoto_Click;
            // 
            // picAnimal
            // 
            picAnimal.BorderStyle = BorderStyle.FixedSingle;
            picAnimal.Location = new Point(118, 199);
            picAnimal.Margin = new Padding(2, 2, 2, 2);
            picAnimal.Name = "picAnimal";
            picAnimal.Size = new Size(362, 345);
            picAnimal.SizeMode = PictureBoxSizeMode.Zoom;
            picAnimal.TabIndex = 21;
            picAnimal.TabStop = false;
            // 
            // cboSex
            // 
            cboSex.FormattingEnabled = true;
            cboSex.Items.AddRange(new object[] { "Female", "Male" });
            cboSex.Location = new Point(723, 254);
            cboSex.Margin = new Padding(2, 2, 2, 2);
            cboSex.Name = "cboSex";
            cboSex.Size = new Size(125, 28);
            cboSex.TabIndex = 22;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Dog", "Cat", "Bird", "Rabbit", "Snake", "Hamster", "Spider" });
            cboCategory.Location = new Point(723, 388);
            cboCategory.Margin = new Padding(2, 2, 2, 2);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(125, 28);
            cboCategory.TabIndex = 23;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Available", "Adopted" });
            cboStatus.Location = new Point(723, 482);
            cboStatus.Margin = new Padding(2, 2, 2, 2);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(125, 28);
            cboStatus.TabIndex = 24;
            // 
            // cboLocality
            // 
            cboLocality.FormattingEnabled = true;
            cboLocality.Items.AddRange(new object[] { "Acadia", "Country Hills", "Downtown", "Elbow Park", "GlenBrook", "Greenview", "Highwood", "Medicine Hill", "Sage Hill", "Tuscany", "Willow Park", "Yorkville" });
            cboLocality.Location = new Point(723, 438);
            cboLocality.Margin = new Padding(2, 2, 2, 2);
            cboLocality.Name = "cboLocality";
            cboLocality.Size = new Size(125, 28);
            cboLocality.TabIndex = 25;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(624, 393);
            lblCategory.Margin = new Padding(2, 0, 2, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(73, 20);
            lblCategory.TabIndex = 26;
            lblCategory.Text = "Category";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, -34);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(207, 171);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // cboSize
            // 
            cboSize.FormattingEnabled = true;
            cboSize.Items.AddRange(new object[] { "Small", "Medium\t", "Large", "Extra Large" });
            cboSize.Location = new Point(723, 346);
            cboSize.Margin = new Padding(2, 2, 2, 2);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(125, 28);
            cboSize.TabIndex = 28;
            // 
            // CreateAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1031, 621);
            Controls.Add(cboSize);
            Controls.Add(pictureBox2);
            Controls.Add(lblCategory);
            Controls.Add(cboLocality);
            Controls.Add(cboStatus);
            Controls.Add(cboCategory);
            Controls.Add(cboSex);
            Controls.Add(picAnimal);
            Controls.Add(btnUploadPhoto);
            Controls.Add(label10);
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
            Controls.Add(btnSave);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CreateAnimal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Animal";
            ((System.ComponentModel.ISupportInitialize)picAnimal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ModelButton btnSave;
        private Label lblName;
        private Label lblAge;
        private Label lblSex;
        private Label lblBreed;
        private Label lblSize;
        private Label lblLocality;
        private Label lblStatus;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtBreed;
        private Label label10;
        private ModelButton btnUploadPhoto;
        private PictureBox picAnimal;
        private ComboBox cboSex;
        private ComboBox cboCategory;
        private ComboBox cboStatus;
        private ComboBox cboLocality;
        private Label lblCategory;
        private PictureBox pictureBox2;
        private ComboBox cboSize;
    }
}