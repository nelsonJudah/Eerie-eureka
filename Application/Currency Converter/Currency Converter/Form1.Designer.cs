namespace Currency_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Conv_Bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "UK - GBP £ (British Pound Sterling)",
            "US - USD $ (Dollar)",
            "Europe - EUR € (Euro)"});
            this.comboBox2.Location = new System.Drawing.Point(195, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(163, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Text = "Select Country";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(101, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 116);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "GBP £ - Pound Sterling",
            "NGN ₦ - Nigerian Naira",
            "USD $ - US Dollar",
            "INR ₹ - Indian Rupee",
            "EUR € - Euro",
            "GHS ₵ - Ghana Cedi",
            "CNY ¥ - Chinese Yuan",
            "IRR ﷼ - Iranian Rial",
            "KRW ẅ - South Korean Won",
            "ZAR R - South African Rand",
            "BRL R$ - Brazilian Real",
            "RUB ₽ - Russian Ruble"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "UK - GBP £ (British Pound Sterling)",
            "US - USD $ (Dollar)",
            "Europe - EUR € (Euro)",
            "Nigeria - NGN ₦ (Naira)",
            "India - INR ₹ (Rupee)",
            "Ghana - GHS ₵ (Cedi)",
            "China - CNY ¥ (Yuan)",
            "Iran IRR - ﷼(Rial)",
            "South Africa - ZAR R (Rand)",
            "KRW ẅ -South Korean Won",
            "Brazil - BRL R$ (Real)",
            "Russia - RUB ₽ (Ruble)",
            "Philippine - PHP Ᵽ (Peso)"});
            this.comboBox1.Location = new System.Drawing.Point(5, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "Select Country";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "0";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(364, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter Amount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Currency Conversion From:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(195, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Currency Conversion To :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(468, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 117);
            this.button1.TabIndex = 15;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Conv_Bttn
            // 
            this.Conv_Bttn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Conv_Bttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Conv_Bttn.Location = new System.Drawing.Point(5, 62);
            this.Conv_Bttn.Name = "Conv_Bttn";
            this.Conv_Bttn.Size = new System.Drawing.Size(90, 117);
            this.Conv_Bttn.TabIndex = 10;
            this.Conv_Bttn.Text = "Convert";
            this.Conv_Bttn.UseVisualStyleBackColor = false;
            this.Conv_Bttn.Click += new System.EventHandler(this.Conv_Bttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(563, 183);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Conv_Bttn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(579, 222);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Conv_Bttn;
    }
}