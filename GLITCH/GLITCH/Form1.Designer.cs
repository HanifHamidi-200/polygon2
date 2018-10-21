namespace GLITCH
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnA1 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnA3 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnA1
            // 
            this.btnA1.BackColor = System.Drawing.Color.Red;
            this.btnA1.Location = new System.Drawing.Point(47, 43);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(102, 115);
            this.btnA1.TabIndex = 0;
            this.btnA1.Text = "TheAlienComputer";
            this.btnA1.UseVisualStyleBackColor = false;
            // 
            // btnB1
            // 
            this.btnB1.BackColor = System.Drawing.Color.Red;
            this.btnB1.Location = new System.Drawing.Point(47, 206);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(102, 115);
            this.btnB1.TabIndex = 1;
            this.btnB1.Text = "VsComputerAlien";
            this.btnB1.UseVisualStyleBackColor = false;
            // 
            // btnA2
            // 
            this.btnA2.BackColor = System.Drawing.Color.Yellow;
            this.btnA2.Location = new System.Drawing.Point(185, 43);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(202, 44);
            this.btnA2.TabIndex = 2;
            this.btnA2.Text = "aGLITCH";
            this.btnA2.UseVisualStyleBackColor = false;
            this.btnA2.Click += new System.EventHandler(this.btnA2_Click);
            // 
            // btnA3
            // 
            this.btnA3.BackColor = System.Drawing.Color.Yellow;
            this.btnA3.Location = new System.Drawing.Point(185, 93);
            this.btnA3.Name = "btnA3";
            this.btnA3.Size = new System.Drawing.Size(202, 44);
            this.btnA3.TabIndex = 3;
            this.btnA3.Text = "aCoverupStory";
            this.btnA3.UseVisualStyleBackColor = false;
            // 
            // btnB2
            // 
            this.btnB2.BackColor = System.Drawing.Color.Yellow;
            this.btnB2.Location = new System.Drawing.Point(185, 206);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(202, 44);
            this.btnB2.TabIndex = 4;
            this.btnB2.Text = "DronesControl";
            this.btnB2.UseVisualStyleBackColor = false;
            this.btnB2.Click += new System.EventHandler(this.btnB2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnB2);
            this.Controls.Add(this.btnA3);
            this.Controls.Add(this.btnA2);
            this.Controls.Add(this.btnB1);
            this.Controls.Add(this.btnA1);
            this.Name = "Form1";
            this.Text = "GLITCH";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.Button btnB2;
    }
}

