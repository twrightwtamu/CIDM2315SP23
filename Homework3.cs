namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
        /*
        Q1 (3 points): Write a C# program that:
        - takes as input a number N, if the number N is a prime number, print “N is prime”, else print “N is non-prime”.
        */
        //Get Input
        int a=0;
        Console.WriteLine("Input an integer");
        int n= Convert.ToInt16(Console.ReadLine());

        for(int i=1; i<=n; i++){
            if (n%i==0){
                a++;
            }
        }
        if (a<=2&&n!=1&&n!=0){
           Console.WriteLine("N is prime");

        }else if(a>2||n<=1){
            Console.WriteLine("N is non-prime");
        }

        /*
        Q2 (2 points): Write a C# program:
        - input an integer N
        - and it prints on screen the following square pattern, where the number of
        rows and columns is equal to N

        */
        Console.WriteLine("Assign an int value to N:");
        int N= Convert.ToInt16(Console.ReadLine());
        for(int row=0; row<N; row++){
            for(int col=0; col<N; col++){
                Console.Write('*');
            }
            Console.WriteLine("");              
        }

        /*
        Q3(5 points):  Write a C# program 
        - input an integer number N
        - and it prints on screen the following square pattern, where the number of
        rows is equal to N

        */
        Console.WriteLine("Assign an int value to N:");
        int N3= Convert.ToInt16(Console.ReadLine());
        for(int row=0; row<N3; row++){
            for(int col=0; col<N3; col++){
                if(row>=col){
                    Console.Write('*');
                }
            }
            Console.WriteLine("");              
        }
        /*
        Bonus (5 points):  Write a C# program
        - input a number N
        - and it prints on screen the following square pattern, where the number of
        rows is equal to N
        */
        Console.WriteLine("Assign an int value to N:");
        int N4= Convert.ToInt16(Console.ReadLine());
        int up=0;
        int down=N4;

        //this only works for single digits
        if (N4<10){
            for(int row=0; row<N4; row++){
                up++;
                down--;
                for(int c=0; c<down;c++){
                    Console.Write(" ");
                }
                for(int b=0; b<up;b++){
                    Console.Write(up);
                }
                    Console.WriteLine("");
            }
        }else{
            Console.WriteLine("Sorry, this only works for single digits right now.");
        }



    }
}
