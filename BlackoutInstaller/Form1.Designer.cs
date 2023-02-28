namespace BlackoutInstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.DirectoryText = new System.Windows.Forms.TextBox();
            this.InstallButton = new System.Windows.Forms.Button();
            this.DirButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.install_label = new System.Windows.Forms.Label();
            this.fail_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.XButton_MouseClick);
            // 
            // DirectoryText
            // 
            this.DirectoryText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.DirectoryText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DirectoryText.ForeColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.DirectoryText, "DirectoryText");
            this.DirectoryText.Name = "DirectoryText";
            // 
            // InstallButton
            // 
            this.InstallButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.InstallButton, "InstallButton");
            this.InstallButton.ForeColor = System.Drawing.Color.White;
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.UseVisualStyleBackColor = true;
            this.InstallButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InstallButton_MouseClick);
            // 
            // DirButton
            // 
            this.DirButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.DirButton, "DirButton");
            this.DirButton.ForeColor = System.Drawing.Color.Silver;
            this.DirButton.Name = "DirButton";
            this.DirButton.UseVisualStyleBackColor = true;
            this.DirButton.Click += new System.EventHandler(this.DirButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.button1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Top_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Top_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Top_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlackoutInstaller.Properties.Resources.banner;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // install_label
            // 
            resources.ApplyResources(this.install_label, "install_label");
            this.install_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.install_label.Name = "install_label";
            // 
            // fail_label
            // 
            resources.ApplyResources(this.fail_label, "fail_label");
            this.fail_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fail_label.Name = "fail_label";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.fail_label);
            this.Controls.Add(this.install_label);
            this.Controls.Add(this.DirectoryText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DirButton);
            this.Controls.Add(this.InstallButton);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox DirectoryText;
        private System.Windows.Forms.Button InstallButton;
        private System.Windows.Forms.Button DirButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label install_label;
        private System.Windows.Forms.Label fail_label;
    }
}

