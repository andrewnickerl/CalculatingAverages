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
            double temp, sum = 0;
            bool isValid;
            for(int i = 0; i < 10; i++)
            {
                Console.Write("Please enter a number: ");
                isValid = double.TryParse(Console.ReadLine(), out temp);
                while(isValid==false)
                {
                    Console.Write("Error! Please enter a number: ");
                    isValid = double.TryParse(Console.ReadLine(), out temp);
                }
                sum += temp;
            }
            Console.WriteLine($"The sum is {sum}.");
        }

        //this function averages 10 input test scores and assigns a letter grade to the average
        void avgTenScores()
        {
            double temp, sum = 0;
            bool isValid;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Please enter a test score between 0 and 100: ");
                isValid = double.TryParse(Console.ReadLine(), out temp);
                while(isValid==false)
                {
                    Console.Write("Error! Please enter a number: ");
                    isValid = double.TryParse(Console.ReadLine(), out temp);
                }
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

            double avg = sum / 10; //calculate average from sum
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
            double temp, sum = 0, numScores;
            bool isValid;

            Console.Write("Please input the total number of scores you will enter: ");
            numScores = double.Parse(Console.ReadLine());

            for (int i = 0; i < numScores; i++)
            {
                Console.Write("Please enter a test score between 0 and 100: ");
                isValid = double.TryParse(Console.ReadLine(), out temp);
                while(isValid==false)
                {
                    Console.Write("Error! Please enter a number: ");
                    isValid = double.TryParse(Console.ReadLine(), out temp);
                }

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

            double avg = sum / numScores; //calculate average from sum
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
            double temp, sum = 0, numScores = 0;
            bool isValid, cont = true;

            bool contSwitch(string answer)
            {
                switch(answer)
                {
                    case "yes":
                        return true;
                    case "Yes":
                        return true;
                    case "y":
                        return true;
                    case "Y":
                        return true;
                    case "no":
                        return false;
                    case "No":
                        return false;
                    case "n":
                        return false;
                    case "N":
                        return false;
                    default:
                        Console.Write("Please enter yes or no: ");
                        return contSwitch(Console.ReadLine());
                }
            }

            while (cont == true)
            {
                Console.Write("Please enter a test score between 0 and 100: ");
                isValid = double.TryParse(Console.ReadLine(), out temp);
                while(isValid==false)
                {
                    Console.Write("Error! Please enter a number: ");
                    isValid = double.TryParse(Console.ReadLine(), out temp);
                }

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
                cont = contSwitch(Console.ReadLine());
            }

            double avg = sum / numScores; //calculate average from sum
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
