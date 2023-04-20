namespace prjHafta8
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
            this.pnlOyun = new System.Windows.Forms.Panel();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlOyun
            // 
            this.pnlOyun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOyun.Location = new System.Drawing.Point(12, 55);
            this.pnlOyun.Name = "pnlOyun";
            this.pnlOyun.Size = new System.Drawing.Size(1119, 759);
            this.pnlOyun.TabIndex = 0;
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.Location = new System.Drawing.Point(12, 26);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(107, 23);
            this.btnYeniOyun.TabIndex = 1;
            this.btnYeniOyun.Text = "Yeni Oyun";
            this.btnYeniOyun.UseVisualStyleBackColor = true;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 826);
            this.Controls.Add(this.btnYeniOyun);
            this.Controls.Add(this.pnlOyun);
            this.Name = "Form1";
            this.Text = "Eşleştir";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOyun;
        private System.Windows.Forms.Button btnYeniOyun;
    }
}

