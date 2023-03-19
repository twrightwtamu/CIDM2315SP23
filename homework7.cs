namespace Homework7;
class Customer{
    private int cus_id;
    public string cus_name;
    public int cus_age;
    public Customer(int inid, string inname, int inage){
        cus_id = inid;
        cus_name = inname;
        cus_age = inage;
    }
    public void ChangeID(int new_id){
        cus_id = new_id;
    }
    public void PrintCusInfo(){
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age: {cus_age} ");
    }
    public void CompareAge(Customer objCustomer){
        if(this.cus_age > objCustomer.cus_age){
            Console.WriteLine($"{this.cus_name} is older.");
        }else
        {
            Console.WriteLine($"{objCustomer.cus_name} is older.");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer(110,"Alice",28);
        Customer c2 = new Customer(111,"Bob",30);
        c1.PrintCusInfo();
        c2.PrintCusInfo();
        c1.ChangeID(220);
        c2.ChangeID(221);
        c1.PrintCusInfo();
        c2.PrintCusInfo();
        c1.CompareAge(c2);
    }
}