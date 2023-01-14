
namespace DiffusionWindowsFormsApp
{
    partial class DiffusionForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RedScoreLabelLeft = new System.Windows.Forms.Label();
            this.BlackScoreLabelLeft = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RedScoreLabelRight = new System.Windows.Forms.Label();
            this.BlackScoreLabelRight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Начать игру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Красных :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Черных :";
            // 
            // RedScoreLabelLeft
            // 
            this.RedScoreLabelLeft.AutoSize = true;
            this.RedScoreLabelLeft.Location = new System.Drawing.Point(83, 194);
            this.RedScoreLabelLeft.Name = "RedScoreLabelLeft";
            this.RedScoreLabelLeft.Size = new System.Drawing.Size(13, 13);
            this.RedScoreLabelLeft.TabIndex = 2;
            this.RedScoreLabelLeft.Text = "0";
            // 
            // BlackScoreLabelLeft
            // 
            this.BlackScoreLabelLeft.AutoSize = true;
            this.BlackScoreLabelLeft.Location = new System.Drawing.Point(83, 221);
            this.BlackScoreLabelLeft.Name = "BlackScoreLabelLeft";
            this.BlackScoreLabelLeft.Size = new System.Drawing.Size(13, 13);
            this.BlackScoreLabelLeft.TabIndex = 2;
            this.BlackScoreLabelLeft.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Красных :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Черных :";
            // 
            // RedScoreLabelRight
            // 
            this.RedScoreLabelRight.AutoSize = true;
            this.RedScoreLabelRight.Location = new System.Drawing.Point(527, 194);
            this.RedScoreLabelRight.Name = "RedScoreLabelRight";
            this.RedScoreLabelRight.Size = new System.Drawing.Size(13, 13);
            this.RedScoreLabelRight.TabIndex = 2;
            this.RedScoreLabelRight.Text = "0";
            // 
            // BlackScoreLabelRight
            // 
            this.BlackScoreLabelRight.AutoSize = true;
            this.BlackScoreLabelRight.Location = new System.Drawing.Point(527, 221);
            this.BlackScoreLabelRight.Name = "BlackScoreLabelRight";
            this.BlackScoreLabelRight.Size = new System.Drawing.Size(13, 13);
            this.BlackScoreLabelRight.TabIndex = 2;
            this.BlackScoreLabelRight.Text = "0";
            // 
            // DiffusionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.BlackScoreLabelRight);
            this.Controls.Add(this.BlackScoreLabelLeft);
            this.Controls.Add(this.RedScoreLabelRight);
            this.Controls.Add(this.RedScoreLabelLeft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "DiffusionForm";
            this.Text = "Diffusion";
            this.Click += new System.EventHandler(this.DiffusionForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RedScoreLabelLeft;
        private System.Windows.Forms.Label BlackScoreLabelLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RedScoreLabelRight;
        private System.Windows.Forms.Label BlackScoreLabelRight;
    }
}

