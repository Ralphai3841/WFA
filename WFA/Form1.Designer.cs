
namespace WFA
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
            this.btnClick = new System.Windows.Forms.Button();
            this.btnSuccess = new System.Windows.Forms.Button();
            this.btnFail1 = new System.Windows.Forms.Button();
            this.btnFail2 = new System.Windows.Forms.Button();
            this.btnFail3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.Red;
            this.btnClick.Location = new System.Drawing.Point(489, 234);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(229, 82);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.BackColorChanged += new System.EventHandler(this.btnClick_Click);
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // btnSuccess
            // 
            this.btnSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSuccess.Location = new System.Drawing.Point(117, 85);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.Size = new System.Drawing.Size(163, 73);
            this.btnSuccess.TabIndex = 1;
            this.btnSuccess.UseVisualStyleBackColor = false;
            this.btnSuccess.Click += new System.EventHandler(this.btnSuccess_Click);
            // 
            // btnFail1
            // 
            this.btnFail1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFail1.Location = new System.Drawing.Point(842, 85);
            this.btnFail1.Name = "btnFail1";
            this.btnFail1.Size = new System.Drawing.Size(151, 73);
            this.btnFail1.TabIndex = 2;
            this.btnFail1.UseVisualStyleBackColor = false;
            this.btnFail1.Click += new System.EventHandler(this.btnFail1_Click);
            // 
            // btnFail2
            // 
            this.btnFail2.BackColor = System.Drawing.Color.Yellow;
            this.btnFail2.Location = new System.Drawing.Point(842, 449);
            this.btnFail2.Name = "btnFail2";
            this.btnFail2.Size = new System.Drawing.Size(151, 61);
            this.btnFail2.TabIndex = 3;
            this.btnFail2.UseVisualStyleBackColor = false;
            this.btnFail2.Click += new System.EventHandler(this.btnFail2_Click);
            // 
            // btnFail3
            // 
            this.btnFail3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFail3.Location = new System.Drawing.Point(117, 437);
            this.btnFail3.Name = "btnFail3";
            this.btnFail3.Size = new System.Drawing.Size(163, 73);
            this.btnFail3.TabIndex = 4;
            this.btnFail3.UseVisualStyleBackColor = false;
            this.btnFail3.Click += new System.EventHandler(this.btnFail3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1293, 595);
            this.Controls.Add(this.btnFail3);
            this.Controls.Add(this.btnFail2);
            this.Controls.Add(this.btnFail1);
            this.Controls.Add(this.btnSuccess);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnSuccess;
        private System.Windows.Forms.Button btnFail1;
        private System.Windows.Forms.Button btnFail2;
        private System.Windows.Forms.Button btnFail3;
    }
}

