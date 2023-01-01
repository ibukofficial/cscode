using System.Diagnostics;

namespace launcher
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\81902\Downloads\BouyomiChan_0_1_11_0_Beta21\BouyomiChan.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Unity Hub\Unity Hub.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\81902\Downloads\aviutl110_-_1366x768_-_ (1)\aviutl110 - 1366x768 - コピー\aviutl.exe");
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
        private void openFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            MessageBox.Show("タスクバーの隠れているインジケーターの中から再度開けます");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe");
            MessageBox.Show("test");
            
        }
    }
}