namespace JvFunction
{
    partial class JvIfCom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JvIfCom));
            this.JvIfCom1 = new AxJVDTLabLib.AxJVLink();
            ((System.ComponentModel.ISupportInitialize)(this.JvIfCom1)).BeginInit();
            this.SuspendLayout();
            // 
            // JvIfCom1
            // 
            this.JvIfCom1.Enabled = true;
            this.JvIfCom1.Location = new System.Drawing.Point(13, 13);
            this.JvIfCom1.Name = "JvIfCom1";
            this.JvIfCom1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("JvIfCom1.OcxState")));
            this.JvIfCom1.Size = new System.Drawing.Size(179, 10);
            this.JvIfCom1.TabIndex = 0;
            // 
            // JvIfCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 34);
            this.Controls.Add(this.JvIfCom1);
            this.Name = "JvIfCom";
            this.Text = "JvIfCom";
            this.Load += new System.EventHandler(this.JvIfCom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JvIfCom1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxJVDTLabLib.AxJVLink JvIfCom1;
    }
}