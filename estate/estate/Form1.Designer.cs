namespace estate
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
            this.label1 = new System.Windows.Forms.Label();
            this.targetCmb = new System.Windows.Forms.ComboBox();
            this.cityCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomsCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.statusCmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цель вашего отъезда:";
            // 
            // targetCmb
            // 
            this.targetCmb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.targetCmb.FormattingEnabled = true;
            this.targetCmb.Items.AddRange(new object[] {
            "Работа",
            "Отдых"});
            this.targetCmb.Location = new System.Drawing.Point(270, 17);
            this.targetCmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.targetCmb.Name = "targetCmb";
            this.targetCmb.Size = new System.Drawing.Size(235, 25);
            this.targetCmb.TabIndex = 1;
            // 
            // cityCmb
            // 
            this.cityCmb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityCmb.FormattingEnabled = true;
            this.cityCmb.Items.AddRange(new object[] {
            "Москва",
            "Санкт-Петербург"});
            this.cityCmb.Location = new System.Drawing.Point(268, 71);
            this.cityCmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cityCmb.Name = "cityCmb";
            this.cityCmb.Size = new System.Drawing.Size(235, 25);
            this.cityCmb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Город:";
            // 
            // roomsCmb
            // 
            this.roomsCmb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomsCmb.FormattingEnabled = true;
            this.roomsCmb.Items.AddRange(new object[] {
            "Студия",
            "1-комнатная",
            "2-комнатная"});
            this.roomsCmb.Location = new System.Drawing.Point(270, 126);
            this.roomsCmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roomsCmb.Name = "roomsCmb";
            this.roomsCmb.Size = new System.Drawing.Size(235, 25);
            this.roomsCmb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество комнат:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена:";
            // 
            // priceTxt
            // 
            this.priceTxt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTxt.Location = new System.Drawing.Point(268, 239);
            this.priceTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(234, 25);
            this.priceTxt.TabIndex = 7;
            // 
            // statusCmb
            // 
            this.statusCmb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusCmb.FormattingEnabled = true;
            this.statusCmb.Items.AddRange(new object[] {
            "Продается",
            "Сдается"});
            this.statusCmb.Location = new System.Drawing.Point(268, 184);
            this.statusCmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusCmb.Name = "statusCmb";
            this.statusCmb.Size = new System.Drawing.Size(235, 25);
            this.statusCmb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(21, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Статус:";
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(154, 296);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(208, 31);
            this.nextBtn.TabIndex = 10;
            this.nextBtn.Text = "Дальше";
            this.nextBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 343);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.statusCmb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.roomsCmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityCmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.targetCmb);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Моя квартира";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox targetCmb;
        private System.Windows.Forms.ComboBox cityCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox roomsCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.ComboBox statusCmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button nextBtn;
    }
}

