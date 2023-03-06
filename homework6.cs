namespace Homework6;
class Professor{
    public string profName;
    public string classTeach;
    private double salary;
    public void SetSalary(double salary_amount){
        salary = salary_amount;
    }
    public double GetSalary(){
        return salary;
    }
}
class Student{
    public string studentName;
    public string classEnroll;
    private double studentGrade;
    public void SetGrade(double newGrade){
        studentGrade = newGrade;
    }
    public double GetGrade(){
        return studentGrade;
    }
}
class Program
{
    static void Main(string[] args)
    {
       Professor p1 = new Professor();
       p1.profName="Alice";
       p1.classTeach="Java";
       p1.SetSalary(9000);
       Professor p2 =new Professor();
       p2.profName="Bob";
       p2.classTeach="Math";
       p2.SetSalary(8000);
       Student s1= new Student();
       s1.studentName="Lisa";
       s1.classEnroll="Java";
       s1.SetGrade(90);
       Student s2 = new Student();
       s2.studentName = "Tom";
       s2.classEnroll = "Math";
       s2.SetGrade(80);
        /*
        Print name, class, salary of each professor;
        Print name, class, grade of each student;
        Calculate the difference of two professors’ salary.
        Calculate the total grade of two students.
        */
        PrintProfinfo(p1.profName, p1.classTeach, p1.GetSalary());
        PrintProfinfo(p2.profName, p2.classTeach, p2.GetSalary());
        PrintStudentInfo(s1.studentName, s1.classEnroll,s1.GetGrade());
        PrintStudentInfo(s2.studentName, s2.classEnroll,s2.GetGrade());
        SalaryDifference(p1.profName, p2.profName, p1.GetSalary(),p2.GetSalary());
        SumGrades(s1.studentName,s2.studentName,s1.GetGrade(),s2.GetGrade());
    }
    public static void PrintProfinfo(string name, string taught, double salary){
        Console.WriteLine($"Professor {name} teaches {taught}, and the salary is: {salary}");
    }
    public static void PrintStudentInfo(string name, string enrolls, double grade){
        Console.WriteLine($"Student {name} enrolls {enrolls}, and the grade is: {grade}");        
    }
    public static void SalaryDifference(string name1, string name2, double sal1, double sal2){
        if(sal1> sal2){
            Console.WriteLine($"The difference between {name1} and {name2} is: {sal1-sal2}");
        }
        else{
            Console.WriteLine($"The difference between {name1} and {name2} is: {sal2-sal1}");
        }
    }
    public static void SumGrades(string name1, string name2, double grade1, double grade2){
        Console.WriteLine($"The total grade of {name1} and {name2} is: {grade1+grade2}");
    }
}
