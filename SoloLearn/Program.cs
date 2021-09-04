using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata.GetVowelCount("абракадабра");
            




        }
            

         
    }



        
    

    public static class Kata
    {
        public static object GetVowelCount(string str)
        {
            int vowelCount = 0;
            
            
        string [] vovels = new string[] {str };
            for (int i = 0;i< vovels.Length;i++)
            {
                
                if (vovels[i].Equals("a") == true)
                {
                    vovels[i] = "a";
                }
                    
                    
                
                else if (vovels[i].Equals("e") == true)
                {
                    vovels[i] = "e";
                }
                else if (vovels[i].Equals("i") == true)
                {
                    vovels[i] = "i";
                }
                else if (vovels[i].Equals("o") == true)
                {
                    vovels[i] = "o";
                }
                else if (vovels[i].Equals("u") == true)
                {
                    vovels[i] = "u";
                }
                else
                {
                    Array.Clear(vovels,i,vowelCount);
                }


            }
                vowelCount = str.Length;

            Console.WriteLine(vowelCount);

        


            return vowelCount;
        }
    }




}

