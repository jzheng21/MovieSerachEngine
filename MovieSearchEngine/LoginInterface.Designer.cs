namespace MovieSearchEngine
{
    partial class LoginInterface
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
            this.uxUsernameTextBox = new System.Windows.Forms.TextBox();
            this.uxPassWordTextbox = new System.Windows.Forms.TextBox();
            this.uxLoginLabel = new System.Windows.Forms.Label();
            this.LoginInButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.uxUserLabel = new System.Windows.Forms.Label();
            this.uxPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxUsernameTextBox
            // 
            this.uxUsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUsernameTextBox.Location = new System.Drawing.Point(12, 77);
            this.uxUsernameTextBox.Name = "uxUsernameTextBox";
            this.uxUsernameTextBox.Size = new System.Drawing.Size(365, 26);
            this.uxUsernameTextBox.TabIndex = 0;
            // 
            // uxPassWordTextbox
            // 
            this.uxPassWordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPassWordTextbox.Location = new System.Drawing.Point(16, 129);
            this.uxPassWordTextbox.Name = "uxPassWordTextbox";
            this.uxPassWordTextbox.PasswordChar = '*';
            this.uxPassWordTextbox.Size = new System.Drawing.Size(365, 26);
            this.uxPassWordTextbox.TabIndex = 1;
            // 
            // uxLoginLabel
            // 
            this.uxLoginLabel.AutoSize = true;
            this.uxLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLoginLabel.Location = new System.Drawing.Point(109, 9);
            this.uxLoginLabel.Name = "uxLoginLabel";
            this.uxLoginLabel.Size = new System.Drawing.Size(175, 24);
            this.uxLoginLabel.TabIndex = 2;
            this.uxLoginLabel.Text = "Login in Or Sign Up";
            // 
            // LoginInButton
            // 
            this.LoginInButton.Location = new System.Drawing.Point(63, 177);
            this.LoginInButton.Name = "LoginInButton";
            this.LoginInButton.Size = new System.Drawing.Size(75, 23);
            this.LoginInButton.TabIndex = 3;
            this.LoginInButton.Text = "login in";
            this.LoginInButton.UseVisualStyleBackColor = true;
            this.LoginInButton.Click += new System.EventHandler(this.LoginInButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(234, 177);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(75, 23);
            this.SignUpButton.TabIndex = 4;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // uxUserLabel
            // 
            this.uxUserLabel.AutoSize = true;
            this.uxUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUserLabel.Location = new System.Drawing.Point(12, 54);
            this.uxUserLabel.Name = "uxUserLabel";
            this.uxUserLabel.Size = new System.Drawing.Size(83, 20);
            this.uxUserLabel.TabIndex = 5;
            this.uxUserLabel.Text = "Username";
            // 
            // uxPasswordLabel
            // 
            this.uxPasswordLabel.AutoSize = true;
            this.uxPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPasswordLabel.Location = new System.Drawing.Point(12, 106);
            this.uxPasswordLabel.Name = "uxPasswordLabel";
            this.uxPasswordLabel.Size = new System.Drawing.Size(82, 20);
            this.uxPasswordLabel.TabIndex = 6;
            this.uxPasswordLabel.Text = "PassWord";
            // 
            // LoginInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 234);
            this.Controls.Add(this.uxPasswordLabel);
            this.Controls.Add(this.uxUserLabel);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.LoginInButton);
            this.Controls.Add(this.uxLoginLabel);
            this.Controls.Add(this.uxPassWordTextbox);
            this.Controls.Add(this.uxUsernameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LoginInterface";
            this.Text = "LoginInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox uxUsernameTextBox;
        public System.Windows.Forms.TextBox uxPassWordTextbox;
        private System.Windows.Forms.Label uxLoginLabel;
        private System.Windows.Forms.Button LoginInButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label uxUserLabel;
        private System.Windows.Forms.Label uxPasswordLabel;
    }
}