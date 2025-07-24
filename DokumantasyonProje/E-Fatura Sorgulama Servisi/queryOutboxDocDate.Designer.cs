namespace DokumantasyonProje.E_Fatura_Sorgulama_Servisi
{
    partial class queryOutboxDocDate
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
            this.btnQueryOutboxDocDate = new System.Windows.Forms.Button();
            this.comboBoxWithXML = new System.Windows.Forms.ComboBox();
            this.comboBoxDocType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.comboBoxQueried = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMinRecordId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(210, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "QueryOutboxDocument Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQueryOutboxDocDate
            // 
            this.btnQueryOutboxDocDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQueryOutboxDocDate.Location = new System.Drawing.Point(61, 292);
            this.btnQueryOutboxDocDate.Name = "btnQueryOutboxDocDate";
            this.btnQueryOutboxDocDate.Size = new System.Drawing.Size(239, 44);
            this.btnQueryOutboxDocDate.TabIndex = 14;
            this.btnQueryOutboxDocDate.Text = "Sorgula";
            this.btnQueryOutboxDocDate.UseVisualStyleBackColor = true;
            this.btnQueryOutboxDocDate.Click += new System.EventHandler(this.btnQueryOutboxDocDate_Click);
            // 
            // comboBoxWithXML
            // 
            this.comboBoxWithXML.FormattingEnabled = true;
            this.comboBoxWithXML.Location = new System.Drawing.Point(61, 166);
            this.comboBoxWithXML.Name = "comboBoxWithXML";
            this.comboBoxWithXML.Size = new System.Drawing.Size(195, 24);
            this.comboBoxWithXML.TabIndex = 19;
            // 
            // comboBoxDocType
            // 
            this.comboBoxDocType.FormattingEnabled = true;
            this.comboBoxDocType.Location = new System.Drawing.Point(283, 166);
            this.comboBoxDocType.Name = "comboBoxDocType";
            this.comboBoxDocType.Size = new System.Drawing.Size(195, 24);
            this.comboBoxDocType.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label3.Location = new System.Drawing.Point(57, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "withXML";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Location = new System.Drawing.Point(274, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 44);
            this.label2.TabIndex = 23;
            this.label2.Text = "Document Type\r\n1 Fatura 2 Uygulama yanıtı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(57, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Başlangıç tarihi giriniz";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(61, 244);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(200, 22);
            this.dateTimeStart.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(281, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Bitiş tarihi giriniz";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(283, 244);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(200, 22);
            this.dateTimeEnd.TabIndex = 26;
            // 
            // comboBoxQueried
            // 
            this.comboBoxQueried.FormattingEnabled = true;
            this.comboBoxQueried.Location = new System.Drawing.Point(504, 166);
            this.comboBoxQueried.Name = "comboBoxQueried";
            this.comboBoxQueried.Size = new System.Drawing.Size(195, 24);
            this.comboBoxQueried.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label6.Location = new System.Drawing.Point(506, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Queried";
            // 
            // textBoxMinRecordId
            // 
            this.textBoxMinRecordId.Location = new System.Drawing.Point(504, 244);
            this.textBoxMinRecordId.Name = "textBoxMinRecordId";
            this.textBoxMinRecordId.Size = new System.Drawing.Size(195, 22);
            this.textBoxMinRecordId.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label7.Location = new System.Drawing.Point(506, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 22);
            this.label7.TabIndex = 31;
            this.label7.Text = "MınRecordedId";
            // 
            // queryOutboxDocDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxMinRecordId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxQueried);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxDocType);
            this.Controls.Add(this.comboBoxWithXML);
            this.Controls.Add(this.btnQueryOutboxDocDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "queryOutboxDocDate";
            this.Text = "queryOutboxDocDate";
            this.Load += new System.EventHandler(this.queryOutboxDocDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQueryOutboxDocDate;
        private System.Windows.Forms.ComboBox comboBoxWithXML;
        private System.Windows.Forms.ComboBox comboBoxDocType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.ComboBox comboBoxQueried;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMinRecordId;
        private System.Windows.Forms.Label label7;
    }
}