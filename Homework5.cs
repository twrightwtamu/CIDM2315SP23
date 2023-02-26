namespace Homework5;
class Program
{
    static void Main()
    {
        /*
        I know my assignment is late, I do not expect points. I completed the assignment in hopes of receiving
        corrections if needed so I don't miss important material for future lessons. Apologies, life happened.
        */
        /*
        Q1 (2 points): Write a C# method that:
        - get 2 integers as inputs from the keyboard
        - and returns the largest one
        - call this method in Main() and print the result.
        */
        int inputA,inputB,inputC,inputD;
        Console.WriteLine("The largest number is: "+Q1(out inputA,out inputB));
        /*
        Q2 (3 points): Write a C# method:
        - get 4 integers as inputs from the keyboard
        - and returns the largest one
        - you should use the method from Q1 to solve this exercise. (You will lose 2 points if you didn’t use the method from Q1 to answer this question)
        - call this method in Main() and print the result.
        */
        Console.WriteLine("The largest number is: "+Q2(out inputA,out inputB, out inputC, out inputD));
        /*
        Q3 (5 points): Please implement the following methods to design an account-creating process:
        static bool checkAge(int birth_year){
            // calculate the age based on the birth_year (age = 2022-birthyear)
            // if age >=18, return true;
            //else return false;
        } // 1 points

        static void createAccount(){
        // ask user to input username
        // ask user to input password
        // ask user to input password again
        // ask user to input birthyear
        // call checkAge(birthyear) method to check if age is greater than 18
        // if checkAge(birthyear) returns true, 
        //then check if two passwords are same, if passwords are same, print “Account is created successfully”
        // else print “Wrong password”
            // if checkAge(birthyear) returns false, print “Could not create an account”
        } //4 points
        */
        CreateAccount();
    }
    static bool CheckAge(int birthyear){
        int age= 2022-birthyear;
        return age >= 18;
    }
    static void CreateAccount(){
        Console.WriteLine("Enter Your Username:");
        string username=(Console.ReadLine());
        Console.WriteLine("Enter Your Password:");
        string password1 = Console.ReadLine();
        Console.WriteLine("Enter Your Password Again:");
        string password2=(Console.ReadLine());
        Console.WriteLine("Enter Your Birthyear:");
        int birthyear=Convert.ToInt16(Console.ReadLine());
        bool age=CheckAge(birthyear);
        bool match=PasswordMatch(password1,password2);
        if(!age){
            Console.WriteLine("Could not create an account.");
        }else{
            if (match){
                Console.WriteLine("Account is created successfully");
            }else{
                Console.WriteLine("Wrong Password");
            }
        }
    }
    static bool PasswordMatch(string p1,string p2){
        return p1 == p2;
    }
    static int Q1(out int A,out int B){
        Console.WriteLine("Please enter two integers:");
        A = Convert.ToInt16(Console.ReadLine());
        B=Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"a={A}; b={B}");
       return GetLargest(A,B);
    }
    static int GetLargest(int A,int B){
         if (A>B){
            return A;
        }else{
            return B;
        }
    }
    static int Q2(out int A, out int B, out int C, out int D){
        Console.WriteLine("Please enter four integers:");
        A=Convert.ToInt16(Console.ReadLine());
        B=Convert.ToInt16(Console.ReadLine());
        C=Convert.ToInt16(Console.ReadLine());
        D=Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"a={A}; b={B}; c={C}; d={D}");
        int comp1= GetLargest(A,B);
        int comp2= GetLargest(C,D);
        return GetLargest(comp1,comp2);
    }
}
