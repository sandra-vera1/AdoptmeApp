namespace AdoptmeApplication
{
    partial class AnimalDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalDetails));
            cboSize = new ComboBox();
            lblCategory = new Label();
            cboLocality = new ComboBox();
            cboStatus = new ComboBox();
            cboCategory = new ComboBox();
            cboSex = new ComboBox();
            txtBreed = new TextBox();
            txtAge = new TextBox();
            txtName = new TextBox();
            txtAnimalId = new TextBox();
            lblStatus = new Label();
            lblLocality = new Label();
            lblSize = new Label();
            lblBreed = new Label();
            lblSex = new Label();
            lblAge = new Label();
            lblName = new Label();
            lblAnimalId = new Label();
            btnUpdate = new ModelButton();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnAdoptMe = new ModelButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cboSize
            // 
            cboSize.FormattingEnabled = true;
            cboSize.Items.AddRange(new object[] { "Small", "Medium\t", "Large", "Extra Large" });
            cboSize.Location = new Point(1223, 550);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(200, 40);
            cboSize.TabIndex = 47;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(1062, 625);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(118, 32);
            lblCategory.TabIndex = 46;
            lblCategory.Text = "Category";
            // 
            // cboLocality
            // 
            cboLocality.FormattingEnabled = true;
            cboLocality.Items.AddRange(new object[] { "Acadia\t", "Country Hills", "Downtown", "Elbow Park", "GlenBrook", "Greenview", "Highwood", "Medicine Hill", "Sage Hill", "Tuscany", "Willow Park", "Yorkville" });
            cboLocality.Location = new Point(1223, 697);
            cboLocality.Name = "cboLocality";
            cboLocality.Size = new Size(200, 40);
            cboLocality.TabIndex = 45;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Available", "Adopted" });
            cboStatus.Location = new Point(1223, 767);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(200, 40);
            cboStatus.TabIndex = 44;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Dog", "Cat", "Rabbit" });
            cboCategory.Location = new Point(1223, 617);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(200, 40);
            cboCategory.TabIndex = 43;
            // 
            // cboSex
            // 
            cboSex.FormattingEnabled = true;
            cboSex.Items.AddRange(new object[] { "Female", "Male" });
            cboSex.Location = new Point(1223, 403);
            cboSex.Name = "cboSex";
            cboSex.Size = new Size(200, 40);
            cboSex.TabIndex = 42;
            // 
            // txtBreed
            // 
            txtBreed.Location = new Point(1223, 475);
            txtBreed.Name = "txtBreed";
            txtBreed.Size = new Size(200, 39);
            txtBreed.TabIndex = 41;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(1223, 332);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(200, 39);
            txtAge.TabIndex = 40;
            // 
            // txtName
            // 
            txtName.Location = new Point(1223, 261);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 39);
            txtName.TabIndex = 39;
            // 
            // txtAnimalId
            // 
            txtAnimalId.Location = new Point(1223, 190);
            txtAnimalId.Name = "txtAnimalId";
            txtAnimalId.ReadOnly = true;
            txtAnimalId.Size = new Size(200, 39);
            txtAnimalId.TabIndex = 38;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(1067, 777);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(83, 32);
            lblStatus.TabIndex = 37;
            lblStatus.Text = "Status";
            // 
            // lblLocality
            // 
            lblLocality.AutoSize = true;
            lblLocality.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocality.Location = new Point(1067, 705);
            lblLocality.Name = "lblLocality";
            lblLocality.Size = new Size(102, 32);
            lblLocality.TabIndex = 36;
            lblLocality.Text = "Locality";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.Location = new Point(1067, 553);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(59, 32);
            lblSize.TabIndex = 35;
            lblSize.Text = "Size";
            // 
            // lblBreed
            // 
            lblBreed.AutoSize = true;
            lblBreed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBreed.Location = new Point(1067, 482);
            lblBreed.Name = "lblBreed";
            lblBreed.Size = new Size(80, 32);
            lblBreed.TabIndex = 34;
            lblBreed.Text = "Breed";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSex.Location = new Point(1067, 411);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(53, 32);
            lblSex.TabIndex = 33;
            lblSex.Text = "Sex";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(1062, 339);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(59, 32);
            lblAge.TabIndex = 32;
            lblAge.Text = "Age";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(1062, 268);
            lblName.Name = "lblName";
            lblName.Size = new Size(88, 32);
            lblName.TabIndex = 31;
            lblName.Text = "Name:";
            // 
            // lblAnimalId
            // 
            lblAnimalId.AutoSize = true;
            lblAnimalId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnimalId.Location = new Point(1057, 200);
            lblAnimalId.Name = "lblAnimalId";
            lblAnimalId.Size = new Size(132, 32);
            lblAnimalId.TabIndex = 30;
            lblAnimalId.Text = "Animal Id:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.BorderRadius = 41;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.GradientAngle = 90F;
            btnUpdate.GradientBottomColor = Color.MediumPurple;
            btnUpdate.GradientTopColor = Color.SlateBlue;
            btnUpdate.Location = new Point(1037, 874);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(175, 53);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(553, 40);
            label10.Name = "label10";
            label10.Size = new Size(676, 71);
            label10.TabIndex = 48;
            label10.Text = "Pet Information Overview";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(63, -65);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(337, 274);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(228, 233);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(587, 551);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // btnAdoptMe
            // 
            btnAdoptMe.BackColor = Color.White;
            btnAdoptMe.BorderRadius = 41;
            btnAdoptMe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdoptMe.ForeColor = Color.White;
            btnAdoptMe.GradientAngle = 90F;
            btnAdoptMe.GradientBottomColor = Color.MediumPurple;
            btnAdoptMe.GradientTopColor = Color.SlateBlue;
            btnAdoptMe.Location = new Point(1272, 874);
            btnAdoptMe.Name = "btnAdoptMe";
            btnAdoptMe.Size = new Size(175, 53);
            btnAdoptMe.TabIndex = 51;
            btnAdoptMe.Text = "Adopt me";
            btnAdoptMe.UseVisualStyleBackColor = false;
            btnAdoptMe.Click += btnAdoptMe_Click;
            // 
            // AnimalDetails
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1676, 993);
            Controls.Add(btnAdoptMe);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label10);
            Controls.Add(cboSize);
            Controls.Add(lblCategory);
            Controls.Add(cboLocality);
            Controls.Add(cboStatus);
            Controls.Add(cboCategory);
            Controls.Add(cboSex);
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
            Controls.Add(btnUpdate);
            Name = "AnimalDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnimalDetails";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSize;
        private Label lblCategory;
        private ComboBox cboLocality;
        private ComboBox cboStatus;
        private ComboBox cboCategory;
        private ComboBox cboSex;
        private TextBox txtBreed;
        private TextBox txtAge;
        private TextBox txtName;
        private TextBox txtAnimalId;
        private Label lblStatus;
        private Label lblLocality;
        private Label lblSize;
        private Label lblBreed;
        private Label lblSex;
        private Label lblAge;
        private Label lblName;
        private Label lblAnimalId;
        private ModelButton btnUpdate;
        private Label label10;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ModelButton btnAdoptMe;
    }
}