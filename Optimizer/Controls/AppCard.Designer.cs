
namespace Optimizer
{
    partial class AppCard
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
            this.appTitle = new Optimizer.MoonCheck();
            this.appImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.appImage)).BeginInit();
            this.SuspendLayout();
            // 
            // appTitle
            // 
            this.appTitle.AutoSize = true;
            this.appTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.appTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appTitle.Location = new System.Drawing.Point(36, 4);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(89, 24);
            this.appTitle.TabIndex = 165;
            this.appTitle.Text = "App Title";
            this.appTitle.UseVisualStyleBackColor = true;
            // 
            // appImage
            // 
            this.appImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.appImage.Location = new System.Drawing.Point(6, 4);
            this.appImage.Name = "appImage";
            this.appImage.Size = new System.Drawing.Size(24, 24);
            this.appImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appImage.TabIndex = 166;
            this.appImage.TabStop = false;
            // 
            // AppCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.appTitle);
            this.Controls.Add(this.appImage);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AppCard";
            this.Size = new System.Drawing.Size(172, 33);
            ((System.ComponentModel.ISupportInitialize)(this.appImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal MoonCheck appTitle;
        internal System.Windows.Forms.PictureBox appImage;
    }
}
