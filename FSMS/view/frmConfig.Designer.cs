namespace FSMS.view
{
    partial class frmConfig
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbComName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReadTimeout = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbWriteTimeout = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbComName
            // 
            this.tbComName.Location = new System.Drawing.Point(166, 19);
            this.tbComName.Name = "tbComName";
            this.tbComName.Size = new System.Drawing.Size(127, 21);
            this.tbComName.TabIndex = 0;
            this.tbComName.Text = "COM1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "串口名称：";
            // 
            // tbRate
            // 
            this.tbRate.Location = new System.Drawing.Point(166, 63);
            this.tbRate.Name = "tbRate";
            this.tbRate.Size = new System.Drawing.Size(127, 21);
            this.tbRate.TabIndex = 1;
            this.tbRate.Text = "9600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "传输速率：";
            // 
            // tbReadTimeout
            // 
            this.tbReadTimeout.Location = new System.Drawing.Point(166, 109);
            this.tbReadTimeout.Name = "tbReadTimeout";
            this.tbReadTimeout.Size = new System.Drawing.Size(127, 21);
            this.tbReadTimeout.TabIndex = 2;
            this.tbReadTimeout.Text = "500";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "读超时(ms)：";
            // 
            // tbWriteTimeout
            // 
            this.tbWriteTimeout.Location = new System.Drawing.Point(166, 152);
            this.tbWriteTimeout.Name = "tbWriteTimeout";
            this.tbWriteTimeout.Size = new System.Drawing.Size(127, 21);
            this.tbWriteTimeout.TabIndex = 3;
            this.tbWriteTimeout.Text = "500";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "写超时(ms)：";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(105, 198);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(81, 26);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(192, 198);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 26);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 236);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbWriteTimeout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbReadTimeout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbComName);
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口配置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbComName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbReadTimeout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbWriteTimeout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnReset;
    }
}