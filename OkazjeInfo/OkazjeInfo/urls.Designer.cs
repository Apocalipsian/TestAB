namespace OkazjeInfo
{
    partial class urls
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
            this.urlsBox = new System.Windows.Forms.RichTextBox();
            this.cluster = new System.Windows.Forms.Button();
            this.numberOfRecords = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lf = new System.Windows.Forms.Button();
            this.frazy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.katCena = new System.Windows.Forms.Button();
            this.katTech = new System.Windows.Forms.Button();
            this.kat = new System.Windows.Forms.Button();
            this.katProducer = new System.Windows.Forms.Button();
            this.katShop = new System.Windows.Forms.Button();
            this.katCity = new System.Windows.Forms.Button();
            this.mix = new System.Windows.Forms.Button();
            this.rankingi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRecords)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // urlsBox
            // 
            this.urlsBox.Location = new System.Drawing.Point(25, 48);
            this.urlsBox.Name = "urlsBox";
            this.urlsBox.Size = new System.Drawing.Size(624, 475);
            this.urlsBox.TabIndex = 0;
            this.urlsBox.Text = "";
            // 
            // cluster
            // 
            this.cluster.Location = new System.Drawing.Point(692, 137);
            this.cluster.Name = "cluster";
            this.cluster.Size = new System.Drawing.Size(181, 23);
            this.cluster.TabIndex = 1;
            this.cluster.Text = "KLASTER";
            this.cluster.UseVisualStyleBackColor = true;
            this.cluster.Click += new System.EventHandler(this.cluster_Click);
            // 
            // numberOfRecords
            // 
            this.numberOfRecords.Location = new System.Drawing.Point(774, 48);
            this.numberOfRecords.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberOfRecords.Name = "numberOfRecords";
            this.numberOfRecords.Size = new System.Drawing.Size(120, 20);
            this.numberOfRecords.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ilość rekordów";
            // 
            // lf
            // 
            this.lf.Location = new System.Drawing.Point(692, 167);
            this.lf.Name = "lf";
            this.lf.Size = new System.Drawing.Size(181, 23);
            this.lf.TabIndex = 4;
            this.lf.Text = "LF";
            this.lf.UseVisualStyleBackColor = true;
            this.lf.Click += new System.EventHandler(this.button1_Click);
            // 
            // frazy
            // 
            this.frazy.Location = new System.Drawing.Point(692, 197);
            this.frazy.Name = "frazy";
            this.frazy.Size = new System.Drawing.Size(181, 23);
            this.frazy.TabIndex = 5;
            this.frazy.Text = "FRAZY SEARCH";
            this.frazy.UseVisualStyleBackColor = true;
            this.frazy.Click += new System.EventHandler(this.frazy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mix);
            this.groupBox1.Controls.Add(this.katCity);
            this.groupBox1.Controls.Add(this.katProducer);
            this.groupBox1.Controls.Add(this.katShop);
            this.groupBox1.Controls.Add(this.katCena);
            this.groupBox1.Controls.Add(this.katTech);
            this.groupBox1.Controls.Add(this.kat);
            this.groupBox1.Location = new System.Drawing.Point(692, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 241);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LISTINGI";
            // 
            // katCena
            // 
            this.katCena.Location = new System.Drawing.Point(6, 79);
            this.katCena.Name = "katCena";
            this.katCena.Size = new System.Drawing.Size(181, 23);
            this.katCena.TabIndex = 8;
            this.katCena.Text = "KAT + CENA";
            this.katCena.UseVisualStyleBackColor = true;
            this.katCena.Click += new System.EventHandler(this.button2_Click);
            // 
            // katTech
            // 
            this.katTech.Location = new System.Drawing.Point(6, 49);
            this.katTech.Name = "katTech";
            this.katTech.Size = new System.Drawing.Size(181, 23);
            this.katTech.TabIndex = 7;
            this.katTech.Text = "KAT + TECH";
            this.katTech.UseVisualStyleBackColor = true;
            this.katTech.Click += new System.EventHandler(this.katTech_Click);
            // 
            // kat
            // 
            this.kat.Location = new System.Drawing.Point(6, 19);
            this.kat.Name = "kat";
            this.kat.Size = new System.Drawing.Size(181, 23);
            this.kat.TabIndex = 6;
            this.kat.Text = "KAT";
            this.kat.UseVisualStyleBackColor = true;
            this.kat.Click += new System.EventHandler(this.kat_Click);
            // 
            // katProducer
            // 
            this.katProducer.Location = new System.Drawing.Point(6, 168);
            this.katProducer.Name = "katProducer";
            this.katProducer.Size = new System.Drawing.Size(181, 23);
            this.katProducer.TabIndex = 10;
            this.katProducer.Text = "KAT + PROD";
            this.katProducer.UseVisualStyleBackColor = true;
            this.katProducer.Click += new System.EventHandler(this.katProducer_Click);
            // 
            // katShop
            // 
            this.katShop.Location = new System.Drawing.Point(6, 108);
            this.katShop.Name = "katShop";
            this.katShop.Size = new System.Drawing.Size(181, 23);
            this.katShop.TabIndex = 9;
            this.katShop.Text = "KAT + SHOP";
            this.katShop.UseVisualStyleBackColor = true;
            this.katShop.Click += new System.EventHandler(this.katShop_Click);
            // 
            // katCity
            // 
            this.katCity.Location = new System.Drawing.Point(6, 137);
            this.katCity.Name = "katCity";
            this.katCity.Size = new System.Drawing.Size(181, 23);
            this.katCity.TabIndex = 11;
            this.katCity.Text = "KAT + CITY";
            this.katCity.UseVisualStyleBackColor = true;
            this.katCity.Click += new System.EventHandler(this.katCity_Click);
            // 
            // mix
            // 
            this.mix.Location = new System.Drawing.Point(6, 212);
            this.mix.Name = "mix";
            this.mix.Size = new System.Drawing.Size(181, 23);
            this.mix.TabIndex = 12;
            this.mix.Text = "MIX";
            this.mix.UseVisualStyleBackColor = true;
            this.mix.Click += new System.EventHandler(this.mix_Click);
            // 
            // rankingi
            // 
            this.rankingi.Location = new System.Drawing.Point(692, 227);
            this.rankingi.Name = "rankingi";
            this.rankingi.Size = new System.Drawing.Size(181, 23);
            this.rankingi.TabIndex = 7;
            this.rankingi.Text = "RANKINGI";
            this.rankingi.UseVisualStyleBackColor = true;
            this.rankingi.Click += new System.EventHandler(this.rankingi_Click);
            // 
            // urls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 554);
            this.Controls.Add(this.rankingi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.frazy);
            this.Controls.Add(this.lf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOfRecords);
            this.Controls.Add(this.cluster);
            this.Controls.Add(this.urlsBox);
            this.Name = "urls";
            this.Text = "urls";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRecords)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox urlsBox;
        private System.Windows.Forms.Button cluster;
        private System.Windows.Forms.NumericUpDown numberOfRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lf;
        private System.Windows.Forms.Button frazy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button katCena;
        private System.Windows.Forms.Button katTech;
        private System.Windows.Forms.Button kat;
        private System.Windows.Forms.Button katCity;
        private System.Windows.Forms.Button katProducer;
        private System.Windows.Forms.Button katShop;
        private System.Windows.Forms.Button mix;
        private System.Windows.Forms.Button rankingi;
    }
}