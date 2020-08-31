namespace PropertyFolio
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Title = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.UsernameAstrick = new System.Windows.Forms.Label();
            this.PasswordAstrick = new System.Windows.Forms.Label();
            this.LoginFailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Title.Location = new System.Drawing.Point(324, 76);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(172, 45);
            this.Title.TabIndex = 0;
            this.Title.Text = "User Login";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.White;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LoginBtn.Location = new System.Drawing.Point(324, 252);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(172, 33);
            this.LoginBtn.TabIndex = 1;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 285);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UsernameLabel.Location = new System.Drawing.Point(185, 149);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(81, 21);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PasswordLabel.Location = new System.Drawing.Point(185, 186);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(76, 21);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // PasswordInput
            // 
            this.PasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordInput.Location = new System.Drawing.Point(277, 186);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(269, 22);
            this.PasswordInput.TabIndex = 4;
            this.PasswordInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UsernameInput
            // 
            this.UsernameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameInput.Location = new System.Drawing.Point(277, 146);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(269, 22);
            this.UsernameInput.TabIndex = 4;
            this.UsernameInput.TextChanged += new System.EventHandler(this.UsernameInput_TextChanged);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CloseBtn.Location = new System.Drawing.Point(745, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(43, 41);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // UsernameAstrick
            // 
            this.UsernameAstrick.AutoSize = true;
            this.UsernameAstrick.BackColor = System.Drawing.Color.Transparent;
            this.UsernameAstrick.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameAstrick.ForeColor = System.Drawing.Color.Red;
            this.UsernameAstrick.Location = new System.Drawing.Point(552, 138);
            this.UsernameAstrick.Name = "UsernameAstrick";
            this.UsernameAstrick.Size = new System.Drawing.Size(22, 30);
            this.UsernameAstrick.TabIndex = 6;
            this.UsernameAstrick.Text = "*";
            this.UsernameAstrick.Visible = false;
            // 
            // PasswordAstrick
            // 
            this.PasswordAstrick.AutoSize = true;
            this.PasswordAstrick.BackColor = System.Drawing.Color.Transparent;
            this.PasswordAstrick.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordAstrick.ForeColor = System.Drawing.Color.Red;
            this.PasswordAstrick.Location = new System.Drawing.Point(552, 178);
            this.PasswordAstrick.Name = "PasswordAstrick";
            this.PasswordAstrick.Size = new System.Drawing.Size(22, 30);
            this.PasswordAstrick.TabIndex = 6;
            this.PasswordAstrick.Text = "*";
            this.PasswordAstrick.Visible = false;
            // 
            // LoginFailLabel
            // 
            this.LoginFailLabel.AutoSize = true;
            this.LoginFailLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginFailLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginFailLabel.ForeColor = System.Drawing.Color.Red;
            this.LoginFailLabel.Location = new System.Drawing.Point(277, 211);
            this.LoginFailLabel.Name = "LoginFailLabel";
            this.LoginFailLabel.Size = new System.Drawing.Size(226, 20);
            this.LoginFailLabel.TabIndex = 6;
            this.LoginFailLabel.Text = "*Username or Password Incorrect";
            this.LoginFailLabel.Visible = false;
            this.LoginFailLabel.Click += new System.EventHandler(this.LoginFailLabel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.LoginFailLabel);
            this.Controls.Add(this.PasswordAstrick);
            this.Controls.Add(this.UsernameAstrick);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "LoginForm";
            this.Text = "Password";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label UsernameAstrick;
        private System.Windows.Forms.Label PasswordAstrick;
        private System.Windows.Forms.Label LoginFailLabel;
    }
}

