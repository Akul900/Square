
namespace Square
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
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmbResultType = new System.Windows.Forms.ComboBox();
            this.cmbFirstType = new System.Windows.Forms.ComboBox();
            this.cmbSecondType = new System.Windows.Forms.ComboBox();
            this.txtThird = new System.Windows.Forms.TextBox();
            this.txtFourth = new System.Windows.Forms.TextBox();
            this.txtResult2 = new System.Windows.Forms.TextBox();
            this.cmbThirdType = new System.Windows.Forms.ComboBox();
            this.cmbOperation2 = new System.Windows.Forms.ComboBox();
            this.cmbResultType2 = new System.Windows.Forms.ComboBox();
            this.txtResult3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOperation
            // 
            this.cmbOperation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "Сравнение"});
            this.cmbOperation.Location = new System.Drawing.Point(182, 27);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(116, 24);
            this.cmbOperation.TabIndex = 0;
            this.cmbOperation.Text = "+";
            this.cmbOperation.SelectedIndexChanged += new System.EventHandler(this.onValueChanged);
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(76, 29);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 22);
            this.txtFirst.TabIndex = 1;
            this.txtFirst.TextChanged += new System.EventHandler(this.onValueChanged);
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(304, 29);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(100, 22);
            this.txtSecond.TabIndex = 2;
            this.txtSecond.TextChanged += new System.EventHandler(this.onValueChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(157, 70);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 22);
            this.txtResult.TabIndex = 3;
            // 
            // cmbResultType
            // 
            this.cmbResultType.FormattingEnabled = true;
            this.cmbResultType.Location = new System.Drawing.Point(263, 70);
            this.cmbResultType.Name = "cmbResultType";
            this.cmbResultType.Size = new System.Drawing.Size(50, 24);
            this.cmbResultType.TabIndex = 4;
            this.cmbResultType.SelectedIndexChanged += new System.EventHandler(this.onValueChanged);
            // 
            // cmbFirstType
            // 
            this.cmbFirstType.FormattingEnabled = true;
            this.cmbFirstType.Location = new System.Drawing.Point(20, 27);
            this.cmbFirstType.Name = "cmbFirstType";
            this.cmbFirstType.Size = new System.Drawing.Size(50, 24);
            this.cmbFirstType.TabIndex = 5;
            this.cmbFirstType.SelectedIndexChanged += new System.EventHandler(this.onValueChanged);
            // 
            // cmbSecondType
            // 
            this.cmbSecondType.FormattingEnabled = true;
            this.cmbSecondType.Location = new System.Drawing.Point(410, 29);
            this.cmbSecondType.Name = "cmbSecondType";
            this.cmbSecondType.Size = new System.Drawing.Size(50, 24);
            this.cmbSecondType.TabIndex = 6;
            this.cmbSecondType.SelectedIndexChanged += new System.EventHandler(this.onValueChanged);
            // 
            // txtThird
            // 
            this.txtThird.Location = new System.Drawing.Point(76, 158);
            this.txtThird.Name = "txtThird";
            this.txtThird.Size = new System.Drawing.Size(100, 22);
            this.txtThird.TabIndex = 7;
            this.txtThird.TextChanged += new System.EventHandler(this.onValueChanged2);
            // 
            // txtFourth
            // 
            this.txtFourth.Location = new System.Drawing.Point(235, 158);
            this.txtFourth.Name = "txtFourth";
            this.txtFourth.Size = new System.Drawing.Size(100, 22);
            this.txtFourth.TabIndex = 8;
            this.txtFourth.TextChanged += new System.EventHandler(this.onValueChanged2);
            // 
            // txtResult2
            // 
            this.txtResult2.Location = new System.Drawing.Point(157, 205);
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.Size = new System.Drawing.Size(100, 22);
            this.txtResult2.TabIndex = 9;
            // 
            // cmbThirdType
            // 
            this.cmbThirdType.FormattingEnabled = true;
            this.cmbThirdType.Location = new System.Drawing.Point(20, 156);
            this.cmbThirdType.Name = "cmbThirdType";
            this.cmbThirdType.Size = new System.Drawing.Size(50, 24);
            this.cmbThirdType.TabIndex = 10;
            this.cmbThirdType.SelectedIndexChanged += new System.EventHandler(this.onValueChanged2);
            // 
            // cmbOperation2
            // 
            this.cmbOperation2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbOperation2.FormattingEnabled = true;
            this.cmbOperation2.Items.AddRange(new object[] {
            "*"});
            this.cmbOperation2.Location = new System.Drawing.Point(182, 156);
            this.cmbOperation2.Name = "cmbOperation2";
            this.cmbOperation2.Size = new System.Drawing.Size(47, 24);
            this.cmbOperation2.TabIndex = 11;
            this.cmbOperation2.Text = "*";
            this.cmbOperation2.SelectedIndexChanged += new System.EventHandler(this.onValueChanged2);
            // 
            // cmbResultType2
            // 
            this.cmbResultType2.FormattingEnabled = true;
            this.cmbResultType2.Location = new System.Drawing.Point(263, 205);
            this.cmbResultType2.Name = "cmbResultType2";
            this.cmbResultType2.Size = new System.Drawing.Size(50, 24);
            this.cmbResultType2.TabIndex = 12;
            this.cmbResultType2.SelectedIndexChanged += new System.EventHandler(this.onValueChanged2);
            // 
            // txtResult3
            // 
            this.txtResult3.Location = new System.Drawing.Point(157, 111);
            this.txtResult3.Name = "txtResult3";
            this.txtResult3.Size = new System.Drawing.Size(156, 22);
            this.txtResult3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Результат";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Сравнение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 246);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult3);
            this.Controls.Add(this.cmbResultType2);
            this.Controls.Add(this.cmbOperation2);
            this.Controls.Add(this.cmbThirdType);
            this.Controls.Add(this.txtResult2);
            this.Controls.Add(this.txtFourth);
            this.Controls.Add(this.txtThird);
            this.Controls.Add(this.cmbSecondType);
            this.Controls.Add(this.cmbFirstType);
            this.Controls.Add(this.cmbResultType);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.cmbOperation);
            this.Name = "Form1";
            this.Text = "Калькулятор площадей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.ComboBox cmbResultType;
        private System.Windows.Forms.ComboBox cmbFirstType;
        private System.Windows.Forms.ComboBox cmbSecondType;
        private System.Windows.Forms.TextBox txtThird;
        private System.Windows.Forms.TextBox txtFourth;
        private System.Windows.Forms.TextBox txtResult2;
        private System.Windows.Forms.ComboBox cmbThirdType;
        private System.Windows.Forms.ComboBox cmbOperation2;
        private System.Windows.Forms.ComboBox cmbResultType2;
        private System.Windows.Forms.TextBox txtResult3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

