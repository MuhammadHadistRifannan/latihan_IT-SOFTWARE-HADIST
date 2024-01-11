
namespace latihanCRUD1
{
    partial class LoadingFormcs
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
            this.components = new System.ComponentModel.Container();
            this.loading_bar = new System.Windows.Forms.Panel();
            this.handle = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loading_title = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.loading_bar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loading_bar
            // 
            this.loading_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loading_bar.Controls.Add(this.handle);
            this.loading_bar.Location = new System.Drawing.Point(103, 217);
            this.loading_bar.Name = "loading_bar";
            this.loading_bar.Size = new System.Drawing.Size(590, 38);
            this.loading_bar.TabIndex = 0;
            // 
            // handle
            // 
            this.handle.BackColor = System.Drawing.Color.Cyan;
            this.handle.Location = new System.Drawing.Point(0, 0);
            this.handle.Name = "handle";
            this.handle.Size = new System.Drawing.Size(10, 41);
            this.handle.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.loading_title);
            this.panel2.Location = new System.Drawing.Point(103, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 98);
            this.panel2.TabIndex = 1;
            // 
            // loading_title
            // 
            this.loading_title.AutoSize = true;
            this.loading_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loading_title.Location = new System.Drawing.Point(37, 23);
            this.loading_title.Name = "loading_title";
            this.loading_title.Size = new System.Drawing.Size(247, 55);
            this.loading_title.TabIndex = 0;
            this.loading_title.Text = "LOADING";
            this.loading_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // update
            // 
            this.update.Enabled = true;
            this.update.Interval = 1000;
            this.update.Tick += new System.EventHandler(this.Loading);
            // 
            // LoadingFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.loading_bar);
            this.Name = "LoadingFormcs";
            this.Text = "LoadingFormcs";
            this.loading_bar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loading_bar;
        private System.Windows.Forms.Panel handle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label loading_title;
        private System.Windows.Forms.Timer update;
    }
}