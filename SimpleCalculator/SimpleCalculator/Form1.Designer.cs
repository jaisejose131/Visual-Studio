namespace SimpleCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtResult1 = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.btnMultiply1 = new System.Windows.Forms.Button();
            this.txtOperand3 = new System.Windows.Forms.TextBox();
            this.txtResult2 = new System.Windows.Forms.TextBox();
            this.txtOperand4 = new System.Windows.Forms.TextBox();
            this.txtOperand5 = new System.Windows.Forms.TextBox();
            this.txtResult3 = new System.Windows.Forms.TextBox();
            this.btnMultiply2 = new System.Windows.Forms.Button();
            this.txtOperand6 = new System.Windows.Forms.TextBox();
            this.txtOperand7 = new System.Windows.Forms.TextBox();
            this.txtOperand8 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtOperand1
            // 
            this.txtOperand1.BackColor = System.Drawing.SystemColors.Info;
            this.txtOperand1.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperand1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtOperand1.Location = new System.Drawing.Point(300, 304);
            this.txtOperand1.MaxLength = 3276;
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(168, 31);
            this.txtOperand1.TabIndex = 4;
            this.txtOperand1.Text = "0.00";
            this.txtOperand1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOperand1.TextChanged += new System.EventHandler(this.txtOperand1_TextChanged);
            this.txtOperand1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOperand1_KeyPress);
            this.txtOperand1.Leave += new System.EventHandler(this.txtOperand1_Leave);
            // 
            // txtResult1
            // 
            this.txtResult1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtResult1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult1.Location = new System.Drawing.Point(297, 558);
            this.txtResult1.Name = "txtResult1";
            this.txtResult1.ReadOnly = true;
            this.txtResult1.Size = new System.Drawing.Size(171, 33);
            this.txtResult1.TabIndex = 0;
            this.txtResult1.TabStop = false;
            this.txtResult1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOperand2
            // 
            this.txtOperand2.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperand2.Location = new System.Drawing.Point(300, 363);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(168, 31);
            this.txtOperand2.TabIndex = 5;
            this.txtOperand2.Text = "0.00";
            this.txtOperand2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOperand2.TextChanged += new System.EventHandler(this.txtOperand2_TextChanged);
            this.txtOperand2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOperand2_KeyPress);
            this.txtOperand2.Leave += new System.EventHandler(this.txtOperand2_Leave);
            // 
            // btnMultiply1
            // 
            this.btnMultiply1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMultiply1.BackColor = System.Drawing.SystemColors.Window;
            this.btnMultiply1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply1.Location = new System.Drawing.Point(180, 477);
            this.btnMultiply1.Name = "btnMultiply1";
            this.btnMultiply1.Size = new System.Drawing.Size(251, 58);
            this.btnMultiply1.TabIndex = 7;
            this.btnMultiply1.Text = "CALCULATE";
            this.btnMultiply1.UseVisualStyleBackColor = false;
            this.btnMultiply1.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // txtOperand3
            // 
            this.txtOperand3.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperand3.Location = new System.Drawing.Point(300, 423);
            this.txtOperand3.Name = "txtOperand3";
            this.txtOperand3.Size = new System.Drawing.Size(168, 31);
            this.txtOperand3.TabIndex = 6;
            this.txtOperand3.Text = "50";
            this.txtOperand3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOperand3.TextChanged += new System.EventHandler(this.txtOperand3_TextChanged);
            // 
            // txtResult2
            // 
            this.txtResult2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtResult2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult2.Location = new System.Drawing.Point(297, 622);
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.ReadOnly = true;
            this.txtResult2.Size = new System.Drawing.Size(171, 33);
            this.txtResult2.TabIndex = 0;
            this.txtResult2.TabStop = false;
            this.txtResult2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOperand4
            // 
            this.txtOperand4.BackColor = System.Drawing.SystemColors.Info;
            this.txtOperand4.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperand4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtOperand4.Location = new System.Drawing.Point(865, 296);
            this.txtOperand4.MaxLength = 3276;
            this.txtOperand4.Name = "txtOperand4";
            this.txtOperand4.Size = new System.Drawing.Size(69, 31);
            this.txtOperand4.TabIndex = 9;
            this.txtOperand4.Text = "0.00";
            this.txtOperand4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOperand4.TextChanged += new System.EventHandler(this.txtOperand4_TextChanged);
            // 
            // txtOperand5
            // 
            this.txtOperand5.BackColor = System.Drawing.SystemColors.Info;
            this.txtOperand5.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperand5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtOperand5.Location = new System.Drawing.Point(985, 296);
            this.txtOperand5.MaxLength = 3276;
            this.txtOperand5.Name = "txtOperand5";
            this.txtOperand5.Size = new System.Drawing.Size(70, 31);
            this.txtOperand5.TabIndex = 10;
            this.txtOperand5.Text = "0.00";
            this.txtOperand5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOperand5.TextChanged += new System.EventHandler(this.txtOperand5_TextChanged);
            // 
            // txtResult3
            // 
            this.txtResult3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtResult3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult3.Location = new System.Drawing.Point(865, 506);
            this.txtResult3.Name = "txtResult3";
            this.txtResult3.ReadOnly = true;
            this.txtResult3.Size = new System.Drawing.Size(171, 33);
            this.txtResult3.TabIndex = 0;
            this.txtResult3.TabStop = false;
            this.txtResult3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMultiply2
            // 
            this.btnMultiply2.BackColor = System.Drawing.SystemColors.Info;
            this.btnMultiply2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply2.Location = new System.Drawing.Point(738, 422);
            this.btnMultiply2.Name = "btnMultiply2";
            this.btnMultiply2.Size = new System.Drawing.Size(251, 58);
            this.btnMultiply2.TabIndex = 12;
            this.btnMultiply2.Text = "CALCULATE";
            this.btnMultiply2.UseVisualStyleBackColor = false;
            this.btnMultiply2.Click += new System.EventHandler(this.btnMultiply2_Click);
            // 
            // txtOperand6
            // 
            this.txtOperand6.BackColor = System.Drawing.SystemColors.Info;
            this.txtOperand6.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperand6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtOperand6.Location = new System.Drawing.Point(865, 357);
            this.txtOperand6.MaxLength = 3276;
            this.txtOperand6.Name = "txtOperand6";
            this.txtOperand6.Size = new System.Drawing.Size(171, 31);
            this.txtOperand6.TabIndex = 11;
            this.txtOperand6.Text = "550";
            this.txtOperand6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOperand6.TextChanged += new System.EventHandler(this.txtOperand6_TextChanged);
            // 
            // txtOperand7
            // 
            this.txtOperand7.BackColor = System.Drawing.SystemColors.Info;
            this.txtOperand7.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperand7.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtOperand7.Location = new System.Drawing.Point(300, 244);
            this.txtOperand7.MaxLength = 3276;
            this.txtOperand7.Name = "txtOperand7";
            this.txtOperand7.Size = new System.Drawing.Size(168, 31);
            this.txtOperand7.TabIndex = 3;
            this.txtOperand7.Text = "1";
            this.txtOperand7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOperand7.TextChanged += new System.EventHandler(this.txtOperand7_TextChanged);
            // 
            // txtOperand8
            // 
            this.txtOperand8.BackColor = System.Drawing.SystemColors.Info;
            this.txtOperand8.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperand8.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtOperand8.Location = new System.Drawing.Point(865, 237);
            this.txtOperand8.MaxLength = 3276;
            this.txtOperand8.Name = "txtOperand8";
            this.txtOperand8.Size = new System.Drawing.Size(168, 31);
            this.txtOperand8.TabIndex = 8;
            this.txtOperand8.Text = "1";
            this.txtOperand8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOperand8.TextChanged += new System.EventHandler(this.txtOperand8_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1101, 668);
            this.Controls.Add(this.txtOperand8);
            this.Controls.Add(this.txtOperand7);
            this.Controls.Add(this.txtOperand6);
            this.Controls.Add(this.btnMultiply2);
            this.Controls.Add(this.txtResult3);
            this.Controls.Add(this.txtOperand5);
            this.Controls.Add(this.txtOperand4);
            this.Controls.Add(this.txtResult2);
            this.Controls.Add(this.txtOperand3);
            this.Controls.Add(this.btnMultiply1);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtResult1);
            this.Controls.Add(this.txtOperand1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CNC Calculator- v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.TextBox txtResult1;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.Button btnMultiply1;
        private System.Windows.Forms.TextBox txtOperand3;
        private System.Windows.Forms.TextBox txtResult2;
        private System.Windows.Forms.TextBox txtOperand4;
        private System.Windows.Forms.TextBox txtOperand5;
        private System.Windows.Forms.TextBox txtResult3;
        private System.Windows.Forms.Button btnMultiply2;
        private System.Windows.Forms.TextBox txtOperand6;
        private System.Windows.Forms.TextBox txtOperand7;
        private System.Windows.Forms.TextBox txtOperand8;
    }
}

