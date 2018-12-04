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
            this.uxMovieNameTextbox = new System.Windows.Forms.TextBox();
            this.uxMovieFoundListbox = new System.Windows.Forms.ListBox();
            this.uxReviewList = new System.Windows.Forms.ListView();
            this.uxSearchButton = new System.Windows.Forms.Button();
            this.uxMovieNameLabel = new System.Windows.Forms.Label();
            this.uxActorNameLabel = new System.Windows.Forms.Label();
            this.uxDirectorNameLabel = new System.Windows.Forms.Label();
            this.uxReleaseYearLabel = new System.Windows.Forms.Label();
            this.uxActorNameTextbox = new System.Windows.Forms.TextBox();
            this.uxDirectorNameTextbox = new System.Windows.Forms.TextBox();
            this.uxGenreLabel = new System.Windows.Forms.Label();
            this.uxYearTextbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uxGenreComboBox = new System.Windows.Forms.ComboBox();
            this.uxMovieDetailListbox = new System.Windows.Forms.ListView();
            this.uxNewReviewTextbox = new System.Windows.Forms.TextBox();
            this.uxPushRevButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMovieNameTextbox
            // 
            this.uxMovieNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMovieNameTextbox.Location = new System.Drawing.Point(128, 5);
            this.uxMovieNameTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxMovieNameTextbox.Name = "uxMovieNameTextbox";
            this.uxMovieNameTextbox.Size = new System.Drawing.Size(201, 29);
            this.uxMovieNameTextbox.TabIndex = 0;
            // 
            // uxMovieFoundListbox
            // 
            this.uxMovieFoundListbox.FormattingEnabled = true;
            this.uxMovieFoundListbox.ItemHeight = 20;
            this.uxMovieFoundListbox.Location = new System.Drawing.Point(13, 288);
            this.uxMovieFoundListbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxMovieFoundListbox.Name = "uxMovieFoundListbox";
            this.uxMovieFoundListbox.Size = new System.Drawing.Size(367, 464);
            this.uxMovieFoundListbox.TabIndex = 6;
            this.uxMovieFoundListbox.SelectedIndexChanged += new System.EventHandler(this.uxMovieFoundListbox_SelectedIndexChanged);
            // 
            // uxReviewList
            // 
            this.uxReviewList.Location = new System.Drawing.Point(388, 288);
            this.uxReviewList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxReviewList.Name = "uxReviewList";
            this.uxReviewList.Size = new System.Drawing.Size(492, 316);
            this.uxReviewList.TabIndex = 8;
            this.uxReviewList.UseCompatibleStateImageBehavior = false;
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Location = new System.Drawing.Point(13, 242);
            this.uxSearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(367, 36);
            this.uxSearchButton.TabIndex = 1;
            this.uxSearchButton.Text = "Search";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            this.uxSearchButton.Click += new System.EventHandler(this.uxSearchButton_Click);
            // 
            // uxMovieNameLabel
            // 
            this.uxMovieNameLabel.AutoSize = true;
            this.uxMovieNameLabel.Location = new System.Drawing.Point(3, 0);
            this.uxMovieNameLabel.Name = "uxMovieNameLabel";
            this.uxMovieNameLabel.Size = new System.Drawing.Size(96, 20);
            this.uxMovieNameLabel.TabIndex = 9;
            this.uxMovieNameLabel.Text = "Movie Name";
            // 
            // uxActorNameLabel
            // 
            this.uxActorNameLabel.AutoSize = true;
            this.uxActorNameLabel.Location = new System.Drawing.Point(3, 43);
            this.uxActorNameLabel.Name = "uxActorNameLabel";
            this.uxActorNameLabel.Size = new System.Drawing.Size(93, 20);
            this.uxActorNameLabel.TabIndex = 10;
            this.uxActorNameLabel.Text = "Actor Name";
            // 
            // uxDirectorNameLabel
            // 
            this.uxDirectorNameLabel.AutoSize = true;
            this.uxDirectorNameLabel.Location = new System.Drawing.Point(3, 86);
            this.uxDirectorNameLabel.Name = "uxDirectorNameLabel";
            this.uxDirectorNameLabel.Size = new System.Drawing.Size(111, 20);
            this.uxDirectorNameLabel.TabIndex = 11;
            this.uxDirectorNameLabel.Text = "Director Name";
            // 
            // uxReleaseYearLabel
            // 
            this.uxReleaseYearLabel.AutoSize = true;
            this.uxReleaseYearLabel.Location = new System.Drawing.Point(3, 129);
            this.uxReleaseYearLabel.Name = "uxReleaseYearLabel";
            this.uxReleaseYearLabel.Size = new System.Drawing.Size(43, 20);
            this.uxReleaseYearLabel.TabIndex = 12;
            this.uxReleaseYearLabel.Text = "Year";
            // 
            // uxActorNameTextbox
            // 
            this.uxActorNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxActorNameTextbox.Location = new System.Drawing.Point(128, 48);
            this.uxActorNameTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxActorNameTextbox.Name = "uxActorNameTextbox";
            this.uxActorNameTextbox.Size = new System.Drawing.Size(201, 29);
            this.uxActorNameTextbox.TabIndex = 13;
            // 
            // uxDirectorNameTextbox
            // 
            this.uxDirectorNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDirectorNameTextbox.Location = new System.Drawing.Point(128, 91);
            this.uxDirectorNameTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxDirectorNameTextbox.Name = "uxDirectorNameTextbox";
            this.uxDirectorNameTextbox.Size = new System.Drawing.Size(201, 29);
            this.uxDirectorNameTextbox.TabIndex = 15;
            // 
            // uxGenreLabel
            // 
            this.uxGenreLabel.AutoSize = true;
            this.uxGenreLabel.Location = new System.Drawing.Point(3, 172);
            this.uxGenreLabel.Name = "uxGenreLabel";
            this.uxGenreLabel.Size = new System.Drawing.Size(54, 20);
            this.uxGenreLabel.TabIndex = 16;
            this.uxGenreLabel.Text = "Genre";
            // 
            // uxYearTextbox
            // 
            this.uxYearTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxYearTextbox.Location = new System.Drawing.Point(128, 134);
            this.uxYearTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxYearTextbox.Name = "uxYearTextbox";
            this.uxYearTextbox.Size = new System.Drawing.Size(201, 29);
            this.uxYearTextbox.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.85417F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.14584F));
            this.tableLayoutPanel1.Controls.Add(this.uxMovieNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uxYearTextbox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.uxActorNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.uxDirectorNameTextbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.uxGenreLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.uxActorNameTextbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.uxReleaseYearLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.uxMovieNameTextbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.uxGenreComboBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.uxDirectorNameLabel, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(367, 215);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // uxGenreComboBox
            // 
            this.uxGenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxGenreComboBox.FormattingEnabled = true;
            this.uxGenreComboBox.Items.AddRange(new object[] {
            "All",
            "Action",
            "Advanture",
            "Business",
            "Comedy",
            "Fantasy",
            "Romance",
            "Science Fiction",
            "Thriller"});
            this.uxGenreComboBox.Location = new System.Drawing.Point(127, 175);
            this.uxGenreComboBox.Name = "uxGenreComboBox";
            this.uxGenreComboBox.Size = new System.Drawing.Size(202, 28);
            this.uxGenreComboBox.TabIndex = 19;
            // 
            // uxMovieDetailListbox
            // 
            this.uxMovieDetailListbox.Location = new System.Drawing.Point(388, 19);
            this.uxMovieDetailListbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxMovieDetailListbox.Name = "uxMovieDetailListbox";
            this.uxMovieDetailListbox.Size = new System.Drawing.Size(492, 259);
            this.uxMovieDetailListbox.TabIndex = 20;
            this.uxMovieDetailListbox.UseCompatibleStateImageBehavior = false;
            // 
            // uxNewReviewTextbox
            // 
            this.uxNewReviewTextbox.Location = new System.Drawing.Point(387, 612);
            this.uxNewReviewTextbox.Multiline = true;
            this.uxNewReviewTextbox.Name = "uxNewReviewTextbox";
            this.uxNewReviewTextbox.Size = new System.Drawing.Size(493, 100);
            this.uxNewReviewTextbox.TabIndex = 21;
            // 
            // uxPushRevButton
            // 
            this.uxPushRevButton.Location = new System.Drawing.Point(782, 718);
            this.uxPushRevButton.Name = "uxPushRevButton";
            this.uxPushRevButton.Size = new System.Drawing.Size(98, 34);
            this.uxPushRevButton.TabIndex = 22;
            this.uxPushRevButton.Text = "Submit";
            this.uxPushRevButton.UseVisualStyleBackColor = true;
            this.uxPushRevButton.Click += new System.EventHandler(this.uxPushRevButton_Click);
            // 
            // userInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 774);
            this.Controls.Add(this.uxPushRevButton);
            this.Controls.Add(this.uxNewReviewTextbox);
            this.Controls.Add(this.uxMovieDetailListbox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.uxReviewList);
            this.Controls.Add(this.uxMovieFoundListbox);
            this.Controls.Add(this.uxSearchButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "userInterface";
            this.Text = "Movie Search Engine";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxMovieNameTextbox;
        private System.Windows.Forms.ListBox uxMovieFoundListbox;
        private System.Windows.Forms.ListView uxReviewList;
        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.Label uxMovieNameLabel;
        private System.Windows.Forms.Label uxActorNameLabel;
        private System.Windows.Forms.Label uxDirectorNameLabel;
        private System.Windows.Forms.Label uxReleaseYearLabel;
        private System.Windows.Forms.TextBox uxActorNameTextbox;
        private System.Windows.Forms.TextBox uxDirectorNameTextbox;
        private System.Windows.Forms.Label uxGenreLabel;
        private System.Windows.Forms.TextBox uxYearTextbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView uxMovieDetailListbox;
        private System.Windows.Forms.TextBox uxNewReviewTextbox;
        private System.Windows.Forms.Button uxPushRevButton;
        private System.Windows.Forms.ComboBox uxGenreComboBox;
    }
}

