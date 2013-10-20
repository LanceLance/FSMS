using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace FSMS.model
{
    class Utils
    {
        /// <summary>
        /// ʮ������ת������
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
        /// ������תʮ������
        /// </summary>  
        public static string BinToHex(string str, int iBit)                                               //������ת16����
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
        /// Hexbin���ַ���ASCII�Ķ��������ݱ�ʾ��ʽ�� �� �ַ�'1'��hex��0x31��ʾΪhexbin�� '3''1' ��GetBytesΪ0x��33 31��00110011,00110001 
        /// Hex���ַ���ֱ�Ӷ��������ݣ�������1����byteΪ00110001��
        /// ʵ���������ģ�stirng s="0102",����ʱ�ᷢ��30313032 ��ת������01 02�����ֽڷ�ʽ������Ϣ 
        /// stringתbyte  
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
        /// ��һ�����������
        /// byteתstring
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

        public static string ReverseStr(string str)            //�ַ�����ת
        {
            char[] cValue = str.ToCharArray();
            Array.Reverse(cValue);
            string sVal = new string(cValue);
            return sVal;
        }

        public static string GetMd5bit16(string ConvertString)                    //16λmd5����
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(ConvertString)), 4, 8);
            t2 = t2.Replace("-", "");
            return t2;
        }

        public static string GetMd5Bit32(string ConvertString)                  //32λmd5����
        {
            string pwd = "";
            MD5 md5 = MD5.Create();                                             //ʵ����һ��md5���� 

            byte[] bTemp = md5.ComputeHash(Encoding.UTF8.GetBytes(ConvertString));        // ���ܺ���һ���ֽ����͵����� 
            for (int i = 0; i < bTemp.Length; i++)                               // ͨ��ʹ��ѭ�������ֽ����͵�����ת��Ϊ�ַ��������ַ����ǳ����ַ���ʽ������ 
            {
                pwd = pwd + bTemp[i].ToString("X").PadLeft(2, '0');                             //ת16���ƴ�д
            }
            return pwd;
        }

        public static string GetMd5String(string ConvertString)                  //���ĵ�md5����
        {
            string md5Str = "";
            MD5 md5 = MD5.Create();                                             //ʵ����һ��md5���� 

            byte[] bTemp = new byte[ConvertString.Length / 2];
            for (int i = 0; i < ConvertString.Length / 2; i++)
                bTemp[i] = Convert.ToByte(ConvertString.Substring(i * 2, 2), 16);

            byte[] cTemp;
            cTemp = md5.ComputeHash(bTemp, 0, bTemp.Length);
            for (int i = 0; i < cTemp.Length; i++)                               // ͨ��ʹ��ѭ�������ֽ����͵�����ת��Ϊ�ַ��������ַ����ǳ����ַ���ʽ������ 
            {
                md5Str = md5Str + cTemp[i].ToString("X").PadLeft(2, '0');       //ת16���ƴ�д
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
            //һ.�ҵ���һ�ܵ����һ�죨�Ȼ�ȡ1��1�������ڼ����Ӷ���֪��һ����ĩ�Ǽ���
            int firstWeekend = 7 - Convert.ToInt32(DateTime.Parse(DateTime.Today.Year + "-1-1").DayOfWeek);
            
            //��.��ȡ������һ�굱�еĵڼ���
            int currentDay = DateTime.Today.DayOfYear;
            //��.������ ��ȥ ��һ����ĩ��/7 ���� ���һ���ж����� �ټ��ϵ�һ�ܵ�1 ���ǽ����ǽ���ĵڼ�����
            //    �պÿ�����Ωһ������������ǣ�����պ��ڵ�һ���ڣ���ô���һ�ܾ���0 �ټ��ϵ�һ�ܵ�1 �����1
            return (currentDay - firstWeekend )/ 7 + 1;
        }
    }
}
