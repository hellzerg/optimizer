
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
            this.Label.AutoEllipsis = true;
            this.Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label.Location = new System.Drawing.Point(0, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(266, 32);
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label.TabIndex = 1;
            this.Label.Text = "label1";
            this.Label.Click += new System.EventHandler(this.Label_Click);
            this.Label.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            this.Label.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            this.Label.MouseHover += new System.EventHandler(this.Label_MouseHover);
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.Label);
            this.Panel.Controls.Add(this.Toggle);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(14, 4);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(312, 32);
            this.Panel.TabIndex = 0;
            // 
            // Toggle
            // 
            this.Toggle.Dock = System.Windows.Forms.DockStyle.Right;
            this.Toggle.Location = new System.Drawing.Point(266, 0);
            this.Toggle.MinimumSize = new System.Drawing.Size(46, 22);
            this.Toggle.Name = "Toggle";
            this.Toggle.Size = new System.Drawing.Size(46, 32);
            this.Toggle.TabIndex = 2;
            this.Toggle.UseVisualStyleBackColor = true;
            this.Toggle.CheckedChanged += new System.EventHandler(this.Toggle_CheckedChanged);
            // 
            // ToggleCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.Panel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Name = "ToggleCard";
            this.Padding = new System.Windows.Forms.Padding(14, 4, 8, 4);
            this.Size = new System.Drawing.Size(334, 40);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel;
        internal System.Windows.Forms.Label Label;
        internal MoonToggle Toggle;
    }
}
