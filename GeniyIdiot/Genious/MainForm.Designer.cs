
namespace Genious
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
            this.nextButton = new System.Windows.Forms.Button();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.TextQuestion = new System.Windows.Forms.Label();
            this.questionText = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RepeatGame = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitClick = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowResults = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowQuestionsStorage = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LeftTime = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(135, 218);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            this.nextButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextButton_KeyDown);
            // 
            // AnswerBox
            // 
            this.AnswerBox.Location = new System.Drawing.Point(123, 178);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(100, 20);
            this.AnswerBox.TabIndex = 0;
            // 
            // TextQuestion
            // 
            this.TextQuestion.AutoSize = true;
            this.TextQuestion.Location = new System.Drawing.Point(128, 126);
            this.TextQuestion.MaximumSize = new System.Drawing.Size(200, 0);
            this.TextQuestion.Name = "TextQuestion";
            this.TextQuestion.Size = new System.Drawing.Size(82, 13);
            this.TextQuestion.TabIndex = 2;
            this.TextQuestion.Text = "Текст вопроса";
            // 
            // questionText
            // 
            this.questionText.AutoSize = true;
            this.questionText.Location = new System.Drawing.Point(141, 86);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(58, 13);
            this.questionText.TabIndex = 3;
            this.questionText.Text = "Вопрос №";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(374, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RepeatGame,
            this.ExitClick,
            this.ShowResults,
            this.ShowQuestionsStorage});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // RepeatGame
            // 
            this.RepeatGame.Name = "RepeatGame";
            this.RepeatGame.Size = new System.Drawing.Size(247, 22);
            this.RepeatGame.Text = "Начать сначала";
            this.RepeatGame.Click += new System.EventHandler(this.RepeatGame_Click);
            // 
            // ExitClick
            // 
            this.ExitClick.Name = "ExitClick";
            this.ExitClick.Size = new System.Drawing.Size(247, 22);
            this.ExitClick.Text = "Выход";
            this.ExitClick.Click += new System.EventHandler(this.ExitClick_Click);
            // 
            // ShowResults
            // 
            this.ShowResults.Name = "ShowResults";
            this.ShowResults.Size = new System.Drawing.Size(247, 22);
            this.ShowResults.Text = "Результаты участников";
            this.ShowResults.Click += new System.EventHandler(this.ShowResultsUsers_Click);
            // 
            // ShowQuestionsStorage
            // 
            this.ShowQuestionsStorage.Name = "ShowQuestionsStorage";
            this.ShowQuestionsStorage.Size = new System.Drawing.Size(247, 22);
            this.ShowQuestionsStorage.Text = "Показать хранилище вопросов";
            this.ShowQuestionsStorage.Click += new System.EventHandler(this.ShowQuestionsStorage_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LeftTime
            // 
            this.LeftTime.AutoSize = true;
            this.LeftTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LeftTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LeftTime.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftTime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LeftTime.Location = new System.Drawing.Point(313, 39);
            this.LeftTime.Name = "LeftTime";
            this.LeftTime.Size = new System.Drawing.Size(49, 35);
            this.LeftTime.TabIndex = 5;
            this.LeftTime.Text = "10";
            this.LeftTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.nextButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 400);
            this.Controls.Add(this.LeftTime);
            this.Controls.Add(this.questionText);
            this.Controls.Add(this.TextQuestion);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Genius or Idiot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.Label TextQuestion;
        private System.Windows.Forms.Label questionText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem RepeatGame;
        private System.Windows.Forms.ToolStripMenuItem ExitClick;
        private System.Windows.Forms.ToolStripMenuItem ShowResults;
        private System.Windows.Forms.ToolStripMenuItem ShowQuestionsStorage;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LeftTime;
    }
}

