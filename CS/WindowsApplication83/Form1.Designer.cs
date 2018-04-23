namespace WindowsApplication83 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.myRangeTrackBarControl1 = new WindowsApplication83.MyRangeTrackBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.myRangeTrackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myRangeTrackBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // myRangeTrackBarControl1
            // 
            this.myRangeTrackBarControl1.EditValue = new DevExpress.XtraEditors.Repository.TrackBarRange(0, 0);
            this.myRangeTrackBarControl1.Location = new System.Drawing.Point(48, 94);
            this.myRangeTrackBarControl1.Name = "myRangeTrackBarControl1";
            this.myRangeTrackBarControl1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.myRangeTrackBarControl1.Properties.Appearance.Options.UseForeColor = true;
            this.myRangeTrackBarControl1.Size = new System.Drawing.Size(303, 56);
            this.myRangeTrackBarControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 269);
            this.Controls.Add(this.myRangeTrackBarControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myRangeTrackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myRangeTrackBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyRangeTrackBarControl myRangeTrackBarControl1;
    }
}

