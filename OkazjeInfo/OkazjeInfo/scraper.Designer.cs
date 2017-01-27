namespace OkazjeInfo
{
    partial class scraper
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
            this.checkOneFile = new System.Windows.Forms.CheckBox();
            this.trunkUrl = new System.Windows.Forms.TextBox();
            this.compareTrunk = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.checkCookie = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.cookieRichBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkOneFile
            // 
            this.checkOneFile.AutoSize = true;
            this.checkOneFile.Location = new System.Drawing.Point(412, 16);
            this.checkOneFile.Name = "checkOneFile";
            this.checkOneFile.Size = new System.Drawing.Size(171, 17);
            this.checkOneFile.TabIndex = 22;
            this.checkOneFile.Text = "ZAPISZ DO JEDNEGO PLIKU";
            this.checkOneFile.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkOneFile.UseVisualStyleBackColor = true;
            // 
            // trunkUrl
            // 
            this.trunkUrl.Location = new System.Drawing.Point(542, 52);
            this.trunkUrl.Name = "trunkUrl";
            this.trunkUrl.Size = new System.Drawing.Size(202, 20);
            this.trunkUrl.TabIndex = 19;
            // 
            // compareTrunk
            // 
            this.compareTrunk.AutoSize = true;
            this.compareTrunk.Location = new System.Drawing.Point(412, 52);
            this.compareTrunk.Name = "compareTrunk";
            this.compareTrunk.Size = new System.Drawing.Size(124, 17);
            this.compareTrunk.TabIndex = 18;
            this.compareTrunk.Text = "Porównaj z trunkiem ";
            this.compareTrunk.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.checkCookie);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.cookieRichBox);
            this.groupBox3.Location = new System.Drawing.Point(412, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 222);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CIASTKA";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(100, 187);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 29);
            this.button5.TabIndex = 18;
            this.button5.Text = "Zapisz";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkCookie
            // 
            this.checkCookie.AutoSize = true;
            this.checkCookie.Location = new System.Drawing.Point(7, 21);
            this.checkCookie.Name = "checkCookie";
            this.checkCookie.Size = new System.Drawing.Size(67, 17);
            this.checkCookie.TabIndex = 15;
            this.checkCookie.Text = "ON/OFF";
            this.checkCookie.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 29);
            this.button4.TabIndex = 17;
            this.button4.Text = "Otwórz";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cookieRichBox
            // 
            this.cookieRichBox.Location = new System.Drawing.Point(7, 44);
            this.cookieRichBox.Name = "cookieRichBox";
            this.cookieRichBox.Size = new System.Drawing.Size(319, 123);
            this.cookieRichBox.TabIndex = 14;
            this.cookieRichBox.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(407, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 122);
            this.button1.TabIndex = 24;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 520);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 43);
            this.button3.TabIndex = 27;
            this.button3.Text = "Otwórz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 43);
            this.button2.TabIndex = 26;
            this.button2.Text = "Zapisz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 40);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(372, 468);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(202, 13);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 28;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "ILE STRON CHCESZ SPRAWDZIĆ :";
            // 
            // scraper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 570);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.checkOneFile);
            this.Controls.Add(this.trunkUrl);
            this.Controls.Add(this.compareTrunk);
            this.Name = "scraper";
            this.Text = "0";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkOneFile;
        private System.Windows.Forms.TextBox trunkUrl;
        private System.Windows.Forms.CheckBox compareTrunk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkCookie;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox cookieRichBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}