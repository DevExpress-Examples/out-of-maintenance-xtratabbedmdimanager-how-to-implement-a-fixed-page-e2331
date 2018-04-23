namespace WindowsApplication1
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
            this.myMDIManager1 = new WindowsApplication1.MyMDIManager();
            ((System.ComponentModel.ISupportInitialize)(this.myMDIManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // myMDIManager1
            // 
            this.myMDIManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.myMDIManager1.FixedPage = null;
            this.myMDIManager1.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.myMDIManager1.FloatOnDrag = DevExpress.Utils.DefaultBoolean.True;
            this.myMDIManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 494);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myMDIManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyMDIManager myMDIManager1;

    }
}

