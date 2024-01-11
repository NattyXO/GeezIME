using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeezIME
{
    public partial class installation : Form
    {
        public installation()
        {
            InitializeComponent();
        }

        private void installation_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if (progressBar1.Value <= progressBar1.Maximum-1)
            {
                progressBar1.Value += 1;
            }

           if (progressBar1.Value == 10)
            {
                lblShortcut.Text = @"Create shortcut: C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
            }
            if (progressBar1.Value == 20)
            {
                lblShortcut.Text = @"Create shortcut: C:\ProgramData\Microsoft\Windows\Start Menu\Programs\GeezIME";
            }
            if (progressBar1.Value == 30)
            {
                lblShortcut.Text = @"Create shortcut: C:\ProgramData\Microsoft\Windows\Start Menu\Programs\GeezIME\GeezIME manual";
            }
            if (progressBar1.Value == 40)
            {
                lblShortcut.Text = @"Create shortcut: C:\ProgramData\Microsoft\Windows\Start Menu\Programs\GeezIME\GeezIME";
            }
            if (progressBar1.Value == 60)
            {
                lblShortcut.Text = @"Create shortcut: C:\ProgramData\Microsoft\Windows\Start Menu\Programs\GeezIME\Tigrinya keyboard";
            }
            if (progressBar1.Value == 70)
            {
                lblShortcut.Text = @"Create shortcut: C:\ProgramData\Microsoft\Windows\Start Menu\Programs\GeezIME\Uninstall";
            }
            if (progressBar1.Value == 80)
            {
                lblShortcut.Text = @"Create shortcut: C:\Program Files (x86)\EriLS\GeezIME\tosk";
            }
            if (progressBar1.Value == 90)
            {
                lblShortcut.Text = @"Create shortcut: C:\Program Files (x86)\EriLS\GeezIME\Uninst";
            }
            if (progressBar1.Value == 100)
            {
                lblShortcut.Text = @"Create shortcut: C:\Program Files (x86)\EriLS\GeezIME\rt\GeezIMEHelper";
            }
           
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Finish ss = new Finish();
                this.Hide();
                ss.Show();
            }

        }
    }
}