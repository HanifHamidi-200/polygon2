namespace RMOTOR
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
            this.btn10 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.Blue;
            this.btn10.Location = new System.Drawing.Point(63, 23);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(106, 89);
            this.btn10.TabIndex = 0;
            this.btn10.Text = "CONST";
            this.btn10.UseVisualStyleBackColor = false;
            this.btn10.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn20
            // 
            this.btn20.BackColor = System.Drawing.Color.Blue;
            this.btn20.Location = new System.Drawing.Point(63, 148);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(106, 89);
            this.btn20.TabIndex = 1;
            this.btn20.Text = "FILE";
            this.btn20.UseVisualStyleBackColor = false;
            // 
            // btn30
            // 
            this.btn30.BackColor = System.Drawing.Color.Blue;
            this.btn30.Location = new System.Drawing.Point(63, 325);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(106, 89);
            this.btn30.TabIndex = 2;
            this.btn30.Text = "ART";
            this.btn30.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(204, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "BenchesFishermenOverview";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.Location = new System.Drawing.Point(204, 75);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = "ExplorationDarkmode";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Yellow;
            this.button6.Location = new System.Drawing.Point(204, 200);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 46);
            this.button6.TabIndex = 6;
            this.button6.Text = "SimplifiedMaths";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Yellow;
            this.button7.Location = new System.Drawing.Point(204, 148);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(166, 46);
            this.button7.TabIndex = 5;
            this.button7.Text = "LettertrayResemblance";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Yellow;
            this.button8.Location = new System.Drawing.Point(204, 325);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(166, 46);
            this.button8.TabIndex = 8;
            this.button8.Text = "TechnicalDrawings";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Yellow;
            this.button9.Location = new System.Drawing.Point(204, 252);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(166, 46);
            this.button9.TabIndex = 7;
            this.button9.Text = "DubosittsStrangular";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Yellow;
            this.button10.Location = new System.Drawing.Point(204, 377);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(166, 46);
            this.button10.TabIndex = 9;
            this.button10.Text = "LayTheTable";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(759, 462);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn30);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn10);
            this.Name = "Form1";
            this.Text = "RMOTOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

