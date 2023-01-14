
namespace Fruit_NinjaWinFormsApp
{
    partial class Fruit_NinjaForm
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
            this.StartGame_button = new System.Windows.Forms.Button();
            this.TakeOff_timer = new System.Windows.Forms.Timer(this.components);
            this.SlowMoretimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // StartGame_button
            // 
            this.StartGame_button.Location = new System.Drawing.Point(12, 25);
            this.StartGame_button.Name = "StartGame_button";
            this.StartGame_button.Size = new System.Drawing.Size(166, 23);
            this.StartGame_button.TabIndex = 0;
            this.StartGame_button.Text = "Начать игру";
            this.StartGame_button.UseVisualStyleBackColor = true;
            this.StartGame_button.Click += new System.EventHandler(this.StartGame_button_Click);
            // 
            // TakeOff_timer
            // 
            this.TakeOff_timer.Tick += new System.EventHandler(this.TakeOff_timer_Tick);
            // 
            // SlowMoretimer
            // 
            this.SlowMoretimer.Interval = 5000;
            this.SlowMoretimer.Tick += new System.EventHandler(this.SlowMoretimer_Tick);
            // 
            // Fruit_NinjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartGame_button);
            this.Name = "Fruit_NinjaForm";
            this.Text = "Fruit Ninja";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Fruit_NinjaForm_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGame_button;
        private System.Windows.Forms.Timer TakeOff_timer;
        private System.Windows.Forms.Timer SlowMoretimer;
    }
}

