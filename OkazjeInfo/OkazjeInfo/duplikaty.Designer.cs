namespace OkazjeInfo
{
    partial class duplikaty
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.checkCookie = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.cookieRichBox = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(307, 230);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.checkCookie);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.cookieRichBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 222);
            this.groupBox3.TabIndex = 24;
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
            this.cookieRichBox.Location = new System.Drawing.Point(6, 44);
            this.cookieRichBox.Name = "cookieRichBox";
            this.cookieRichBox.Size = new System.Drawing.Size(245, 123);
            this.cookieRichBox.TabIndex = 14;
            this.cookieRichBox.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(339, 37);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(575, 512);
            this.richTextBox2.TabIndex = 25;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "PODAJ URLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "WYNIKI ";
            // 
            // duplikaty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 597);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "duplikaty";
            this.Text = "duplikaty";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkCookie;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox cookieRichBox;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}