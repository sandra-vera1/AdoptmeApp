namespace AdoptmeApplication
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            lblPassword = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            btnLogin = new ModelButton();
            txtPassword = new TextBox();
            pictureBox2 = new PictureBox();
            lblAdoptionApplication = new Label();
            panel1 = new Panel();
            panelButtonsAdmin = new Panel();
            panelViewApplications = new Panel();
            label3 = new Label();
            panelCreateCategory = new Panel();
            label2 = new Label();
            panelCreateAnimal = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            modelButton1 = new ModelButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panelButtonsAdmin.SuspendLayout();
            panelViewApplications.SuspendLayout();
            panelCreateCategory.SuspendLayout();
            panelCreateAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.DarkGreen;
            lblPassword.Location = new Point(967, 25);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 20);
            lblPassword.TabIndex = 86;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.DarkGreen;
            lblUsername.Location = new Point(700, 24);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 20);
            lblUsername.TabIndex = 85;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(784, 21);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(171, 27);
            txtUsername.TabIndex = 88;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.BorderRadius = 41;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.GradientAngle = 90F;
            btnLogin.GradientBottomColor = SystemColors.ActiveBorder;
            btnLogin.GradientTopColor = Color.LightSlateGray;
            btnLogin.Location = new Point(1235, 14);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(108, 43);
            btnLogin.TabIndex = 95;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(1050, 22);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(171, 27);
            txtPassword.TabIndex = 96;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(11, 181);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 97;
            pictureBox2.TabStop = false;
            // 
            // lblAdoptionApplication
            // 
            lblAdoptionApplication.AutoSize = true;
            lblAdoptionApplication.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdoptionApplication.ForeColor = Color.DarkGreen;
            lblAdoptionApplication.Location = new Point(165, 217);
            lblAdoptionApplication.Margin = new Padding(2, 0, 2, 0);
            lblAdoptionApplication.Name = "lblAdoptionApplication";
            lblAdoptionApplication.Size = new Size(280, 46);
            lblAdoptionApplication.TabIndex = 98;
            lblAdoptionApplication.Text = "Animals Catalog";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(modelButton1);
            panel1.Controls.Add(panelButtonsAdmin);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1481, 147);
            panel1.TabIndex = 99;
            // 
            // panelButtonsAdmin
            // 
            panelButtonsAdmin.Controls.Add(panelViewApplications);
            panelButtonsAdmin.Controls.Add(panelCreateCategory);
            panelButtonsAdmin.Controls.Add(panelCreateAnimal);
            panelButtonsAdmin.Location = new Point(255, 80);
            panelButtonsAdmin.Name = "panelButtonsAdmin";
            panelButtonsAdmin.Size = new Size(1226, 64);
            panelButtonsAdmin.TabIndex = 100;
            // 
            // panelViewApplications
            // 
            panelViewApplications.Controls.Add(label3);
            panelViewApplications.Location = new Point(295, 3);
            panelViewApplications.Name = "panelViewApplications";
            panelViewApplications.Size = new Size(165, 61);
            panelViewApplications.TabIndex = 102;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(7, 18);
            label3.Name = "label3";
            label3.Size = new Size(154, 23);
            label3.TabIndex = 100;
            label3.Text = "View Applications";
            // 
            // panelCreateCategory
            // 
            panelCreateCategory.Controls.Add(label2);
            panelCreateCategory.Location = new Point(141, 3);
            panelCreateCategory.Name = "panelCreateCategory";
            panelCreateCategory.Size = new Size(153, 61);
            panelCreateCategory.TabIndex = 101;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(7, 18);
            label2.Name = "label2";
            label2.Size = new Size(141, 23);
            label2.TabIndex = 100;
            label2.Text = "Create Category";
            // 
            // panelCreateAnimal
            // 
            panelCreateAnimal.Controls.Add(label1);
            panelCreateAnimal.Location = new Point(3, 3);
            panelCreateAnimal.Name = "panelCreateAnimal";
            panelCreateAnimal.Size = new Size(139, 61);
            panelCreateAnimal.TabIndex = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(7, 18);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 100;
            label1.Text = "Create Animal";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MainDog;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 100;
            pictureBox1.TabStop = false;
            // 
            // modelButton1
            // 
            modelButton1.BackColor = Color.White;
            modelButton1.BorderRadius = 41;
            modelButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modelButton1.ForeColor = Color.White;
            modelButton1.GradientAngle = 90F;
            modelButton1.GradientBottomColor = SystemColors.ActiveBorder;
            modelButton1.GradientTopColor = Color.LightSlateGray;
            modelButton1.Location = new Point(1356, 13);
            modelButton1.Margin = new Padding(2);
            modelButton1.Name = "modelButton1";
            modelButton1.Size = new Size(108, 43);
            modelButton1.TabIndex = 101;
            modelButton1.Text = "Logout";
            modelButton1.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1481, 994);
            Controls.Add(pictureBox2);
            Controls.Add(lblAdoptionApplication);
            Controls.Add(panel1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catalog";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelButtonsAdmin.ResumeLayout(false);
            panelViewApplications.ResumeLayout(false);
            panelViewApplications.PerformLayout();
            panelCreateCategory.ResumeLayout(false);
            panelCreateCategory.PerformLayout();
            panelCreateAnimal.ResumeLayout(false);
            panelCreateAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtUsername;
        private ModelButton btnLogin;
        private TextBox txtPassword;
        private PictureBox pictureBox2;
        private Label lblAdoptionApplication;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panelButtonsAdmin;
        private Panel panel4;
        private Panel panelCreateAnimal;
        private Label label1;
        private Panel panelCreateCategory;
        private Label label2;
        private Panel panelViewApplications;
        private Label label3;
        private ModelButton modelButton1;
    }
}
