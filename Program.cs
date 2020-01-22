using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
            Console.ReadKey();
        }

        void run()
        {
            //sumOfNumbers();
            //avgTenScores();
            //avgSpecScores();
            avgNonSpecScores();
        }

        //this method takes the sum of 10 input numbers
        void sumOfNumbers()
        {
            int temp;
            int sum = 0;
            for(int i = 0; i < 10; i++)
            {
                Console.Write("Please enter a number: ");
                temp = int.Parse(Console.ReadLine());
                sum += temp;
            }
            Console.WriteLine($"The sum is {sum}.");
        }

        //this function averages 10 input test scores and assigns a letter grade to the average
        void avgTenScores()
        {
            int temp;
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Please enter a test score between 0 and 100: ");
                temp = int.Parse(Console.ReadLine());
                if(temp > 100 || temp < 0) //disallow values outside the specified range and allow another iteration of loop for 10 total accepted values
                {
                    Console.WriteLine("Please enter a value between 0 and 100.");
                    i--;
                }
                else  //if value is within specified range, add it to sum
                {
                    sum += temp;
                }
            }

            int avg = sum / 10; //calculate average from sum
            char grade;

            if (avg <= 100 && avg >= 93)
            {
                grade = 'A';
                Console.WriteLine($"Numerical grade is {avg}. Letter grade is {grade}.");
            }
            else if (avg <= 92 && avg >= 85)
            {
                grade = 'B';
                Console.WriteLine($"Numerical grade is {avg}. Letter grade is {grade}.");
            }
            else if (avg <= 84 && avg >= 78)
            {
                grade = 'C';
                Console.WriteLine($"Numerical grade is {avg}. Letter grade is {grade}.");
            }
            else if (avg <= 77 && avg >= 70)
            {
                grade = 'D';
                Console.WriteLine($"Numerical grade is {avg}. Letter grade is {grade}.");
            }
            else if (avg <= 69)
            {
                grade = 'F';
                Console.WriteLine($"Numerical grade is {avg}. Letter grade is {grade}.");
            }
        }

        //this function averages a user-predetermined amount of input test scores and assigns a letter grade to the average
        void avgSpecScores()
        {
            int temp;
            int sum = 0;
            int numScores;

            Console.Write("Please input the total number of scores you will enter: ");
            numScores = int.Parse(Console.ReadLine());

            for (int i = 0; i < numScores; i++)
            {
                Console.Write("Please enter a test score between 0 and 100: ");
                temp = int.Parse(Console.ReadLine());
                if (temp > 100 || temp < 0) //disallow values outside the specified range and allow another iteration of loop for 10 total accepted values
                {
                    Console.WriteLine("Please enter a value between 0 and 100.");
                    i--;
                }
                else  //if value is within specified range, add it to sum
                {
                    sum += temp;
                }
            }

            int avg = sum / numScores; //calculate average from sum
            char grade;

            if (avg <= 100 && avg >= 93)
            {
                grade = 'A';
                Console.WriteLine($"Numerical grade is {avg}. Letter grade is {grade}.");
            }
            else if (avg <= 92 && avg >= 85)
            {
                grade = 'B';
                Console.WriteLine($"Numerical grade is {avg}. Letter grade is {grade}.");
            }
            else if (avg <= 84 && avg >= 78)
            {
                grade = 'C';
                Console.WriteLine($"Numerical grade is {avg}. Letter grade is {grade}.");
            }
            else if (avg <= 77 && avg >= 70)
            {
                grade = 'D';
                Console.WriteLine($"Numerical grade is {avg}. Letter grade is {grade}.");
            }
            else if (avg <= 69)
            {
                grade = 'F';
                Console.WriteLine($"Numerical grade is {avg}. Letter grade is {grade}.");
            }
        }

        //this function averages a nonspecific amount of input test scores and assigns a letter grade to the average
        void avgNonSpecScores()
        {
            int temp;
            int sum = 0;
            int numScores = 0;
            bool cont = true;
            while (cont == true)
            {
                Console.Write("Please enter a test score between 0 and 100: ");
                temp = int.Parse(Console.ReadLine());
                if (temp > 100 || temp < 0) //disallow values outside the specified range and allow another iteration of loop for 10 total accepted values
                {
                    Console.WriteLine("Please enter a value between 0 and 100.");
                }
                else  //if value is within specified range, add it to sum
                {
                    sum += temp;
                    numScores++;
                }
                Console.Write("Would you like to enter another score? Please enter yes or no: ");
                switch(Console.ReadLine())
                {
                    case "yes":
                        cont = true;
                        break;
                    case "Yes":
                        cont = true;
                        break;
                    case "y":
                        cont = true;
                        break;
                    case "Y":
                        cont = true;
                        break;
                    case "no":
                        cont = false;
                        break;
                    case "No":
                        cont = false;
                        break;
                    case "n":
                        cont = false;
                        break;
                    case "N":
                        cont = false;
                        break;
                    default:
                        Console.WriteLine("Please enter yes or no.");
                        break;
                }
            }

            int avg = sum / numScores; //calculate average from sum
            char grade;

            if (avg <= 100 && avg >= 93)
            {
                grade = 'A';
                Console.WriteLine($"Numerical grade is {avg}. Letter grade is {grade}.");
            }
            else if (avg <= 92 && avg >= 85)
            {
                grade = 'B';
                Console.WriteLine($"Numerical grade is {avg}. Letter grade is {grade}.");
            }
            else if (avg <= 84 && avg >= 78)
            {
                grade = 'C';
                Console.WriteLine($"Numerical grade is {avg}. Letter grade is {grade}.");
            }
            else if (avg <= 77 && avg >= 70)
            {
                grade = 'D';
                Console.WriteLine($"Numerical grade is {avg}. Letter grade is {grade}.");
            }
            else if (avg <= 69)
            {
                grade = 'F';
                Console.WriteLine($"Numerical grade is {avg}. Letter grade is {grade}.");
            }
        }

    }
}
