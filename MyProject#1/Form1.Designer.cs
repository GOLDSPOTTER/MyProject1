namespace MyProject_1
{
    partial class Form1
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
            this.ProfileButtons = new System.Windows.Forms.Button();
            this.Homelabel = new System.Windows.Forms.Label();
            this.ProjectsButton = new System.Windows.Forms.Button();
            this.LessonsButton = new System.Windows.Forms.Button();
            this.TeacherPortalButton = new System.Windows.Forms.Button();
            this.ParentPortalButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.CreateProjectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfileButtons
            // 
            this.ProfileButtons.Location = new System.Drawing.Point(28, 109);
            this.ProfileButtons.Name = "ProfileButtons";
            this.ProfileButtons.Size = new System.Drawing.Size(86, 23);
            this.ProfileButtons.TabIndex = 1;
            this.ProfileButtons.Text = "Profile";
            this.ProfileButtons.UseVisualStyleBackColor = true;
            // 
            // Homelabel
            // 
            this.Homelabel.AutoSize = true;
            this.Homelabel.Location = new System.Drawing.Point(56, 64);
            this.Homelabel.Name = "Homelabel";
            this.Homelabel.Size = new System.Drawing.Size(35, 13);
            this.Homelabel.TabIndex = 2;
            this.Homelabel.Text = "Home";
            // 
            // ProjectsButton
            // 
            this.ProjectsButton.Location = new System.Drawing.Point(28, 157);
            this.ProjectsButton.Name = "ProjectsButton";
            this.ProjectsButton.Size = new System.Drawing.Size(86, 23);
            this.ProjectsButton.TabIndex = 3;
            this.ProjectsButton.Text = "Projects";
            this.ProjectsButton.UseVisualStyleBackColor = true;
            // 
            // LessonsButton
            // 
            this.LessonsButton.Location = new System.Drawing.Point(28, 202);
            this.LessonsButton.Name = "LessonsButton";
            this.LessonsButton.Size = new System.Drawing.Size(86, 23);
            this.LessonsButton.TabIndex = 4;
            this.LessonsButton.Text = "Lessons";
            this.LessonsButton.UseVisualStyleBackColor = true;
            // 
            // TeacherPortalButton
            // 
            this.TeacherPortalButton.Location = new System.Drawing.Point(28, 247);
            this.TeacherPortalButton.Name = "TeacherPortalButton";
            this.TeacherPortalButton.Size = new System.Drawing.Size(86, 23);
            this.TeacherPortalButton.TabIndex = 5;
            this.TeacherPortalButton.Text = "Teacher Portal";
            this.TeacherPortalButton.UseVisualStyleBackColor = true;
            // 
            // ParentPortalButton
            // 
            this.ParentPortalButton.Location = new System.Drawing.Point(28, 294);
            this.ParentPortalButton.Name = "ParentPortalButton";
            this.ParentPortalButton.Size = new System.Drawing.Size(86, 23);
            this.ParentPortalButton.TabIndex = 6;
            this.ParentPortalButton.Text = "Parent Portal";
            this.ParentPortalButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 64);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(352, 27);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(69, 13);
            this.Title.TabIndex = 8;
            this.Title.Text = "Blockly Code";
            // 
            // CreateProjectButton
            // 
            this.CreateProjectButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CreateProjectButton.Location = new System.Drawing.Point(105, 22);
            this.CreateProjectButton.Name = "CreateProjectButton";
            this.CreateProjectButton.Size = new System.Drawing.Size(87, 23);
            this.CreateProjectButton.TabIndex = 9;
            this.CreateProjectButton.Text = "Create Project";
            this.CreateProjectButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 453);
            this.Controls.Add(this.CreateProjectButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ParentPortalButton);
            this.Controls.Add(this.TeacherPortalButton);
            this.Controls.Add(this.LessonsButton);
            this.Controls.Add(this.ProjectsButton);
            this.Controls.Add(this.Homelabel);
            this.Controls.Add(this.ProfileButtons);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ProfileButtons;
        private System.Windows.Forms.Label Homelabel;
        private System.Windows.Forms.Button ProjectsButton;
        private System.Windows.Forms.Button LessonsButton;
        private System.Windows.Forms.Button TeacherPortalButton;
        private System.Windows.Forms.Button ParentPortalButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button CreateProjectButton;
    }
}

