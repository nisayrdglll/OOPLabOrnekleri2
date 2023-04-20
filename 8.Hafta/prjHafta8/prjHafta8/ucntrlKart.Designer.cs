namespace prjHafta8
{
    partial class ucntrlKart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResim
            // 
            this.lblResim.Location = new System.Drawing.Point(0, 0);
            this.lblResim.Name = "lblResim";
            this.lblResim.Size = new System.Drawing.Size(170, 130);
            this.lblResim.TabIndex = 0;
            this.lblResim.Click += new System.EventHandler(this.lblResim_Click);
            // 
            // ucntrlKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblResim);
            this.Name = "ucntrlKart";
            this.Size = new System.Drawing.Size(170, 130);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblResim;
    }
}
