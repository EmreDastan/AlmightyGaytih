
namespace LordGaytih
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Display = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.Maroon;
            this.Display.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Display.Location = new System.Drawing.Point(25, 40);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(311, 69);
            this.Display.TabIndex = 0;
            this.Display.Text = "Are you worthy of ALMIGHTY GAYTIH";
            this.Display.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LordGaytih.Properties.Resources._8nOHlKcJ_400x400;
            this.pictureBox1.Location = new System.Drawing.Point(395, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 396);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.Color.Red;
            this.Button.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button.Location = new System.Drawing.Point(48, 291);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(268, 56);
            this.Button.TabIndex = 3;
            this.Button.Text = "Test And See";
            this.Button.UseVisualStyleBackColor = false;
            this.Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Result.Font = new System.Drawing.Font("Wide Latin", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.Green;
            this.Result.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Result.Location = new System.Drawing.Point(12, 129);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(343, 140);
            this.Result.TabIndex = 4;
            this.Result.Text = "RESULT";
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(786, 393);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label Result;
    }
}

