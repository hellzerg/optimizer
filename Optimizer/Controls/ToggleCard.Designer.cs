﻿
namespace Optimizer
{
    partial class ToggleCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.Toggle = new Optimizer.MoonToggle();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(52, 2);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(45, 19);
            this.Label.TabIndex = 1;
            this.Label.Text = "label1";
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.Label);
            this.Panel.Controls.Add(this.Toggle);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(334, 25);
            this.Panel.TabIndex = 2;
            // 
            // Toggle
            // 
            this.Toggle.AutoSize = true;
            this.Toggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Toggle.ForeColor = System.Drawing.Color.White;
            this.Toggle.Location = new System.Drawing.Point(0, 1);
            this.Toggle.MinimumSize = new System.Drawing.Size(46, 22);
            this.Toggle.Name = "Toggle";
            this.Toggle.Size = new System.Drawing.Size(46, 22);
            this.Toggle.TabIndex = 0;
            this.Toggle.UseVisualStyleBackColor = true;
            this.Toggle.CheckedChanged += new System.EventHandler(this.Toggle_CheckedChanged);
            // 
            // ToggleCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.Panel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ToggleCard";
            this.Size = new System.Drawing.Size(334, 25);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel;
        protected internal System.Windows.Forms.Label Label;
        protected internal MoonToggle Toggle;
    }
}
