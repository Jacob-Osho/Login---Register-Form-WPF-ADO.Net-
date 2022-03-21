namespace WindowsFormsTesting
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Registrationlabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.registerPassPictureBox = new System.Windows.Forms.PictureBox();
            this.UseerLabel = new System.Windows.Forms.Label();
            this.registerLoginTextBox = new System.Windows.Forms.TextBox();
            this.registerUserpictureBox = new System.Windows.Forms.PictureBox();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.confirmPasslabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPassPictureBox = new System.Windows.Forms.PictureBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.namePictureBox = new System.Windows.Forms.PictureBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.surnamePictureBox = new System.Windows.Forms.PictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerPassPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerUserpictureBox)).BeginInit();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnamePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(212)))), ((int)(((byte)(178)))));
            this.TopPanel.Controls.Add(this.Registrationlabel);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(532, 80);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // Registrationlabel
            // 
            this.Registrationlabel.AutoSize = true;
            this.Registrationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registrationlabel.Location = new System.Drawing.Point(177, 24);
            this.Registrationlabel.Name = "Registrationlabel";
            this.Registrationlabel.Size = new System.Drawing.Size(199, 39);
            this.Registrationlabel.TabIndex = 2;
            this.Registrationlabel.Text = "Registration";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(513, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(19, 19);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(121, 195);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(67, 16);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(82, 214);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(168, 22);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // registerPassPictureBox
            // 
            this.registerPassPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("registerPassPictureBox.Image")));
            this.registerPassPictureBox.Location = new System.Drawing.Point(12, 214);
            this.registerPassPictureBox.Name = "registerPassPictureBox";
            this.registerPassPictureBox.Size = new System.Drawing.Size(64, 64);
            this.registerPassPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.registerPassPictureBox.TabIndex = 4;
            this.registerPassPictureBox.TabStop = false;
            // 
            // UseerLabel
            // 
            this.UseerLabel.AutoSize = true;
            this.UseerLabel.Location = new System.Drawing.Point(135, 103);
            this.UseerLabel.Name = "UseerLabel";
            this.UseerLabel.Size = new System.Drawing.Size(40, 16);
            this.UseerLabel.TabIndex = 3;
            this.UseerLabel.Text = "Login";
            // 
            // registerLoginTextBox
            // 
            this.registerLoginTextBox.Location = new System.Drawing.Point(82, 122);
            this.registerLoginTextBox.Multiline = true;
            this.registerLoginTextBox.Name = "registerLoginTextBox";
            this.registerLoginTextBox.Size = new System.Drawing.Size(168, 64);
            this.registerLoginTextBox.TabIndex = 2;
            // 
            // registerUserpictureBox
            // 
            this.registerUserpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("registerUserpictureBox.Image")));
            this.registerUserpictureBox.Location = new System.Drawing.Point(12, 122);
            this.registerUserpictureBox.Name = "registerUserpictureBox";
            this.registerUserpictureBox.Size = new System.Drawing.Size(64, 64);
            this.registerUserpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.registerUserpictureBox.TabIndex = 1;
            this.registerUserpictureBox.TabStop = false;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.BottomPanel.Controls.Add(this.loginLabel);
            this.BottomPanel.Controls.Add(this.surnameLabel);
            this.BottomPanel.Controls.Add(this.surnameTextBox);
            this.BottomPanel.Controls.Add(this.surnamePictureBox);
            this.BottomPanel.Controls.Add(this.nameLabel);
            this.BottomPanel.Controls.Add(this.nameTextBox);
            this.BottomPanel.Controls.Add(this.namePictureBox);
            this.BottomPanel.Controls.Add(this.emailLabel);
            this.BottomPanel.Controls.Add(this.emailTextBox);
            this.BottomPanel.Controls.Add(this.emailPictureBox);
            this.BottomPanel.Controls.Add(this.confirmPasslabel);
            this.BottomPanel.Controls.Add(this.confirmPasswordTextBox);
            this.BottomPanel.Controls.Add(this.confirmPassPictureBox);
            this.BottomPanel.Controls.Add(this.registerButton);
            this.BottomPanel.Controls.Add(this.passwordLabel);
            this.BottomPanel.Controls.Add(this.passwordTextBox);
            this.BottomPanel.Controls.Add(this.registerPassPictureBox);
            this.BottomPanel.Controls.Add(this.UseerLabel);
            this.BottomPanel.Controls.Add(this.registerLoginTextBox);
            this.BottomPanel.Controls.Add(this.registerUserpictureBox);
            this.BottomPanel.Controls.Add(this.TopPanel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(532, 436);
            this.BottomPanel.TabIndex = 1;
            // 
            // confirmPasslabel
            // 
            this.confirmPasslabel.AutoSize = true;
            this.confirmPasslabel.Location = new System.Drawing.Point(103, 285);
            this.confirmPasslabel.Name = "confirmPasslabel";
            this.confirmPasslabel.Size = new System.Drawing.Size(115, 16);
            this.confirmPasslabel.TabIndex = 10;
            this.confirmPasslabel.Text = "Confirm Password";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(82, 304);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(168, 22);
            this.confirmPasswordTextBox.TabIndex = 9;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPassPictureBox
            // 
            this.confirmPassPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("confirmPassPictureBox.Image")));
            this.confirmPassPictureBox.Location = new System.Drawing.Point(12, 304);
            this.confirmPassPictureBox.Name = "confirmPassPictureBox";
            this.confirmPassPictureBox.Size = new System.Drawing.Size(64, 64);
            this.confirmPassPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.confirmPassPictureBox.TabIndex = 8;
            this.confirmPassPictureBox.TabStop = false;
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(224)))), ((int)(((byte)(123)))));
            this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(56)))));
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.Location = new System.Drawing.Point(193, 374);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(137, 41);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(389, 103);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(41, 16);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(336, 122);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(168, 64);
            this.emailTextBox.TabIndex = 12;
            // 
            // emailPictureBox
            // 
            this.emailPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("emailPictureBox.Image")));
            this.emailPictureBox.Location = new System.Drawing.Point(266, 122);
            this.emailPictureBox.Name = "emailPictureBox";
            this.emailPictureBox.Size = new System.Drawing.Size(64, 64);
            this.emailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emailPictureBox.TabIndex = 11;
            this.emailPictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(389, 195);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 16);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(336, 214);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(168, 64);
            this.nameTextBox.TabIndex = 15;
            // 
            // namePictureBox
            // 
            this.namePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("namePictureBox.Image")));
            this.namePictureBox.Location = new System.Drawing.Point(266, 214);
            this.namePictureBox.Name = "namePictureBox";
            this.namePictureBox.Size = new System.Drawing.Size(64, 64);
            this.namePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.namePictureBox.TabIndex = 14;
            this.namePictureBox.TabStop = false;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(381, 285);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(61, 16);
            this.surnameLabel.TabIndex = 19;
            this.surnameLabel.Text = "Surname";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(336, 304);
            this.surnameTextBox.Multiline = true;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(168, 64);
            this.surnameTextBox.TabIndex = 18;
            // 
            // surnamePictureBox
            // 
            this.surnamePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("surnamePictureBox.Image")));
            this.surnamePictureBox.Location = new System.Drawing.Point(266, 304);
            this.surnamePictureBox.Name = "surnamePictureBox";
            this.surnamePictureBox.Size = new System.Drawing.Size(64, 64);
            this.surnamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.surnamePictureBox.TabIndex = 17;
            this.surnamePictureBox.TabStop = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(204)))), ((int)(((byte)(157)))));
            this.loginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginLabel.Location = new System.Drawing.Point(447, 399);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(43, 16);
            this.loginLabel.TabIndex = 20;
            this.loginLabel.Text = "Log in";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 436);
            this.Controls.Add(this.BottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.Text = "LogingForm";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerPassPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerUserpictureBox)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnamePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label Registrationlabel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.PictureBox registerPassPictureBox;
        private System.Windows.Forms.Label UseerLabel;
        private System.Windows.Forms.TextBox registerLoginTextBox;
        private System.Windows.Forms.PictureBox registerUserpictureBox;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label confirmPasslabel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.PictureBox confirmPassPictureBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.PictureBox surnamePictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.PictureBox namePictureBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.PictureBox emailPictureBox;
        private System.Windows.Forms.Label loginLabel;
    }
}