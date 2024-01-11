
namespace latihanCRUD1
{
    partial class LoginPage
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
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.username_field = new System.Windows.Forms.TextBox();
            this.password_field = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.version_label = new System.Windows.Forms.Label();
            this.canvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(78, 79);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(85, 17);
            this.username.TabIndex = 1;
            this.username.Text = "Username : ";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(78, 114);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(81, 17);
            this.password.TabIndex = 2;
            this.password.Text = "Password : ";
            // 
            // username_field
            // 
            this.username_field.BackColor = System.Drawing.Color.White;
            this.username_field.Location = new System.Drawing.Point(169, 79);
            this.username_field.Name = "username_field";
            this.username_field.Size = new System.Drawing.Size(171, 22);
            this.username_field.TabIndex = 3;
            // 
            // password_field
            // 
            this.password_field.Location = new System.Drawing.Point(169, 114);
            this.password_field.Name = "password_field";
            this.password_field.Size = new System.Drawing.Size(171, 22);
            this.password_field.TabIndex = 4;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.login_btn.Location = new System.Drawing.Point(214, 162);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(81, 29);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.Silver;
            this.canvas.Controls.Add(this.Title);
            this.canvas.Controls.Add(this.password_field);
            this.canvas.Controls.Add(this.login_btn);
            this.canvas.Controls.Add(this.username);
            this.canvas.Controls.Add(this.password);
            this.canvas.Controls.Add(this.username_field);
            this.canvas.Location = new System.Drawing.Point(148, 105);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(471, 222);
            this.canvas.TabIndex = 6;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.DarkGreen;
            this.Title.Location = new System.Drawing.Point(87, 10);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(333, 29);
            this.Title.TabIndex = 6;
            this.Title.Text = "WELCOME TO STEREOFY";
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.Location = new System.Drawing.Point(697, 26);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(78, 17);
            this.version_label.TabIndex = 7;
            this.version_label.Text = "version 0.1";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.canvas);
            this.Name = "LoginPage";
            this.Text = "Login";
            this.canvas.ResumeLayout(false);
            this.canvas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox username_field;
        private System.Windows.Forms.TextBox password_field;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.Timer loading;
    }
}

