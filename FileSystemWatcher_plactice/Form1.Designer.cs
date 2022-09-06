
namespace FileSystemWatcher_plactice
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.btnBeginMonitering = new System.Windows.Forms.Button();
            this.btnStopMoniterring = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnBeginMonitering
            // 
            this.btnBeginMonitering.Location = new System.Drawing.Point(294, 98);
            this.btnBeginMonitering.Name = "btnBeginMonitering";
            this.btnBeginMonitering.Size = new System.Drawing.Size(75, 23);
            this.btnBeginMonitering.TabIndex = 0;
            this.btnBeginMonitering.Text = "監視開始";
            this.btnBeginMonitering.UseVisualStyleBackColor = true;
            this.btnBeginMonitering.Click += new System.EventHandler(this.btnBeginMonitering_Click);
            // 
            // btnStopMoniterring
            // 
            this.btnStopMoniterring.Location = new System.Drawing.Point(389, 96);
            this.btnStopMoniterring.Name = "btnStopMoniterring";
            this.btnStopMoniterring.Size = new System.Drawing.Size(75, 25);
            this.btnStopMoniterring.TabIndex = 1;
            this.btnStopMoniterring.Text = "監視停止";
            this.btnStopMoniterring.UseVisualStyleBackColor = true;
            this.btnStopMoniterring.Click += new System.EventHandler(this.btnStopMoniterring_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(438, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "監視ディレクトリ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(26, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(242, 96);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 168);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStopMoniterring);
            this.Controls.Add(this.btnBeginMonitering);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeginMonitering;
        private System.Windows.Forms.Button btnStopMoniterring;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

