namespace AdoptmeApplication
{
    partial class CreateCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCategory));
            pictureBox2 = new PictureBox();
            lblAdoptionApplication = new Label();
            textCategoryName = new TextBox();
            lblName = new Label();
            btnSaveAnimalCategory = new ModelButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-12, -31);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(174, 171);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 77;
            pictureBox2.TabStop = false;
            // 
            // lblAdoptionApplication
            // 
            lblAdoptionApplication.AutoSize = true;
            lblAdoptionApplication.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdoptionApplication.ForeColor = Color.DarkGreen;
            lblAdoptionApplication.Location = new Point(152, 30);
            lblAdoptionApplication.Margin = new Padding(2, 0, 2, 0);
            lblAdoptionApplication.Name = "lblAdoptionApplication";
            lblAdoptionApplication.Size = new Size(288, 46);
            lblAdoptionApplication.TabIndex = 76;
            lblAdoptionApplication.Text = "Animal Category";
            // 
            // textCategoryName
            // 
            textCategoryName.Location = new Point(163, 142);
            textCategoryName.Margin = new Padding(2);
            textCategoryName.Name = "textCategoryName";
            textCategoryName.Size = new Size(266, 27);
            textCategoryName.TabIndex = 103;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(81, 142);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 20);
            lblName.TabIndex = 102;
            lblName.Text = "Name";
            // 
            // btnSaveAnimalCategory
            // 
            btnSaveAnimalCategory.BackColor = Color.White;
            btnSaveAnimalCategory.BorderRadius = 41;
            btnSaveAnimalCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveAnimalCategory.ForeColor = Color.White;
            btnSaveAnimalCategory.GradientAngle = 90F;
            btnSaveAnimalCategory.GradientBottomColor = SystemColors.ActiveBorder;
            btnSaveAnimalCategory.GradientTopColor = Color.LightSlateGray;
            btnSaveAnimalCategory.Location = new Point(195, 182);
            btnSaveAnimalCategory.Margin = new Padding(2);
            btnSaveAnimalCategory.Name = "btnSaveAnimalCategory";
            btnSaveAnimalCategory.Size = new Size(108, 43);
            btnSaveAnimalCategory.TabIndex = 104;
            btnSaveAnimalCategory.Text = "Save";
            btnSaveAnimalCategory.UseVisualStyleBackColor = false;
            btnSaveAnimalCategory.Click += btnSaveAnimalCategory_Click;
            // 
            // CreateCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(468, 241);
            Controls.Add(btnSaveAnimalCategory);
            Controls.Add(textCategoryName);
            Controls.Add(lblName);
            Controls.Add(pictureBox2);
            Controls.Add(lblAdoptionApplication);
            Name = "CreateCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Animal Category";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label lblAdoptionApplication;
        private TextBox textCategoryName;
        private Label lblName;
        private ModelButton btnSaveAnimalCategory;
    }
}