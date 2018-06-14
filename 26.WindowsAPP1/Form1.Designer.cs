namespace _26.WindowsAPP1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.helloButton = new System.Windows.Forms.Button();
            this.helloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloButton
            // 
            this.helloButton.Location = new System.Drawing.Point(271, 302);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(243, 73);
            this.helloButton.TabIndex = 0;
            this.helloButton.Text = "クリック！！！！";
            this.helloButton.UseVisualStyleBackColor = true;
            this.helloButton.Click += new System.EventHandler(this.HelloButtonClickd);
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Location = new System.Drawing.Point(340, 145);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(128, 18);
            this.helloLabel.TabIndex = 1;
            this.helloLabel.Text = "???????????????";
            this.helloLabel.AutoSizeChanged += new System.EventHandler(this.helloLabel_AutoSizeChanged);
            this.helloLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.helloButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button helloButton;
        private System.Windows.Forms.Label helloLabel;
    }
}

