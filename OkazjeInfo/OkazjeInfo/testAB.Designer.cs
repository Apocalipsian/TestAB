namespace OkazjeInfo
{
    partial class testAB
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
            this.testAbPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seeTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.testOffBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.testOnBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.cookieBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.testAbPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // testAbPanel
            // 
            this.testAbPanel.Controls.Add(this.dataGridView1);
            this.testAbPanel.Controls.Add(this.groupBox3);
            this.testAbPanel.Controls.Add(this.groupBox2);
            this.testAbPanel.Controls.Add(this.groupBox1);
            this.testAbPanel.Controls.Add(this.button1);
            this.testAbPanel.Location = new System.Drawing.Point(-56, 12);
            this.testAbPanel.Name = "testAbPanel";
            this.testAbPanel.Size = new System.Drawing.Size(1136, 893);
            this.testAbPanel.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.url,
            this.testEvent,
            this.testId,
            this.seeTest});
            this.dataGridView1.Location = new System.Drawing.Point(698, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 874);
            this.dataGridView1.TabIndex = 18;
            // 
            // url
            // 
            this.url.HeaderText = "Url";
            this.url.Name = "url";
            this.url.ReadOnly = true;
            this.url.Width = 200;
            // 
            // testEvent
            // 
            this.testEvent.HeaderText = "Event";
            this.testEvent.Name = "testEvent";
            this.testEvent.ReadOnly = true;
            this.testEvent.Width = 50;
            // 
            // testId
            // 
            this.testId.HeaderText = "Test ID";
            this.testId.Name = "testId";
            this.testId.ReadOnly = true;
            this.testId.Width = 60;
            // 
            // seeTest
            // 
            this.seeTest.HeaderText = "Czy widział stronę testową?";
            this.seeTest.Name = "seeTest";
            this.seeTest.ReadOnly = true;
            this.seeTest.Width = 70;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.testOffBox);
            this.groupBox3.Location = new System.Drawing.Point(94, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 181);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Strony nie poddane testowi";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(423, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "OPEN";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(423, 152);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "SAVE";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // testOffBox
            // 
            this.testOffBox.Location = new System.Drawing.Point(6, 19);
            this.testOffBox.Name = "testOffBox";
            this.testOffBox.Size = new System.Drawing.Size(411, 156);
            this.testOffBox.TabIndex = 1;
            this.testOffBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.testOnBox);
            this.groupBox2.Location = new System.Drawing.Point(94, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 190);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Strony poddane testowi";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "OPEN";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(429, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "SAVE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // testOnBox
            // 
            this.testOnBox.Location = new System.Drawing.Point(6, 19);
            this.testOnBox.Name = "testOnBox";
            this.testOnBox.Size = new System.Drawing.Size(411, 157);
            this.testOnBox.TabIndex = 0;
            this.testOnBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.cookieBox);
            this.groupBox1.Location = new System.Drawing.Point(94, 452);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 144);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ciastka";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(423, 86);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 23;
            this.button7.Text = "OPEN";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(423, 115);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 24;
            this.button6.Text = "SAVE";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // cookieBox
            // 
            this.cookieBox.Location = new System.Drawing.Point(6, 19);
            this.cookieBox.Name = "cookieBox";
            this.cookieBox.Size = new System.Drawing.Size(411, 119);
            this.cookieBox.TabIndex = 3;
            this.cookieBox.Text = "";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(94, 664);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 67);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testAB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 917);
            this.Controls.Add(this.testAbPanel);
            this.Name = "testAB";
            this.Text = "testAB";
            this.testAbPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel testAbPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.DataGridViewTextBoxColumn testEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn testId;
        private System.Windows.Forms.DataGridViewTextBoxColumn seeTest;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox testOffBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox testOnBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox cookieBox;
        private System.Windows.Forms.Button button1;
    }
}