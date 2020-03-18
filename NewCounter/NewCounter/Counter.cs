using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NewCounter
{
    class Counter
    {
        String x;
        String y;
        char mathSign;

        public String X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public String Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public char MathSign
        {
            get
            {
                return mathSign;
            }

            set
            {
                mathSign = value;
            }
        }


        #region 判断字符串是否有字母方法一
        /// <summary>
        /// 名称：IsAllChar
        /// 判断文本是否全是字母组合
        /// </summary>
        /// <param name="text">需判断的文本或是字符串</param>
        /// <returns>返回true代表有字母存在</returns>
        public static bool IsAllChar(string text)
        {
            foreach (char tempchar in text.ToCharArray())
            {
                if (!char.IsLetter(tempchar))
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
        #region 判断字符串是否有字母方法二
        /// <summary>
        /// 正则表达式
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool isExists(string str)
        {
            return Regex.Matches(str, "[a-zA-Z]").Count > 0;
        }
        #endregion
        /// <summary>
        /// 字符串相减
        /// </summary>
        /// <param name="str">被减字符串</param>
        /// <param name="STR">减字符串</param>
        /// <returns>返回差字符串</returns>
        public string subt(string str ,string STR)
        {
            int j = str.IndexOf(STR);// “12x”.“x”
            return str.Remove(j,STR.Length);
        }

        public void counter()
        {
            switch (MathSign)
            {
                case '+':
                    if (isExists(x) || isExists(y))
                        Console.WriteLine("{0} {1} {2}= {3}", x, MathSign, y, x + y);
                    else
                        Console.WriteLine("{0} {1} {2}= {3}", Int32.Parse(x), MathSign, Int32.Parse(y), Int32.Parse(x) + Int32.Parse(y));
                    break;
                case '-':
                    if (isExists(x) || isExists(y))
                        if (x.Length < y.Length)
                        {
                            Console.WriteLine("被减字符串长度不符"); break;
                        }
                        else
                        {
                            Console.WriteLine("{0} {1} {2}= {3}", x, MathSign, y,subt(x,y));
                        }
                    else
                        Console.WriteLine("{0} {1} {2}= {3}", Int32.Parse(x), MathSign, Int32.Parse(y), Int32.Parse(x) - Int32.Parse(y));
                    break;
                case '*': Console.WriteLine("{0} {1} {2}= {3}", Int32.Parse(x), MathSign, Int32.Parse(y), Int32.Parse(x) * Int32.Parse(y)); break;
                case '/':
                    if (Int32.Parse(y) != 0)
                        Console.WriteLine("{0} {1} {2}= {3}", Int32.Parse(x), MathSign, Int32.Parse(y), Int32.Parse(x) / Int32.Parse(y));
                    else
                        Console.WriteLine(" Your divisor can not be zero!");
                    break;
                default: Console.WriteLine(" Your math sign is ERROR!!!"); break;
            }
        }

    }
}
