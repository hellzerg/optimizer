namespace Optimizer
{
    partial class StartupRestoreForm
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
            this.backupL = new System.Windows.Forms.Label();
            this.listRestoreItems = new Optimizer.MoonList();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNoBackups = new System.Windows.Forms.Label();
            this.previewBackupB = new System.Windows.Forms.Button();
            this.restoreBackupB = new System.Windows.Forms.Button();
            this.deleteBackupB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backupL
            // 
            this.backupL.AutoSize = true;
            this.backupL.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.backupL.Location = new System.Drawing.Point(7, 9);
            this.backupL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.backupL.Name = "backupL";
            this.backupL.Size = new System.Drawing.Size(254, 28);
            this.backupL.TabIndex = 4;
            this.backupL.Tag = "themeable";
            this.backupL.Text = "Restore your startup items";
            // 
            // listRestoreItems
            // 
            this.listRestoreItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listRestoreItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listRestoreItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listRestoreItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listRestoreItems.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRestoreItems.ForeColor = System.Drawing.Color.White;
            this.listRestoreItems.FormattingEnabled = true;
            this.listRestoreItems.ItemHeight = 21;
            this.listRestoreItems.Location = new System.Drawing.Point(0, 0);
            this.listRestoreItems.Name = "listRestoreItems";
            this.listRestoreItems.Size = new System.Drawing.Size(364, 383);
            this.listRestoreItems.TabIndex = 5;
            this.listRestoreItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listRestoreItems_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtNoBackups);
            this.panel1.Controls.Add(this.listRestoreItems);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 385);
            this.panel1.TabIndex = 6;
            // 
            // txtNoBackups
            // 
            this.txtNoBackups.BackColor = System.Drawing.Color.Transparent;
            this.txtNoBackups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNoBackups.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoBackups.ForeColor = System.Drawing.Color.Gold;
            this.txtNoBackups.Location = new System.Drawing.Point(0, 0);
            this.txtNoBackups.Name = "txtNoBackups";
            this.txtNoBackups.Size = new System.Drawing.Size(364, 383);
            this.txtNoBackups.TabIndex = 168;
            this.txtNoBackups.Text = "No backups found";
            this.txtNoBackups.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtNoBackups.Visible = false;
            // 
            // previewBackupB
            // 
            this.previewBackupB.BackColor = System.Drawing.Color.DodgerBlue;
            this.previewBackupB.FlatAppearance.BorderSize = 0;
            this.previewBackupB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.previewBackupB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.previewBackupB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previewBackupB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewBackupB.ForeColor = System.Drawing.Color.White;
            this.previewBackupB.Location = new System.Drawing.Point(383, 50);
            this.previewBackupB.Margin = new System.Windows.Forms.Padding(2);
            this.previewBackupB.Name = "previewBackupB";
            this.previewBackupB.Size = new System.Drawing.Size(209, 31);
            this.previewBackupB.TabIndex = 31;
            this.previewBackupB.Text = "Preview";
            this.previewBackupB.UseVisualStyleBackColor = false;
            this.previewBackupB.Click += new System.EventHandler(this.button39_Click);
            // 
            // restoreBackupB
            // 
            this.restoreBackupB.BackColor = System.Drawing.Color.DodgerBlue;
            this.restoreBackupB.FlatAppearance.BorderSize = 0;
            this.restoreBackupB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.restoreBackupB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.restoreBackupB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreBackupB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreBackupB.ForeColor = System.Drawing.Color.White;
            this.restoreBackupB.Location = new System.Drawing.Point(383, 85);
            this.restoreBackupB.Margin = new System.Windows.Forms.Padding(2);
            this.restoreBackupB.Name = "restoreBackupB";
            this.restoreBackupB.Size = new System.Drawing.Size(209, 31);
            this.restoreBackupB.TabIndex = 32;
            this.restoreBackupB.Text = "Restore";
            this.restoreBackupB.UseVisualStyleBackColor = false;
            this.restoreBackupB.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteBackupB
            // 
            this.deleteBackupB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteBackupB.BackColor = System.Drawing.Color.DodgerBlue;
            this.deleteBackupB.FlatAppearance.BorderSize = 0;
            this.deleteBackupB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.deleteBackupB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.deleteBackupB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBackupB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBackupB.ForeColor = System.Drawing.Color.White;
            this.deleteBackupB.Location = new System.Drawing.Point(383, 404);
            this.deleteBackupB.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBackupB.Name = "deleteBackupB";
            this.deleteBackupB.Size = new System.Drawing.Size(209, 31);
            this.deleteBackupB.TabIndex = 33;
            this.deleteBackupB.Text = "Delete";
            this.deleteBackupB.UseVisualStyleBackColor = false;
            this.deleteBackupB.Click += new System.EventHandler(this.button2_Click);
            // 
            // StartupRestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(603, 447);
            this.Controls.Add(this.deleteBackupB);
            this.Controls.Add(this.restoreBackupB);
            this.Controls.Add(this.previewBackupB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backupL);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(552, 486);
            this.Name = "StartupRestoreForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restore Startup Items";
            this.Load += new System.EventHandler(this.StartupRestoreForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label backupL;
        private MoonList listRestoreItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button previewBackupB;
        private System.Windows.Forms.Button restoreBackupB;
        private System.Windows.Forms.Button deleteBackupB;
        private System.Windows.Forms.Label txtNoBackups;
    }
}