namespace DokumantasyonProje
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
            this.txtVKN = new System.Windows.Forms.TextBox();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVKN
            // 
            this.txtVKN.AccessibleName = "txtVKN";
            this.txtVKN.Location = new System.Drawing.Point(288, 136);
            this.txtVKN.Name = "txtVKN";
            this.txtVKN.Size = new System.Drawing.Size(148, 22);
            this.txtVKN.TabIndex = 0;
            this.txtVKN.Text = "VKN giriniz";
            // 
            // btnSorgula
            // 
            this.btnSorgula.AccessibleName = "btnSorgula";
            this.btnSorgula.Location = new System.Drawing.Point(302, 164);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(120, 34);
            this.btnSorgula.TabIndex = 2;
            this.btnSorgula.Text = "Kredi Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.txtVKN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVKN;
        private System.Windows.Forms.Button btnSorgula;
    }
}

