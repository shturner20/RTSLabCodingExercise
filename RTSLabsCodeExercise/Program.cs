using System;
using System.Text;

namespace RTSLabsCodeExercise
{
    class Program
    {
        //1 Print the number of integers in an array that are above the given input and the number that are below,
        //e.g. for the array [1, 5, 2, 1, 10] with input 6, print “above: 1, below: 4”
        public static string PrintArrayIntegerAboveAndBelow(int[] intArray, int inputNum)
        {
            int aboveCount = 0;
            int belowCount = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[0] == inputNum)
                    continue;
                else if (intArray[i] > inputNum)
                    aboveCount++;
                else
                    belowCount++;
            }

            return $"above: {aboveCount}, below: {belowCount}";
        }

        //2 Rotate the characters in a string by a given input and have the overflow appear at the beginning, e.g.
        //“MyString” rotated by 2 is “ngMyStri”.
        public static string RotateString(string input, int rotateNum)
        {
            if (input.Length < rotateNum)
                rotateNum = rotateNum % input.Length;

            var endIndex = input.Length - rotateNum;
            var endString = input.Substring(endIndex, input.Length - endIndex);

            var rotatedString = endString + input.Remove(endIndex);

            return rotatedString;


        }




        static void Main(string[] args)
        {

          

            bool runtest = true;

            while (true)
            {
               

                if(runtest)
                {
                    Console.WriteLine("Select test to run");
                    Console.WriteLine("Integer Above/Below (A), Rotate String (B)");
                    var testResponseKey = Console.ReadKey().Key.ToString();
                    Console.WriteLine(Environment.NewLine);


                    switch (testResponseKey.ToUpper())
                    {
                        case "A":
                            RunAboveBelowIntegerTest();
                            break;
                        case "B":
                            RunRotateStringTest();
                            break;
                        default:
                            Console.WriteLine("Invalid Input!" + Environment.NewLine);
                            break;
                    }

                }



                Console.WriteLine(Environment.NewLine + "Try again (A) or quit (Q)");

                var responsekey = Console.ReadKey().Key.ToString();
                Console.WriteLine(Environment.NewLine);

                if (responsekey.ToUpper() == "A")
                {
                    runtest = true;
                    continue;
                }
                else if (responsekey.ToUpper() == "Q")
                    Environment.Exit(0);
                else
                {
                    runtest = false;
                    Console.WriteLine("Invalid Response!" + Environment.NewLine);
                }
                  
            }


            
        }

        private static void RunAboveBelowIntegerTest()
        {
            Console.WriteLine("Enter input for Above Below Array [1, 5, 2, 1, 10, 7, 13, 17, 22]");
            var input = Console.ReadLine();

            if (int.TryParse(input, out int parsedInt))
            {
                var result = PrintArrayIntegerAboveAndBelow(new int[9] { 1, 5, 2, 1, 10, 7, 13, 17, 22 }, parsedInt);

                Console.WriteLine(result + Environment.NewLine);

            }
        }

       

       

        public static void RunRotateStringTest()
        {
            Console.WriteLine("Enter string to rotate.");
            var input = Console.ReadLine();
            int rotateInputNum = 0;


            while (true)
            {
                Console.WriteLine(Environment.NewLine + "Enter Integer to rotate by.");
                var rotateInput = Console.ReadLine();

                if (int.TryParse(rotateInput, out rotateInputNum))
                    break;
                else
                    Console.WriteLine(Environment.NewLine + "Invalid number.");
            }

                var result = RotateString(input, rotateInputNum);         
                Console.WriteLine(Environment.NewLine + $"Rotated String: {result}");

           
        }
    }
}
