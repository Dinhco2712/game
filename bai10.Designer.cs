
namespace phandinhco2122110336
{
    partial class bai10
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
            this.tbDisplay = new System.Windows.Forms.RichTextBox();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btdot = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(12, 12);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(306, 55);
            this.tbDisplay.TabIndex = 0;
            this.tbDisplay.Text = "";
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(12, 86);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(72, 71);
            this.bt0.TabIndex = 1;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(90, 86);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(72, 71);
            this.bt1.TabIndex = 2;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(168, 86);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(72, 71);
            this.bt2.TabIndex = 3;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(246, 86);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(72, 71);
            this.bt3.TabIndex = 4;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // btdot
            // 
            this.btdot.Location = new System.Drawing.Point(168, 163);
            this.btdot.Name = "btdot";
            this.btdot.Size = new System.Drawing.Size(72, 71);
            this.btdot.TabIndex = 5;
            this.btdot.Text = ".";
            this.btdot.UseVisualStyleBackColor = true;
            this.btdot.Click += new System.EventHandler(this.btdot_Click);
            // 
            // btMul
            // 
            this.btMul.Location = new System.Drawing.Point(90, 163);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(72, 71);
            this.btMul.TabIndex = 6;
            this.btMul.Text = "*";
            this.btMul.UseVisualStyleBackColor = true;
            this.btMul.Click += new System.EventHandler(this.btMul_Click);
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(12, 163);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(72, 71);
            this.btPlus.TabIndex = 7;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btEquals
            // 
            this.btEquals.Location = new System.Drawing.Point(246, 163);
            this.btEquals.Name = "btEquals";
            this.btEquals.Size = new System.Drawing.Size(72, 71);
            this.btEquals.TabIndex = 8;
            this.btEquals.Text = "=";
            this.btEquals.UseVisualStyleBackColor = true;
            this.btEquals.Click += new System.EventHandler(this.btEquals_Click);
            // 
            // bai10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 252);
            this.Controls.Add(this.btEquals);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.btdot);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.tbDisplay);
            this.Name = "bai10";
            this.Text = "bai10";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbDisplay;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btdot;
        private System.Windows.Forms.Button btMul;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btEquals;
    }
}