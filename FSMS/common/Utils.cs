using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace FSMS.common
{
    class Utils
    {
        /// <summary>
        /// 十六进制转二进制
        /// </summary>
        public static string HexToBin(string str)
        {
            string sTemp = string.Empty;
            foreach (char vChar in str)
            {
                byte vByte = Convert.ToByte(string.Empty + vChar, 16);
                string B = Convert.ToString(vByte, 2);
                sTemp += "0000".Substring(B.Length) + B;
            }
            return sTemp;
        }

        /// <summary>
        /// 二进制转十六进制
        /// </summary>  
        public static string BinToHex(string str, int iBit)                                               //二进制转16进制
        {
            int len = str.Length;
            double values = 0;
            for (int i = 0; i < len; i++)
            {
                values += double.Parse(str.Substring(len - i - 1, 1)) * (double)System.Math.Pow(2, i);
            }

            string sTemp = Convert.ToString(Convert.ToInt64(values), 16).ToUpper();
            sTemp = sTemp.PadLeft(iBit, '0');
            return sTemp;
        }

        /// <summary>
        /// Hexbin：字符的ASCII的二进制数据表示形式， 例 字符'1'的hex是0x31表示为hexbin是 '3''1' ，GetBytes为0x：33 31即00110011,00110001 
        /// Hex：字符的直接二进制数据（例，‘1’，byte为00110001）
        /// 实际是这样的：stirng s="0102",发送时会发送30313032 ，转换后发送01 02即以字节方式发送信息 
        /// string转byte  
        /// </summary>
        public static void Hexbin2Hex(byte[] bHexbin, byte[] bHex, int nLen)
        {
            for (int i = 0; i < nLen / 2; i++)
            {
                if (bHexbin[2 * i] < 0x41)
                {
                    bHex[i] = Convert.ToByte(((bHexbin[2 * i] - 0x30) << 4) & 0xf0);
                }
                else
                {
                    bHex[i] = Convert.ToByte(((bHexbin[2 * i] - 0x37) << 4) & 0xf0);
                }

                if (bHexbin[2 * i + 1] < 0x41)
                {
                    bHex[i] |= Convert.ToByte((bHexbin[2 * i + 1] - 0x30) & 0x0f);
                }
                else
                {
                    bHex[i] |= Convert.ToByte((bHexbin[2 * i + 1] - 0x37) & 0x0f);
                }
            }
        }

        /// <summary>
        /// 上一函数的逆过程
        /// byte转string
        /// </summary> 
        public static void Hex2Hexbin(byte[] bHex, byte[] bHexbin, int nLen)
        {
            byte c;
            for (int i = 0; i < nLen; i++)
            {
                c = Convert.ToByte((bHex[i] >> 4) & 0x0f);
                if (c < 0x0a)
                {
                    bHexbin[2 * i] = Convert.ToByte(c + 0x30);
                }
                else
                {
                    bHexbin[2 * i] = Convert.ToByte(c + 0x37);
                }
                c = Convert.ToByte(bHex[i] & 0x0f);
                if (c < 0x0a)
                {
                    bHexbin[2 * i + 1] = Convert.ToByte(c + 0x30);
                }
                else
                {
                    bHexbin[2 * i + 1] = Convert.ToByte(c + 0x37);
                }
            }
        }

        

        public static string StrToHex(string str, int iLen)
        {
            return string.Format("{0:X" + iLen + "}", Convert.ToInt32(str.Trim()));
        }

        public static string ReverseStr(string str)            //字符串反转
        {
            char[] cValue = str.ToCharArray();
            Array.Reverse(cValue);
            string sVal = new string(cValue);
            return sVal;
        }

        public static string GetMd5bit16(string ConvertString)                    //16位md5加密
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(ConvertString)), 4, 8);
            t2 = t2.Replace("-", "");
            return t2;
        }

        public static string GetMd5Bit32(string ConvertString)                  //32位md5加密
        {
            string pwd = "";
            MD5 md5 = MD5.Create();                                             //实例化一个md5对像 

            byte[] bTemp = md5.ComputeHash(Encoding.UTF8.GetBytes(ConvertString));        // 加密后是一个字节类型的数组 
            for (int i = 0; i < bTemp.Length; i++)                               // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得 
            {
                pwd = pwd + bTemp[i].ToString("X").PadLeft(2, '0');                             //转16进制大写
            }
            return pwd;
        }

        public static string GetMd5String(string ConvertString)                  //报文的md5加密
        {
            string md5Str = "";
            MD5 md5 = MD5.Create();                                             //实例化一个md5对像 

            byte[] bTemp = new byte[ConvertString.Length / 2];
            for (int i = 0; i < ConvertString.Length / 2; i++)
                bTemp[i] = Convert.ToByte(ConvertString.Substring(i * 2, 2), 16);

            byte[] cTemp;
            cTemp = md5.ComputeHash(bTemp, 0, bTemp.Length);
            for (int i = 0; i < cTemp.Length; i++)                               // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得 
            {
                md5Str = md5Str + cTemp[i].ToString("X").PadLeft(2, '0');       //转16进制大写
            }
            return md5Str;
        }

        static public string GetTimeNowDbFmt()
        { 
            return  DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        static public int GetWeekDayOfNowI()
        {
            int i = 0;
            string weekDay = DateTime.Now.ToString("dddd");
            for (i = 0; i < 7; i++)
            {
                if (GlobalDefiniation.WeekDayCnStr[i] == weekDay)
                {
                    break;
                }
            }

            return i;
        }

        static public int GetYear()
        {
            return DateTime.Now.Year;
        }
        
        public static int GetWeekOfYear()
        {
            //一.找到第一周的最后一天（先获取1月1日是星期几，从而得知第一周周末是几）
            int firstWeekend = 7 - Convert.ToInt32(DateTime.Parse(DateTime.Today.Year + "-1-1").DayOfWeek);
            
            //二.获取今天是一年当中的第几天
            int currentDay = DateTime.Today.DayOfYear;
            //三.（今天 减去 第一周周末）/7 等于 距第一周有多少周 再加上第一周的1 就是今天是今年的第几周了
            //    刚好考虑了惟一的特殊情况就是，今天刚好在第一周内，那么距第一周就是0 再加上第一周的1 最后还是1
            return Convert.ToInt32(Math.Ceiling(((currentDay - firstWeekend)/7.0))) + 1;
        }

        public static int GetWeekOfEndYear()
        {
            
            int firstWeekend = 7 - Convert.ToInt32(DateTime.Parse(DateTime.Today.Year + "-1-1").DayOfWeek);
            int yearday = 365;
            if (DateTime.Now.Year % 4 == 0)
                yearday = 366;
            return Convert.ToInt32(Math.Ceiling(((yearday - firstWeekend) / 7.0))) + 1;
        }


        public static double GetSecOfWeek(string timeFmt)
        {
            

            return 1;
        }

        public static string GetDateByWeekDay(int dayOfWeek)
        {
            int i = 0;
            string weekDay = DateTime.Now.ToString("dddd");
            for (i=0 ; i < 7; i++)
            {
                if (GlobalDefiniation.WeekDayCnStr[i] == weekDay)
                {
                    break;
                }
            }

            DateTime firstDayOfWeek = DateTime.Parse(DateTime.Now.AddDays(0 - i).ToString("yyyy-MM-dd"));
            
            //if (dayOfWeek < i)  //the next week
            //{
            //    return firstDayOfWeek.AddDays(dayOfWeek).AddDays(7).ToString("yyyy-MM-dd");
            //}
            //else
            {
                return firstDayOfWeek.AddDays(dayOfWeek).ToString("yyyy-MM-dd");
            }
        }

        public static string GetThisSundayDate()
        {
            int i = 0;
            string weekDay = DateTime.Now.ToString("dddd");
            for (i = 0; i < 7; i++)
            {
                if (GlobalDefiniation.WeekDayCnStr[i] == weekDay)
                {
                    break;
                }
            }

            DateTime firstDayOfWeek = DateTime.Parse(DateTime.Now.AddDays(0 - i).ToString("yyyy-MM-dd"));

            return firstDayOfWeek.ToString("yyyy-MM-dd"); 
        }

        public static long GetSecond()
        {
            DateTime dt = DateTime.Parse("1970-01-01");
            TimeSpan ts = DateTime.Now - dt;
            
            return (long)ts.TotalSeconds;
        }
        public static ManualResetEvent seqNoEvent = new ManualResetEvent(true);
        public static int GetSeqNo() 
        {
            int seqNo;
            seqNoEvent.WaitOne();

            if (GlobalDefiniation.Seq_No >= 0xffff)                                 
            {
                GlobalDefiniation.Seq_No = 1;
            }
            else
            {
                GlobalDefiniation.Seq_No ++;
            }
            seqNo = GlobalDefiniation.Seq_No;
            seqNoEvent.Set();

            return GlobalDefiniation.Seq_No;
            
        }

        /*
         *  public static int Max7_Mem_Addr = 0x7f5f;
            public static int Max_Mem_Addr = 0x7ff8;
            public static int Min_Mem_Addr = 0x0008;
         */
        public static void GetMemArea(ref int areaNo, ref int memAddr)
        {
            areaNo = GlobalDefiniation.Area_No;
            memAddr = GlobalDefiniation.Mem_Addr;
                        
        }

        public static void IncMemArea()
        {
            GlobalDefiniation.Mem_Addr += 8;

            if (GlobalDefiniation.Area_No < 7)
            {
                if (GlobalDefiniation.Mem_Addr > GlobalDefiniation.Max_Mem_Addr)
                {
                    GlobalDefiniation.Area_No = ++GlobalDefiniation.Area_No % 8;
                    GlobalDefiniation.Mem_Addr = GlobalDefiniation.Min_Mem_Addr;

                }
            }
            else if (GlobalDefiniation.Mem_Addr > GlobalDefiniation.Max7_Mem_Addr)
            {
                GlobalDefiniation.Area_No = ++GlobalDefiniation.Area_No % 8;
                GlobalDefiniation.Mem_Addr = GlobalDefiniation.Min_Mem_Addr;
            }

            WritePrivateProfileString("SEQ", "AreaNo", GlobalDefiniation.Area_No.ToString(), GlobalDefiniation.SEQ_CONFIG_FILE);
            WritePrivateProfileString("SEQ", "MemAddr", GlobalDefiniation.Mem_Addr.ToString(), GlobalDefiniation.SEQ_CONFIG_FILE);
        }

        public static Control getControl(string controlName, Form form)
        {
            
            foreach (Control c in form.Controls)
            {
                if (c.Name == controlName)
                {
                    return c;
                }
            }
            return null;
        }
        public static Control getControl(string controlName, PictureBox form)
        {

            foreach (Control c in form.Controls)
            {
                if (c.Name == controlName)
                {
                    return c;
                }
            }
            return null;
        }
        public static Control getControl(string controlName, GroupBox form)
        {
            foreach (Control c in form.Controls)
            {
                if (c.Name == controlName)
                {
                    return c;
                }
            }
            return null;
        }

        public static Control getControl(string controlName, TabPage form)
        {
            foreach (Control c in form.Controls)
            {
                if (c.Name == controlName)
                {
                    return c;
                }
            }
            return null;
        }

        public static Control getControl(string controlName, TabControl form)
        {
            foreach (Control c in form.Controls)
            {
                if (c.Name == controlName)
                {
                    return c;
                }
            }
            return null;
        }


        /// <summary>
        /// 用memcmp比较字节数组
        /// </summary>
        /// <param name="b1">字节数组1</param>
        /// <param name="b2">字节数组2</param>
        /// <returns>如果两个数组相同，返回0；如果数组1小于数组2，返回小于0的值；如果数组1大于数组2，返回大于0的值。</returns>
        public static int MemoryCompare(byte[] b1, byte[] b2)
        {
            IntPtr retval = memcmp(b1, b2, new IntPtr(b1.Length));
            return retval.ToInt32();
        }

        /// <summary>
        /// 比较字节数组
        /// </summary>
        /// <param name="b1">字节数组1</param>
        /// <param name="b2">字节数组2</param>
        /// <returns>如果两个数组相同，返回0；如果数组1小于数组2，返回小于0的值；如果数组1大于数组2，返回大于0的值。</returns>
        public static int MemoryCompare2(byte[] b1, byte[] b2)
        {
            int result = 0;
            if (b1.Length != b2.Length)
                result = b1.Length - b2.Length;
            else
            {
                for (int i = 0; i < b1.Length; i++)
                {
                    if (b1[i] != b2[i])
                    {
                        result = (int)(b1[i] - b2[i]);
                        break;
                    }
                }
            }
            return result;
        }


        public static string GetDevNoFmt(string devNo)
        {
            return devNo.PadLeft(3, '0');
        }

        public static string BytesToHexStr(byte[] buf)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < buf.Length; i++)
            {
                sb.Append(Convert.ToString(buf[i], 16).PadLeft(2,'0').ToUpper() + " ");
            }
            return sb.ToString();
        }

        /// <summary>
        /// memcmp API
        /// </summary>
        /// <param name="b1">字节数组1</param>
        /// <param name="b2">字节数组2</param>
        /// <returns>如果两个数组相同，返回0；如果数组1小于数组2，返回小于0的值；如果数组1大于数组2，返回大于0的值。</returns>
        [DllImport("msvcrt.dll")]
        private static extern IntPtr memcmp(byte[] b1, byte[] b2, IntPtr count);
        [DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
    }
}
