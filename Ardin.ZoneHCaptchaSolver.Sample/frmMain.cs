using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ardin.ZoneHCaptchaSolver.Sample
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLoadCaptcha_Click(object sender, EventArgs e)
        {
            string url = "http://zone-h.org/captcha.py";
            url = @"C:\Storage\Workplace\Ardin.ZoneHCaptchaSolver\CaptchaSamples\captcha.png";
            pictureBox1.ImageLocation = url;
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            string tmp = Path.GetTempFileName().Replace(".tmp" , ".png");
            pictureBox1.Image.Save(tmp);
            lblSolvedCaptchaText.Text = ML.Engine.ZoneH.Solve(tmp);
        }
    }
}
