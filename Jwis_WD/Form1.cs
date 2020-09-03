using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jwis_WD;
using System.Diagnostics;
using System.Reflection;

namespace Jwis_WD
{
    public partial class Form1 : Form
    {
        private EAPI_Library eapi;

        private bool m_wdtEnable;
        public bool WdtEnable
        {
            get
            {
                return m_wdtEnable;
            }
            set
            {
                m_wdtEnable = value;
            }
        }

        private int m_wdtTime;
        public int WdtTime
        {
            get
            {
                return m_wdtTime;
            }
            set
            {
                m_wdtTime = value;
            }
        }

        private int m_wdtRefreshTime;
        public int WdtRefreshTime
        {
            get
            {
                return m_wdtRefreshTime;
            }
            set
            {
                m_wdtRefreshTime = value;
            }
        }

        ConfigManager m_cfg;
        public ConfigManager GetCfgManager() => m_cfg;

        public Form1()
        {
            InitializeComponent();


            pictureBox1.Image = Properties.Resources.jw_logo_누끼;

            notifyIcon1.ContextMenuStrip = contextMenuStrip1;

            /// 설정 파일 읽기
            m_cfg = new ConfigManager(this);
            GetCfgManager().setFileName(System.AppDomain.CurrentDomain.BaseDirectory + @"WDT.ini");
            GetCfgManager().Load();

            this.Text += " " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion.ToString();
#if false
            try
            {
                eapi = new EAPI_Library();
            }
            catch (System.Exception se)
            {
                throw se;
            }
#endif
            InitialEAPI_Library();

        }
        private void InitialEAPI_Library()
        {
#if false
            UInt32 pMaxDelay = new UInt32(), pMaxEventTimeout = new UInt32(), pMaxResetTimeout = new UInt32();
            if (0 != EAPI_Library.EApiWDogGetCap(ref pMaxDelay, ref pMaxEventTimeout, ref pMaxResetTimeout))
            {
                this.tableLayoutPanel_form.Enabled = false;
            }
#endif
            /// 시작 여부
            numericUpDown_timer.Value = Convert.ToDecimal(m_wdtTime);
            refresh_UpDown.Value = Convert.ToDecimal(m_wdtRefreshTime);
            if (m_wdtEnable)
            {
                ///와치독 enable이면 자동으로 시작한다.
                button_start_stop_Click(this, null);
            }
        }
        private void button_start_stop_Click(object sender, EventArgs e)
        {
            this.button_start_stop.Text = this.button_trigger.Enabled ? "Start" : "Stop";

            this.button_trigger.Enabled = !this.button_trigger.Enabled;

            if (this.button_trigger.Enabled)
            {
                uint timeout = Decimal.ToUInt32(this.numericUpDown_timer.Value);
                this.label_timer.Text = timeout.ToString();
                EAPI_Library.EApiWDogStart(0, 0, timeout * 1000);
                this.timerWatchdog.Start();
            }
            else
            {
                EAPI_Library.EApiWDogStop();
                this.timerWatchdog.Stop();
            }

            m_wdtEnable = this.button_trigger.Enabled;
            m_cfg.Save();
        }

        private void button_trigger_Click(object sender, EventArgs e)
        {
            EAPI_Library.EApiWDogTrigger();
            this.label_timer.Text = this.numericUpDown_timer.Value.ToString();
        }

        private void button_trigger_EnabledChanged(object sender, EventArgs e)
        {
            this.button_trigger.BackColor = this.button_trigger.Enabled ? System.Drawing.Color.FromArgb(0, 159, 168) : System.Drawing.Color.Gray;
        }

        private void timerWatchdog_Tick(object sender, EventArgs e)
        {
            int timeout = Convert.ToInt32(this.label_timer.Text);
            if (0 != timeout)
            {
                --timeout;
                if(timeout < 10)
                {
                    this.label_timer.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    this.label_timer.ForeColor = SystemColors.ActiveCaptionText;
                }
                this.label_timer.Text = timeout.ToString();
            }
            else
            {
                this.timerWatchdog.Stop();
            }

            if( (m_wdtTime - timeout) > m_wdtRefreshTime)
            {
                button_trigger_Click(this, null);
            }
        }

        private void WDT_TimeChanged(object sender, EventArgs e)
        {
            m_wdtTime = Decimal.ToInt32(numericUpDown_timer.Value);
            m_cfg.Save();
        }

        private void WDT_RefreshTimeChanged(object sender, EventArgs e)
        {
            m_wdtRefreshTime = Decimal.ToInt32(refresh_UpDown.Value);
            m_cfg.Save();
        }

        private void ToolStripMenuItemShow_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            Application.ExitThread();
            EAPI_Library.EApiWDogStop();
            this.timerWatchdog.Stop();
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            if(FormWindowState.Minimized == WindowState)
            {
                Use_Notify();
                notifyIcon1.Visible = true;
                this.ShowInTaskbar = false;
                this.Hide();
            }
            else  if(FormWindowState.Normal == WindowState)
            {
                notifyIcon1.Visible = false;
                this.ShowInTaskbar = true;
            }
        }

        private void Use_Notify()
        {
            if (WdtEnable)
                notifyIcon1.BalloonTipText = "와치독 실행 중입니다.";
            else
                notifyIcon1.BalloonTipText = "와치독 미실행 상태 입니다.";
            notifyIcon1.BalloonTipText = "진우산전 WDT";
            notifyIcon1.ShowBalloonTip(1);
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            Use_Notify();
            notifyIcon1.Visible = true;
        }
    }
}
