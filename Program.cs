using System;
using System.Text;

namespace CesarSifra
{

    class Program
    {
        static void Main(string[] args)
        {
            Kript kr = new Kript();

            string x = kr.CesarInkript(12, "ahojte vsichni") ;
            Console.WriteLine(x);
            Console.WriteLine(kr.CesarDekript(12, x));
            string y = kr.VigeInkript("quark", "salanender");
            Console.WriteLine(y);
            Console.WriteLine(kr.VigeDekript("quark", y));


        }
    }
    class Kript
    {
        static string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
       
        public string CesarInkript(int key, string word)
        {
            
            
            StringBuilder str = new StringBuilder(word);
            string exi = "";
            str.Replace(" ","");
            word = str.ToString();
            word = word.ToUpper();
            for (int i = 0; i < str.Length; i++)
            {
                int pos = 0;
                for (int j = 0 ;  j  < abc.Length;  j ++)
                {
                    if (word[i] == abc[j])
                    {                        
                        pos = j + key;
                        
                        break;
                    }

                }
                int x = pos % abc.Length;
                exi += Convert.ToString(abc[x]);
            }
            return exi.ToString();
        }
        public string CesarDekript(int key, string word)
        {
            StringBuilder str = new StringBuilder(word);
            string exi = "";
            str.Replace(" ", "");
            word = str.ToString();
            word = word.ToUpper();
            for (int i = 0; i < str.Length; i++)
            {
                int pos = 0;
                for (int j = 0; j < abc.Length; j++)
                {
                    if (word[i] == abc[j])
                    {
                        pos = (abc.Length + j - key )% abc.Length;

                        break;
                    }

                }

                exi += Convert.ToString(abc[pos]);
            }
            return exi;
        }

        public string VigeInkript(string kl, string word)
        {
            StringBuilder str = new StringBuilder(word);
            string exi = "";
            str.Replace(" ", "");
            word = str.ToString();
            word = word.ToUpper();
            kl = kl.ToUpper();
            int key = 0;
            for (int i = 0; i < word.Length; i++)
            {
                int x = i % kl.Length;
                for (int j = 0; j < abc.Length; j++)
                {
                    
                    if (kl[x] == abc[j])
                    {
                        key = j;

                        break;
                    }
                }
                exi += CesarInkript(key, Convert.ToString(word[i]));
            }
            return exi;   
        }
        public string VigeDekript(string kl, string word)
        {
            StringBuilder str = new StringBuilder(word);
            string exi = "";
            str.Replace(" ", "");
            word = str.ToString();
            word = word.ToUpper();
            kl = kl.ToUpper();
            int key = 0;
            for (int i = 0; i < word.Length; i++)
            {
                int x = i % kl.Length;
                for (int j = 0; j < abc.Length; j++)
                {

                    if (kl[x] == abc[j])
                    {
                        key = j;

                        break;
                    }
                }
                exi += CesarDekript(key, Convert.ToString(word[i]));
            }
            return exi;
        }
    }
}
