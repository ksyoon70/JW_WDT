using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;   //class 추가

namespace Jwis_WD
{
    public class ConfigManager
    {

        static string PROGRAM_INI_FULLPATH;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        Form1 m_form;

        public ConfigManager(Form1 parent)
        {
            m_form = parent;
        }

        public void Load()
        {
            StringBuilder temp = new StringBuilder(255);
            ///WDT 사용여부
            GetPrivateProfileString("SYSTEM", "WDT_ENABLE", "Y", temp, 255, PROGRAM_INI_FULLPATH);
            if(temp.ToString().CompareTo("Y") == 0)
            {
                m_form.WdtEnable = true;
            }
            else
            {
                m_form.WdtEnable = false;
            }
            ///WDT Time
            GetPrivateProfileString("SYSTEM", "WDT_TIME", "60", temp, 255, PROGRAM_INI_FULLPATH);
            m_form.WdtTime = Convert.ToInt32(temp.ToString());
            ///WDT Refresh time
            GetPrivateProfileString("SYSTEM", "WDT_REFRESH", "10", temp, 255, PROGRAM_INI_FULLPATH);
            m_form.WdtRefreshTime = Convert.ToInt32(temp.ToString());
        }

        public void Save()
        {
            ///WDT 사용여부
            WritePrivateProfileString("SYSTEM", "WDT_ENABLE", m_form.WdtEnable == true ? "Y" : "N" , PROGRAM_INI_FULLPATH);
            ///WDT Time
            WritePrivateProfileString("SYSTEM", "WDT_TIME", m_form.WdtTime.ToString(), PROGRAM_INI_FULLPATH);
            ///WDT Refreshtime
            WritePrivateProfileString("SYSTEM", "WDT_REFRESH", m_form.WdtRefreshTime.ToString(), PROGRAM_INI_FULLPATH);
        }

        /// <summary>
        /// INI 파일이름 설정
        /// </summary>
        public void setFileName(string fileName) => PROGRAM_INI_FULLPATH = fileName;
    }
}
