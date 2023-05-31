namespace Calender
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
            this._pnlDisplay = new System.Windows.Forms.Panel();
            this._lblActualDate = new System.Windows.Forms.Label();
            this._btnBackward = new System.Windows.Forms.Button();
            this._btnForward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _pnlDisplay
            // 
            this._pnlDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._pnlDisplay.Location = new System.Drawing.Point(12, 37);
            this._pnlDisplay.Name = "_pnlDisplay";
            this._pnlDisplay.Size = new System.Drawing.Size(897, 595);
            this._pnlDisplay.TabIndex = 0;
            this._pnlDisplay.AutoSizeChanged += new System.EventHandler(this._pnlDisplay_AutoSizeChanged);
            this._pnlDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this._pnlDisplay_Paint);
            this._pnlDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this._pnlDisplay_MouseDown);
            this._pnlDisplay.Resize += new System.EventHandler(this._pnlDisplay_Resize);
            this._pnlDisplay.ParentChanged += new System.EventHandler(this._pnlDisplay_ParentChanged);
            // 
            // _lblActualDate
            // 
            this._lblActualDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._lblActualDate.Location = new System.Drawing.Point(396, 9);
            this._lblActualDate.Name = "_lblActualDate";
            this._lblActualDate.Size = new System.Drawing.Size(100, 23);
            this._lblActualDate.TabIndex = 1;
            this._lblActualDate.Text = "x.xx.xxxx";
            this._lblActualDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _btnBackward
            // 
            this._btnBackward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnBackward.Location = new System.Drawing.Point(715, 7);
            this._btnBackward.Name = "_btnBackward";
            this._btnBackward.Size = new System.Drawing.Size(94, 24);
            this._btnBackward.TabIndex = 2;
            this._btnBackward.Text = "<<<";
            this._btnBackward.UseVisualStyleBackColor = true;
            this._btnBackward.Click += new System.EventHandler(this._btnBackward_Click);
            // 
            // _btnForward
            // 
            this._btnForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnForward.Location = new System.Drawing.Point(815, 7);
            this._btnForward.Name = "_btnForward";
            this._btnForward.Size = new System.Drawing.Size(94, 24);
            this._btnForward.TabIndex = 3;
            this._btnForward.Text = ">>>";
            this._btnForward.UseVisualStyleBackColor = true;
            this._btnForward.Click += new System.EventHandler(this._btnForward_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 644);
            this.Controls.Add(this._btnForward);
            this.Controls.Add(this._btnBackward);
            this.Controls.Add(this._lblActualDate);
            this.Controls.Add(this._pnlDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button _btnBackward;
        private System.Windows.Forms.Button _btnForward;

        private System.Windows.Forms.Label _lblActualDate;

        private System.Windows.Forms.Panel _pnlDisplay;

        #endregion
    }
}