namespace DokumantasyonProje.E_Fatura_Sorgulama_Servisi
{
    partial class queryLastInvoiceIdAndDate
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetLastInIdDate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxsource_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxdocumentIdPrefix = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(207, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Get Last Invoice Id And Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGetLastInIdDate
            // 
            this.btnGetLastInIdDate.Location = new System.Drawing.Point(279, 236);
            this.btnGetLastInIdDate.Name = "btnGetLastInIdDate";
            this.btnGetLastInIdDate.Size = new System.Drawing.Size(224, 45);
            this.btnGetLastInIdDate.TabIndex = 13;
            this.btnGetLastInIdDate.Text = "Sorgula";
            this.btnGetLastInIdDate.UseVisualStyleBackColor = true;
            this.btnGetLastInIdDate.Click += new System.EventHandler(this.btnGetLastInIdDate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label7.Location = new System.Drawing.Point(188, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 53;
            this.label7.Text = "tckn no:";
            // 
            // textBoxsource_id
            // 
            this.textBoxsource_id.Location = new System.Drawing.Point(186, 184);
            this.textBoxsource_id.Name = "textBoxsource_id";
            this.textBoxsource_id.Size = new System.Drawing.Size(195, 22);
            this.textBoxsource_id.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Location = new System.Drawing.Point(400, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 44);
            this.label2.TabIndex = 55;
            this.label2.Text = "Faturaların üç haneli seri numarasını \r\ngiriniz (TST gibi):";
            // 
            // textBoxdocumentIdPrefix
            // 
            this.textBoxdocumentIdPrefix.Location = new System.Drawing.Point(404, 184);
            this.textBoxdocumentIdPrefix.Name = "textBoxdocumentIdPrefix";
            this.textBoxdocumentIdPrefix.Size = new System.Drawing.Size(195, 22);
            this.textBoxdocumentIdPrefix.TabIndex = 54;
            // 
            // queryLastInvoiceIdAndDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxdocumentIdPrefix);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxsource_id);
            this.Controls.Add(this.btnGetLastInIdDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "queryLastInvoiceIdAndDate";
            this.Text = "queryLastInvoiceIdAndDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetLastInIdDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxsource_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxdocumentIdPrefix;
    }
}