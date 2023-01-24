namespace Homework1;
class Program
{
    static void Main(string[] args)


    {
        /*
        Assignment:
        Q1 (5 Points) The linear line Equation is: Z = 4X2+3Y, when  X = 2.5, Y=3.3, write a program to:
        calculate the value of Z and print it out in the following format.
        (Hint: in computer programming,  4X2  can be represented as 4*X*X; and use formatted string to print results)
        */

        // Declare the variables
        double x=2.5;
        double y=3.3;
        double z;

        //alternate possibility
        //double z=4*x*x+3*y;
        //string text= "The value of Z is: ";

        /*
        Note to Zhang: 
        I included this extra commented out variable line & WriteLine because this is how I would normally do this.
        I have very limited java 'experience'. 
        I did not expect calculations to be performed in the WriteLine so I chose this method of presentation.
        I have never seen or used interpolation so I chose this method for practice purposes.
        I hope that I will not lose points for all my extra comments. 
        */

        //Write the answer to the console.
        
        Console.WriteLine($"X = {x}, Y = {y}");
        //Console.WriteLine(text+z);
        Console.WriteLine($"The value of Z is: { z=4*x*x+3*y} ");




    }
}
