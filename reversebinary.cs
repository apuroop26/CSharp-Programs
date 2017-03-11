using System;

namespace rev
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = 0; //user input
            int[] binNum = new int[30]; //array to hold binary 

            number = Convert.ToInt32(Console.ReadLine());

            //Test for boundary cond
            if (number < 1 || number > 1000000000)
            {
               Console.WriteLine("Error in size");
                //return 0;
            }

            //convert input to binary
            int marker = 29;
            while (number >= 1)
            {
                if (number % 2 == 0)
                {
                    binNum[marker] = 0;
                }
                else
                {
                    binNum[marker] = 1;
                }
                number = number / 2;

                marker--;
            } //end while loop

            //Determines most significant bit 
            int buff;
            int toggle = 0;
            int breakPoint = 0;
            for (int i = 0; i < 30; i++)
            {
                if (binNum[i] == 1 && toggle == 0)
                {
                    buff = 1;
                    breakPoint = i;
                    toggle = 1;
                }

            }


            //Block copies binary equivalent
            int[] swap = new int[30];
            for(int i=0; i<30; i++)
            {
                swap[i] = binNum[i];
            }

            //Block reverse
            int pivot = 0;
            for(int i=29; i >= breakPoint; i--)
            {
                binNum[i] = swap[breakPoint + pivot];
                pivot++;
            }


            double newNumber = 0;
            double range = 29 - breakPoint;

            for (int i=breakPoint; i < 30; i++)
            {
                if (binNum[i] == 1)
                {
                    newNumber = newNumber + Math.Pow(2, range);
                }
                range--;
            }

            Console.WriteLine(newNumber);

            return;

            }
    }
}
