namespace DokumantasyonProje.E_Fatura_Sorgulama_Servisi
{
    partial class queryInboxDocGUIDList
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDocType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxGUID = new System.Windows.Forms.TextBox();
            this.btnQueryInboxDocLocalId = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Location = new System.Drawing.Point(383, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 44);
            this.label2.TabIndex = 58;
            this.label2.Text = "Document Type\r\n1 Fatura 2 Uygulama yanıtı";
            // 
            // comboBoxDocType
            // 
            this.comboBoxDocType.FormattingEnabled = true;
            this.comboBoxDocType.Location = new System.Drawing.Point(392, 182);
            this.comboBoxDocType.Name = "comboBoxDocType";
            this.comboBoxDocType.Size = new System.Drawing.Size(195, 24);
            this.comboBoxDocType.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label7.Location = new System.Drawing.Point(174, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 22);
            this.label7.TabIndex = 56;
            this.label7.Text = "GUID list giriniz";
            // 
            // textBoxGUID
            // 
            this.textBoxGUID.Location = new System.Drawing.Point(172, 182);
            this.textBoxGUID.Name = "textBoxGUID";
            this.textBoxGUID.Size = new System.Drawing.Size(195, 22);
            this.textBoxGUID.TabIndex = 55;
            // 
            // btnQueryInboxDocLocalId
            // 
            this.btnQueryInboxDocLocalId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQueryInboxDocLocalId.Location = new System.Drawing.Point(271, 235);
            this.btnQueryInboxDocLocalId.Name = "btnQueryInboxDocLocalId";
            this.btnQueryInboxDocLocalId.Size = new System.Drawing.Size(239, 44);
            this.btnQueryInboxDocLocalId.TabIndex = 54;
            this.btnQueryInboxDocLocalId.Text = "Sorgula";
            this.btnQueryInboxDocLocalId.UseVisualStyleBackColor = true;
            this.btnQueryInboxDocLocalId.Click += new System.EventHandler(this.btnQueryInboxDocLocalId_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(186, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 32);
            this.label1.TabIndex = 53;
            this.label1.Text = "Query Inbox Document GUID List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // queryInboxDocGUIDList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDocType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxGUID);
            this.Controls.Add(this.btnQueryInboxDocLocalId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "queryInboxDocGUIDList";
            this.Text = "queryInboxDocGUIDList";
            this.Load += new System.EventHandler(this.queryInboxDocGUIDList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDocType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxGUID;
        private System.Windows.Forms.Button btnQueryInboxDocLocalId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}