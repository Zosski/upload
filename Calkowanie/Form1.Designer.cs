namespace Calkowanie
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.przedzialBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioSimps = new System.Windows.Forms.RadioButton();
            this.radioTrapez = new System.Windows.Forms.RadioButton();
            this.calcBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.aBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 126);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Wartości kolejnych stałch wielomianu";
            this.Column1.Name = "Column1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zapisz wielomian";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // przedzialBox
            // 
            this.przedzialBox.Location = new System.Drawing.Point(495, 15);
            this.przedzialBox.Name = "przedzialBox";
            this.przedzialBox.Size = new System.Drawing.Size(51, 20);
            this.przedzialBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liczba przedziałów:";
            // 
            // radioSimps
            // 
            this.radioSimps.AutoSize = true;
            this.radioSimps.Location = new System.Drawing.Point(552, 16);
            this.radioSimps.Name = "radioSimps";
            this.radioSimps.Size = new System.Drawing.Size(110, 17);
            this.radioSimps.TabIndex = 5;
            this.radioSimps.TabStop = true;
            this.radioSimps.Text = "Metoda Simpsona";
            this.radioSimps.UseVisualStyleBackColor = true;
            // 
            // radioTrapez
            // 
            this.radioTrapez.AutoSize = true;
            this.radioTrapez.Location = new System.Drawing.Point(668, 15);
            this.radioTrapez.Name = "radioTrapez";
            this.radioTrapez.Size = new System.Drawing.Size(107, 17);
            this.radioTrapez.TabIndex = 6;
            this.radioTrapez.TabStop = true;
            this.radioTrapez.Text = "Metoda trapezów";
            this.radioTrapez.UseVisualStyleBackColor = true;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(263, 115);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 7;
            this.calcBtn.Text = "Oblicz";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "A:";
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(412, 47);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(52, 20);
            this.aBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "B:";
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(495, 47);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(51, 20);
            this.bBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.radioTrapez);
            this.Controls.Add(this.radioSimps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.przedzialBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox przedzialBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioSimps;
        private System.Windows.Forms.RadioButton radioTrapez;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.Label label5;
    }
}

