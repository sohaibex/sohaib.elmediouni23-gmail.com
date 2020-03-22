namespace Facturation
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PassworldInput = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.EmailInput = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.labelError = new System.Windows.Forms.Label();
            this.LabelOublie = new System.Windows.Forms.LinkLabel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureVerificationEmail = new System.Windows.Forms.PictureBox();
            this.btnLogin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVerificationEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 487);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox1.Image = global::Facturation.Properties.Resources.Design_2;
            this.pictureBox1.Location = new System.Drawing.Point(-24, -53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 594);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(69)))), ((int)(((byte)(164)))));
            this.label4.Location = new System.Drawing.Point(383, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(69)))), ((int)(((byte)(164)))));
            this.label3.Location = new System.Drawing.Point(383, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username/Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(180)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(364, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            // 
            // PassworldInput
            // 
            this.PassworldInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PassworldInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PassworldInput.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PassworldInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassworldInput.Font = new System.Drawing.Font("Doppio One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassworldInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PassworldInput.HintForeColor = System.Drawing.Color.Empty;
            this.PassworldInput.HintText = "Password";
            this.PassworldInput.isPassword = true;
            this.PassworldInput.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(180)))), ((int)(((byte)(249)))));
            this.PassworldInput.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(180)))), ((int)(((byte)(249)))));
            this.PassworldInput.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(180)))), ((int)(((byte)(249)))));
            this.PassworldInput.LineThickness = 3;
            this.PassworldInput.Location = new System.Drawing.Point(387, 207);
            this.PassworldInput.Margin = new System.Windows.Forms.Padding(4);
            this.PassworldInput.MaxLength = 32767;
            this.PassworldInput.Name = "PassworldInput";
            this.PassworldInput.Size = new System.Drawing.Size(278, 33);
            this.PassworldInput.TabIndex = 2;
            this.PassworldInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pictureBox1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // EmailInput
            // 
            this.EmailInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.EmailInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.EmailInput.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.EmailInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailInput.Font = new System.Drawing.Font("Doppio One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmailInput.HintForeColor = System.Drawing.Color.Empty;
            this.EmailInput.HintText = "example@mail.com";
            this.EmailInput.isPassword = false;
            this.EmailInput.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(180)))), ((int)(((byte)(249)))));
            this.EmailInput.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(180)))), ((int)(((byte)(249)))));
            this.EmailInput.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(180)))), ((int)(((byte)(249)))));
            this.EmailInput.LineThickness = 3;
            this.EmailInput.Location = new System.Drawing.Point(387, 137);
            this.EmailInput.Margin = new System.Windows.Forms.Padding(4);
            this.EmailInput.MaxLength = 32767;
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(278, 33);
            this.EmailInput.TabIndex = 2;
            this.EmailInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmailInput.Leave += new System.EventHandler(this.bunifuMaterialTextbox4_Leave);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(427, 254);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(192, 20);
            this.labelError.TabIndex = 9;
            this.labelError.Text = "Mot de passe incorrect";
            this.labelError.Visible = false;
            // 
            // LabelOublie
            // 
            this.LabelOublie.AutoSize = true;
            this.LabelOublie.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOublie.LinkColor = System.Drawing.Color.Purple;
            this.LabelOublie.Location = new System.Drawing.Point(450, 387);
            this.LabelOublie.Name = "LabelOublie";
            this.LabelOublie.Size = new System.Drawing.Size(136, 13);
            this.LabelOublie.TabIndex = 5;
            this.LabelOublie.TabStop = true;
            this.LabelOublie.Text = "Mot de passe oublié ..?";
            this.LabelOublie.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelOublie_LinkClicked);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Image = global::Facturation.Properties.Resources.minimizeBlue;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(636, 8);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(33, 30);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 25;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = global::Facturation.Properties.Resources.invalidBlue;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(672, 9);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(33, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 25;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureVerificationEmail
            // 
            this.pictureVerificationEmail.Location = new System.Drawing.Point(638, 139);
            this.pictureVerificationEmail.Name = "pictureVerificationEmail";
            this.pictureVerificationEmail.Size = new System.Drawing.Size(28, 26);
            this.pictureVerificationEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureVerificationEmail.TabIndex = 24;
            this.pictureVerificationEmail.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.ButtonTextMarginLeft = 0;
            this.btnLogin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnLogin.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnLogin.DisabledForecolor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Snow;
            this.btnLogin.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.IconPadding = 10;
            this.btnLogin.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnLogin.IdleBorderRadius = 35;
            this.btnLogin.IdleBorderThickness = 0;
            this.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(126)))), ((int)(((byte)(208)))));
            this.btnLogin.IdleIconLeftImage = null;
            this.btnLogin.IdleIconRightImage = null;
            this.btnLogin.Location = new System.Drawing.Point(450, 331);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            stateProperties1.BorderColor = System.Drawing.Color.Black;
            stateProperties1.BorderRadius = 30;
            stateProperties1.BorderThickness = 2;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnLogin.onHoverState = stateProperties1;
            this.btnLogin.Size = new System.Drawing.Size(136, 41);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Facturation.Properties.Resources.ShowEYE;
            this.pictureBox2.Location = new System.Drawing.Point(636, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(713, 487);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.pictureVerificationEmail);
            this.Controls.Add(this.LabelOublie);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.PassworldInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVerificationEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PassworldInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmailInput;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label labelError;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogin;
        private System.Windows.Forms.LinkLabel LabelOublie;
        private System.Windows.Forms.PictureBox pictureVerificationEmail;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
    }
}

