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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            lblPassword = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            btnLogin = new ModelButton();
            txtPassword = new TextBox();
            lblAdoptionApplication = new Label();
            panel1 = new Panel();
            modelButton1 = new ModelButton();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            createAnimalToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            viewApplicationsToolStripMenuItem = new ToolStripMenuItem();
            cboLocality = new ComboBox();
            label4 = new Label();
            cboTypeAnimal = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            linkLabel1 = new LinkLabel();
            dataGridView1 = new DataGridView();
            modelButton2 = new ModelButton();
            imageList1 = new ImageList(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(969, 45);
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
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(702, 44);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 20);
            lblUsername.TabIndex = 85;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(786, 41);
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
            btnLogin.Location = new Point(1237, 34);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(108, 43);
            btnLogin.TabIndex = 95;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(1052, 42);
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
            lblAdoptionApplication.Location = new Point(593, 151);
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
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1481, 135);
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
            modelButton1.Location = new Point(1358, 33);
            modelButton1.Margin = new Padding(2);
            modelButton1.Name = "modelButton1";
            modelButton1.Size = new Size(108, 43);
            modelButton1.TabIndex = 101;
            modelButton1.Text = "Logout";
            modelButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MainDog;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 100;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Tan;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { createAnimalToolStripMenuItem, toolStripMenuItem1, viewApplicationsToolStripMenuItem });
            menuStrip1.Location = new Point(252, 94);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(469, 31);
            menuStrip1.TabIndex = 109;
            menuStrip1.Text = "menuStrip1";
            // 
            // createAnimalToolStripMenuItem
            // 
            createAnimalToolStripMenuItem.Name = "createAnimalToolStripMenuItem";
            createAnimalToolStripMenuItem.Size = new Size(138, 27);
            createAnimalToolStripMenuItem.Text = "Create Animal";
            createAnimalToolStripMenuItem.Click += createAnimalToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(155, 27);
            toolStripMenuItem1.Text = "Create Category";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // viewApplicationsToolStripMenuItem
            // 
            viewApplicationsToolStripMenuItem.Name = "viewApplicationsToolStripMenuItem";
            viewApplicationsToolStripMenuItem.Size = new Size(168, 27);
            viewApplicationsToolStripMenuItem.Text = "View Applications";
            viewApplicationsToolStripMenuItem.Click += viewApplicationsToolStripMenuItem_Click;
            // 
            // cboLocality
            // 
            cboLocality.FormattingEnabled = true;
            cboLocality.Items.AddRange(new object[] { "Acadia\t", "Country Hills", "Downtown", "Elbow Park", "GlenBrook", "Greenview", "Highwood", "Medicine Hill", "Sage Hill", "Tuscany", "Willow Park", "Yorkville" });
            cboLocality.Location = new Point(95, 199);
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
            label4.Location = new Point(21, 202);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 102;
            label4.Text = "Filter by:";
            // 
            // cboTypeAnimal
            // 
            cboTypeAnimal.FormattingEnabled = true;
            cboTypeAnimal.Items.AddRange(new object[] { "Dog", "Cat", "Rabbit", "Exotic" });
            cboTypeAnimal.Location = new Point(241, 199);
            cboTypeAnimal.Margin = new Padding(2);
            cboTypeAnimal.Name = "cboTypeAnimal";
            cboTypeAnimal.Size = new Size(125, 28);
            cboTypeAnimal.TabIndex = 103;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(95, 171);
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
            label6.Location = new Point(241, 171);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 105;
            label6.Text = "Type of animal";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(121, 316);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(165, 132);
            pictureBox3.TabIndex = 106;
            pictureBox3.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(160, 478);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(76, 20);
            linkLabel1.TabIndex = 107;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            linkLabel1.LinkClicked += LinkLabel1_LinkClicked;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(702, 222);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(727, 484);
            dataGridView1.TabIndex = 108;
            // 
            // modelButton2
            // 
            modelButton2.BackColor = Color.White;
            modelButton2.BorderRadius = 41;
            modelButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modelButton2.ForeColor = Color.White;
            modelButton2.GradientAngle = 90F;
            modelButton2.GradientBottomColor = SystemColors.ActiveBorder;
            modelButton2.GradientTopColor = Color.LightSlateGray;
            modelButton2.Location = new Point(383, 184);
            modelButton2.Margin = new Padding(2);
            modelButton2.Name = "modelButton2";
            modelButton2.Size = new Size(108, 43);
            modelButton2.TabIndex = 110;
            modelButton2.Text = "Search";
            modelButton2.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Canary.jpg");
            imageList1.Images.SetKeyName(1, "cat.jpg");
            imageList1.Images.SetKeyName(2, "labrador.jpg");
            imageList1.Images.SetKeyName(3, "MainDog.jpg");
            imageList1.Images.SetKeyName(4, "rabbit.jpg");
            imageList1.Images.SetKeyName(5, "snake.jpg");
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1481, 994);
            Controls.Add(modelButton2);
            Controls.Add(dataGridView1);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cboTypeAnimal);
            Controls.Add(label4);
            Controls.Add(cboLocality);
            Controls.Add(lblAdoptionApplication);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catalog";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Panel panel4;
        private ModelButton modelButton1;
        private ComboBox cboLocality;
        private Label label4;
        private ComboBox cboTypeAnimal;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox3;
        private LinkLabel linkLabel1;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem createAnimalToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem viewApplicationsToolStripMenuItem;
        private ModelButton modelButton2;
        private ImageList imageList1;
    }
}
