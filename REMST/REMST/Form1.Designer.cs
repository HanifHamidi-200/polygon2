namespace REMST
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
            this.btnShow1 = new System.Windows.Forms.Button();
            this.btnShow2 = new System.Windows.Forms.Button();
            this.btnShow3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShow1
            // 
            this.btnShow1.BackColor = System.Drawing.Color.Yellow;
            this.btnShow1.Location = new System.Drawing.Point(26, 48);
            this.btnShow1.Name = "btnShow1";
            this.btnShow1.Size = new System.Drawing.Size(184, 43);
            this.btnShow1.TabIndex = 0;
            this.btnShow1.Text = "REMST";
            this.btnShow1.UseVisualStyleBackColor = false;
            this.btnShow1.Click += new System.EventHandler(this.btnShow1_Click);
            // 
            // btnShow2
            // 
            this.btnShow2.BackColor = System.Drawing.Color.Yellow;
            this.btnShow2.Location = new System.Drawing.Point(26, 97);
            this.btnShow2.Name = "btnShow2";
            this.btnShow2.Size = new System.Drawing.Size(184, 43);
            this.btnShow2.TabIndex = 1;
            this.btnShow2.Text = "TITPW";
            this.btnShow2.UseVisualStyleBackColor = false;
            this.btnShow2.Click += new System.EventHandler(this.btnShow2_Click);
            // 
            // btnShow3
            // 
            this.btnShow3.BackColor = System.Drawing.Color.Yellow;
            this.btnShow3.Location = new System.Drawing.Point(26, 146);
            this.btnShow3.Name = "btnShow3";
            this.btnShow3.Size = new System.Drawing.Size(184, 43);
            this.btnShow3.TabIndex = 2;
            this.btnShow3.Text = "JWALK";
            this.btnShow3.UseVisualStyleBackColor = false;
            this.btnShow3.Click += new System.EventHandler(this.btnShow3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(361, 224);
            this.Controls.Add(this.btnShow3);
            this.Controls.Add(this.btnShow2);
            this.Controls.Add(this.btnShow1);
            this.Name = "Form1";
            this.Text = "REMST";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShow1;
        private System.Windows.Forms.Button btnShow2;
        private System.Windows.Forms.Button btnShow3;
    }
}

