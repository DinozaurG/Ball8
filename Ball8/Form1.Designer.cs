namespace Ball8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonForAnswer = new System.Windows.Forms.Button();
            this.labelForAnswer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxForQuestion = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelForNum = new System.Windows.Forms.Label();
            this.buttonForGuess = new System.Windows.Forms.Button();
            this.buttonForAstr = new System.Windows.Forms.Button();
            this.labelForAstr = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonForAnswer);
            this.panel1.Controls.Add(this.labelForAnswer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxForQuestion);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 411);
            this.panel1.TabIndex = 0;
            // 
            // buttonForAnswer
            // 
            this.buttonForAnswer.Location = new System.Drawing.Point(137, 203);
            this.buttonForAnswer.Name = "buttonForAnswer";
            this.buttonForAnswer.Size = new System.Drawing.Size(75, 23);
            this.buttonForAnswer.TabIndex = 3;
            this.buttonForAnswer.Text = "Press!!!";
            this.buttonForAnswer.UseVisualStyleBackColor = true;
            this.buttonForAnswer.Click += new System.EventHandler(this.buttonForAnswer_Click);
            // 
            // labelForAnswer
            // 
            this.labelForAnswer.AutoSize = true;
            this.labelForAnswer.Location = new System.Drawing.Point(153, 331);
            this.labelForAnswer.Name = "labelForAnswer";
            this.labelForAnswer.Size = new System.Drawing.Size(0, 17);
            this.labelForAnswer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Задай вопрос машине";
            // 
            // textBoxForQuestion
            // 
            this.textBoxForQuestion.Location = new System.Drawing.Point(4, 119);
            this.textBoxForQuestion.Name = "textBoxForQuestion";
            this.textBoxForQuestion.Size = new System.Drawing.Size(354, 22);
            this.textBoxForQuestion.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelForAstr);
            this.panel2.Controls.Add(this.buttonForAstr);
            this.panel2.Controls.Add(this.labelForNum);
            this.panel2.Controls.Add(this.buttonForGuess);
            this.panel2.Location = new System.Drawing.Point(427, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 411);
            this.panel2.TabIndex = 1;
            // 
            // labelForNum
            // 
            this.labelForNum.AutoSize = true;
            this.labelForNum.Location = new System.Drawing.Point(169, 120);
            this.labelForNum.Name = "labelForNum";
            this.labelForNum.Size = new System.Drawing.Size(0, 17);
            this.labelForNum.TabIndex = 1;
            // 
            // buttonForGuess
            // 
            this.buttonForGuess.Location = new System.Drawing.Point(101, 10);
            this.buttonForGuess.Name = "buttonForGuess";
            this.buttonForGuess.Size = new System.Drawing.Size(174, 87);
            this.buttonForGuess.TabIndex = 0;
            this.buttonForGuess.Text = "Загадай цифру от 1 до 10, и я её отгадаю";
            this.buttonForGuess.UseVisualStyleBackColor = true;
            this.buttonForGuess.Click += new System.EventHandler(this.buttonForGuess_Click);
            // 
            // buttonForAstr
            // 
            this.buttonForAstr.Location = new System.Drawing.Point(101, 259);
            this.buttonForAstr.Name = "buttonForAstr";
            this.buttonForAstr.Size = new System.Drawing.Size(174, 38);
            this.buttonForAstr.TabIndex = 2;
            this.buttonForAstr.Text = "Предскажу будущее";
            this.buttonForAstr.UseVisualStyleBackColor = true;
            this.buttonForAstr.Click += new System.EventHandler(this.buttonForAstr_Click);
            // 
            // labelForAstr
            // 
            this.labelForAstr.AutoSize = true;
            this.labelForAstr.Location = new System.Drawing.Point(46, 332);
            this.labelForAstr.Name = "labelForAstr";
            this.labelForAstr.Size = new System.Drawing.Size(0, 17);
            this.labelForAstr.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonForAnswer;
        private System.Windows.Forms.Label labelForAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxForQuestion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelForNum;
        private System.Windows.Forms.Button buttonForGuess;
        private System.Windows.Forms.Label labelForAstr;
        private System.Windows.Forms.Button buttonForAstr;
    }
}

