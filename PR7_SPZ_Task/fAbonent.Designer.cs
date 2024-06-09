namespace PR7_SPZ_Task
{
    partial class fAbonent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTariff = new System.Windows.Forms.TextBox();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.dtActivation = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbHasInternet = new System.Windows.Forms.CheckBox();
            this.cbHasDigitalTV = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBalance);
            this.groupBox1.Controls.Add(this.dtActivation);
            this.groupBox1.Controls.Add(this.tbTariff);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні дані";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ім\'я";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тариф";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Баланс, грн";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата активації";
            // 
            // tbNumber
            // 
            this.tbNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNumber.Location = new System.Drawing.Point(171, 43);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(155, 29);
            this.tbNumber.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(171, 81);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(155, 29);
            this.tbName.TabIndex = 6;
            // 
            // tbTariff
            // 
            this.tbTariff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTariff.Location = new System.Drawing.Point(171, 119);
            this.tbTariff.Name = "tbTariff";
            this.tbTariff.Size = new System.Drawing.Size(155, 29);
            this.tbTariff.TabIndex = 7;
            // 
            // tbBalance
            // 
            this.tbBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBalance.Location = new System.Drawing.Point(171, 157);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(155, 29);
            this.tbBalance.TabIndex = 8;
            // 
            // dtActivation
            // 
            this.dtActivation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtActivation.Location = new System.Drawing.Point(171, 197);
            this.dtActivation.Name = "dtActivation";
            this.dtActivation.Size = new System.Drawing.Size(155, 29);
            this.dtActivation.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbHasDigitalTV);
            this.groupBox2.Controls.Add(this.cbHasInternet);
            this.groupBox2.Location = new System.Drawing.Point(12, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Послуги";
            // 
            // cbHasInternet
            // 
            this.cbHasInternet.AutoSize = true;
            this.cbHasInternet.Location = new System.Drawing.Point(25, 40);
            this.cbHasInternet.Name = "cbHasInternet";
            this.cbHasInternet.Size = new System.Drawing.Size(104, 31);
            this.cbHasInternet.TabIndex = 0;
            this.cbHasInternet.Text = "Інтернет";
            this.cbHasInternet.UseVisualStyleBackColor = true;
            // 
            // cbHasDigitalTV
            // 
            this.cbHasDigitalTV.AutoSize = true;
            this.cbHasDigitalTV.Location = new System.Drawing.Point(25, 77);
            this.cbHasDigitalTV.Name = "cbHasDigitalTV";
            this.cbHasDigitalTV.Size = new System.Drawing.Size(217, 31);
            this.cbHasDigitalTV.TabIndex = 1;
            this.cbHasDigitalTV.Text = "Цифрове телебачення";
            this.cbHasDigitalTV.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(366, 48);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(126, 36);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(366, 95);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(126, 36);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "Скасувати";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // fAbonent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 404);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Onest", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fAbonent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані про нового абонента";
            this.Load += new System.EventHandler(this.fAbonent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.DateTimePicker dtActivation;
        private System.Windows.Forms.TextBox tbTariff;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbHasDigitalTV;
        private System.Windows.Forms.CheckBox cbHasInternet;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnNo;
    }
}