namespace ADPP_CW
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioEngine = new System.Windows.Forms.RadioButton();
            this.radioHanbrake = new System.Windows.Forms.RadioButton();
            this.radioClutch = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Location = new System.Drawing.Point(184, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 387);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // radioEngine
            // 
            this.radioEngine.AutoSize = true;
            this.radioEngine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioEngine.Enabled = false;
            this.radioEngine.Location = new System.Drawing.Point(20, 51);
            this.radioEngine.Name = "radioEngine";
            this.radioEngine.Size = new System.Drawing.Size(80, 17);
            this.radioEngine.TabIndex = 3;
            this.radioEngine.Text = "Двигатель";
            this.radioEngine.UseVisualStyleBackColor = false;
            // 
            // radioHanbrake
            // 
            this.radioHanbrake.AutoCheck = false;
            this.radioHanbrake.AutoSize = true;
            this.radioHanbrake.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioHanbrake.Checked = true;
            this.radioHanbrake.Enabled = false;
            this.radioHanbrake.Location = new System.Drawing.Point(20, 74);
            this.radioHanbrake.Name = "radioHanbrake";
            this.radioHanbrake.Size = new System.Drawing.Size(60, 17);
            this.radioHanbrake.TabIndex = 4;
            this.radioHanbrake.TabStop = true;
            this.radioHanbrake.Text = "Ручник";
            this.radioHanbrake.UseVisualStyleBackColor = false;
            // 
            // radioClutch
            // 
            this.radioClutch.AutoCheck = false;
            this.radioClutch.AutoSize = true;
            this.radioClutch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioClutch.Enabled = false;
            this.radioClutch.Location = new System.Drawing.Point(20, 97);
            this.radioClutch.Name = "radioClutch";
            this.radioClutch.Size = new System.Drawing.Size(80, 17);
            this.radioClutch.TabIndex = 5;
            this.radioClutch.Text = "Сцепление";
            this.radioClutch.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(20, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Передача: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Трансмиссия";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(20, 150);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "С инструктором";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Механическая",
            "Автоматическая"});
            this.comboBox1.Location = new System.Drawing.Point(100, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioClutch);
            this.Controls.Add(this.radioHanbrake);
            this.Controls.Add(this.radioEngine);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioEngine;
        private System.Windows.Forms.RadioButton radioHanbrake;
        private System.Windows.Forms.RadioButton radioClutch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

