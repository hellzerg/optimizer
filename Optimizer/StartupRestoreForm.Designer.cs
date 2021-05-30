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
            this.label5 = new System.Windows.Forms.Label();
            this.listRestoreItems = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button39 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNoBackups = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(7, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 28);
            this.label5.TabIndex = 4;
            this.label5.Tag = "themeable";
            this.label5.Text = "Restore your startup items";
            // 
            // listRestoreItems
            // 
            this.listRestoreItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listRestoreItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listRestoreItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listRestoreItems.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRestoreItems.ForeColor = System.Drawing.Color.White;
            this.listRestoreItems.FormattingEnabled = true;
            this.listRestoreItems.ItemHeight = 21;
            this.listRestoreItems.Location = new System.Drawing.Point(0, 0);
            this.listRestoreItems.Name = "listRestoreItems";
            this.listRestoreItems.Size = new System.Drawing.Size(404, 383);
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
            this.panel1.Size = new System.Drawing.Size(406, 385);
            this.panel1.TabIndex = 6;
            // 
            // button39
            // 
            this.button39.BackColor = System.Drawing.Color.DodgerBlue;
            this.button39.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button39.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button39.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button39.ForeColor = System.Drawing.Color.White;
            this.button39.Location = new System.Drawing.Point(423, 50);
            this.button39.Margin = new System.Windows.Forms.Padding(2);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(102, 31);
            this.button39.TabIndex = 31;
            this.button39.Text = "Preview";
            this.button39.UseVisualStyleBackColor = false;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(423, 85);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 31);
            this.button1.TabIndex = 32;
            this.button1.Text = "Restore";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(423, 404);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 31);
            this.button2.TabIndex = 33;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNoBackups
            // 
            this.txtNoBackups.BackColor = System.Drawing.Color.Transparent;
            this.txtNoBackups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNoBackups.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoBackups.ForeColor = System.Drawing.Color.Gold;
            this.txtNoBackups.Location = new System.Drawing.Point(0, 0);
            this.txtNoBackups.Name = "txtNoBackups";
            this.txtNoBackups.Size = new System.Drawing.Size(404, 383);
            this.txtNoBackups.TabIndex = 168;
            this.txtNoBackups.Text = "No backups found";
            this.txtNoBackups.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtNoBackups.Visible = false;
            // 
            // StartupRestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(536, 447);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
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

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listRestoreItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label txtNoBackups;
    }
}