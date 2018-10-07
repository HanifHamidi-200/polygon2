namespace DRPOX
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
            this.fraPrimary = new System.Windows.Forms.GroupBox();
            this.txt2 = new System.Windows.Forms.RichTextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.fraSecondary = new System.Windows.Forms.GroupBox();
            this.txt3 = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStyle1 = new System.Windows.Forms.Button();
            this.btnStyle3 = new System.Windows.Forms.Button();
            this.btnStyle4 = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnStyle2 = new System.Windows.Forms.Button();
            this.fraPrimary.SuspendLayout();
            this.fraSecondary.SuspendLayout();
            this.SuspendLayout();
            // 
            // fraPrimary
            // 
            this.fraPrimary.Controls.Add(this.txt2);
            this.fraPrimary.Controls.Add(this.lbl1);
            this.fraPrimary.Controls.Add(this.txt1);
            this.fraPrimary.Location = new System.Drawing.Point(32, 55);
            this.fraPrimary.Name = "fraPrimary";
            this.fraPrimary.Size = new System.Drawing.Size(380, 319);
            this.fraPrimary.TabIndex = 0;
            this.fraPrimary.TabStop = false;
            this.fraPrimary.Text = "Primary";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(27, 147);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(264, 148);
            this.txt2.TabIndex = 2;
            this.txt2.Text = "";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(33, 61);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(155, 75);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Title";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(27, 27);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(253, 20);
            this.txt1.TabIndex = 0;
            // 
            // fraSecondary
            // 
            this.fraSecondary.Controls.Add(this.txt3);
            this.fraSecondary.Location = new System.Drawing.Point(32, 393);
            this.fraSecondary.Name = "fraSecondary";
            this.fraSecondary.Size = new System.Drawing.Size(380, 181);
            this.fraSecondary.TabIndex = 1;
            this.fraSecondary.TabStop = false;
            this.fraSecondary.Text = "Secondary";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(27, 27);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(264, 130);
            this.txt3.TabIndex = 3;
            this.txt3.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClear.Location = new System.Drawing.Point(462, 80);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 36);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "&ClearAll";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStyle1
            // 
            this.btnStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStyle1.Location = new System.Drawing.Point(462, 137);
            this.btnStyle1.Name = "btnStyle1";
            this.btnStyle1.Size = new System.Drawing.Size(120, 81);
            this.btnStyle1.TabIndex = 3;
            this.btnStyle1.Text = "Frank";
            this.btnStyle1.UseVisualStyleBackColor = false;
            this.btnStyle1.Click += new System.EventHandler(this.btnStyle1_Click);
            // 
            // btnStyle3
            // 
            this.btnStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStyle3.Location = new System.Drawing.Point(462, 224);
            this.btnStyle3.Name = "btnStyle3";
            this.btnStyle3.Size = new System.Drawing.Size(120, 81);
            this.btnStyle3.TabIndex = 4;
            this.btnStyle3.Text = "Pluto";
            this.btnStyle3.UseVisualStyleBackColor = false;
            this.btnStyle3.Click += new System.EventHandler(this.btnStyle2_Click);
            // 
            // btnStyle4
            // 
            this.btnStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStyle4.Location = new System.Drawing.Point(588, 224);
            this.btnStyle4.Name = "btnStyle4";
            this.btnStyle4.Size = new System.Drawing.Size(120, 81);
            this.btnStyle4.TabIndex = 5;
            this.btnStyle4.Text = "Account";
            this.btnStyle4.UseVisualStyleBackColor = false;
            this.btnStyle4.Click += new System.EventHandler(this.btnStyle3_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.Yellow;
            this.txtTitle.Location = new System.Drawing.Point(462, 554);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(120, 20);
            this.txtTitle.TabIndex = 6;
            // 
            // btnStyle2
            // 
            this.btnStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStyle2.Location = new System.Drawing.Point(588, 137);
            this.btnStyle2.Name = "btnStyle2";
            this.btnStyle2.Size = new System.Drawing.Size(120, 81);
            this.btnStyle2.TabIndex = 7;
            this.btnStyle2.Text = "BanburyCircle";
            this.btnStyle2.UseVisualStyleBackColor = false;
            this.btnStyle2.Click += new System.EventHandler(this.btnStyle2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(748, 603);
            this.Controls.Add(this.btnStyle2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnStyle4);
            this.Controls.Add(this.btnStyle3);
            this.Controls.Add(this.btnStyle1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.fraSecondary);
            this.Controls.Add(this.fraPrimary);
            this.Name = "Form1";
            this.Text = "DRPOX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fraPrimary.ResumeLayout(false);
            this.fraPrimary.PerformLayout();
            this.fraSecondary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox fraPrimary;
        private System.Windows.Forms.RichTextBox txt2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.GroupBox fraSecondary;
        private System.Windows.Forms.RichTextBox txt3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStyle1;
        private System.Windows.Forms.Button btnStyle3;
        private System.Windows.Forms.Button btnStyle4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnStyle2;
    }
}

