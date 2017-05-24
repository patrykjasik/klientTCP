namespace klientTCP
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
            this.przycisk = new System.Windows.Forms.Button();
            this.adres = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.polaczenie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.port)).BeginInit();
            this.SuspendLayout();
            // 
            // przycisk
            // 
            this.przycisk.Location = new System.Drawing.Point(533, 420);
            this.przycisk.Name = "przycisk";
            this.przycisk.Size = new System.Drawing.Size(257, 70);
            this.przycisk.TabIndex = 0;
            this.przycisk.Text = "Zamknij";
            this.przycisk.UseVisualStyleBackColor = true;
            this.przycisk.Click += new System.EventHandler(this.przycisk_Click);
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(13, 13);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(244, 20);
            this.adres.TabIndex = 1;
            this.adres.Text = "Adres";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(403, 12);
            this.port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(339, 20);
            this.port.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(777, 329);
            this.listBox1.TabIndex = 3;
            // 
            // polaczenie
            // 
            this.polaczenie.Location = new System.Drawing.Point(89, 420);
            this.polaczenie.Name = "polaczenie";
            this.polaczenie.Size = new System.Drawing.Size(231, 70);
            this.polaczenie.TabIndex = 4;
            this.polaczenie.Text = "Połącz";
            this.polaczenie.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 502);
            this.Controls.Add(this.polaczenie);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.port);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.przycisk);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button przycisk;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.NumericUpDown port;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button polaczenie;
    }
}

