namespace midtermbonus;
class HumanPlayer{
    private int points;
    public HumanPlayer(int initial){
        points=initial;
    }
    public int GetPoints(){
        return points;
    }
    public void WinRound(){
        Console.WriteLine("You Win!");
        points=points+5;
    }
    public void LoseRound(){
        Console.WriteLine("You Lose!");
        points=points-5;
    }
    public string HumanDecision(){
        string choice= Console.ReadLine()!.ToLower();
        if(choice=="rock"| choice=="paper"| choice=="scissors"){
            return choice;
        }else{
            Console.WriteLine("Please enter a valid choice");
            return this.HumanDecision();
        }
    }
}
class ComputerPlayer{
    public string ComputerDecision(){
        Random rnd = new Random();
        int rnd_num = rnd.Next(0,3);
        if(rnd_num==0){
            return "rock";
        }else if(rnd_num==1){
            return "paper";
        }else{
            return "scissors";
        }
    }
}
class RockPaperScissors
{
    static void Main(string[] args)
    {
        HumanPlayer human1= new HumanPlayer(5);
        ComputerPlayer computer1=new ComputerPlayer();
        LetsPlayAGame(human1,computer1);
    }
    public static void LetsPlayAGame(HumanPlayer human1, ComputerPlayer computer1){
        Console.WriteLine("**** Rock, Paper, Scissors, Start!****");
        Console.WriteLine($"You have {human1.GetPoints()} points");
        Console.WriteLine("Please input your choice: rock, paper, or scissors.");
        string human = human1.HumanDecision();
        string computer = computer1.ComputerDecision();
        Console.WriteLine($"--> Your Decision: {human}");
        Console.WriteLine($"--> Computer Decision: {computer}");
        whoWon(human, computer, human1,computer1);
        keepPlaying(human1,computer1);                                         
    }
    public static void keepPlaying(HumanPlayer human1, ComputerPlayer computer1){
        if (human1.GetPoints()>0){
            Console.WriteLine("-->Play Again? Input y to continue, or n to exit");
            string goOn=Console.ReadLine()!.ToLower();
            if (goOn=="y"){
                LetsPlayAGame(human1, computer1);
            }else if(goOn=="n"){
                Console.WriteLine("Thank you for playing!");
            }else{
                Console.WriteLine("Invalid input");
                keepPlaying(human1,computer1);
            }
        }else{
            Console.WriteLine("Sorry you don't have enough points, thanks for playing!");
            Console.WriteLine("Thank you for playing!");
        }
    }
    public static void whoWon(string humanChoice,string computerChoice,HumanPlayer human1, ComputerPlayer computer1){
        string tie="It's a tie!";
        if (humanChoice=="rock"){
            if (computerChoice=="paper"){
                human1.LoseRound();
            }else if(computerChoice=="rock"){
            Console.WriteLine(tie);
            }else{
                human1.WinRound();
            }
        }else if( humanChoice=="paper"){
            if (computerChoice=="paper"){
                Console.WriteLine(tie);
            }else if (computerChoice=="rock"){
                human1.WinRound();
            }else{
                human1.LoseRound();
            }
        }else{
            if (computerChoice=="scissors"){
                Console.WriteLine(tie);
            }else if(computerChoice=="rock"){
                human1.LoseRound();
            }else{
                human1.WinRound();
            }
        }
    }

}