using System;
using System.Linq;
using System.Net;

namespace testlogic2_banurm
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of families: ");
            int inpNum = Convert.ToInt32(Console.ReadLine());
            //int inpNum = 5;

            Console.WriteLine("Input the number of members in the family\r\n( separated by a space) :");
            string membFam = Console.ReadLine();
            //string membFam = "1 2 4 3 3";
            //string membFam = "2 3 4 4 2 1 3 1";


            string[] memberFams = membFam.Split(' ').ToArray();
            if (memberFams.Length < inpNum)
            {
                Console.WriteLine("Input must be equal with count of family");
            }
            else
            {
                int[] membersFams = Array.ConvertAll(memberFams, Int32.Parse);

                int totalMem = 0;
                int minPass = 4;
                int minBus = 0;

                foreach (int s in membersFams)
                {
                    totalMem += s;
                }

                int sisaBagi = totalMem % minPass;
                if(sisaBagi == 0) {
                    minBus = totalMem / minPass;
                }
                else
                {
                    minBus = (totalMem - sisaBagi) / minPass;

                    if(sisaBagi <= 4)
                    {
                        minBus ++;
                    }
                }

                Console.WriteLine($"Minimum bus required is: {minBus}");
            }

            
            



        }
    }
}
