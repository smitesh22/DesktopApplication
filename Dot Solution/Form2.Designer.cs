namespace Dot_Solution
{
    partial class Form2
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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Blank = new System.Windows.Forms.Label();
            this.ViewFlagged = new System.Windows.Forms.Button();
            this.FlagUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Remove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.BlogPostView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(623, 55);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(408, 413);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "View Users";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Blank
            // 
            this.Blank.AutoSize = true;
            this.Blank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blank.Location = new System.Drawing.Point(405, 9);
            this.Blank.Name = "Blank";
            this.Blank.Size = new System.Drawing.Size(0, 24);
            this.Blank.TabIndex = 2;
            this.Blank.Click += new System.EventHandler(this.label1_Click);
            // 
            // ViewFlagged
            // 
            this.ViewFlagged.Location = new System.Drawing.Point(155, 55);
            this.ViewFlagged.Name = "ViewFlagged";
            this.ViewFlagged.Size = new System.Drawing.Size(96, 23);
            this.ViewFlagged.TabIndex = 3;
            this.ViewFlagged.Text = "View Flagged";
            this.ViewFlagged.UseVisualStyleBackColor = true;
            this.ViewFlagged.Click += new System.EventHandler(this.ViewFlagged_Click);
            // 
            // FlagUser
            // 
            this.FlagUser.Location = new System.Drawing.Point(47, 198);
            this.FlagUser.Name = "FlagUser";
            this.FlagUser.Size = new System.Drawing.Size(81, 23);
            this.FlagUser.TabIndex = 4;
            this.FlagUser.Text = "Flag users";
            this.FlagUser.UseVisualStyleBackColor = true;
            this.FlagUser.Click += new System.EventHandler(this.FlagUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Scan Users to flag them for explict content";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(47, 364);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(93, 23);
            this.Remove.TabIndex = 6;
            this.Remove.Text = "Remove Users";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Remove users repeatedly posting explicit content";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.listBox1.Location = new System.Drawing.Point(47, 330);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 17);
            this.listBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select the number of times the user has offended";
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(937, 474);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 10;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // BlogPostView
            // 
            this.BlogPostView.Location = new System.Drawing.Point(47, 101);
            this.BlogPostView.Name = "BlogPostView";
            this.BlogPostView.Size = new System.Drawing.Size(102, 23);
            this.BlogPostView.TabIndex = 11;
            this.BlogPostView.Text = "View Blog Posts";
            this.BlogPostView.UseVisualStyleBackColor = true;
            this.BlogPostView.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 507);
            this.Controls.Add(this.BlogPostView);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FlagUser);
            this.Controls.Add(this.ViewFlagged);
            this.Controls.Add(this.Blank);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewUsers);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Blank;
        private System.Windows.Forms.Button ViewFlagged;
        private System.Windows.Forms.Button FlagUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button BlogPostView;
    }
}