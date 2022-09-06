
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbAsyncMonitorResults = new System.Windows.Forms.RichTextBox();
            this.btnBeginAsyncMonitor = new System.Windows.Forms.Button();
            this.btnStopAsyncMonitor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBeginMonitering
            // 
            this.btnBeginMonitering.Location = new System.Drawing.Point(357, 46);
            this.btnBeginMonitering.Name = "btnBeginMonitering";
            this.btnBeginMonitering.Size = new System.Drawing.Size(75, 23);
            this.btnBeginMonitering.TabIndex = 0;
            this.btnBeginMonitering.Text = "監視開始";
            this.btnBeginMonitering.UseVisualStyleBackColor = true;
            this.btnBeginMonitering.Click += new System.EventHandler(this.btnBeginMonitering_Click);
            // 
            // btnStopMoniterring
            // 
            this.btnStopMoniterring.Location = new System.Drawing.Point(357, 100);
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
            this.richTextBox1.Location = new System.Drawing.Point(20, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(331, 137);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.btnBeginMonitering);
            this.groupBox1.Controls.Add(this.btnStopMoniterring);
            this.groupBox1.Location = new System.Drawing.Point(26, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 172);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "同期監視";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbAsyncMonitorResults);
            this.groupBox2.Controls.Add(this.btnBeginAsyncMonitor);
            this.groupBox2.Controls.Add(this.btnStopAsyncMonitor);
            this.groupBox2.Location = new System.Drawing.Point(26, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 172);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "非同期監視";
            // 
            // rtbAsyncMonitorResults
            // 
            this.rtbAsyncMonitorResults.Enabled = false;
            this.rtbAsyncMonitorResults.Location = new System.Drawing.Point(20, 22);
            this.rtbAsyncMonitorResults.Name = "rtbAsyncMonitorResults";
            this.rtbAsyncMonitorResults.Size = new System.Drawing.Size(331, 137);
            this.rtbAsyncMonitorResults.TabIndex = 4;
            this.rtbAsyncMonitorResults.Text = "";
            // 
            // btnBeginAsyncMonitor
            // 
            this.btnBeginAsyncMonitor.Location = new System.Drawing.Point(357, 44);
            this.btnBeginAsyncMonitor.Name = "btnBeginAsyncMonitor";
            this.btnBeginAsyncMonitor.Size = new System.Drawing.Size(75, 23);
            this.btnBeginAsyncMonitor.TabIndex = 0;
            this.btnBeginAsyncMonitor.Text = "監視開始";
            this.btnBeginAsyncMonitor.UseVisualStyleBackColor = true;
            this.btnBeginAsyncMonitor.Click += new System.EventHandler(this.btnBeginAsyncMonitor_Click);
            // 
            // btnStopAsyncMonitor
            // 
            this.btnStopAsyncMonitor.Location = new System.Drawing.Point(357, 108);
            this.btnStopAsyncMonitor.Name = "btnStopAsyncMonitor";
            this.btnStopAsyncMonitor.Size = new System.Drawing.Size(75, 25);
            this.btnStopAsyncMonitor.TabIndex = 1;
            this.btnStopAsyncMonitor.Text = "監視停止";
            this.btnStopAsyncMonitor.UseVisualStyleBackColor = true;
            this.btnStopAsyncMonitor.Click += new System.EventHandler(this.btnStopAsyncMonitor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 503);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeginMonitering;
        private System.Windows.Forms.Button btnStopMoniterring;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbAsyncMonitorResults;
        private System.Windows.Forms.Button btnBeginAsyncMonitor;
        private System.Windows.Forms.Button btnStopAsyncMonitor;
    }
}

