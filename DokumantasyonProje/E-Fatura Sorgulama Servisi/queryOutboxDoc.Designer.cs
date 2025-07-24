namespace DokumantasyonProje.E_Fatura_Sorgulama_Servisi
{
    partial class queryOutboxDoc
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
            this.btnQueryOutboxDoc = new System.Windows.Forms.Button();
            this.textBoxParameter = new System.Windows.Forms.TextBox();
            this.comboBoxWithXML = new System.Windows.Forms.ComboBox();
            this.comboBoxParamType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(239, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "QueryOutboxDocument";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQueryOutboxDoc
            // 
            this.btnQueryOutboxDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQueryOutboxDoc.Location = new System.Drawing.Point(287, 295);
            this.btnQueryOutboxDoc.Name = "btnQueryOutboxDoc";
            this.btnQueryOutboxDoc.Size = new System.Drawing.Size(239, 44);
            this.btnQueryOutboxDoc.TabIndex = 13;
            this.btnQueryOutboxDoc.Text = "Sorgula";
            this.btnQueryOutboxDoc.UseVisualStyleBackColor = true;
            this.btnQueryOutboxDoc.Click += new System.EventHandler(this.btnQueryOutboxDoc_Click);
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(135, 238);
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.Size = new System.Drawing.Size(239, 22);
            this.textBoxParameter.TabIndex = 17;
            // 
            // comboBoxWithXML
            // 
            this.comboBoxWithXML.FormattingEnabled = true;
            this.comboBoxWithXML.Location = new System.Drawing.Point(417, 161);
            this.comboBoxWithXML.Name = "comboBoxWithXML";
            this.comboBoxWithXML.Size = new System.Drawing.Size(239, 24);
            this.comboBoxWithXML.TabIndex = 18;
            // 
            // comboBoxParamType
            // 
            this.comboBoxParamType.FormattingEnabled = true;
            this.comboBoxParamType.Location = new System.Drawing.Point(134, 161);
            this.comboBoxParamType.Name = "comboBoxParamType";
            this.comboBoxParamType.Size = new System.Drawing.Size(239, 24);
            this.comboBoxParamType.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Location = new System.Drawing.Point(131, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "paramType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label3.Location = new System.Drawing.Point(414, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "withXML";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label4.Location = new System.Drawing.Point(131, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "parameter";
            // 
            // queryOutboxDoc
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
            this.Controls.Add(this.btnQueryOutboxDoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "queryOutboxDoc";
            this.Text = "queryOutboxDoc";
            this.Load += new System.EventHandler(this.queryOutboxDoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQueryOutboxDoc;
        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.ComboBox comboBoxWithXML;
        private System.Windows.Forms.ComboBox comboBoxParamType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}