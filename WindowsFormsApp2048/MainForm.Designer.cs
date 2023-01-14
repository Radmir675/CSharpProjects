
namespace WindowsFormsApp2048
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
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bestScore = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.RestartButton = new System.Windows.Forms.ToolStripMenuItem();
            this.GameRules = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Счет:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(201, 12);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(13, 13);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(162, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Лучший результат";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bestScore
            // 
            this.bestScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bestScore.AutoSize = true;
            this.bestScore.Location = new System.Drawing.Point(267, 34);
            this.bestScore.Name = "bestScore";
            this.bestScore.Size = new System.Drawing.Size(13, 13);
            this.bestScore.TabIndex = 3;
            this.bestScore.Text = "0";
            this.bestScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitButton.Location = new System.Drawing.Point(0, 427);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(306, 23);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Visible = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(306, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainStrip
            // 
            this.MainStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestartButton,
            this.GameRules});
            this.MainStrip.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.MainStrip.Name = "MainStrip";
            this.MainStrip.Padding = new System.Windows.Forms.Padding(5, 0, 4, 0);
            this.MainStrip.Size = new System.Drawing.Size(54, 20);
            this.MainStrip.Text = "Меню";
            // 
            // RestartButton
            // 
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(153, 22);
            this.RestartButton.Text = "Перезапуск";
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // GameRules
            // 
            this.GameRules.Name = "GameRules";
            this.GameRules.Size = new System.Drawing.Size(153, 22);
            this.GameRules.Text = "Правила игры";
            this.GameRules.Click += new System.EventHandler(this.GameRules_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(306, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.bestScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bestScore;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainStrip;
        private System.Windows.Forms.ToolStripMenuItem RestartButton;
        private System.Windows.Forms.ToolStripMenuItem GameRules;
    }
}

