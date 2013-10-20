using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace FSMS.model
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
            return  DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        static public string GetWeekDayOfNow()
        {
            return DateTime.Now.DayOfWeek.ToString() ;
        }

        
        public static int GetWeekOfYear()
        {
            //一.找到第一周的最后一天（先获取1月1日是星期几，从而得知第一周周末是几）
            int firstWeekend = 7 - Convert.ToInt32(DateTime.Parse(DateTime.Today.Year + "-1-1").DayOfWeek);
            
            //二.获取今天是一年当中的第几天
            int currentDay = DateTime.Today.DayOfYear;
            //三.（今天 减去 第一周周末）/7 等于 距第一周有多少周 再加上第一周的1 就是今天是今年的第几周了
            //    刚好考虑了惟一的特殊情况就是，今天刚好在第一周内，那么距第一周就是0 再加上第一周的1 最后还是1
            return (currentDay - firstWeekend )/ 7 + 1;
        }
    }
}
