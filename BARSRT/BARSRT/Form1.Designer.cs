namespace BARSRT
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
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.Red;
            this.btn11.Location = new System.Drawing.Point(43, 31);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(104, 121);
            this.btn11.TabIndex = 0;
            this.btn11.Text = "BarSortedOut";
            this.btn11.UseVisualStyleBackColor = false;
            this.btn11.Click += new System.EventHandler(this.btn11_Click);
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.Color.Lime;
            this.btn12.Location = new System.Drawing.Point(183, 31);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(183, 58);
            this.btn12.TabIndex = 1;
            this.btn12.Text = "TradeWarEffect postout";
            this.btn12.UseVisualStyleBackColor = false;
            // 
            // btn13
            // 
            this.btn13.BackColor = System.Drawing.Color.Lime;
            this.btn13.Location = new System.Drawing.Point(183, 95);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(183, 58);
            this.btn13.TabIndex = 2;
            this.btn13.Text = "SeamlessLanguages inturn";
            this.btn13.UseVisualStyleBackColor = false;
            // 
            // btn22
            // 
            this.btn22.BackColor = System.Drawing.Color.Lime;
            this.btn22.Location = new System.Drawing.Point(183, 176);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(183, 58);
            this.btn22.TabIndex = 4;
            this.btn22.Text = "ToxicRadioactive";
            this.btn22.UseVisualStyleBackColor = false;
            // 
            // btn21
            // 
            this.btn21.BackColor = System.Drawing.Color.Red;
            this.btn21.Location = new System.Drawing.Point(43, 176);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(104, 121);
            this.btn21.TabIndex = 3;
            this.btn21.Text = "Gazientep\r\nHorseride";
            this.btn21.UseVisualStyleBackColor = false;
            this.btn21.Click += new System.EventHandler(this.btn21_Click);
            // 
            // btn32
            // 
            this.btn32.BackColor = System.Drawing.Color.Lime;
            this.btn32.Location = new System.Drawing.Point(183, 326);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(183, 58);
            this.btn32.TabIndex = 7;
            this.btn32.Text = "GooglePlusExemplar";
            this.btn32.UseVisualStyleBackColor = false;
            // 
            // btn31
            // 
            this.btn31.BackColor = System.Drawing.Color.Red;
            this.btn31.Location = new System.Drawing.Point(43, 326);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(104, 121);
            this.btn31.TabIndex = 6;
            this.btn31.Text = "GoogleTissue";
            this.btn31.UseVisualStyleBackColor = false;
            this.btn31.Click += new System.EventHandler(this.btn31_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(618, 489);
            this.Controls.Add(this.btn32);
            this.Controls.Add(this.btn31);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Name = "Form1";
            this.Text = "BARSRT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn31;
    }
}

