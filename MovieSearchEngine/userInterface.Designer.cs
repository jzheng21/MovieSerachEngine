namespace MovieSearchEngine
{
    partial class userInterface
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
            this.uxSearchBox = new System.Windows.Forms.TextBox();
            this.uxSearchButton = new System.Windows.Forms.Button();
            this.uxMovieNameCheck = new System.Windows.Forms.CheckBox();
            this.uxActorNameCheck = new System.Windows.Forms.CheckBox();
            this.uxDirectorNameCheck = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxSearchBox
            // 
            this.uxSearchBox.Location = new System.Drawing.Point(24, 23);
            this.uxSearchBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uxSearchBox.Name = "uxSearchBox";
            this.uxSearchBox.Size = new System.Drawing.Size(610, 38);
            this.uxSearchBox.TabIndex = 0;
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Location = new System.Drawing.Point(650, 23);
            this.uxSearchButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(316, 45);
            this.uxSearchButton.TabIndex = 1;
            this.uxSearchButton.Text = "Search";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            this.uxSearchButton.Click += new System.EventHandler(this.uxSearchButton_Click);
            // 
            // uxMovieNameCheck
            // 
            this.uxMovieNameCheck.AutoSize = true;
            this.uxMovieNameCheck.Location = new System.Drawing.Point(24, 78);
            this.uxMovieNameCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uxMovieNameCheck.Name = "uxMovieNameCheck";
            this.uxMovieNameCheck.Size = new System.Drawing.Size(187, 35);
            this.uxMovieNameCheck.TabIndex = 2;
            this.uxMovieNameCheck.Text = "Movie Name";
            this.uxMovieNameCheck.UseVisualStyleBackColor = true;
            // 
            // uxActorNameCheck
            // 
            this.uxActorNameCheck.AutoSize = true;
            this.uxActorNameCheck.Location = new System.Drawing.Point(252, 78);
            this.uxActorNameCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uxActorNameCheck.Name = "uxActorNameCheck";
            this.uxActorNameCheck.Size = new System.Drawing.Size(179, 35);
            this.uxActorNameCheck.TabIndex = 3;
            this.uxActorNameCheck.Text = "Actor Name";
            this.uxActorNameCheck.UseVisualStyleBackColor = true;
            // 
            // uxDirectorNameCheck
            // 
            this.uxDirectorNameCheck.AutoSize = true;
            this.uxDirectorNameCheck.Location = new System.Drawing.Point(472, 78);
            this.uxDirectorNameCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uxDirectorNameCheck.Name = "uxDirectorNameCheck";
            this.uxDirectorNameCheck.Size = new System.Drawing.Size(211, 35);
            this.uxDirectorNameCheck.TabIndex = 4;
            this.uxDirectorNameCheck.Text = "Director Name";
            this.uxDirectorNameCheck.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(24, 130);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(432, 562);
            this.listBox1.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(490, 130);
            this.listView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(780, 554);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Comedy"});
            this.comboBox1.Location = new System.Drawing.Point(802, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 39);
            this.comboBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Genere";
            // 
            // userInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 711);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.uxDirectorNameCheck);
            this.Controls.Add(this.uxActorNameCheck);
            this.Controls.Add(this.uxMovieNameCheck);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.uxSearchBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "userInterface";
            this.Text = "Movie Search Engine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxSearchBox;
        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.CheckBox uxMovieNameCheck;
        private System.Windows.Forms.CheckBox uxActorNameCheck;
        private System.Windows.Forms.CheckBox uxDirectorNameCheck;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

