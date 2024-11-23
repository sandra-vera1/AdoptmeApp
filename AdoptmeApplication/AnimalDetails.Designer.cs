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
            lblStatus = new Label();
            lblLocality = new Label();
            lblSize = new Label();
            lblBreed = new Label();
            lblSex = new Label();
            lblAge = new Label();
            lblName = new Label();
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
            cboSize.Enabled = false;
            cboSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboSize.FormattingEnabled = true;
            cboSize.Items.AddRange(new object[] { "Small", "Medium\t", "Large", "Extra Large" });
            cboSize.Location = new Point(753, 328);
            cboSize.Margin = new Padding(2);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(125, 28);
            cboSize.TabIndex = 47;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(654, 374);
            lblCategory.Margin = new Padding(2, 0, 2, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(73, 20);
            lblCategory.TabIndex = 46;
            lblCategory.Text = "Category";
            // 
            // cboLocality
            // 
            cboLocality.Enabled = false;
            cboLocality.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboLocality.FormattingEnabled = true;
            cboLocality.Items.AddRange(new object[] { "Acadia\t", "Country Hills", "Downtown", "Elbow Park", "GlenBrook", "Greenview", "Highwood", "Medicine Hill", "Sage Hill", "Tuscany", "Willow Park", "Yorkville" });
            cboLocality.Location = new Point(753, 419);
            cboLocality.Margin = new Padding(2);
            cboLocality.Name = "cboLocality";
            cboLocality.Size = new Size(125, 28);
            cboLocality.TabIndex = 45;
            // 
            // cboStatus
            // 
            cboStatus.Enabled = false;
            cboStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Available", "Adopted" });
            cboStatus.Location = new Point(753, 463);
            cboStatus.Margin = new Padding(2);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(125, 28);
            cboStatus.TabIndex = 44;
            // 
            // cboCategory
            // 
            cboCategory.Enabled = false;
            cboCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Dog", "Cat", "Rabbit" });
            cboCategory.Location = new Point(753, 369);
            cboCategory.Margin = new Padding(2);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(125, 28);
            cboCategory.TabIndex = 43;
            // 
            // cboSex
            // 
            cboSex.Enabled = false;
            cboSex.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboSex.FormattingEnabled = true;
            cboSex.Items.AddRange(new object[] { "Female", "Male" });
            cboSex.Location = new Point(753, 236);
            cboSex.Margin = new Padding(2);
            cboSex.Name = "cboSex";
            cboSex.Size = new Size(125, 28);
            cboSex.TabIndex = 42;
            // 
            // txtBreed
            // 
            txtBreed.Enabled = false;
            txtBreed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBreed.Location = new Point(753, 281);
            txtBreed.Margin = new Padding(2);
            txtBreed.Name = "txtBreed";
            txtBreed.Size = new Size(125, 27);
            txtBreed.TabIndex = 41;
            // 
            // txtAge
            // 
            txtAge.Enabled = false;
            txtAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(753, 191);
            txtAge.Margin = new Padding(2);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 40;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(753, 147);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 39;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(657, 469);
            lblStatus.Margin = new Padding(2, 0, 2, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(53, 20);
            lblStatus.TabIndex = 37;
            lblStatus.Text = "Status";
            // 
            // lblLocality
            // 
            lblLocality.AutoSize = true;
            lblLocality.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocality.Location = new Point(657, 424);
            lblLocality.Margin = new Padding(2, 0, 2, 0);
            lblLocality.Name = "lblLocality";
            lblLocality.Size = new Size(63, 20);
            lblLocality.TabIndex = 36;
            lblLocality.Text = "Locality";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.Location = new Point(657, 329);
            lblSize.Margin = new Padding(2, 0, 2, 0);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(36, 20);
            lblSize.TabIndex = 35;
            lblSize.Text = "Size";
            // 
            // lblBreed
            // 
            lblBreed.AutoSize = true;
            lblBreed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBreed.Location = new Point(657, 285);
            lblBreed.Margin = new Padding(2, 0, 2, 0);
            lblBreed.Name = "lblBreed";
            lblBreed.Size = new Size(50, 20);
            lblBreed.TabIndex = 34;
            lblBreed.Text = "Breed";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSex.Location = new Point(657, 241);
            lblSex.Margin = new Padding(2, 0, 2, 0);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(33, 20);
            lblSex.TabIndex = 33;
            lblSex.Text = "Sex";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(654, 196);
            lblAge.Margin = new Padding(2, 0, 2, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(37, 20);
            lblAge.TabIndex = 32;
            lblAge.Text = "Age";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(654, 151);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(55, 20);
            lblName.TabIndex = 31;
            lblName.Text = "Name:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.BorderRadius = 41;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.GradientAngle = 90F;
            btnUpdate.GradientBottomColor = SystemColors.ActiveBorder;
            btnUpdate.GradientTopColor = Color.LightSlateGray;
            btnUpdate.Location = new Point(638, 546);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 33);
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
            label10.Location = new Point(340, 25);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(433, 46);
            label10.TabIndex = 48;
            label10.Text = "Pet Information Overview";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(39, -41);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(207, 171);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(140, 146);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 345);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
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
            btnAdoptMe.GradientBottomColor = SystemColors.ActiveBorder;
            btnAdoptMe.GradientTopColor = Color.LightSlateGray;
            btnAdoptMe.Location = new Point(783, 546);
            btnAdoptMe.Margin = new Padding(2);
            btnAdoptMe.Name = "btnAdoptMe";
            btnAdoptMe.Size = new Size(108, 33);
            btnAdoptMe.TabIndex = 51;
            btnAdoptMe.Text = "Adopt me";
            btnAdoptMe.UseVisualStyleBackColor = false;
            btnAdoptMe.Click += btnAdoptMe_Click;
            // 
            // AnimalDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1031, 621);
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
            Controls.Add(lblStatus);
            Controls.Add(lblLocality);
            Controls.Add(lblSize);
            Controls.Add(lblBreed);
            Controls.Add(lblSex);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(btnUpdate);
            Margin = new Padding(2);
            Name = "AnimalDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnimalDetails";
            Load += Form_Load;
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
        private Label lblStatus;
        private Label lblLocality;
        private Label lblSize;
        private Label lblBreed;
        private Label lblSex;
        private Label lblAge;
        private Label lblName;
        private ModelButton btnUpdate;
        private Label label10;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ModelButton btnAdoptMe;
    }
}