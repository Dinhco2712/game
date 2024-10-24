
namespace phandinhco2122110336
{
    partial class bai23
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
            this.btLeft = new System.Windows.Forms.Button();
            this.btFile = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLeft
            // 
            this.btLeft.Location = new System.Drawing.Point(72, 202);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(52, 35);
            this.btLeft.TabIndex = 1;
            this.btLeft.Text = "<-";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(323, 202);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(75, 35);
            this.btFile.TabIndex = 3;
            this.btFile.Text = "File ...";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // btRight
            // 
            this.btRight.Location = new System.Drawing.Point(140, 202);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(52, 35);
            this.btRight.TabIndex = 4;
            this.btRight.Text = "->";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btRight_Click);
            // 
            // bai23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 262);
            this.Controls.Add(this.btRight);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.btLeft);
            this.Name = "bai23";
            this.Text = "bai23";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btFile;
        private System.Windows.Forms.Button btRight;
    }
}