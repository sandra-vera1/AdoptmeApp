namespace AdoptmeApplication
{
    partial class ApplicationList
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationList));
            lblUpdate = new Label();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            btnSave = new ModelButton();
            lblResult = new Label();
            rboPending = new RadioButton();
            rboApproved = new RadioButton();
            rboDenied = new RadioButton();
            btnPetPopularity = new ModelButton();
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new ModelButton();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdate.ForeColor = Color.DarkGreen;
            lblUpdate.Location = new Point(648, 121);
            lblUpdate.Margin = new Padding(2, 0, 2, 0);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(430, 46);
            lblUpdate.TabIndex = 50;
            lblUpdate.Text = "Adoption Application List";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(113, 37);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(424, 205);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 75;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 246);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1643, 464);
            dataGridView1.TabIndex = 79;
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
            btnSave.Location = new Point(1440, 203);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 39);
            btnSave.TabIndex = 80;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(1113, 216);
            lblResult.Margin = new Padding(2, 0, 2, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(52, 20);
            lblResult.TabIndex = 81;
            lblResult.Text = "Result:";
            // 
            // rboPending
            // 
            rboPending.AutoSize = true;
            rboPending.Location = new Point(1175, 214);
            rboPending.Margin = new Padding(2);
            rboPending.Name = "rboPending";
            rboPending.Size = new Size(83, 24);
            rboPending.TabIndex = 82;
            rboPending.TabStop = true;
            rboPending.Text = "Pending";
            rboPending.UseVisualStyleBackColor = true;
            // 
            // rboApproved
            // 
            rboApproved.AutoSize = true;
            rboApproved.Location = new Point(1260, 214);
            rboApproved.Margin = new Padding(2);
            rboApproved.Name = "rboApproved";
            rboApproved.Size = new Size(96, 24);
            rboApproved.TabIndex = 83;
            rboApproved.TabStop = true;
            rboApproved.Text = "Approved";
            rboApproved.UseVisualStyleBackColor = true;
            // 
            // rboDenied
            // 
            rboDenied.AutoSize = true;
            rboDenied.Location = new Point(1355, 214);
            rboDenied.Margin = new Padding(2);
            rboDenied.Name = "rboDenied";
            rboDenied.Size = new Size(78, 24);
            rboDenied.TabIndex = 84;
            rboDenied.TabStop = true;
            rboDenied.Text = "Denied";
            rboDenied.UseVisualStyleBackColor = true;
            // 
            // btnPetPopularity
            // 
            btnPetPopularity.BackColor = Color.White;
            btnPetPopularity.BorderRadius = 41;
            btnPetPopularity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPetPopularity.ForeColor = Color.White;
            btnPetPopularity.GradientAngle = 90F;
            btnPetPopularity.GradientBottomColor = SystemColors.ActiveBorder;
            btnPetPopularity.GradientTopColor = Color.LightSlateGray;
            btnPetPopularity.Location = new Point(1532, 203);
            btnPetPopularity.Margin = new Padding(2);
            btnPetPopularity.Name = "btnPetPopularity";
            btnPetPopularity.Size = new Size(128, 39);
            btnPetPopularity.TabIndex = 85;
            btnPetPopularity.Text = "Pet Popularity";
            btnPetPopularity.UseVisualStyleBackColor = false;
            btnPetPopularity.Click += btnPetPopularity_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1006, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 86;
            label1.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1076, 28);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(299, 27);
            txtSearch.TabIndex = 87;
            toolTip1.SetToolTip(txtSearch, "Enter the Application Id Number");
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.BorderRadius = 41;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.GradientAngle = 90F;
            btnSearch.GradientBottomColor = SystemColors.ActiveBorder;
            btnSearch.GradientTopColor = Color.LightSlateGray;
            btnSearch.Location = new Point(1407, 24);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(81, 33);
            btnSearch.TabIndex = 88;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // ApplicationList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1683, 799);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnPetPopularity);
            Controls.Add(rboDenied);
            Controls.Add(rboApproved);
            Controls.Add(rboPending);
            Controls.Add(lblResult);
            Controls.Add(btnSave);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(lblUpdate);
            Margin = new Padding(2);
            Name = "ApplicationList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application List";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUpdate;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private ModelButton btnSave;
        private Label lblResult;
        private RadioButton rboPending;
        private RadioButton rboApproved;
        private RadioButton rboDenied;
        private ModelButton btnPetPopularity;
        private Label label1;
        private TextBox txtSearch;
        private ModelButton btnSearch;
        private ToolTip toolTip1;
    }
}