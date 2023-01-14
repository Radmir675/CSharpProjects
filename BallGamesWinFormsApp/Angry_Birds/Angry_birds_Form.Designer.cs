
namespace Angry_Birds
{
    partial class Angry_birds_Form
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
            this.StartGameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Scorelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(21, 12);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(176, 23);
            this.StartGameButton.TabIndex = 0;
            this.StartGameButton.Text = "Начать игру";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество очков";
            // 
            // Scorelabel
            // 
            this.Scorelabel.AutoSize = true;
            this.Scorelabel.Location = new System.Drawing.Point(332, 22);
            this.Scorelabel.Name = "Scorelabel";
            this.Scorelabel.Size = new System.Drawing.Size(13, 13);
            this.Scorelabel.TabIndex = 2;
            this.Scorelabel.Text = "0";
            // 
            // Angry_birds_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Scorelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartGameButton);
            this.Name = "Angry_birds_Form";
            this.Text = "Angry Birds";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Angry_birds_Form_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Scorelabel;
    }
}

