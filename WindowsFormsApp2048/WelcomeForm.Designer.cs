
namespace WindowsFormsApp2048
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.NameLabel = new System.Windows.Forms.Label();
            this.ОК_button = new System.Windows.Forms.Button();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameLabel.Font = new System.Drawing.Font("AcadEref", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(0, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(336, 112);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Здравсвуйте, введите ваше имя!";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ОК_button
            // 
            this.ОК_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ОК_button.Location = new System.Drawing.Point(121, 313);
            this.ОК_button.Name = "ОК_button";
            this.ОК_button.Size = new System.Drawing.Size(75, 23);
            this.ОК_button.TabIndex = 1;
            this.ОК_button.Text = "ОК";
            this.ОК_button.UseVisualStyleBackColor = true;
            this.ОК_button.Click += new System.EventHandler(this.ОК_button_Click);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.UserNameTextBox.Location = new System.Drawing.Point(40, 92);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(250, 26);
            this.UserNameTextBox.TabIndex = 2;
            this.UserNameTextBox.Text = "Ваше имя...";
            this.UserNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserNameTextBox_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(181, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Welcome
            // 
            this.AcceptButton = this.ОК_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 372);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.ОК_button);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button ОК_button;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}