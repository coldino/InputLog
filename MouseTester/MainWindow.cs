using System;
using System.Windows.Forms;

namespace MouseTester
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            LogEvent("Started");
        }

        private void LogEvent(string msg)
        {
            logView.Items.Add(new ListViewItem(new string[] { DateTime.Now.ToLongTimeString(), msg }));
            logView.EnsureVisible(logView.Items.Count - 1);
        }

        private void HandleKeyEvent(KeyEventArgs e, string upDown)
        {
            LogEvent($"Key {upDown} : KeyCode={e.KeyCode}, KeyValue={e.KeyValue}, KeyData={e.KeyData}, Modifiers={e.Modifiers}");
            e.SuppressKeyPress = true;
            e.Handled = true;
        }

        private void HandleMouseEvent(MouseEventArgs e, string upDown)
        {
            LogEvent($"Mouse {upDown} : Button={e.Button}, Clicks={e.Clicks}");
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            HandleKeyEvent(e, "down");
        }

        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            HandleKeyEvent(e, "up");
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseEvent(e, "down");
        }

        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            HandleMouseEvent(e, "up");
        }

        private void LogView_MouseUp(object sender, MouseEventArgs e)
        {
            HandleMouseEvent(e, "up");
        }

        private void LogView_MouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseEvent(e, "down");
        }

        private void LogView_KeyUp(object sender, KeyEventArgs e)
        {
            HandleKeyEvent(e, "up");
        }

        private void LogView_KeyDown(object sender, KeyEventArgs e)
        {
            HandleKeyEvent(e, "down");
        }
    }
}
