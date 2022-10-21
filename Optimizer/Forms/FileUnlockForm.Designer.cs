namespace Optimizer
{
    partial class FileUnlockForm
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
            this.txtFile = new System.Windows.Forms.TextBox();
            this.radioFile = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.panelModernAppsList = new System.Windows.Forms.Panel();
            this.listProcesses = new Optimizer.MoonCheckList();
            this.btnKill = new System.Windows.Forms.Button();
            this.panelModernAppsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFile.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.ForeColor = System.Drawing.Color.White;
            this.txtFile.Location = new System.Drawing.Point(16, 32);
            this.txtFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(333, 25);
            this.txtFile.TabIndex = 54;
            // 
            // radioFile
            // 
            this.radioFile.AutoSize = true;
            this.radioFile.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFile.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioFile.Location = new System.Drawing.Point(11, 9);
            this.radioFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.radioFile.Name = "radioFile";
            this.radioFile.Size = new System.Drawing.Size(34, 19);
            this.radioFile.TabIndex = 55;
            this.radioFile.Tag = "themeable";
            this.radioFile.Text = "File:";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(353, 32);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(50, 25);
            this.btnFind.TabIndex = 58;
            this.btnFind.Text = "✓";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // panelModernAppsList
            // 
            this.panelModernAppsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelModernAppsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelModernAppsList.Controls.Add(this.listProcesses);
            this.panelModernAppsList.Location = new System.Drawing.Point(16, 74);
            this.panelModernAppsList.Name = "panelModernAppsList";
            this.panelModernAppsList.Size = new System.Drawing.Size(387, 292);
            this.panelModernAppsList.TabIndex = 59;
            // 
            // listProcesses
            // 
            this.listProcesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listProcesses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listProcesses.CheckOnClick = true;
            this.listProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listProcesses.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listProcesses.ForeColor = System.Drawing.Color.White;
            this.listProcesses.FormattingEnabled = true;
            this.listProcesses.HorizontalScrollbar = true;
            this.listProcesses.Location = new System.Drawing.Point(0, 0);
            this.listProcesses.Name = "listProcesses";
            this.listProcesses.Size = new System.Drawing.Size(385, 290);
            this.listProcesses.Sorted = true;
            this.listProcesses.TabIndex = 0;
            // 
            // btnKill
            // 
            this.btnKill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKill.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKill.FlatAppearance.BorderSize = 0;
            this.btnKill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnKill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnKill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKill.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnKill.ForeColor = System.Drawing.Color.White;
            this.btnKill.Location = new System.Drawing.Point(255, 371);
            this.btnKill.Margin = new System.Windows.Forms.Padding(2);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(148, 31);
            this.btnKill.TabIndex = 61;
            this.btnKill.Text = "Kill";
            this.btnKill.UseVisualStyleBackColor = false;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // FileUnlockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(414, 413);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.panelModernAppsList);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.radioFile);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "FileUnlockForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FileUnlockForm_Load);
            this.panelModernAppsList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label radioFile;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Panel panelModernAppsList;
        private MoonCheckList listProcesses;
        private System.Windows.Forms.Button btnKill;
    }
}