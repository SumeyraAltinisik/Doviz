namespace Doviz
{
    partial class Form1
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Mevcut = new System.Windows.Forms.ComboBox();
            this.cevirilecek = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cevirilendoviz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(226, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Alış";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(362, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Satış";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Mevcut
            // 
            this.Mevcut.FormattingEnabled = true;
            this.Mevcut.Items.AddRange(new object[] {
            "Dolar",
            "Pound",
            "Euro"});
            this.Mevcut.Location = new System.Drawing.Point(155, 139);
            this.Mevcut.Name = "Mevcut";
            this.Mevcut.Size = new System.Drawing.Size(121, 24);
            this.Mevcut.TabIndex = 2;
            this.Mevcut.SelectedIndexChanged += new System.EventHandler(this.Mevcut_SelectedIndexChanged);
            // 
            // cevirilecek
            // 
            this.cevirilecek.FormattingEnabled = true;
            this.cevirilecek.Items.AddRange(new object[] {
            "Dolar",
            "Pound",
            "Euro"});
            this.cevirilecek.Location = new System.Drawing.Point(155, 205);
            this.cevirilecek.Name = "cevirilecek";
            this.cevirilecek.Size = new System.Drawing.Size(121, 24);
            this.cevirilecek.TabIndex = 3;
            this.cevirilecek.SelectedIndexChanged += new System.EventHandler(this.cevirilecek_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cevirilendoviz
            // 
            this.cevirilendoviz.Location = new System.Drawing.Point(319, 141);
            this.cevirilendoviz.Name = "cevirilendoviz";
            this.cevirilendoviz.Size = new System.Drawing.Size(121, 22);
            this.cevirilendoviz.TabIndex = 5;
            this.cevirilendoviz.TextChanged += new System.EventHandler(this.cevirilendoviz_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cevirilendoviz);
            this.Controls.Add(this.cevirilecek);
            this.Controls.Add(this.Mevcut);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Form1";
            this.Text = "DovizKurlari";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox Mevcut;
        private System.Windows.Forms.ComboBox cevirilecek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cevirilendoviz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

