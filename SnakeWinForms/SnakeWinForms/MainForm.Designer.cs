
namespace SnakeWinForms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.currentScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moveTimer
            // 
            this.moveTimer.Tick += new System.EventHandler(this.moveTimer_Tick);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(593, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 45);
            this.label11.TabIndex = 1;
            this.label11.Text = "Очков:\r\n";
            // 
            // currentScoreLabel
            // 
            this.currentScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentScoreLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentScoreLabel.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.currentScoreLabel.Location = new System.Drawing.Point(676, 9);
            this.currentScoreLabel.Name = "currentScoreLabel";
            this.currentScoreLabel.Size = new System.Drawing.Size(92, 45);
            this.currentScoreLabel.TabIndex = 1;
            this.currentScoreLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::SnakeWinForms.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 482);
            this.Controls.Add(this.currentScoreLabel);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label currentScoreLabel;
    }
}

