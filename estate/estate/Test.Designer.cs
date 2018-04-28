namespace estate
{
    partial class Test
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
            this.Lbl_question = new System.Windows.Forms.Label();
            this.Answer1 = new System.Windows.Forms.RadioButton();
            this.Answer2 = new System.Windows.Forms.RadioButton();
            this.Answer3 = new System.Windows.Forms.RadioButton();
            this.Btn_next = new System.Windows.Forms.Button();
            this.Answer4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_question
            // 
            this.Lbl_question.AutoSize = true;
            this.Lbl_question.Location = new System.Drawing.Point(9, 30);
            this.Lbl_question.Name = "Lbl_question";
            this.Lbl_question.Size = new System.Drawing.Size(381, 17);
            this.Lbl_question.TabIndex = 0;
            this.Lbl_question.Text = "В каком городе вы желаете жить(по населенности) ?";
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer1.Location = new System.Drawing.Point(9, 72);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(140, 21);
            this.Answer1.TabIndex = 1;
            this.Answer1.Text = "Крупные города";
            this.Answer1.UseVisualStyleBackColor = true;
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer2.Location = new System.Drawing.Point(9, 114);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(126, 21);
            this.Answer2.TabIndex = 2;
            this.Answer2.Text = "Малые города";
            this.Answer2.UseVisualStyleBackColor = true;
            // 
            // Answer3
            // 
            this.Answer3.AutoSize = true;
            this.Answer3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer3.Location = new System.Drawing.Point(9, 152);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(169, 21);
            this.Answer3.TabIndex = 3;
            this.Answer3.Text = "Сельская местность";
            this.Answer3.UseVisualStyleBackColor = true;
            // 
            // Btn_next
            // 
            this.Btn_next.Location = new System.Drawing.Point(144, 221);
            this.Btn_next.Name = "Btn_next";
            this.Btn_next.Size = new System.Drawing.Size(110, 32);
            this.Btn_next.TabIndex = 4;
            this.Btn_next.Text = "Дальше";
            this.Btn_next.UseVisualStyleBackColor = true;
            this.Btn_next.Click += new System.EventHandler(this.Btn_next_Click);
            // 
            // Answer4
            // 
            this.Answer4.AutoSize = true;
            this.Answer4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer4.Location = new System.Drawing.Point(9, 190);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(169, 21);
            this.Answer4.TabIndex = 5;
            this.Answer4.Text = "Сельская местность";
            this.Answer4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 6;
            this.label1.Visible = false;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Answer4);
            this.Controls.Add(this.Btn_next);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.Lbl_question);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_question;
        private System.Windows.Forms.RadioButton Answer1;
        private System.Windows.Forms.RadioButton Answer2;
        private System.Windows.Forms.RadioButton Answer3;
        private System.Windows.Forms.Button Btn_next;
        private System.Windows.Forms.RadioButton Answer4;
        private System.Windows.Forms.Label label1;
    }
}