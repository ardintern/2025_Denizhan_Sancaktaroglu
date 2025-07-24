namespace DokumantasyonProje.E_Fatura_Sorgulama_Servisi
{
    partial class queryOutboxDocLocalId
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
            this.btnQueryOutboxDocLocalId = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLocalId = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(165, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "QueryOutboxDocumentWithLocalId";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQueryOutboxDocLocalId
            // 
            this.btnQueryOutboxDocLocalId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQueryOutboxDocLocalId.Location = new System.Drawing.Point(262, 201);
            this.btnQueryOutboxDocLocalId.Name = "btnQueryOutboxDocLocalId";
            this.btnQueryOutboxDocLocalId.Size = new System.Drawing.Size(239, 44);
            this.btnQueryOutboxDocLocalId.TabIndex = 33;
            this.btnQueryOutboxDocLocalId.Text = "Sorgula";
            this.btnQueryOutboxDocLocalId.UseVisualStyleBackColor = true;
            this.btnQueryOutboxDocLocalId.Click += new System.EventHandler(this.btnQueryOutboxDocLocalId_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label7.Location = new System.Drawing.Point(264, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 22);
            this.label7.TabIndex = 46;
            this.label7.Text = "Local Id giriniz";
            // 
            // textBoxLocalId
            // 
            this.textBoxLocalId.Location = new System.Drawing.Point(262, 160);
            this.textBoxLocalId.Name = "textBoxLocalId";
            this.textBoxLocalId.Size = new System.Drawing.Size(195, 22);
            this.textBoxLocalId.TabIndex = 45;
            // 
            // queryOutboxDocLocalId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxLocalId);
            this.Controls.Add(this.btnQueryOutboxDocLocalId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "queryOutboxDocLocalId";
            this.Text = "queryOutboxDocLocalId";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQueryOutboxDocLocalId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLocalId;
    }
}