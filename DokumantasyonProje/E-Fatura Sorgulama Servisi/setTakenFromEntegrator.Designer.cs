namespace DokumantasyonProje.E_Fatura_Sorgulama_Servisi
{
    partial class setTakenFromEntegrator
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
            this.btnDocUUID = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(219, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Set Taken From Entegrator ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDocUUID
            // 
            this.btnDocUUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDocUUID.Location = new System.Drawing.Point(270, 229);
            this.btnDocUUID.Name = "btnDocUUID";
            this.btnDocUUID.Size = new System.Drawing.Size(239, 44);
            this.btnDocUUID.TabIndex = 24;
            this.btnDocUUID.Text = "Sorgula";
            this.btnDocUUID.UseVisualStyleBackColor = true;
            this.btnDocUUID.Click += new System.EventHandler(this.btnDocUUID_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label4.Location = new System.Drawing.Point(266, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "documentUuid";
            // 
            // textBoxDocUUID
            // 
            this.textBoxDocUUID.Location = new System.Drawing.Point(270, 179);
            this.textBoxDocUUID.Name = "textBoxDocUUID";
            this.textBoxDocUUID.Size = new System.Drawing.Size(239, 22);
            this.textBoxDocUUID.TabIndex = 30;
            // 
            // setTakenFromEntegrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDocUUID);
            this.Controls.Add(this.btnDocUUID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "setTakenFromEntegrator";
            this.Text = "setTakenFromEntegrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDocUUID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDocUUID;
    }
}