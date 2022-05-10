namespace List_test
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.generovat = new System.Windows.Forms.Button();
            this.textBox_vystup = new System.Windows.Forms.TextBox();
            this.listBox_slov = new System.Windows.Forms.ListBox();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_cisel = new System.Windows.Forms.ListBox();
            this.listBox_znaku = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // generovat
            // 
            this.generovat.Location = new System.Drawing.Point(184, 9);
            this.generovat.Name = "generovat";
            this.generovat.Size = new System.Drawing.Size(75, 23);
            this.generovat.TabIndex = 0;
            this.generovat.Text = "Generovat";
            this.generovat.UseVisualStyleBackColor = true;
            this.generovat.Click += new System.EventHandler(this.generovat_Click);
            // 
            // textBox_vystup
            // 
            this.textBox_vystup.Location = new System.Drawing.Point(12, 178);
            this.textBox_vystup.Name = "textBox_vystup";
            this.textBox_vystup.ReadOnly = true;
            this.textBox_vystup.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_vystup.Size = new System.Drawing.Size(247, 20);
            this.textBox_vystup.TabIndex = 1;
            // 
            // listBox_slov
            // 
            this.listBox_slov.FormattingEnabled = true;
            this.listBox_slov.Location = new System.Drawing.Point(12, 38);
            this.listBox_slov.Name = "listBox_slov";
            this.listBox_slov.Size = new System.Drawing.Size(96, 134);
            this.listBox_slov.TabIndex = 2;
            // 
            // textBox_N
            // 
            this.textBox_N.Location = new System.Drawing.Point(66, 12);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(112, 20);
            this.textBox_N.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zadej N:";
            // 
            // listBox_cisel
            // 
            this.listBox_cisel.FormattingEnabled = true;
            this.listBox_cisel.Location = new System.Drawing.Point(114, 39);
            this.listBox_cisel.Name = "listBox_cisel";
            this.listBox_cisel.Size = new System.Drawing.Size(65, 134);
            this.listBox_cisel.TabIndex = 5;
            // 
            // listBox_znaku
            // 
            this.listBox_znaku.FormattingEnabled = true;
            this.listBox_znaku.Location = new System.Drawing.Point(185, 39);
            this.listBox_znaku.Name = "listBox_znaku";
            this.listBox_znaku.Size = new System.Drawing.Size(74, 134);
            this.listBox_znaku.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 209);
            this.Controls.Add(this.listBox_znaku);
            this.Controls.Add(this.listBox_cisel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_N);
            this.Controls.Add(this.listBox_slov);
            this.Controls.Add(this.textBox_vystup);
            this.Controls.Add(this.generovat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "List test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generovat;
        private System.Windows.Forms.TextBox textBox_vystup;
        private System.Windows.Forms.ListBox listBox_slov;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_cisel;
        private System.Windows.Forms.ListBox listBox_znaku;
    }
}

