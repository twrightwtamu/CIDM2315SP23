namespace Homework4;
class Program
{
    static void Main(string[] args)
    {
        /*
        Q1 (4 points): Write a C# method that:
        - takes as input 2 numbers
        - and returns the largest one
        - call this method in Main() and print the result.
        */
        Console.WriteLine("Question 1: take 2 inputs, return the largest");
        //call ask for int method and assign values to x & y variables
        int x=AskforInt();
        int y=AskforInt();
        //call question 1 method and return values to user
        Console.WriteLine($"a={x}, b={y}");
        Console.WriteLine("The largest number is: "+Question1(x,y));
         /*
         Q2(6 points):  Write a C# method 
        - take as an integer number N and a shape (left or right) 
        - if the shape is left and N = 5, print values of N and shape, and a left-side triangle 
        */
        //request input
        Console.WriteLine(" ");  
        Console.WriteLine("Question 2: Get integer input and shape input return values and triangle");
        //call method and assign new value to existing int x
        x=AskforInt();
        //ask for shape
        Console.WriteLine("Please enter shape(left or right):");
        //call get shape method and assign numeric value to theShape variable
        int theShape=GetShape();
        //call question 2 output method, pass int x and theShape int parameters to method
        Question2Output(x,theShape);
    }//main ends

    //this method asks for an int and converts the input to int
    static int AskforInt(){
    Console.WriteLine("Please enter an integer.");
    return Convert.ToInt16(Console.ReadLine());
    }

    //this method compares 2 integers and returns the largest value for question 1
     static int Question1(int a, int b){
        if(a>b){
            int res=a;
            return res;
        }else{
            int res=b;
            return res;
        }
    }

    //gets imput from console, calls shape value method returns numeric shape value
    static int GetShape(){
        string shape=Console.ReadLine();
        int value=GetShapeValue(shape);
        return value;
    }

    /*
    this method takes a string parameter, checks if the shape is valid and assigns a numeric value.
    if the shape does not match expected input, calls the GetShape method again. A valid shape is required. 
    shape string should be converted to all caps or lowercase to be more effective/neater. I didn't do this. oops.
    I returned 0 because the method expects an int value. Could have used bool.
    */
    static int GetShapeValue(string shape){
        if (shape=="Left"||shape=="left"){
            return 1;
        }else if(shape=="Right"||shape=="right"){
            return 2;
        }else{
            Console.WriteLine("Must enter valid shape to proceed!");
            GetShape();
            return 0;           
        }
    }

    /*
    this method determines the output for question 2, a value of 1= left, a value of 2=right, the only possible values
    passed to this method are 1&2. I am lazy so I copied and modified code from homework 3 into their own methods and called them.
    I should clean all of this up more. 
    */
    static void Question2Output(int x,int theShape){
        if (theShape==1){
            Console.WriteLine($"N is: {x}; shape is left" );
            Homework3Q3Code(x);
        }else{
            Console.WriteLine($"N is: {x}; shape is right" );
            Homework3BonusCode(x);
        }
    }

    //modified and recycled the homework3 bonus code because I can, aligned right
    static void Homework3BonusCode(int N4){
        int up=0;
        int down=N4;
        for(int row=0; row<N4; row++){
            up++;
            down--;
            for(int c=0; c<down;c++){
                Console.Write(" ");
            }
            for(int b=0; b<up;b++){
                Console.Write("*");
            }
                Console.WriteLine("");
        }
    }
    
    //modified and recycled the homework3 question 3 code because I can, aligned left
    static void Homework3Q3Code(int N3){
        for(int row=0; row<N3; row++){
            for(int col=0; col<N3; col++){
                if(row>=col){
                    Console.Write('*');
                }
            }
            Console.WriteLine("");              
        }
    }
}