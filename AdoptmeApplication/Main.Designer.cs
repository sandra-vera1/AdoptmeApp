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
            lblPassword = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            btnLogin = new ModelButton();
            txtPassword = new TextBox();
            lblAdoptionApplication = new Label();
            panel1 = new Panel();
            modelButton1 = new ModelButton();
            panelButtonsAdmin = new Panel();
            panelViewApplications = new Panel();
            label3 = new Label();
            panelCreateCategory = new Panel();
            label2 = new Label();
            panelCreateAnimal = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            cboLocality = new ComboBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            linkLabel1 = new LinkLabel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panelButtonsAdmin.SuspendLayout();
            panelViewApplications.SuspendLayout();
            panelCreateCategory.SuspendLayout();
            panelCreateAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // lblAdoptionApplication
            // 
            lblAdoptionApplication.AutoSize = true;
            lblAdoptionApplication.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdoptionApplication.ForeColor = Color.DarkGreen;
            lblAdoptionApplication.Location = new Point(600, 177);
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
            // cboLocality
            // 
            cboLocality.FormattingEnabled = true;
            cboLocality.Items.AddRange(new object[] { "Acadia\t", "Country Hills", "Downtown", "Elbow Park", "GlenBrook", "Greenview", "Highwood", "Medicine Hill", "Sage Hill", "Tuscany", "Willow Park", "Yorkville" });
            cboLocality.Location = new Point(531, 300);
            cboLocality.Margin = new Padding(2);
            cboLocality.Name = "cboLocality";
            cboLocality.Size = new Size(125, 28);
            cboLocality.TabIndex = 101;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(450, 303);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 102;
            label4.Text = "Filter by";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dog", "Cat", "Rabbit", "Exotic" });
            comboBox1.Location = new Point(677, 300);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 103;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(531, 278);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 104;
            label5.Text = "Location";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(677, 278);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 105;
            label6.Text = "Type of animal";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(160, 415);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(165, 132);
            pictureBox3.TabIndex = 106;
            pictureBox3.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(160, 564);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(76, 20);
            linkLabel1.TabIndex = 107;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(677, 511);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(780, 309);
            dataGridView1.TabIndex = 108;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1481, 994);
            Controls.Add(dataGridView1);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(cboLocality);
            Controls.Add(lblAdoptionApplication);
            Controls.Add(panel1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catalog";
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtUsername;
        private ModelButton btnLogin;
        private TextBox txtPassword;
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
        private ComboBox cboLocality;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox3;
        private LinkLabel linkLabel1;
        private DataGridView dataGridView1;
    }
}
