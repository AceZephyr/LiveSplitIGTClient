using System;
using System.IO.Pipes;
using System.Text;
using System.Windows.Forms;

namespace LiveSplitIGTClient {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        byte[] MARK = Encoding.ASCII.GetBytes("mark");

        private void clickMark() {
            try {
                using(NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "LiveSplitIGT", PipeDirection.Out)) {
                    pipeClient.Connect(500);
                    pipeClient.Write(MARK, 0, 4);
                    pipeClient.Flush();
                }
            } catch(TimeoutException ex) {
                MessageBox.Show("Could not connect to LiveSplit");
                return;
            }
            inputMarkIGT_TextChanged(null, null);
        }

        private void inputMarkIGT_TextChanged(object sender, EventArgs e) {
            double seconds = 0;
            if(radioHHMMSS.Checked) {
                string[] parts = inputMarkIGT.Text.Split(" :.,".ToCharArray());
                foreach(var part in parts) {
                    try {
                        seconds = (seconds * 60) + int.Parse(part);
                    } catch(FormatException ex) {
                        return; // do nothing if string is bad
                    }
                }
            } else if(radioNumberOfSeconds.Checked) {
                try {
                    seconds = double.Parse(inputMarkIGT.Text);
                } catch(FormatException ex) {
                    return; // do nothing if string is bad
                }
            }
            
            string cmdStr = $"markigt {seconds}";
            byte[] cmd = Encoding.ASCII.GetBytes(cmdStr);
            try {
                using(NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "LiveSplitIGT", PipeDirection.Out)) {
                    pipeClient.Connect(500);
                    pipeClient.Write(cmd, 0, cmdStr.Length);
                    pipeClient.Flush();
                }
            } catch(TimeoutException ex) {
                MessageBox.Show("Could not connect to LiveSplit");
            }
        }

        private void radioHHMMSS_CheckedChanged(object sender, EventArgs e) {
            inputMarkIGT_TextChanged(null, null);
        }

        private void radioNumberOfSeconds_CheckedChanged(object sender, EventArgs e) {
            inputMarkIGT_TextChanged(null, null);
        }

        private void buttonMark_MouseDown(object sender, MouseEventArgs e) {
            if(radioMarkOnPress.Checked)
                clickMark();
        }

        private void buttonMark_KeyDown(object sender, KeyEventArgs e) {
            if(radioMarkOnPress.Checked)
                clickMark();
        }

        private void buttonMark_MouseUp(object sender, MouseEventArgs e) {
            if(radioMarkOnRelease.Checked)
                clickMark();
        }

        private void buttonMark_KeyUp(object sender, KeyEventArgs e) {
            if(radioMarkOnRelease.Checked)
                clickMark();
        }
    }
}
