namespace DokumantasyonProje.E_Fatura_Sorgulama_Servisi
{
    partial class queryEnvelope
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEnvelopeUUID = new System.Windows.Forms.TextBox();
            this.btnQueryEnvelope = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDocUUID = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(289, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Query Envelope";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label4.Location = new System.Drawing.Point(161, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "envelopeUUID";
            // 
            // textBoxEnvelopeUUID
            // 
            this.textBoxEnvelopeUUID.Location = new System.Drawing.Point(165, 190);
            this.textBoxEnvelopeUUID.Name = "textBoxEnvelopeUUID";
            this.textBoxEnvelopeUUID.Size = new System.Drawing.Size(239, 22);
            this.textBoxEnvelopeUUID.TabIndex = 30;
            // 
            // btnQueryEnvelope
            // 
            this.btnQueryEnvelope.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQueryEnvelope.Location = new System.Drawing.Point(268, 242);
            this.btnQueryEnvelope.Name = "btnQueryEnvelope";
            this.btnQueryEnvelope.Size = new System.Drawing.Size(239, 44);
            this.btnQueryEnvelope.TabIndex = 32;
            this.btnQueryEnvelope.Text = "Sorgula";
            this.btnQueryEnvelope.UseVisualStyleBackColor = true;
            this.btnQueryEnvelope.Click += new System.EventHandler(this.btnQueryEnvelope_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Location = new System.Drawing.Point(425, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "DocUUID";
            // 
            // textBoxDocUUID
            // 
            this.textBoxDocUUID.Location = new System.Drawing.Point(429, 190);
            this.textBoxDocUUID.Name = "textBoxDocUUID";
            this.textBoxDocUUID.Size = new System.Drawing.Size(239, 22);
            this.textBoxDocUUID.TabIndex = 33;
            // 
            // queryEnvelope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDocUUID);
            this.Controls.Add(this.btnQueryEnvelope);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEnvelopeUUID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "queryEnvelope";
            this.Text = "queryEnvelope";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEnvelopeUUID;
        private System.Windows.Forms.Button btnQueryEnvelope;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDocUUID;
    }
}