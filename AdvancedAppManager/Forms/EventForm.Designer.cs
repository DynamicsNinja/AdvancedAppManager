
namespace Fic.XTB.AdvancedAppManager.Forms
{
    partial class EventForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFunctionName = new System.Windows.Forms.TextBox();
            this.cbLibrary = new System.Windows.Forms.ComboBox();
            this.tbParameters = new System.Windows.Forms.TextBox();
            this.cbEventName = new System.Windows.Forms.ComboBox();
            this.cbxEnabled = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Function Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Library";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parameters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enabled";
            // 
            // tbFunctionName
            // 
            this.tbFunctionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFunctionName.Location = new System.Drawing.Point(135, 94);
            this.tbFunctionName.Name = "tbFunctionName";
            this.tbFunctionName.Size = new System.Drawing.Size(653, 26);
            this.tbFunctionName.TabIndex = 5;
            // 
            // cbLibrary
            // 
            this.cbLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLibrary.FormattingEnabled = true;
            this.cbLibrary.Location = new System.Drawing.Point(135, 142);
            this.cbLibrary.Name = "cbLibrary";
            this.cbLibrary.Size = new System.Drawing.Size(653, 28);
            this.cbLibrary.TabIndex = 6;
            this.cbLibrary.TextUpdate += new System.EventHandler(this.cbLibrary_TextUpdate);
            // 
            // tbParameters
            // 
            this.tbParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbParameters.Location = new System.Drawing.Point(135, 189);
            this.tbParameters.Name = "tbParameters";
            this.tbParameters.Size = new System.Drawing.Size(653, 26);
            this.tbParameters.TabIndex = 7;
            // 
            // cbEventName
            // 
            this.cbEventName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEventName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEventName.FormattingEnabled = true;
            this.cbEventName.Items.AddRange(new object[] {
            "onload"});
            this.cbEventName.Location = new System.Drawing.Point(135, 41);
            this.cbEventName.Name = "cbEventName";
            this.cbEventName.Size = new System.Drawing.Size(653, 28);
            this.cbEventName.TabIndex = 8;
            // 
            // cbxEnabled
            // 
            this.cbxEnabled.AutoSize = true;
            this.cbxEnabled.Checked = true;
            this.cbxEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxEnabled.Location = new System.Drawing.Point(135, 242);
            this.cbxEnabled.Name = "cbxEnabled";
            this.cbxEnabled.Size = new System.Drawing.Size(22, 21);
            this.cbxEnabled.TabIndex = 9;
            this.cbxEnabled.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(698, 327);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 49);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(602, 327);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 49);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbxEnabled);
            this.Controls.Add(this.cbEventName);
            this.Controls.Add(this.tbParameters);
            this.Controls.Add(this.cbLibrary);
            this.Controls.Add(this.tbFunctionName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Event Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFunctionName;
        private System.Windows.Forms.ComboBox cbLibrary;
        private System.Windows.Forms.TextBox tbParameters;
        private System.Windows.Forms.ComboBox cbEventName;
        private System.Windows.Forms.CheckBox cbxEnabled;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}