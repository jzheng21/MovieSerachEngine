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
            this.uxSearchText = new System.Windows.Forms.TextBox();
            this.uxSearchButton = new System.Windows.Forms.Button();
            this.uxMovieNameCheckbox = new System.Windows.Forms.CheckBox();
            this.uxActorNameCheckbox = new System.Windows.Forms.CheckBox();
            this.uxDirectorNameCheckbox = new System.Windows.Forms.CheckBox();
            this.movieFoundListbox = new System.Windows.Forms.ListBox();
            this.uxMovieDetailsListview = new System.Windows.Forms.ListView();
            this.uxGenereDropDownList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxSearchText
            // 
            this.uxSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchText.Location = new System.Drawing.Point(18, 19);
            this.uxSearchText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxSearchText.MinimumSize = new System.Drawing.Size(0, 36);
            this.uxSearchText.Name = "uxSearchText";
            this.uxSearchText.Size = new System.Drawing.Size(466, 29);
            this.uxSearchText.TabIndex = 0;
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
            // uxMovieNameCheckbox
            // 
            this.uxMovieNameCheckbox.AutoSize = true;
            this.uxMovieNameCheckbox.Location = new System.Drawing.Point(18, 63);
            this.uxMovieNameCheckbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxMovieNameCheckbox.Name = "uxMovieNameCheckbox";
            this.uxMovieNameCheckbox.Size = new System.Drawing.Size(115, 24);
            this.uxMovieNameCheckbox.TabIndex = 2;
            this.uxMovieNameCheckbox.Text = "Movie Name";
            this.uxMovieNameCheckbox.UseVisualStyleBackColor = true;
            // 
            // uxActorNameCheckbox
            // 
            this.uxActorNameCheckbox.AutoSize = true;
            this.uxActorNameCheckbox.Location = new System.Drawing.Point(189, 63);
            this.uxActorNameCheckbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxActorNameCheckbox.Name = "uxActorNameCheckbox";
            this.uxActorNameCheckbox.Size = new System.Drawing.Size(112, 24);
            this.uxActorNameCheckbox.TabIndex = 3;
            this.uxActorNameCheckbox.Text = "Actor Name";
            this.uxActorNameCheckbox.UseVisualStyleBackColor = true;
            // 
            // uxDirectorNameCheckbox
            // 
            this.uxDirectorNameCheckbox.AutoSize = true;
            this.uxDirectorNameCheckbox.Location = new System.Drawing.Point(354, 63);
            this.uxDirectorNameCheckbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxDirectorNameCheckbox.Name = "uxDirectorNameCheckbox";
            this.uxDirectorNameCheckbox.Size = new System.Drawing.Size(130, 24);
            this.uxDirectorNameCheckbox.TabIndex = 4;
            this.uxDirectorNameCheckbox.Text = "Director Name";
            this.uxDirectorNameCheckbox.UseVisualStyleBackColor = true;
            // 
            // movieFoundListbox
            // 
            this.movieFoundListbox.FormattingEnabled = true;
            this.movieFoundListbox.ItemHeight = 20;
            this.movieFoundListbox.Location = new System.Drawing.Point(18, 105);
            this.movieFoundListbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.movieFoundListbox.Name = "movieFoundListbox";
            this.movieFoundListbox.Size = new System.Drawing.Size(248, 444);
            this.movieFoundListbox.TabIndex = 6;
            // 
            // uxMovieDetailsListview
            // 
            this.uxMovieDetailsListview.Location = new System.Drawing.Point(274, 105);
            this.uxMovieDetailsListview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxMovieDetailsListview.Name = "uxMovieDetailsListview";
            this.uxMovieDetailsListview.Size = new System.Drawing.Size(451, 444);
            this.uxMovieDetailsListview.TabIndex = 8;
            this.uxMovieDetailsListview.UseCompatibleStateImageBehavior = false;
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
            this.uxGenereDropDownList.Location = new System.Drawing.Point(557, 63);
            this.uxGenereDropDownList.Margin = new System.Windows.Forms.Padding(2);
            this.uxGenereDropDownList.Name = "uxGenereDropDownList";
            this.uxGenereDropDownList.Size = new System.Drawing.Size(168, 28);
            this.uxGenereDropDownList.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 64);
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
            this.ClientSize = new System.Drawing.Size(740, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxGenereDropDownList);
            this.Controls.Add(this.uxMovieDetailsListview);
            this.Controls.Add(this.movieFoundListbox);
            this.Controls.Add(this.uxDirectorNameCheckbox);
            this.Controls.Add(this.uxActorNameCheckbox);
            this.Controls.Add(this.uxMovieNameCheckbox);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.uxSearchText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "userInterface";
            this.Text = "Movie Search Engine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxSearchText;
        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.CheckBox uxMovieNameCheckbox;
        private System.Windows.Forms.CheckBox uxActorNameCheckbox;
        private System.Windows.Forms.CheckBox uxDirectorNameCheckbox;
        private System.Windows.Forms.ListBox movieFoundListbox;
        private System.Windows.Forms.ListView uxMovieDetailsListview;
        private System.Windows.Forms.ComboBox uxGenereDropDownList;
        private System.Windows.Forms.Label label1;
    }
}

