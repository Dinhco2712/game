
namespace phandinhco2122110336
{
    partial class bai11
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btMC = new System.Windows.Forms.Button();
            this.btMR = new System.Windows.Forms.Button();
            this.btMS = new System.Windows.Forms.Button();
            this.btMplus = new System.Windows.Forms.Button();
            this.btMdivision = new System.Windows.Forms.Button();
            this.btSqrt = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btCE = new System.Windows.Forms.Button();
            this.btBackspace = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btPartX = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(424, 49);
            this.txtDisplay.TabIndex = 2;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDisplay_KeyPress);
            // 
            // btMC
            // 
            this.btMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btMC.Location = new System.Drawing.Point(12, 67);
            this.btMC.Name = "btMC";
            this.btMC.Size = new System.Drawing.Size(80, 60);
            this.btMC.TabIndex = 2;
            this.btMC.Text = "MC";
            this.btMC.UseVisualStyleBackColor = true;
            this.btMC.Click += new System.EventHandler(this.Button_Click);
            // 
            // btMR
            // 
            this.btMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btMR.Location = new System.Drawing.Point(98, 67);
            this.btMR.Name = "btMR";
            this.btMR.Size = new System.Drawing.Size(80, 60);
            this.btMR.TabIndex = 2;
            this.btMR.Text = "MR";
            this.btMR.UseVisualStyleBackColor = true;
            this.btMR.Click += new System.EventHandler(this.Button_Click);
            // 
            // btMS
            // 
            this.btMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btMS.Location = new System.Drawing.Point(184, 67);
            this.btMS.Name = "btMS";
            this.btMS.Size = new System.Drawing.Size(80, 60);
            this.btMS.TabIndex = 3;
            this.btMS.Text = "MS";
            this.btMS.UseVisualStyleBackColor = true;
            this.btMS.Click += new System.EventHandler(this.Button_Click);
            // 
            // btMplus
            // 
            this.btMplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btMplus.Location = new System.Drawing.Point(270, 67);
            this.btMplus.Name = "btMplus";
            this.btMplus.Size = new System.Drawing.Size(80, 60);
            this.btMplus.TabIndex = 4;
            this.btMplus.Text = "M+";
            this.btMplus.UseVisualStyleBackColor = true;
            this.btMplus.Click += new System.EventHandler(this.Button_Click);
            // 
            // btMdivision
            // 
            this.btMdivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btMdivision.Location = new System.Drawing.Point(356, 67);
            this.btMdivision.Name = "btMdivision";
            this.btMdivision.Size = new System.Drawing.Size(80, 60);
            this.btMdivision.TabIndex = 5;
            this.btMdivision.Text = "M-";
            this.btMdivision.UseVisualStyleBackColor = true;
            this.btMdivision.Click += new System.EventHandler(this.Button_Click);
            // 
            // btSqrt
            // 
            this.btSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSqrt.Location = new System.Drawing.Point(356, 133);
            this.btSqrt.Name = "btSqrt";
            this.btSqrt.Size = new System.Drawing.Size(80, 60);
            this.btSqrt.TabIndex = 10;
            this.btSqrt.Text = "√";
            this.btSqrt.UseVisualStyleBackColor = true;
            this.btSqrt.Click += new System.EventHandler(this.Button_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button7.Location = new System.Drawing.Point(270, 133);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 60);
            this.button7.TabIndex = 9;
            this.button7.Text = "±";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button_Click);
            // 
            // btC
            // 
            this.btC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btC.Location = new System.Drawing.Point(184, 133);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(80, 60);
            this.btC.TabIndex = 8;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = true;
            this.btC.Click += new System.EventHandler(this.Button_Click);
            // 
            // btCE
            // 
            this.btCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btCE.Location = new System.Drawing.Point(98, 133);
            this.btCE.Name = "btCE";
            this.btCE.Size = new System.Drawing.Size(80, 60);
            this.btCE.TabIndex = 7;
            this.btCE.Text = "CE";
            this.btCE.UseVisualStyleBackColor = true;
            this.btCE.Click += new System.EventHandler(this.Button_Click);
            // 
            // btBackspace
            // 
            this.btBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btBackspace.Location = new System.Drawing.Point(12, 133);
            this.btBackspace.Name = "btBackspace";
            this.btBackspace.Size = new System.Drawing.Size(80, 60);
            this.btBackspace.TabIndex = 6;
            this.btBackspace.Text = "←";
            this.btBackspace.UseVisualStyleBackColor = true;
            this.btBackspace.Click += new System.EventHandler(this.Button_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button11.Location = new System.Drawing.Point(270, 265);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(80, 60);
            this.button11.TabIndex = 15;
            this.button11.Text = "*";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.divide.Location = new System.Drawing.Point(270, 199);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(80, 60);
            this.divide.TabIndex = 14;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.Button_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button13.Location = new System.Drawing.Point(184, 199);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(80, 60);
            this.button13.TabIndex = 13;
            this.button13.Text = "9";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Button_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button14.Location = new System.Drawing.Point(98, 199);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(80, 60);
            this.button14.TabIndex = 12;
            this.button14.Text = "8";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Button_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button15.Location = new System.Drawing.Point(12, 199);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(80, 60);
            this.button15.TabIndex = 11;
            this.button15.Text = "7";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Button_Click);
            // 
            // btPartX
            // 
            this.btPartX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btPartX.Location = new System.Drawing.Point(356, 265);
            this.btPartX.Name = "btPartX";
            this.btPartX.Size = new System.Drawing.Size(80, 60);
            this.btPartX.TabIndex = 1;
            this.btPartX.Text = "1/x";
            this.btPartX.UseVisualStyleBackColor = true;
            this.btPartX.Click += new System.EventHandler(this.Button_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button17.Location = new System.Drawing.Point(356, 199);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(80, 60);
            this.button17.TabIndex = 19;
            this.button17.Text = "%";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.Button_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button18.Location = new System.Drawing.Point(184, 265);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(80, 60);
            this.button18.TabIndex = 18;
            this.button18.Text = "6";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.Button_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button19.Location = new System.Drawing.Point(98, 265);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(80, 60);
            this.button19.TabIndex = 17;
            this.button19.Text = "5";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.Button_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button20.Location = new System.Drawing.Point(12, 265);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(80, 60);
            this.button20.TabIndex = 16;
            this.button20.Text = "4";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.Button_Click);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button22.Location = new System.Drawing.Point(270, 331);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(80, 60);
            this.button22.TabIndex = 24;
            this.button22.Text = "-";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.Button_Click);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button23.Location = new System.Drawing.Point(184, 331);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(80, 60);
            this.button23.TabIndex = 23;
            this.button23.Text = "3";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.Button_Click);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button24.Location = new System.Drawing.Point(98, 331);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(80, 60);
            this.button24.TabIndex = 22;
            this.button24.Text = "2";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.Button_Click);
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button25.Location = new System.Drawing.Point(12, 331);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(80, 60);
            this.button25.TabIndex = 21;
            this.button25.Text = "1";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.Button_Click);
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button26.Location = new System.Drawing.Point(356, 331);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(80, 126);
            this.button26.TabIndex = 2;
            this.button26.Text = "=";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.Button_Click);
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button27.Location = new System.Drawing.Point(270, 397);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(80, 60);
            this.button27.TabIndex = 29;
            this.button27.Text = "+";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.Button_Click);
            // 
            // button28
            // 
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button28.Location = new System.Drawing.Point(184, 396);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(80, 60);
            this.button28.TabIndex = 28;
            this.button28.Text = ".";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.Button_Click);
            // 
            // bt0
            // 
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt0.Location = new System.Drawing.Point(12, 397);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(166, 60);
            this.bt0.TabIndex = 26;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.Button_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // bai11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 468);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.btPartX);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.btSqrt);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.btCE);
            this.Controls.Add(this.btBackspace);
            this.Controls.Add(this.btMdivision);
            this.Controls.Add(this.btMplus);
            this.Controls.Add(this.btMS);
            this.Controls.Add(this.btMR);
            this.Controls.Add(this.btMC);
            this.Controls.Add(this.txtDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "bai11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Caculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btMC;
        private System.Windows.Forms.Button btMR;
        private System.Windows.Forms.Button btMS;
        private System.Windows.Forms.Button btMplus;
        private System.Windows.Forms.Button btMdivision;
        private System.Windows.Forms.Button btSqrt;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btCE;
        private System.Windows.Forms.Button btBackspace;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btPartX;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button bt0;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}

