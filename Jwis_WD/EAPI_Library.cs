using System;
using System.Text;
using System.Runtime.InteropServices; /// for DllImport

namespace Jwis_WD
{
    class EAPI_Library
    {
        public EAPI_Library()
        {
            if (0 != EApiLibInitialize())
            {
                /// throw a exception "Initial Failed" when initial failed
                throw new System.Exception("Initial Failed");
            }
        }

        ~EAPI_Library()
        {
            EApiLibUnInitialize();
        }

        public static uint GetBit(uint test, int bit)
        {
            return (test >> bit) & 1;
        }

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiLibInitialize", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt32 EApiLibInitialize();

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiLibUnInitialize", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt32 EApiLibUnInitialize();

        //// begin of Info
        public const uint EAPI_ID_BOARD_MANUFACTURER_STR = 0;
        public const uint EAPI_ID_BOARD_NAME_STR = 1;
        public const uint EAPI_ID_BOARD_REVISION_STR = 2;
        public const uint EAPI_ID_BOARD_SERIAL_STR = 3;
        public const uint EAPI_ID_BOARD_BIOS_REVISION_STR = 4;
        public const uint EAPI_ID_BOARD_HW_REVISION_STR = 5;
        public const uint EAPI_ID_BOARD_PLATFORM_TYPE_STR = 6;

        public const uint EAPI_ID_HWMON_CPU_TEMP = 0x20000;
        public const uint EAPI_ID_HWMON_CHIPSET_TEMP = 0x20001;
        public const uint EAPI_ID_HWMON_SYSTEM_TEMP = 0x20002;
        public const uint EAPI_ID_HWMON_SYSTEM2_TEMP = 0x20003;
        public const uint EAPI_ID_HWMON_SYSTEM3_TEMP = 0x20004;
        public const uint EAPI_ID_HWMON_SYSTEM4_TEMP = 0x20005;
        public const uint EAPI_ID_HWMON_SYSTEM5_TEMP = 0x20006;
        public const uint EAPI_ID_HWMON_SYSTEM6_TEMP = 0x20007;
        public const uint EAPI_ID_HWMON_SYSTEM7_TEMP = 0x20008;
        public const uint EAPI_ID_HWMON_CPU2_TEMP = 0x20009;

        public const uint EAPI_ID_HWMON_FAN_CPU = 0x22000;
        public const uint EAPI_ID_HWMON_FAN_SYSTEM = 0x22001;
        public const uint EAPI_ID_HWMON_FAN_SYSTEM2 = 0x22002;
        public const uint EAPI_ID_HWMON_FAN_SYSTEM3 = 0x22003;
        public const uint EAPI_ID_HWMON_FAN_SYSTEM4 = 0x22004;
        public const uint EAPI_ID_HWMON_FAN_SYSTEM5 = 0x22005;
        public const uint EAPI_ID_HWMON_FAN_SYSTEM6 = 0x22006;
        public const uint EAPI_ID_HWMON_FAN_SYSTEM7 = 0x22007;
        public const uint EAPI_ID_HWMON_FAN_CPU2 = 0x22008;

        public const uint EAPI_ID_HWMON_VOLTAGE_SUPPORT_LIST = 0x1002;
        public const uint EAPI_ID_EC_VERSION = 0x30000;

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiBoardGetStringA", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiBoardGetStringA(UInt32 id, StringBuilder pBuffer, ref UInt32 pBufLen);

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiBoardGetStringExA", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiBoardGetStringExA(UInt32 id, String pplatform_code, String pmemory_type, StringBuilder pBuffer, ref UInt32 pBufLen);

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiBoardGetValue", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiBoardGetValue(UInt32 id, ref UInt32 pBufLen);

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiBoardGetValueEx", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiBoardGetValueEx(UInt32 id, ref Char pplatform_code, ref Char pmemory_type, ref UInt32 pBufLen);
        //// end of Info

        //// begin of GPIO
        
        public const uint EAPI_GPIO_GPIO_BITMASK = 1;

        /* Bit mask Bit States */
        public const uint EAPI_GPIO_BITMASK_SELECT = 1;
        public const uint EAPI_GPIO_BITMASK_NOSELECT = 0;

        /* Levels */
        public const uint EAPI_GPIO_LOW = 0;
        public const uint EAPI_GPIO_HIGH = 1;

        /* Directions */
        public const uint EAPI_GPIO_INPUT = 1;
        public const uint EAPI_GPIO_OUTPUT = 0;

        public static uint EAPI_GPIO_GPIO_ID(int GPIO_NUM)
        {
            return (uint)GPIO_NUM;
        }
        /*
         * Multiple GPIOs Per ID Mapping
         */
        public static uint EAPI_GPIO_BANK_ID(uint GPIO_NUM)
        {
            return 0x10000 | ((GPIO_NUM) >> 5);
        }

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiGPIOGetCount", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiGPIOGetCount(ref UInt32 pCount);

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiGPIOGetDirectionCaps", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiGPIOGetDirectionCaps(UInt32 id, ref UInt32 pInputs, ref UInt32 pOutputs);

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiGPIOGetDirection", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiGPIOGetDirection(UInt32 id, UInt32 bitmask, ref UInt32 pDirection);

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiGPIOSetDirection", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiGPIOSetDirection(UInt32 id, UInt32 bitmask, UInt32 Direction);

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiGPIOGetLevel", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiGPIOGetLevel(UInt32 id, UInt32 bitmask, ref UInt32 pLevel);

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiGPIOSetLevel", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiGPIOSetLevel(UInt32 id, UInt32 bitmask, UInt32 Level);
        //// end of GPIO

        //// begin of Caseopen
        public const uint EAPI_ID_CASEOPEN_1 = 0;
        public const uint CASEOPEN_OPEN = 1;
        public const uint BEEP_ENABLE = 1;

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiCaseOpenGetCaseStatus", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiCaseOpenGetCaseStatus(UInt32 id, ref UInt32 pStatus);

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiCaseOpenGetCaseBeepStatus", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiCaseOpenGetCaseBeepStatus(UInt32 id, ref UInt32 pBeepStatus);

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiCaseOpenEnableCaseBeep", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiCaseOpenEnableCaseBeep(UInt32 id, UInt32 Enable);

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiCaseOpenResetCaseStatus", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiCaseOpenResetCaseStatus(UInt32 id);
        //// end of Caseopen

        //// begin of Backlight
        public const uint EAPI_ID_BACKLIGHT_1 = 0;
        public const uint EAPI_ID_BACKLIGHT_2 = 1;
        public const uint EAPI_ID_BACKLIGHT_3 = 2;
        public const uint EAPI_BACKLIGHT_SET_ON = 0;
        public const uint EAPI_BACKLIGHT_SET_OFF = 0xFFFFFFFF;
        public const uint EAPI_BACKLIGHT_SET_DIMEST = 0;
        public const uint EAPI_BACKLIGHT_SET_BRIGHTEST = 255;

        public const uint EAPI_ID_I2C_EXTERNAL = 0;
        public const uint EAPI_ID_I2C_EXTERNAL_2 = 3;
        public const uint EAPI_ID_I2C_EXTERNAL_3 = 4;
        public const uint EAPI_ID_I2C_LVDS_1 = 1;
        public const uint EAPI_ID_I2C_LVDS_2 = 2;

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiVgaGetBacklightEnable", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiVgaGetBacklightEnable(UInt32 id, ref UInt32 pEnable);

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiVgaSetBacklightEnable", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiVgaSetBacklightEnable(UInt32 id, UInt32 Enable);

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiVgaGetBacklightBrightness", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiVgaGetBacklightBrightness(UInt32 id, ref UInt32 pBrightness);

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiVgaSetBacklightBrightness", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiVgaSetBacklightBrightness(UInt32 id, UInt32 Brightness);
        //// end of Backlight

        //// begin of I2C
        public static uint EAPI_I2C_ENC_STD_CMD(uint x)
        {
            return (x & 0x00FF) | (0 << 30);
        }

        public static uint EAPI_I2C_ENC_EXT_CMD(uint x)
        {
            return (x & 0xFFFF) | ((uint)2 << 30);
        }

        public static uint EAPI_I2C_ENC_NO_CMD(uint x)
        {
            return (x & 0x0000) | (1 << 30);
        }

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiI2CGetBusCap", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiI2CGetBusCap(UInt32 id, ref UInt32 pMaxBlkLen);

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiI2CWriteReadRaw", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiI2CWriteReadRaw(UInt32 id, UInt32 Addr, byte[] pWBuffer, UInt32 WriteBCnt, byte[] pRBuffer, UInt32 RBufLen, UInt32 ReadBCnt);

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiI2CReadTransfer", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiI2CReadTransfer(UInt32 id, UInt32 Addr, UInt32 Cmd, byte[] pBuffer, UInt32 BufLen, UInt32 ByteCnt);

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiI2CWriteTransfer", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiI2CWriteTransfer(UInt32 id, UInt32 Addr, UInt32 Cmd, byte[] pBuffer, UInt32 ByteCnt);

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiI2CProbeDevice", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiI2CProbeDevice(UInt32 id, UInt32 Addr);
        //// end of I2C

        //// begin of WDT
        [DllImport("EAPI_Library.dll", EntryPoint = "EApiWDogGetCap", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiWDogGetCap(ref UInt32 pMaxDelay, ref UInt32 pMaxEventTimeout, ref UInt32 pMaxResetTimeout);

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiWDogStart", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiWDogStart(UInt32 Delay, UInt32 EventTimeout, UInt32 ResetTimeout);

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiWDogTrigger", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiWDogTrigger();

        [DllImport("EAPI_Library.dll", EntryPoint = "EApiWDogStop", CharSet = CharSet.None, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 EApiWDogStop();
        //// end of WDT
    }
}

