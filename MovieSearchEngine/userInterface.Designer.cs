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
            this.uxGenereList = new System.Windows.Forms.DomainUpDown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // uxSearchBox
            // 
            this.uxSearchBox.Location = new System.Drawing.Point(12, 12);
            this.uxSearchBox.Name = "uxSearchBox";
            this.uxSearchBox.Size = new System.Drawing.Size(307, 22);
            this.uxSearchBox.TabIndex = 0;
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Location = new System.Drawing.Point(325, 12);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(158, 23);
            this.uxSearchButton.TabIndex = 1;
            this.uxSearchButton.Text = "Search";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            this.uxSearchButton.Click += new System.EventHandler(this.uxSearchButton_Click);
            // 
            // uxMovieNameCheck
            // 
            this.uxMovieNameCheck.AutoSize = true;
            this.uxMovieNameCheck.Location = new System.Drawing.Point(12, 40);
            this.uxMovieNameCheck.Name = "uxMovieNameCheck";
            this.uxMovieNameCheck.Size = new System.Drawing.Size(108, 21);
            this.uxMovieNameCheck.TabIndex = 2;
            this.uxMovieNameCheck.Text = "Movie Name";
            this.uxMovieNameCheck.UseVisualStyleBackColor = true;
            // 
            // uxActorNameCheck
            // 
            this.uxActorNameCheck.AutoSize = true;
            this.uxActorNameCheck.Location = new System.Drawing.Point(126, 40);
            this.uxActorNameCheck.Name = "uxActorNameCheck";
            this.uxActorNameCheck.Size = new System.Drawing.Size(104, 21);
            this.uxActorNameCheck.TabIndex = 3;
            this.uxActorNameCheck.Text = "Actor Name";
            this.uxActorNameCheck.UseVisualStyleBackColor = true;
            // 
            // uxDirectorNameCheck
            // 
            this.uxDirectorNameCheck.AutoSize = true;
            this.uxDirectorNameCheck.Location = new System.Drawing.Point(236, 40);
            this.uxDirectorNameCheck.Name = "uxDirectorNameCheck";
            this.uxDirectorNameCheck.Size = new System.Drawing.Size(121, 21);
            this.uxDirectorNameCheck.TabIndex = 4;
            this.uxDirectorNameCheck.Text = "Director Name";
            this.uxDirectorNameCheck.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(218, 292);
            this.listBox1.TabIndex = 6;
            // 
            // uxGenereList
            // 
            this.uxGenereList.Location = new System.Drawing.Point(363, 41);
            this.uxGenereList.Name = "uxGenereList";
            this.uxGenereList.Size = new System.Drawing.Size(120, 22);
            this.uxGenereList.TabIndex = 7;
            this.uxGenereList.Text = "Genere";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(245, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(392, 288);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // userInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 367);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.uxGenereList);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.uxDirectorNameCheck);
            this.Controls.Add(this.uxActorNameCheck);
            this.Controls.Add(this.uxMovieNameCheck);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.uxSearchBox);
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
        private System.Windows.Forms.DomainUpDown uxGenereList;
        private System.Windows.Forms.ListView listView1;
    }
}

