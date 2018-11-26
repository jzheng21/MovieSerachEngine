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
            this.movieFoundListbox = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.uxGenereDropDownList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxSearchBox
            // 
            this.uxSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchBox.Location = new System.Drawing.Point(18, 19);
            this.uxSearchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxSearchBox.Name = "uxSearchBox";
            this.uxSearchBox.Size = new System.Drawing.Size(458, 29);
            this.uxSearchBox.TabIndex = 0;
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Location = new System.Drawing.Point(488, 19);
            this.uxSearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(237, 36);
            this.uxSearchButton.TabIndex = 1;
            this.uxSearchButton.Text = "Search";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            this.uxSearchButton.Click += new System.EventHandler(this.uxSearchButton_Click);
            // 
            // uxMovieNameCheck
            // 
            this.uxMovieNameCheck.AutoSize = true;
            this.uxMovieNameCheck.Location = new System.Drawing.Point(18, 63);
            this.uxMovieNameCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxMovieNameCheck.Name = "uxMovieNameCheck";
            this.uxMovieNameCheck.Size = new System.Drawing.Size(115, 24);
            this.uxMovieNameCheck.TabIndex = 2;
            this.uxMovieNameCheck.Text = "Movie Name";
            this.uxMovieNameCheck.UseVisualStyleBackColor = true;
            // 
            // uxActorNameCheck
            // 
            this.uxActorNameCheck.AutoSize = true;
            this.uxActorNameCheck.Location = new System.Drawing.Point(189, 63);
            this.uxActorNameCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxActorNameCheck.Name = "uxActorNameCheck";
            this.uxActorNameCheck.Size = new System.Drawing.Size(112, 24);
            this.uxActorNameCheck.TabIndex = 3;
            this.uxActorNameCheck.Text = "Actor Name";
            this.uxActorNameCheck.UseVisualStyleBackColor = true;
            // 
            // uxDirectorNameCheck
            // 
            this.uxDirectorNameCheck.AutoSize = true;
            this.uxDirectorNameCheck.Location = new System.Drawing.Point(354, 63);
            this.uxDirectorNameCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxDirectorNameCheck.Name = "uxDirectorNameCheck";
            this.uxDirectorNameCheck.Size = new System.Drawing.Size(130, 24);
            this.uxDirectorNameCheck.TabIndex = 4;
            this.uxDirectorNameCheck.Text = "Director Name";
            this.uxDirectorNameCheck.UseVisualStyleBackColor = true;
            // 
            // movieFoundListbox
            // 
            this.movieFoundListbox.FormattingEnabled = true;
            this.movieFoundListbox.ItemHeight = 20;
            this.movieFoundListbox.Location = new System.Drawing.Point(18, 105);
            this.movieFoundListbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.movieFoundListbox.Name = "movieFoundListbox";
            this.movieFoundListbox.Size = new System.Drawing.Size(325, 444);
            this.movieFoundListbox.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(368, 105);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(586, 448);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // uxGenereDropDownList
            // 
            this.uxGenereDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxGenereDropDownList.FormattingEnabled = true;
            this.uxGenereDropDownList.Items.AddRange(new object[] {
            "Select Genere",
            "Comedy",
            "Horror",
            "Scientific"});
            this.uxGenereDropDownList.Location = new System.Drawing.Point(586, 63);
            this.uxGenereDropDownList.Margin = new System.Windows.Forms.Padding(2);
            this.uxGenereDropDownList.Name = "uxGenereDropDownList";
            this.uxGenereDropDownList.Size = new System.Drawing.Size(139, 28);
            this.uxGenereDropDownList.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Genere";
            // 
            // userInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxGenereDropDownList);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.movieFoundListbox);
            this.Controls.Add(this.uxDirectorNameCheck);
            this.Controls.Add(this.uxActorNameCheck);
            this.Controls.Add(this.uxMovieNameCheck);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.uxSearchBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.ListBox movieFoundListbox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox uxGenereDropDownList;
        private System.Windows.Forms.Label label1;
    }
}

