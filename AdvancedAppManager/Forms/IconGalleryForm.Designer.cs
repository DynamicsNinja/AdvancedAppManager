
namespace Fic.XTB.AdvancedAppManager.Forms
{
    partial class IconGalleryForm
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
            this.wvIconGallery = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wvIconGallery)).BeginInit();
            this.SuspendLayout();
            // 
            // wvIconGallery
            // 
            this.wvIconGallery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wvIconGallery.CreationProperties = null;
            this.wvIconGallery.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvIconGallery.Location = new System.Drawing.Point(12, 12);
            this.wvIconGallery.Name = "wvIconGallery";
            this.wvIconGallery.Size = new System.Drawing.Size(776, 370);
            this.wvIconGallery.TabIndex = 0;
            this.wvIconGallery.ZoomFactor = 1D;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(672, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 50);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(550, 388);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(116, 50);
            this.btnSelect.TabIndex = 13;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // IconGalleryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.wvIconGallery);
            this.Name = "IconGalleryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pick Icon";
            this.Load += new System.EventHandler(this.IconGalleryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wvIconGallery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wvIconGallery;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
    }
}