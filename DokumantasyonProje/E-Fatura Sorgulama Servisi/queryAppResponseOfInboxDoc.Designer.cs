namespace DokumantasyonProje.E_Fatura_Sorgulama_Servisi
{
    partial class queryAppResponseOfInboxDoc
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
            this.btnQueryOutboxDoc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxdocumentUUID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxWithXML = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQueryOutboxDoc
            // 
            this.btnQueryOutboxDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQueryOutboxDoc.Location = new System.Drawing.Point(247, 291);
            this.btnQueryOutboxDoc.Name = "btnQueryOutboxDoc";
            this.btnQueryOutboxDoc.Size = new System.Drawing.Size(239, 44);
            this.btnQueryOutboxDoc.TabIndex = 46;
            this.btnQueryOutboxDoc.Text = "Sorgula";
            this.btnQueryOutboxDoc.UseVisualStyleBackColor = true;
            this.btnQueryOutboxDoc.Click += new System.EventHandler(this.btnQueryInboxDoc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label4.Location = new System.Drawing.Point(356, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 45;
            this.label4.Text = "documentUUID";
            // 
            // textBoxdocumentUUID
            // 
            this.textBoxdocumentUUID.Location = new System.Drawing.Point(360, 224);
            this.textBoxdocumentUUID.Name = "textBoxdocumentUUID";
            this.textBoxdocumentUUID.Size = new System.Drawing.Size(239, 22);
            this.textBoxdocumentUUID.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label3.Location = new System.Drawing.Point(170, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 43;
            this.label3.Text = "withXML";
            // 
            // comboBoxWithXML
            // 
            this.comboBoxWithXML.FormattingEnabled = true;
            this.comboBoxWithXML.Location = new System.Drawing.Point(174, 222);
            this.comboBoxWithXML.Name = "comboBoxWithXML";
            this.comboBoxWithXML.Size = new System.Drawing.Size(148, 24);
            this.comboBoxWithXML.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(120, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 32);
            this.label1.TabIndex = 41;
            this.label1.Text = "Query App Response Of Inbox Document";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // queryAppResponseOfInboxDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQueryOutboxDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxdocumentUUID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxWithXML);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "queryAppResponseOfInboxDoc";
            this.Text = "queryAppResponseOfInboxDoc";
            this.Load += new System.EventHandler(this.queryInboxDoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQueryOutboxDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxdocumentUUID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxWithXML;
        private System.Windows.Forms.Label label1;
    }
}