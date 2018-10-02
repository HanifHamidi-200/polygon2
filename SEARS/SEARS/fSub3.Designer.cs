namespace SEARS
{
    partial class fSub3
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
            this.btnOpen3 = new System.Windows.Forms.Button();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen3
            // 
            this.btnOpen3.BackColor = System.Drawing.Color.Black;
            this.btnOpen3.ForeColor = System.Drawing.Color.White;
            this.btnOpen3.Location = new System.Drawing.Point(50, 161);
            this.btnOpen3.Name = "btnOpen3";
            this.btnOpen3.Size = new System.Drawing.Size(218, 42);
            this.btnOpen3.TabIndex = 11;
            this.btnOpen3.Text = "BotFramework";
            this.btnOpen3.UseVisualStyleBackColor = false;
            this.btnOpen3.Click += new System.EventHandler(this.btnOpen3_Click);
            // 
            // btnOpen2
            // 
            this.btnOpen2.BackColor = System.Drawing.Color.Blue;
            this.btnOpen2.Location = new System.Drawing.Point(50, 113);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(218, 42);
            this.btnOpen2.TabIndex = 10;
            this.btnOpen2.Text = "Phones";
            this.btnOpen2.UseVisualStyleBackColor = false;
            this.btnOpen2.Click += new System.EventHandler(this.btnOpen2_Click);
            // 
            // btnOpen1
            // 
            this.btnOpen1.BackColor = System.Drawing.Color.Red;
            this.btnOpen1.Location = new System.Drawing.Point(50, 65);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(218, 42);
            this.btnOpen1.TabIndex = 9;
            this.btnOpen1.Text = "Drones";
            this.btnOpen1.UseVisualStyleBackColor = false;
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen1_Click);
            // 
            // fSub3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 259);
            this.Controls.Add(this.btnOpen3);
            this.Controls.Add(this.btnOpen2);
            this.Controls.Add(this.btnOpen1);
            this.Name = "fSub3";
            this.Text = "SITES";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen3;
        private System.Windows.Forms.Button btnOpen2;
        private System.Windows.Forms.Button btnOpen1;
    }
}