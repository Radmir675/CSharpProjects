
using System;

namespace Genious
{
    partial class UserName
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
            this.AskText = new System.Windows.Forms.Label();
            this.AcceptName = new System.Windows.Forms.Button();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            this.SuspendLayout();
            // 
            // AskText
            // 
            this.AskText.AutoEllipsis = true;
            this.AskText.AutoSize = true;
            this.AskText.BackColor = System.Drawing.Color.Transparent;
            this.AskText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AskText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AskText.Location = new System.Drawing.Point(66, 78);
            this.AskText.Name = "AskText";
            this.AskText.Size = new System.Drawing.Size(173, 26);
            this.AskText.TabIndex = 0;
            this.AskText.Text = "Пожалуйста, введите ваше имя\r\nИ тест начнется прямо сейчас!";
            this.AskText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AcceptName
            // 
            this.AcceptName.Location = new System.Drawing.Point(113, 157);
            this.AcceptName.Name = "AcceptName";
            this.AcceptName.Size = new System.Drawing.Size(75, 23);
            this.AcceptName.TabIndex = 1;
            this.AcceptName.Text = "Ок";
            this.AcceptName.UseVisualStyleBackColor = true;
            this.AcceptName.Click += new System.EventHandler(this.AcceptName_Click);
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(98, 119);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 20);
            this.NameInput.TabIndex = 2;
            this.NameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameInput.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
            // 
            // errorProviderName
            // 
            this.errorProviderName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderName.ContainerControl = this;
            // 
            // UserName
            // 
            this.AcceptButton = this.AcceptName;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 210);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.AcceptName);
            this.Controls.Add(this.AskText);
            this.Name = "UserName";
            this.Text = "UserName";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
       


        #endregion

        private System.Windows.Forms.Label AskText;
        private System.Windows.Forms.Button AcceptName;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.ErrorProvider errorProviderName;
    }
}