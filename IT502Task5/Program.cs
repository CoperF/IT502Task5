using System;


namespace Task5
{
    class Calculate //Create class to do calculations in
    {
        public double CalcAverage(double math, double physics, double chemistry, double ComputerScience) //Creating method to calculate the average grade of the 4 subjects
        {


            return (math + physics + chemistry + ComputerScience) / 4.00; //Calculating to get the average grade using the marks from the 4 subjects
        }

        public char CalcMarks(double average) //Creating method to get the final grade using the average grade
        {

            if (average >= 80 && average <= 100)
                return 'A';

            else if (average >= 70 && average < 80)
                return 'B';

            else if (average >= 60 && average < 70)
                return 'C';

            else if (average >= 50 && average < 60)
                return 'D';

            else if (average < 50 && average >= 0)
                return 'F';

            else
                return '!';
        }
    }


    class IT502 //Create another class to store the main method
    {
        public static void Main(string[] args) //Creating the main method

        {
            try //Implementing try and catch to catch any invalid inputs within this and display it
            {
                int studentID; //Initializing integer variable studentID to take user input

                Console.WriteLine("Enter your student ID: "); //Display asking user to enter their student ID
                studentID = Convert.ToInt32(Console.ReadLine()); //Taking user's input for student ID
                Console.WriteLine("You have signed in as student: " + studentID); //Display the user's input
                
                Console.WriteLine("Please enter your marks for Math (0/100): "); //Display asking user to enter marks for math 0 out of 100
                double math = Convert.ToDouble(Console.ReadLine()); //Taking the user's input for math marks

                Console.WriteLine("Please enter your marks for Physics (0/100): "); //Display asking user to enter marks for physics 0 out of 100
                double physics = Convert.ToDouble(Console.ReadLine()); //Taking user's input for physics marks

                Console.WriteLine("Please enter your marks for Chemistry (0/100): "); //Display asking user to enter marks for chemistry 0 out of 100
                double chemistry = Convert.ToDouble(Console.ReadLine()); //Taking user's input for chemistry marks

                Console.WriteLine("Please enter your marks for ComputerScience (0/100): "); //Display asking user to enter marks for computerscience 0 out of 100
                double ComputerScience = Convert.ToDouble(Console.ReadLine()); //Taking user's input for computerscience marks
     
                Calculate calculated = new Calculate(); //Making instance of the class Calculate to be able to do calculations for the student marks
                double average = calculated.CalcAverage(math, physics, chemistry, ComputerScience); //Calculate average marks for all the subjects
                char grade = calculated.CalcMarks(average); //Calculating to see the final grade based of the average marks

                switch (grade) //Using switch case statements to display message based on the final grade
                {
                    case 'A':
                        Console.WriteLine("Excellent! Your grade is A");
                        break;

                    case 'B':
                        Console.WriteLine("Good! Your grade is B");
                        break;

                    case 'C':
                        Console.WriteLine("Satisfactory. Your grade is C");
                        break;

                    case 'D':
                        Console.WriteLine("Pass. Your grade is D");
                        break;

                    case 'F':
                        Console.WriteLine("Fail. Your grade is F");
                        break;

                    default:
                        Console.WriteLine("You have entered the wrong input.");
                        break;
                }
            }
            catch (Exception ex) //Catching any exceptions of invalid inputs
            {
                Console.WriteLine("Exception is " + ex.Message); //Displaying message of what the exception is
            }
        }
    }
}