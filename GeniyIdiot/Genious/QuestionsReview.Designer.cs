
namespace Genious
{
    partial class QuestionsReview
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
            this.QuestionsList = new System.Windows.Forms.DataGridView();
            this.RemoveQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.RefreshTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsList)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionsList
            // 
            this.QuestionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuestionsList.Location = new System.Drawing.Point(12, 12);
            this.QuestionsList.Name = "QuestionsList";
            this.QuestionsList.Size = new System.Drawing.Size(575, 323);
            this.QuestionsList.TabIndex = 0;
            this.QuestionsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.QuestionsList_CellContentClick);
            // 
            // RemoveQuestion
            // 
            this.RemoveQuestion.Location = new System.Drawing.Point(281, 424);
            this.RemoveQuestion.Name = "RemoveQuestion";
            this.RemoveQuestion.Size = new System.Drawing.Size(106, 23);
            this.RemoveQuestion.TabIndex = 1;
            this.RemoveQuestion.Text = "Удалить вопрос";
            this.RemoveQuestion.UseVisualStyleBackColor = true;
            this.RemoveQuestion.Click += new System.EventHandler(this.RemoveQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вопрос";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 357);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 387);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(279, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ответ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить вопрос";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RefreshTable
            // 
            this.RefreshTable.Location = new System.Drawing.Point(502, 354);
            this.RefreshTable.Name = "RefreshTable";
            this.RefreshTable.Size = new System.Drawing.Size(75, 23);
            this.RefreshTable.TabIndex = 6;
            this.RefreshTable.Text = "Обновить";
            this.RefreshTable.UseVisualStyleBackColor = true;
            this.RefreshTable.Click += new System.EventHandler(this.RefreshTable_Click);
            // 
            // QuestionsReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 468);
            this.Controls.Add(this.RefreshTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RemoveQuestion);
            this.Controls.Add(this.QuestionsList);
            this.Name = "QuestionsReview";
            this.Text = "QuestionsReview";
            this.Load += new System.EventHandler(this.QuestionsReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView QuestionsList;
        private System.Windows.Forms.Button RemoveQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button RefreshTable;
    }
}