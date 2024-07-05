namespace DateTimeChecker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(163, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Time Checker";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(1, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(189, 90);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(149, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Day";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(254, 147);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(328, 31);
            this.txtDay.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(149, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Month";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(254, 192);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(328, 31);
            this.txtMonth.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(149, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(254, 238);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(328, 31);
            this.txtYear.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(254, 286);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 34);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(470, 286);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(112, 34);
            this.btnCheck.TabIndex = 9;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Date Time Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheck;
    }
}
