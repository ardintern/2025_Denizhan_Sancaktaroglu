namespace DokumantasyonProje.E_Fatura_Sorgulama_Servisi
{
    partial class queryInboxDoc
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxParamType = new System.Windows.Forms.ComboBox();
            this.comboBoxWithXML = new System.Windows.Forms.ComboBox();
            this.textBoxParameter = new System.Windows.Forms.TextBox();
            this.btnQueryInboxDoc = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(222, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Query Inbox Document";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label4.Location = new System.Drawing.Point(138, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 29;
            this.label4.Text = "parameter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label3.Location = new System.Drawing.Point(421, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "withXML";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Location = new System.Drawing.Point(138, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "paramType";
            // 
            // comboBoxParamType
            // 
            this.comboBoxParamType.FormattingEnabled = true;
            this.comboBoxParamType.Location = new System.Drawing.Point(141, 150);
            this.comboBoxParamType.Name = "comboBoxParamType";
            this.comboBoxParamType.Size = new System.Drawing.Size(239, 24);
            this.comboBoxParamType.TabIndex = 26;
            // 
            // comboBoxWithXML
            // 
            this.comboBoxWithXML.FormattingEnabled = true;
            this.comboBoxWithXML.Location = new System.Drawing.Point(424, 150);
            this.comboBoxWithXML.Name = "comboBoxWithXML";
            this.comboBoxWithXML.Size = new System.Drawing.Size(239, 24);
            this.comboBoxWithXML.TabIndex = 25;
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(142, 227);
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.Size = new System.Drawing.Size(239, 22);
            this.textBoxParameter.TabIndex = 24;
            // 
            // btnQueryInboxDoc
            // 
            this.btnQueryInboxDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQueryInboxDoc.Location = new System.Drawing.Point(294, 284);
            this.btnQueryInboxDoc.Name = "btnQueryInboxDoc";
            this.btnQueryInboxDoc.Size = new System.Drawing.Size(239, 44);
            this.btnQueryInboxDoc.TabIndex = 23;
            this.btnQueryInboxDoc.Text = "Sorgula";
            this.btnQueryInboxDoc.UseVisualStyleBackColor = true;
            this.btnQueryInboxDoc.Click += new System.EventHandler(this.btnQueryInboxDoc_Click);
            // 
            // queryInboxDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxParamType);
            this.Controls.Add(this.comboBoxWithXML);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.btnQueryInboxDoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "queryInboxDoc";
            this.Text = "queryInboxDoc";
            this.Load += new System.EventHandler(this.queryInboxDoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxParamType;
        private System.Windows.Forms.ComboBox comboBoxWithXML;
        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Button btnQueryInboxDoc;
    }
}