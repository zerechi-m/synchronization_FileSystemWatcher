using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileSystemWatcher_plactice
{
    public partial class Form1 : Form
    {
        // 同期的監視
        public FileSystemWatcher _watcher { get; set; }

        // 非同期監視
        public FileSystemWatcher AsyncWatcher { get; set; }

        // 非同期時にRichTextBoxへの書込み関数を宣言
        delegate void WriteText(string txt);
        WriteText _writeRichText;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string pathMoniter = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Monitoring");

            if (Directory.Exists(pathMoniter))
            {
                textBox1.Text = pathMoniter;
            }

            // Delegateのインスタンス作成
            _writeRichText = new WriteText(WriteRichText);

        }

        /// <summary>
        /// 同期的にファイルの監視
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBeginMonitering_Click(object sender, EventArgs e)
        {
            // FileWatcherクラスのインスタンス作成
            _watcher = new FileSystemWatcher();

            // ディレクトリパスの設定
            _watcher.Path = Path.Combine(textBox1.Text);

            // 全てのファイル
            _watcher.Filter = "";

            // NotifyFilterに監視する項目
            _watcher.NotifyFilter = NotifyFilters.FileName |       // ファイル名
                                    NotifyFilters.DirectoryName |  // フォルダ名
                                    NotifyFilters.LastAccess |     // 最終アクセス日
                                    NotifyFilters.LastWrite;       // 最終書込日

            // 監視ディレクトリ配下のサブフォルダは監視しない
            _watcher.IncludeSubdirectories = false;

            // 同期的に監視を開始するイベントを設定
            WaitForChangedResult changedResult = _watcher.WaitForChanged(WatcherChangeTypes.All);

            if (changedResult.TimedOut)
            {
                richTextBox1.Text += "タイムアウト";
            }

            // 監視ディレクトリの各イベント発火
            switch (changedResult.ChangeType)
            {
                // ファイルの作成
                case WatcherChangeTypes.Created:
                    richTextBox1.Text += $"ファイル「{changedResult.Name}」が作成されました\n";
                    break;

                // ファイルの変更
                case WatcherChangeTypes.Changed:
                    richTextBox1.Text += $"ファイル「{changedResult.Name}」が変更されました\n";
                    break;

                // ファイルの削除
                case WatcherChangeTypes.Deleted:
                    richTextBox1.Text += $"ファイル「{changedResult.Name}」が削除されました\n";
                    break;

                // ファイル名の変更
                case WatcherChangeTypes.Renamed:
                    richTextBox1.Text += $"ファイル「{changedResult.OldName}」が「{changedResult.Name}」に変更されました\n";
                    break;

            }
        }

        private void btnStopMoniterring_Click(object sender, EventArgs e)
        {
            _watcher.EnableRaisingEvents = false;
            _watcher.Dispose();
            _watcher = null;

            richTextBox1.Text += "監視を終了しました。";
        }

        /// <summary>
        /// 非同期的にフォルダ監視を開始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBeginAsyncMonitor_Click(object sender, EventArgs e)
        {

            AsyncWatcher = new FileSystemWatcher();

            // 監視するディレクトリパスを設定
            AsyncWatcher.Path = textBox1.Text;

            // 監視対象は全てを設定
            AsyncWatcher.Filter = "";

            // 監視対象を設定
            AsyncWatcher.NotifyFilter = NotifyFilters.FileName |
                                        NotifyFilters.DirectoryName |
                                        NotifyFilters.LastWrite;

            // イベントハンドラの追加
            AsyncWatcher.Changed += new FileSystemEventHandler(AsyncWatcher_Changed);
            AsyncWatcher.Created += new FileSystemEventHandler(AsyncWatcher_Created);
            AsyncWatcher.Renamed += new RenamedEventHandler(AsyncWatcher_Renamed);
            AsyncWatcher.Deleted += new FileSystemEventHandler(AsyncWatcher_Deleted);

            // 監視を開始
            AsyncWatcher.EnableRaisingEvents = true;

            rtbAsyncMonitorResults.Text += "非同期監視の開始\n";

        }

        private void btnStopAsyncMonitor_Click(object sender, EventArgs e)
        {
            // 監視の終了
            AsyncWatcher.EnableRaisingEvents = false;
            // リソースの破棄
            AsyncWatcher.Dispose();
            // インスタンスを削除
            AsyncWatcher = null;

            rtbAsyncMonitorResults.Text += "非同期監視の終了\n";
        }

        private void AsyncWatcher_Created(object sender, FileSystemEventArgs e)
        {
            string txt = $"ファイル「{e.Name}」が作成されました\n";

            this.Invoke(new WriteText(WriteRichText), txt);
        }

        private void AsyncWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            string txt = $"ファイル「{e.Name}」が変更されました\n";

            this.Invoke(new WriteText(WriteRichText), txt);
        }

        private void AsyncWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            
            string txt= $"ファイル「{e.OldName}」が「{e.Name}」に変更されました\n";

            this.Invoke(new WriteText(WriteRichText), txt);
        }

        private void AsyncWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            string txt= $"ファイル「{e.Name}」が削除されました。\n";

            this.Invoke(new WriteText(WriteRichText), txt);
        }

        private void WriteRichText(string text)
        {
            rtbAsyncMonitorResults.Text += text;
            return;
        }
    }
}
