using System.ComponentModel;

namespace Calender
{
    partial class DayPlanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this._pnlPlan = new System.Windows.Forms.Panel();
            this._lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _pnlPlan
            // 
            this._pnlPlan.Location = new System.Drawing.Point(2, 36);
            this._pnlPlan.Name = "_pnlPlan";
            this._pnlPlan.Size = new System.Drawing.Size(794, 480);
            this._pnlPlan.TabIndex = 0;
            this._pnlPlan.Paint += new System.Windows.Forms.PaintEventHandler(this._pnlPlan_Paint);
            // 
            // _lblDate
            // 
            this._lblDate.Location = new System.Drawing.Point(2, 9);
            this._lblDate.Name = "_lblDate";
            this._lblDate.Size = new System.Drawing.Size(175, 23);
            this._lblDate.TabIndex = 1;
            this._lblDate.Text = "label1";
            // 
            // DayPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this._lblDate);
            this.Controls.Add(this._pnlPlan);
            this.Name = "DayPlanForm";
            this.Text = "DayPlanForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label _lblDate;

        private System.Windows.Forms.Panel _pnlPlan;

        #endregion
    }
}