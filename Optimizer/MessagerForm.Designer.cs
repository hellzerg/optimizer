namespace Optimizer
{
    partial class MessagerForm
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
            this.msg = new System.Windows.Forms.Label();
            this.yesbtn = new System.Windows.Forms.Button();
            this.nobtn = new System.Windows.Forms.Button();
            this.chkPrint = new System.Windows.Forms.CheckBox();
            this.chkSensors = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // msg
            // 
            this.msg.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.msg.Location = new System.Drawing.Point(10, 7);
            this.msg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(432, 69);
            this.msg.TabIndex = 0;
            this.msg.Text = "Restart to apply changes?";
            // 
            // yesbtn
            // 
            this.yesbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.yesbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.yesbtn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.yesbtn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.yesbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.yesbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.yesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesbtn.ForeColor = System.Drawing.Color.White;
            this.yesbtn.Location = new System.Drawing.Point(346, 128);
            this.yesbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yesbtn.Name = "yesbtn";
            this.yesbtn.Size = new System.Drawing.Size(96, 31);
            this.yesbtn.TabIndex = 31;
            this.yesbtn.Tag = "themeable";
            this.yesbtn.Text = "Yes";
            this.yesbtn.UseVisualStyleBackColor = false;
            this.yesbtn.Click += new System.EventHandler(this.button39_Click);
            // 
            // nobtn
            // 
            this.nobtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nobtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.nobtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.nobtn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.nobtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.nobtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.nobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nobtn.ForeColor = System.Drawing.Color.White;
            this.nobtn.Location = new System.Drawing.Point(245, 128);
            this.nobtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nobtn.Name = "nobtn";
            this.nobtn.Size = new System.Drawing.Size(96, 31);
            this.nobtn.TabIndex = 32;
            this.nobtn.Tag = "themeable";
            this.nobtn.Text = "No";
            this.nobtn.UseVisualStyleBackColor = false;
            this.nobtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkPrint
            // 
            this.chkPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkPrint.AutoSize = true;
            this.chkPrint.Checked = true;
            this.chkPrint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chkPrint.Location = new System.Drawing.Point(10, 117);
            this.chkPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.Size = new System.Drawing.Size(211, 19);
            this.chkPrint.TabIndex = 33;
            this.chkPrint.Text = "I use Print Service, do not disable it";
            this.chkPrint.UseVisualStyleBackColor = true;
            this.chkPrint.Visible = false;
            // 
            // chkSensors
            // 
            this.chkSensors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSensors.AutoSize = true;
            this.chkSensors.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chkSensors.Location = new System.Drawing.Point(10, 140);
            this.chkSensors.Margin = new System.Windows.Forms.Padding(2);
            this.chkSensors.Name = "chkSensors";
            this.chkSensors.Size = new System.Drawing.Size(226, 19);
            this.chkSensors.TabIndex = 34;
            this.chkSensors.Text = "This is a tablet, do not disable Sensors";
            this.chkSensors.UseVisualStyleBackColor = true;
            this.chkSensors.Visible = false;
            // 
            // Messager
            // 
            this.AcceptButton = this.yesbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CancelButton = this.nobtn;
            this.ClientSize = new System.Drawing.Size(451, 169);
            this.Controls.Add(this.chkSensors);
            this.Controls.Add(this.chkPrint);
            this.Controls.Add(this.nobtn);
            this.Controls.Add(this.yesbtn);
            this.Controls.Add(this.msg);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Messager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Restarter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.Button yesbtn;
        private System.Windows.Forms.Button nobtn;
        private System.Windows.Forms.CheckBox chkPrint;
        private System.Windows.Forms.CheckBox chkSensors;
    }
}