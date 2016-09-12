using System;

namespace _03_Simon_Says
{
    internal class Simon
    {

        internal string Echo(string v)
        {
            return v.ToLower();
        }

        internal string Shout(string v)
        {
            return v.ToUpper();
        }

        internal string Repeat(string v)
        {
            return v + " " + v;
        }

        internal object Repeat(string v1, int v2)
        {
            string str = "";
            for (int i = 0; i < v2; i++)
            {
                if (i == 0)
                {
                    str = str + v1;
                }
                else
                {
                    str = str + " " + v1;
                }
            }
            return str;
        }

        internal string StartOfWord(string v1, int v2)
        {
            return v1.Substring(0, v2);
        }

        internal string FirstWord(string v)
        {
            return v.Substring(0, v.IndexOf(" "));
        }

        internal string Titleize(string v)
        {
            string result = "";
            string RStr;
            int i = 0;
            string[] words = v.Split(' ');

            foreach (string str in words)
            {
                if (i == 0)
                {
                    RStr = char.ToUpper(str[0]) + str.Substring(1);
                    result = result + RStr;
                }
                else
                {
                    if (str != "over" && str != "the" && str != "and" )
                    {
                        RStr = char.ToUpper(str[0]) + str.Substring(1);
                        result = result + " " + RStr;
                    }
                    else
                    {
                        result = result + " " + str;
                    }

                }
                i++;
            }

            return result;
        }

       
    }
}