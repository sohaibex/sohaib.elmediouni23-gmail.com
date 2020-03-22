namespace Facturation
{
    partial class RecuperationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperationForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.labelExplication = new System.Windows.Forms.Label();
            this.Email_Input = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSoumettre = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureVerificationEmail = new System.Windows.Forms.PictureBox();
            this.labelMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVerificationEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // labelExplication
            // 
            this.labelExplication.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelExplication.ForeColor = System.Drawing.Color.Maroon;
            this.labelExplication.Location = new System.Drawing.Point(21, 79);
            this.labelExplication.Name = "labelExplication";
            this.labelExplication.Size = new System.Drawing.Size(342, 92);
            this.labelExplication.TabIndex = 6;
            this.labelExplication.Text = "Si vous avez oublié votre mot de passe, nous pourrons vous l\'envoyer directement " +
    "dans votre adresse Email .Veuillez vérifiez dans les spam.";
            this.labelExplication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Email_Input
            // 
            this.Email_Input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Email_Input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Email_Input.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Email_Input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email_Input.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Email_Input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Email_Input.HintForeColor = System.Drawing.Color.Empty;
            this.Email_Input.HintText = "example@mail.com";
            this.Email_Input.isPassword = false;
            this.Email_Input.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(126)))), ((int)(((byte)(208)))));
            this.Email_Input.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(126)))), ((int)(((byte)(208)))));
            this.Email_Input.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(126)))), ((int)(((byte)(208)))));
            this.Email_Input.LineThickness = 3;
            this.Email_Input.Location = new System.Drawing.Point(16, 180);
            this.Email_Input.Margin = new System.Windows.Forms.Padding(4);
            this.Email_Input.MaxLength = 32767;
            this.Email_Input.Name = "Email_Input";
            this.Email_Input.Size = new System.Drawing.Size(357, 33);
            this.Email_Input.TabIndex = 3;
            this.Email_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pictureBox1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Facturation.Properties.Resources.red;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSoumettre
            // 
            this.BtnSoumettre.BackColor = System.Drawing.Color.Transparent;
            this.BtnSoumettre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSoumettre.BackgroundImage")));
            this.BtnSoumettre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSoumettre.ButtonText = "Soumettre";
            this.BtnSoumettre.ButtonTextMarginLeft = 0;
            this.BtnSoumettre.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.BtnSoumettre.DisabledFillColor = System.Drawing.Color.Gray;
            this.BtnSoumettre.DisabledForecolor = System.Drawing.Color.White;
            this.BtnSoumettre.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSoumettre.ForeColor = System.Drawing.Color.Snow;
            this.BtnSoumettre.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnSoumettre.IconPadding = 10;
            this.BtnSoumettre.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnSoumettre.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.BtnSoumettre.IdleBorderRadius = 35;
            this.BtnSoumettre.IdleBorderThickness = 0;
            this.BtnSoumettre.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(126)))), ((int)(((byte)(208)))));
            this.BtnSoumettre.IdleIconLeftImage = null;
            this.BtnSoumettre.IdleIconRightImage = null;
            this.BtnSoumettre.Location = new System.Drawing.Point(120, 246);
            this.BtnSoumettre.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSoumettre.Name = "BtnSoumettre";
            stateProperties2.BorderColor = System.Drawing.Color.Black;
            stateProperties2.BorderRadius = 30;
            stateProperties2.BorderThickness = 2;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.BtnSoumettre.onHoverState = stateProperties2;
            this.BtnSoumettre.Size = new System.Drawing.Size(136, 32);
            this.BtnSoumettre.TabIndex = 23;
            this.BtnSoumettre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSoumettre.Click += new System.EventHandler(this.BtnSoumettre_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.bunifuImageButton1.Image = global::Facturation.Properties.Resources.invalidBlue;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(356, 8);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(33, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 26;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureVerificationEmail
            // 
            this.pictureVerificationEmail.Location = new System.Drawing.Point(104, 216);
            this.pictureVerificationEmail.Name = "pictureVerificationEmail";
            this.pictureVerificationEmail.Size = new System.Drawing.Size(33, 27);
            this.pictureVerificationEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureVerificationEmail.TabIndex = 27;
            this.pictureVerificationEmail.TabStop = false;
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsg.Location = new System.Drawing.Point(138, 223);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(0, 13);
            this.labelMsg.TabIndex = 28;
            // 
            // RecuperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 286);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.pictureVerificationEmail);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.BtnSoumettre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Email_Input);
            this.Controls.Add(this.labelExplication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecuperationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuperationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVerificationEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelExplication;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Email_Input;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnSoumettre;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.PictureBox pictureVerificationEmail;
    }
}