
namespace Optimizer
{
    partial class CleanPreviewForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelBackup = new System.Windows.Forms.Button();
            this.cleanDriveB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listPreview = new Optimizer.ColoredCheckList();
            this.checkSelectAll = new System.Windows.Forms.LinkLabel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkSelectAll);
            this.panel2.Controls.Add(this.cancelBackup);
            this.panel2.Controls.Add(this.cleanDriveB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 526);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 38);
            this.panel2.TabIndex = 1;
            // 
            // cancelBackup
            // 
            this.cancelBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBackup.BackColor = System.Drawing.Color.DodgerBlue;
            this.cancelBackup.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cancelBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.cancelBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.cancelBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBackup.ForeColor = System.Drawing.Color.White;
            this.cancelBackup.Location = new System.Drawing.Point(532, 3);
            this.cancelBackup.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBackup.Name = "cancelBackup";
            this.cancelBackup.Size = new System.Drawing.Size(147, 31);
            this.cancelBackup.TabIndex = 36;
            this.cancelBackup.Tag = "themeable";
            this.cancelBackup.Text = "Cancel";
            this.cancelBackup.UseVisualStyleBackColor = false;
            this.cancelBackup.Click += new System.EventHandler(this.cancelBackup_Click);
            // 
            // cleanDriveB
            // 
            this.cleanDriveB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cleanDriveB.BackColor = System.Drawing.Color.DodgerBlue;
            this.cleanDriveB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cleanDriveB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.cleanDriveB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.cleanDriveB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanDriveB.ForeColor = System.Drawing.Color.White;
            this.cleanDriveB.Location = new System.Drawing.Point(683, 3);
            this.cleanDriveB.Margin = new System.Windows.Forms.Padding(2);
            this.cleanDriveB.Name = "cleanDriveB";
            this.cleanDriveB.Size = new System.Drawing.Size(147, 31);
            this.cleanDriveB.TabIndex = 35;
            this.cleanDriveB.Tag = "themeable";
            this.cleanDriveB.Text = "Clean";
            this.cleanDriveB.UseVisualStyleBackColor = false;
            this.cleanDriveB.Click += new System.EventHandler(this.cleanDriveB_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listPreview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 526);
            this.panel1.TabIndex = 2;
            // 
            // listPreview
            // 
            this.listPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPreview.ForeColor = System.Drawing.Color.Silver;
            this.listPreview.FormattingEnabled = true;
            this.listPreview.Location = new System.Drawing.Point(0, 0);
            this.listPreview.Name = "listPreview";
            this.listPreview.Size = new System.Drawing.Size(832, 524);
            this.listPreview.TabIndex = 0;
            // 
            // checkSelectAll
            // 
            this.checkSelectAll.AutoSize = true;
            this.checkSelectAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSelectAll.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkSelectAll.LinkColor = System.Drawing.Color.DodgerBlue;
            this.checkSelectAll.Location = new System.Drawing.Point(2, 7);
            this.checkSelectAll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.checkSelectAll.Name = "checkSelectAll";
            this.checkSelectAll.Size = new System.Drawing.Size(75, 21);
            this.checkSelectAll.TabIndex = 87;
            this.checkSelectAll.TabStop = true;
            this.checkSelectAll.Tag = "themeable";
            this.checkSelectAll.Text = "Select all";
            this.checkSelectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.checkSelectAll_LinkClicked);
            // 
            // CleanPreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(834, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MinimizeBox = false;
            this.Name = "CleanPreviewForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clean Preview";
            this.Load += new System.EventHandler(this.CleanPreviewForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelBackup;
        private System.Windows.Forms.Button cleanDriveB;
        private ColoredCheckList listPreview;
        private System.Windows.Forms.LinkLabel checkSelectAll;
    }
}