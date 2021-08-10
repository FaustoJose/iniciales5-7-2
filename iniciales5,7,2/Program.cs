using System;


namespace iniciales5_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = "dios fiel";
            iniciales(ref num1);
            Console.WriteLine(num1);
        }
        public static void iniciales(ref string Palabra)
        {
            string inc1="";
            string inc2="";
           
 
            for (int i = 0; i <= Palabra.Length-1; i++)
            {


                if (Palabra[i] == ' ')
                {
                    for (int j = i; j <= Palabra.Length-1; j++)
                    {
                        inc2 += Palabra[j].ToString();

                        
                    }


                }
                else
                {
                    inc1 +=Palabra[i].ToString();

                }
               
            }

            Palabra = inc1[0].ToString() + inc2[1].ToString();
            Palabra = Palabra.ToUpper();

        }
    }
}
