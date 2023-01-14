
namespace BallGamesWinFormsApp
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
            this.Create = new System.Windows.Forms.Button();
            this.RandomDrawing = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(370, 12);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(148, 23);
            this.Create.TabIndex = 0;
            this.Create.Text = "Нарисовать много шаров";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Draw);
            // 
            // RandomDrawing
            // 
            this.RandomDrawing.Location = new System.Drawing.Point(370, 50);
            this.RandomDrawing.Name = "RandomDrawing";
            this.RandomDrawing.Size = new System.Drawing.Size(148, 23);
            this.RandomDrawing.TabIndex = 0;
            this.RandomDrawing.Text = "Двигать 1 шарик";
            this.RandomDrawing.UseVisualStyleBackColor = true;
            this.RandomDrawing.Click += new System.EventHandler(this.RandomDrawing_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Остановить все шарики";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.StopBalls_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(370, 135);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(148, 23);
            this.Clear_button.TabIndex = 1;
            this.Clear_button.TabStop = false;
            this.Clear_button.Text = "Очистить";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RandomDrawing);
            this.Controls.Add(this.Create);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button RandomDrawing;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Clear_button;
    }
}

