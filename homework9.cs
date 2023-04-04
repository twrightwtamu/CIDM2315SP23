namespace Homework9;
using System.Linq;
//******note to self******
// Linq: add data querying capabilities to .NET languages
// Max(), Min(), Sum(), Average() only work on 1d-array


class Student{
    private int studentID;
    private string studentName;
    public static List<Student> studentList = new List<Student>();
    public void PrintInfo(){
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
    public Student(int id, string name){
        studentID=id;
        studentName=name;
        studentList.Add(this);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");
        Dictionary<string,double> gradebook=new Dictionary<string,double>();
        gradebook.Add("Alice",4.0);
        gradebook.Add("Bob",3.6);
        gradebook.Add("Cathy",2.5);
        gradebook.Add("David",1.8);
        if (!gradebook.ContainsKey("Tom")){
            gradebook.Add("Tom",3.3);
        }
        double sumGPA=gradebook.Values.Sum();
        double averageGPA=sumGPA/gradebook.Count;
        Console.WriteLine($"The average GPA is: "+sumGPA/gradebook.Count);
        foreach(var stu in gradebook){
            if(gradebook[stu.Key]>averageGPA){
                Console.WriteLine(stu.Key);
               

                

            }
             
        }
        Console.WriteLine("I gave up/ran out of time");

        // foreach (KeyValuePair<string,double> entry in gradebook){
        //     if (entry.Value>averageGPA){
        //         Student.PrintInfo();
        //     }

        // }

    }
}
