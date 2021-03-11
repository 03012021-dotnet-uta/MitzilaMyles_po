using System;
// Print the numbers 1 to 1000 to the console. 
// 2.Print them in groups of 10 per line with a space separating each number.  
// 3.When the number is multiple of three, print “sweet” instead of the number on the console.  
// 4.If the number is a multiple of five, print “salty” (instead of the number) to the console.  
// 5.For numbers which are multiples of three and five, print “sweet’nSalty” to the console (instead of the number).  
// 6.After the numbers have all been printed, print out how many sweet’s, how many salty’s, and how many sweet’nSalty’s. 
// 7.These are three separate groups, so sweet’nSalty does not increment sweet or salty (and vice versa). 
// 7.Include verbose commentary in the source code to tell me what each few lines are doing. 
// 8.The coding Challenge is due by midnight, today, 03.10.21. 
// 9.Push the “compilable” source code to your P0 repo. 

namespace Sweetn_salty
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sweet = 0;
            int salty = 0;
            int sweetnSalty = 0;
            string[] nArray = new string[1002];

            for (int n = 1; n < 1001; n++)
            {
                nArray[n] = n.ToString();
                if (n % 3 == 0)
                {
                    nArray[n] = "Sweet";
                    sweet += 1;

                }
                else if(n % 5 == 0)
                {
                    nArray[n] = "Salty";
                    salty += 1;
                }
                if (n % 3 == 0 && n % 5 == 0)
                {
                    nArray[n] = "Sweet'nSalty";
                    sweetnSalty += 1;
                }

            }
            for (int m = 0; m < nArray.Length; m++)
            {
                Console.Write("{0} ", nArray[m]);
                // every 68 iterations prints a \ and new line
                if ((m + 1) % 10 == 0) Console.WriteLine("");
            }

            Console.WriteLine("\nThere are {0} Sweet", sweet);
            Console.WriteLine("There are {0} Salty", salty);
            Console.WriteLine("There are {0} Sweet'nSalty", sweetnSalty); 
        }
    }
}
