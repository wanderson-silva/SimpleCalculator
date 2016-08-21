namespace simpleCalculator
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
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btsoma = new System.Windows.Forms.Button();
            this.btsulb = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btmult = new System.Windows.Forms.Button();
            this.btresult = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.btdiv = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(26, 70);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(61, 23);
            this.bt7.TabIndex = 1;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.gerarNumero);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(93, 70);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(61, 23);
            this.bt8.TabIndex = 2;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.gerarNumero);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(160, 70);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(61, 23);
            this.bt9.TabIndex = 3;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.gerarNumero);
            // 
            // btsoma
            // 
            this.btsoma.Location = new System.Drawing.Point(227, 70);
            this.btsoma.Name = "btsoma";
            this.btsoma.Size = new System.Drawing.Size(32, 23);
            this.btsoma.TabIndex = 4;
            this.btsoma.Text = "+";
            this.btsoma.UseVisualStyleBackColor = true;
            this.btsoma.Click += new System.EventHandler(this.operadores);
            // 
            // btsulb
            // 
            this.btsulb.Location = new System.Drawing.Point(227, 99);
            this.btsulb.Name = "btsulb";
            this.btsulb.Size = new System.Drawing.Size(32, 23);
            this.btsulb.TabIndex = 8;
            this.btsulb.Text = "-";
            this.btsulb.UseVisualStyleBackColor = true;
            this.btsulb.Click += new System.EventHandler(this.operadores);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(160, 99);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(61, 23);
            this.bt6.TabIndex = 7;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.gerarNumero);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(93, 99);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(61, 23);
            this.bt5.TabIndex = 6;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.gerarNumero);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(26, 99);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(61, 23);
            this.bt4.TabIndex = 5;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.gerarNumero);
            // 
            // btmult
            // 
            this.btmult.Location = new System.Drawing.Point(227, 158);
            this.btmult.Name = "btmult";
            this.btmult.Size = new System.Drawing.Size(32, 23);
            this.btmult.TabIndex = 16;
            this.btmult.Text = "x";
            this.btmult.UseVisualStyleBackColor = true;
            this.btmult.Click += new System.EventHandler(this.operadores);
            // 
            // btresult
            // 
            this.btresult.Location = new System.Drawing.Point(160, 158);
            this.btresult.Name = "btresult";
            this.btresult.Size = new System.Drawing.Size(61, 23);
            this.btresult.TabIndex = 15;
            this.btresult.Text = "=";
            this.btresult.UseVisualStyleBackColor = true;
            this.btresult.Click += new System.EventHandler(this.btresult_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(93, 158);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(61, 23);
            this.bt0.TabIndex = 14;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.gerarNumero);
            // 
            // btlimpar
            // 
            this.btlimpar.Location = new System.Drawing.Point(26, 158);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(61, 23);
            this.btlimpar.TabIndex = 13;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // btdiv
            // 
            this.btdiv.Location = new System.Drawing.Point(227, 129);
            this.btdiv.Name = "btdiv";
            this.btdiv.Size = new System.Drawing.Size(32, 23);
            this.btdiv.TabIndex = 12;
            this.btdiv.Text = "/";
            this.btdiv.UseVisualStyleBackColor = true;
            this.btdiv.Click += new System.EventHandler(this.operadores);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(160, 129);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(61, 23);
            this.bt3.TabIndex = 11;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.gerarNumero);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(93, 129);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(61, 23);
            this.bt2.TabIndex = 10;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.gerarNumero);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(26, 129);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(61, 23);
            this.bt1.TabIndex = 9;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.gerarNumero);
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(26, 35);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(233, 20);
            this.txtresult.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 213);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.btmult);
            this.Controls.Add(this.btresult);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btdiv);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btsulb);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btsoma);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.operadores);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btsoma;
        private System.Windows.Forms.Button btsulb;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btmult;
        private System.Windows.Forms.Button btresult;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.Button btdiv;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.MaskedTextBox txtresult;
    }
}

