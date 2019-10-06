namespace Mackay_Nel_Task1
{
    partial class Form1
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
            this.grpMap = new System.Windows.Forms.GroupBox();
            this.roundLbl = new System.Windows.Forms.Label();
            this.startbttn = new System.Windows.Forms.Button();
            this.puasebttn = new System.Windows.Forms.Button();
            this.infoTxtBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveBttn = new System.Windows.Forms.Button();
            this.loadBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grpMap
            // 
            this.grpMap.Location = new System.Drawing.Point(35, 41);
            this.grpMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMap.Name = "grpMap";
            this.grpMap.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMap.Size = new System.Drawing.Size(618, 548);
            this.grpMap.TabIndex = 0;
            this.grpMap.TabStop = false;
            this.grpMap.Text = "groupBox1";
            // 
            // roundLbl
            // 
            this.roundLbl.AutoSize = true;
            this.roundLbl.Location = new System.Drawing.Point(659, 57);
            this.roundLbl.Name = "roundLbl";
            this.roundLbl.Size = new System.Drawing.Size(50, 17);
            this.roundLbl.TabIndex = 1;
            this.roundLbl.Text = "Round";
            // 
            // startbttn
            // 
            this.startbttn.Location = new System.Drawing.Point(404, 593);
            this.startbttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startbttn.Name = "startbttn";
            this.startbttn.Size = new System.Drawing.Size(101, 46);
            this.startbttn.TabIndex = 2;
            this.startbttn.Text = "Start";
            this.startbttn.UseVisualStyleBackColor = true;
            this.startbttn.Click += new System.EventHandler(this.startbttn_Click);
            // 
            // puasebttn
            // 
            this.puasebttn.Location = new System.Drawing.Point(511, 593);
            this.puasebttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.puasebttn.Name = "puasebttn";
            this.puasebttn.Size = new System.Drawing.Size(101, 46);
            this.puasebttn.TabIndex = 2;
            this.puasebttn.Text = "Pause";
            this.puasebttn.UseVisualStyleBackColor = true;
            this.puasebttn.Click += new System.EventHandler(this.puasebttn_Click);
            // 
            // infoTxtBox
            // 
            this.infoTxtBox.Location = new System.Drawing.Point(662, 76);
            this.infoTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoTxtBox.Multiline = true;
            this.infoTxtBox.Name = "infoTxtBox";
            this.infoTxtBox.Size = new System.Drawing.Size(268, 301);
            this.infoTxtBox.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saveBttn
            // 
            this.saveBttn.Location = new System.Drawing.Point(750, 397);
            this.saveBttn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBttn.Name = "saveBttn";
            this.saveBttn.Size = new System.Drawing.Size(141, 48);
            this.saveBttn.TabIndex = 4;
            this.saveBttn.Text = "Save";
            this.saveBttn.UseVisualStyleBackColor = true;
            this.saveBttn.Click += new System.EventHandler(this.saveBttn_Click);
            // 
            // loadBttn
            // 
            this.loadBttn.Location = new System.Drawing.Point(750, 452);
            this.loadBttn.Margin = new System.Windows.Forms.Padding(4);
            this.loadBttn.Name = "loadBttn";
            this.loadBttn.Size = new System.Drawing.Size(141, 48);
            this.loadBttn.TabIndex = 4;
            this.loadBttn.Text = "Load";
            this.loadBttn.UseVisualStyleBackColor = true;
            this.loadBttn.Click += new System.EventHandler(this.loadBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 660);
            this.Controls.Add(this.loadBttn);
            this.Controls.Add(this.saveBttn);
            this.Controls.Add(this.infoTxtBox);
            this.Controls.Add(this.puasebttn);
            this.Controls.Add(this.startbttn);
            this.Controls.Add(this.roundLbl);
            this.Controls.Add(this.grpMap);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMap;
        private System.Windows.Forms.Label roundLbl;
        private System.Windows.Forms.Button startbttn;
        private System.Windows.Forms.Button puasebttn;
        private System.Windows.Forms.TextBox infoTxtBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button saveBttn;
        private System.Windows.Forms.Button loadBttn;
    }
}

