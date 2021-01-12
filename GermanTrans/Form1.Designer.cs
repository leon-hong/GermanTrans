namespace GermanTrans
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
            this.edt_src = new System.Windows.Forms.TextBox();
            this.btn_trans = new System.Windows.Forms.Button();
            this.edt_res_google = new System.Windows.Forms.TextBox();
            this.sta_res_google = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // edt_src
            // 
            this.edt_src.Location = new System.Drawing.Point(34, 49);
            this.edt_src.Name = "edt_src";
            this.edt_src.Size = new System.Drawing.Size(328, 21);
            this.edt_src.TabIndex = 0;
            // 
            // btn_trans
            // 
            this.btn_trans.Location = new System.Drawing.Point(389, 42);
            this.btn_trans.Name = "btn_trans";
            this.btn_trans.Size = new System.Drawing.Size(78, 32);
            this.btn_trans.TabIndex = 1;
            this.btn_trans.Text = "Translation";
            this.btn_trans.UseVisualStyleBackColor = true;
            this.btn_trans.Click += new System.EventHandler(this.btn_trans_Click);
            // 
            // edt_res_google
            // 
            this.edt_res_google.Location = new System.Drawing.Point(139, 98);
            this.edt_res_google.Name = "edt_res_google";
            this.edt_res_google.Size = new System.Drawing.Size(328, 21);
            this.edt_res_google.TabIndex = 2;
            // 
            // sta_res_google
            // 
            this.sta_res_google.AutoSize = true;
            this.sta_res_google.Location = new System.Drawing.Point(36, 101);
            this.sta_res_google.Name = "sta_res_google";
            this.sta_res_google.Size = new System.Drawing.Size(85, 12);
            this.sta_res_google.TabIndex = 3;
            this.sta_res_google.Text = "구글 번역 결과";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 150);
            this.Controls.Add(this.sta_res_google);
            this.Controls.Add(this.edt_res_google);
            this.Controls.Add(this.btn_trans);
            this.Controls.Add(this.edt_src);
            this.Name = "Form1";
            this.Text = "German Translation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edt_src;
        private System.Windows.Forms.Button btn_trans;
        private System.Windows.Forms.TextBox edt_res_google;
        private System.Windows.Forms.Label sta_res_google;
    }
}

