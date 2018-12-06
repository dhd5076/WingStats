namespace WingStats
{
    partial class WingStatsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WingStatsForm));
            this.fileButton = new System.Windows.Forms.Button();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.fileLabel = new System.Windows.Forms.Label();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.parseButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.totalMessageLabel = new System.Windows.Forms.Label();
            this.wingMessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileButton
            // 
            this.fileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileButton.Location = new System.Drawing.Point(305, 174);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(75, 23);
            this.fileButton.TabIndex = 0;
            this.fileButton.Text = "Select File";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += this.OpenFileClicked;
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(119, 176);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(177, 20);
            this.fileTextBox.TabIndex = 2;
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLabel.Location = new System.Drawing.Point(12, 177);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(104, 15);
            this.fileLabel.TabIndex = 3;
            this.fileLabel.Text = "Conversation File:";
            // 
            // logoPicture
            // 
            this.logoPicture.Image = ((System.Drawing.Image)(resources.GetObject("logoPicture.Image")));
            this.logoPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoPicture.InitialImage")));
            this.logoPicture.Location = new System.Drawing.Point(13, 9);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(367, 71);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicture.TabIndex = 4;
            this.logoPicture.TabStop = false;
            // 
            // parseButton
            // 
            this.parseButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.parseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parseButton.Location = new System.Drawing.Point(203, 231);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(177, 56);
            this.parseButton.TabIndex = 5;
            this.parseButton.Text = "Parse";
            this.parseButton.UseVisualStyleBackColor = false;
            this.parseButton.Click += ParseFileClicked;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 202);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(368, 23);
            this.progressBar.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.userListBox);
            this.panel1.Location = new System.Drawing.Point(387, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 212);
            this.panel1.TabIndex = 7;
            // 
            // userListBox
            // 
            this.userListBox.BackColor = System.Drawing.SystemColors.Menu;
            this.userListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userListBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 16;
            this.userListBox.Location = new System.Drawing.Point(4, 4);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(394, 196);
            this.userListBox.TabIndex = 0;
            // 
            // totalMessageLabel
            // 
            this.totalMessageLabel.AutoSize = true;
            this.totalMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMessageLabel.Location = new System.Drawing.Point(384, 231);
            this.totalMessageLabel.Name = "totalMessageLabel";
            this.totalMessageLabel.Size = new System.Drawing.Size(116, 17);
            this.totalMessageLabel.TabIndex = 8;
            this.totalMessageLabel.Text = "Total Messages: ";
            // 
            // wingMessageLabel
            // 
            this.wingMessageLabel.AutoSize = true;
            this.wingMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wingMessageLabel.Location = new System.Drawing.Point(384, 257);
            this.wingMessageLabel.Name = "wingMessageLabel";
            this.wingMessageLabel.Size = new System.Drawing.Size(116, 17);
            this.wingMessageLabel.TabIndex = 9;
            this.wingMessageLabel.Text = "Wing Messages: ";
            // 
            // WingStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 299);
            this.Controls.Add(this.wingMessageLabel);
            this.Controls.Add(this.totalMessageLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.parseButton);
            this.Controls.Add(this.logoPicture);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.fileButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WingStatsForm";
            this.Text = "WingStats";
            this.Load += new System.EventHandler(this.WingStatsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Label totalMessageLabel;
        private System.Windows.Forms.Label wingMessageLabel;
    }
}