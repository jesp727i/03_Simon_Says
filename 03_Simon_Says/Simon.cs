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
            //Initialisere de variabler jeg skal bruge
            string result = ""; //Endelige resultat
            string RStr; //Er den variabel der til hvert ord der får stort får bogstav
            int i = 0; //tæller til mit foreach loop
            string[] words = v.Split(' '); //splitter den string der bliver sendt over, hvergang der er et mellemrum og ligger dem i et array

            //løkke der løber i gennem mit array "words" og giver mig det enkelte ord som "str"
            foreach (string str in words)
            {
                if (i == 0) //tjekker om det er den første plads i mit array
                {
                    RStr = char.ToUpper(str[0]) + str.Substring(1); // laver ordet i "str" om så det første bogstav er stort
                    result = result + RStr; // ligger ordet i "RSts" oven i mit resultat
                }
                else // tager alle andre ord en det første i mit array
                {
                    if (str != "over" && str != "the" && str != "and" ) // thekker om ordet "str" er en af de ord som ikke skal være små
                    {
                        RStr = char.ToUpper(str[0]) + str.Substring(1); // laver ordet i "str" om så det første bogstav er stort
                        result = result + " " + RStr;// laver et mellemrum og ligger ordet i "RSts" oven i mit resultat
                    }
                    else //bruges når ordet er et af dem der skal være små
                    {
                        result = result + " " + str; // ligger ordet "str" oven i min sætning uden at det bliver stort
                    }

                }
                i++; // tæller som fortæller om det er det første ord i mit array
            }
            string t = "jesper";
            return result; //retunerer mit resultat
        }

       
    }
}