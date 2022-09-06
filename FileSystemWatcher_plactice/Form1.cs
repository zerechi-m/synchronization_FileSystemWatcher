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

        FileSystemWatcher _watcher;

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
        }

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
    }
}
