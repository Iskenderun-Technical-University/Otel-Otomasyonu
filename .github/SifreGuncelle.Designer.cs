
namespace Otel_Otomasyonu
{
    partial class SifreGuncelle
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
            this.txtguncellesifre = new System.Windows.Forms.TextBox();
            this.txtgucellead = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadminguncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtguncellesifre
            // 
            this.txtguncellesifre.Location = new System.Drawing.Point(386, 148);
            this.txtguncellesifre.Name = "txtguncellesifre";
            this.txtguncellesifre.PasswordChar = '*';
            this.txtguncellesifre.Size = new System.Drawing.Size(195, 22);
            this.txtguncellesifre.TabIndex = 8;
            // 
            // txtgucellead
            // 
            this.txtgucellead.Location = new System.Drawing.Point(386, 102);
            this.txtgucellead.Name = "txtgucellead";
            this.txtgucellead.Size = new System.Drawing.Size(195, 22);
            this.txtgucellead.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(245, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(223, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // btnadminguncelle
            // 
            this.btnadminguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadminguncelle.Location = new System.Drawing.Point(345, 229);
            this.btnadminguncelle.Name = "btnadminguncelle";
            this.btnadminguncelle.Size = new System.Drawing.Size(151, 43);
            this.btnadminguncelle.TabIndex = 9;
            this.btnadminguncelle.Text = "Güncelle";
            this.btnadminguncelle.UseVisualStyleBackColor = true;
            this.btnadminguncelle.Click += new System.EventHandler(this.btnadminguncelle_Click);
            // 
            // SifreGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnadminguncelle);
            this.Controls.Add(this.txtguncellesifre);
            this.Controls.Add(this.txtgucellead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SifreGuncelle";
            this.Text = "Şifre Güncelleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtguncellesifre;
        private System.Windows.Forms.TextBox txtgucellead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadminguncelle;
    }
}