namespace Optimizer
{
    partial class WizardForm
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
            this.lblUsingPrint = new System.Windows.Forms.Label();
            this.moonToggleButton1 = new Optimizer.MoonToggleButton();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.panelGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsingPrint
            // 
            this.lblUsingPrint.AutoSize = true;
            this.lblUsingPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsingPrint.ForeColor = System.Drawing.Color.Silver;
            this.lblUsingPrint.Location = new System.Drawing.Point(21, 21);
            this.lblUsingPrint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsingPrint.Name = "lblUsingPrint";
            this.lblUsingPrint.Size = new System.Drawing.Size(39, 19);
            this.lblUsingPrint.TabIndex = 56;
            this.lblUsingPrint.Tag = "";
            this.lblUsingPrint.Text = "label";
            // 
            // moonToggleButton1
            // 
            this.moonToggleButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.moonToggleButton1.FlatAppearance.BorderSize = 0;
            this.moonToggleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moonToggleButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.moonToggleButton1.Location = new System.Drawing.Point(25, 43);
            this.moonToggleButton1.Name = "moonToggleButton1";
            this.moonToggleButton1.Size = new System.Drawing.Size(113, 29);
            this.moonToggleButton1.TabIndex = 57;
            this.moonToggleButton1.Text = "Yes";
            this.moonToggleButton1.ToggleState = false;
            this.moonToggleButton1.UseVisualStyleBackColor = false;
            this.moonToggleButton1.Click += new System.EventHandler(this.moonToggleButton1_Click);
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.moonToggleButton1);
            this.panelGeneral.Controls.Add(this.lblUsingPrint);
            this.panelGeneral.Location = new System.Drawing.Point(12, 12);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(473, 402);
            this.panelGeneral.TabIndex = 57;
            // 
            // WizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(771, 568);
            this.Controls.Add(this.panelGeneral);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "WizardForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.WizardForm_Load);
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsingPrint;
        private MoonToggleButton moonToggleButton1;
        private System.Windows.Forms.Panel panelGeneral;
    }
}