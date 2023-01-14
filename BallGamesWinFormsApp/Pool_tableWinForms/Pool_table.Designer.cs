
namespace Pool_tableWinForms
{
    partial class Pool_table
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
            this.Toplabel = new System.Windows.Forms.Label();
            this.Downlabel = new System.Windows.Forms.Label();
            this.Rightlabel = new System.Windows.Forms.Label();
            this.Leftlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Toplabel
            // 
            this.Toplabel.AutoSize = true;
            this.Toplabel.Location = new System.Drawing.Point(323, 4);
            this.Toplabel.Name = "Toplabel";
            this.Toplabel.Size = new System.Drawing.Size(13, 13);
            this.Toplabel.TabIndex = 0;
            this.Toplabel.Text = "0";
            // 
            // Downlabel
            // 
            this.Downlabel.AutoSize = true;
            this.Downlabel.Location = new System.Drawing.Point(314, 428);
            this.Downlabel.Name = "Downlabel";
            this.Downlabel.Size = new System.Drawing.Size(13, 13);
            this.Downlabel.TabIndex = 0;
            this.Downlabel.Text = "0";
            // 
            // Rightlabel
            // 
            this.Rightlabel.AutoSize = true;
            this.Rightlabel.Location = new System.Drawing.Point(608, 178);
            this.Rightlabel.Name = "Rightlabel";
            this.Rightlabel.Size = new System.Drawing.Size(13, 13);
            this.Rightlabel.TabIndex = 0;
            this.Rightlabel.Text = "0";
            // 
            // Leftlabel
            // 
            this.Leftlabel.AutoSize = true;
            this.Leftlabel.Location = new System.Drawing.Point(12, 178);
            this.Leftlabel.Name = "Leftlabel";
            this.Leftlabel.Size = new System.Drawing.Size(13, 13);
            this.Leftlabel.TabIndex = 0;
            this.Leftlabel.Text = "0";
            // 
            // Pool_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.Leftlabel);
            this.Controls.Add(this.Rightlabel);
            this.Controls.Add(this.Downlabel);
            this.Controls.Add(this.Toplabel);
            this.Name = "Pool_table";
            this.Text = "Бильярд";
            this.Load += new System.EventHandler(this.Pool_table_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Toplabel;
        private System.Windows.Forms.Label Downlabel;
        private System.Windows.Forms.Label Rightlabel;
        private System.Windows.Forms.Label Leftlabel;
    }
}

