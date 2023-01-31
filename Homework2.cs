namespace Homework2;
class Program
{
    static void Main(string[] args)
    {
        /*
        Q1 (5 points): Write a C# program:
        Input a grade in letters (A, B, C, D, F), print the corresponding GPA points
        A:4     B:3   C:2	D:1	F:0
        If the user input a letter rather than (A, B, C, D, F), then print “Wrong Letter Grade!”
        */

        //Get Input
        Console.WriteLine("Please input a letter grade:");
        string userInput= Console.ReadLine();
        string LetterGrade=userInput.ToUpper();

        //switch statement
           switch(LetterGrade)
            {
            case "A":
                Console.WriteLine("GPA point: 4");
                break;
            case "B":
                Console.WriteLine("GPA point: 3");
                break;
            case "C":
                Console.WriteLine("GPA point: 2");
                break;
            case "D":
                Console.WriteLine("GPA point: 1");
                break;
            case "F":
                Console.WriteLine("GPA point: 0");
                break; 
            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;
            }

        /*
            Q2 (5 points): Write a C# program:
            Ask the user to input three numbers and print the smallest value.
        */

        //Get Input
        Console.WriteLine("Please input the first num:");
        string userInNum1= Console.ReadLine();
        Console.WriteLine("Please input the second num:");
        string userInNum2= Console.ReadLine();
        Console.WriteLine("Please input the third num:");
        string userInNum3= Console.ReadLine();

        //convert the input to integers
        int n1 = Convert.ToInt16(userInNum1);
        int n2 = Convert.ToInt16(userInNum2);
        int n3 = Convert.ToInt16(userInNum3);

        //declare other variables
        string leadText= "The smallest value is: ";

        //determine the smallest value with a nested if statement

        if(n1<n2){
            if(n1<n3){
                Console.WriteLine(leadText+n1);
            }
            else{
                Console.WriteLine(leadText+n3);
            }
        }else{
            if(n2<n3){
                Console.WriteLine(leadText+n2);
            }
            else{
                Console.WriteLine(leadText+n3);
            }
        }
        
        /*
        Bonus (5 points):  Write a C# program that takes as input a year and check if it is a leap year.
        Test your program by inputting:
        - a leap year: 2008
        - and a non-leap year: 1900
        */
        
        //Get Input
        Console.WriteLine("Please input a year :");
        string userInYear = Console.ReadLine();

        //convert year to int
        int year = Convert.ToInt16(userInYear);

        //else if divisible by 400=true, else divisible by100=false, else divisible by 4=true, all else=false
        if(year%400==0){
            Console.WriteLine($"{year} is a leap year");
        }else if(year%100==0){
            Console.WriteLine($"{year} is not a leap year");
        }else if(year%4==0){
            Console.WriteLine($"{year} is a leap year");
        }else{
            Console.WriteLine($"{year} is not a leap year");
        }

    }
}
