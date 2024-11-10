namespace MidtermBonus;

class Program
{
    static void Main(string[] args)
    {
        HumanPlayer joe = new HumanPlayer(5);
        ComputerPlayer steve = new ComputerPlayer();


    joe.GetPoints();
    string continueGame;


    do{

        Console.WriteLine("-----ROCK, PAPER, SCISSORS START!!!-----");
        Console.WriteLine($"YOU HAVE {joe.GetPoints()} POINTS");
        
        string joeDecision = joe.HumanDecision();
        string steveDecision = steve.ComputerDecision();
        
        if(joeDecision == "rock" && steveDecision == "scissors"){
            Console.WriteLine("You Win!!");
            joe.WinRound();
        }
        else if(joeDecision == "paper" && steveDecision== "rock"){
            Console.WriteLine("You Win!!");
            joe.WinRound();
        }
        else if(joeDecision == "scissors" && steveDecision == "paper"){
            Console.WriteLine("You Win!!");
            joe.WinRound();
        }
        else if(joeDecision == steveDecision){
            Console.WriteLine("It's a tie.");
        }
        else{
            Console.WriteLine("YOU LOSE!!!!!");
            joe.LoseRound();
        }

            if(joe.GetPoints() == 0){
                break;
             }


    Console.WriteLine("***Do you wish to continue?*** \n\t Y or N");
    continueGame = Console.ReadLine();

    //n--;
    } while(joe.GetPoints() > 0 && continueGame == "Y");
    if(joe.GetPoints() == 0){
        Console.WriteLine("NOT ENOUGH POINTS");
    }
    Console.WriteLine("THANKS FOR PLAYING!!!!");
    }
}


class HumanPlayer{
    private int points {get;set;} = 5;

    public HumanPlayer(int inital){         //could not figure out how to use this
        points = inital;
    }



    public int GetPoints(){
        return points;
    }

    public void WinRound(){
        points += 5;
    }

    public void LoseRound(){
        points -= 5;
    }

    public string HumanDecision(){
        Console.WriteLine("Please input your choice: rock, paper, or scissors");
        string huChoice = Console.ReadLine();

        if(huChoice == "rock"){
            Console.WriteLine("Your Decision: rock");
            return "rock";
        }
        else if(huChoice == "paper"){
            Console.WriteLine("Your Decicion: paper");
            return "paper";
        }
        else if(huChoice == "scissors"){
            Console.WriteLine("Your Decision: scissors");
            return "scissors";
        }
        else{
            Console.WriteLine("Please input a valid choice.");
            return null;
        }
    }
}

class ComputerPlayer{
    
    public string ComputerDecision(){
        Random rnd = new Random();
        int rnd_num = rnd.Next(0,3);

        if(rnd_num == 0){
            Console.WriteLine("Computer's decision: rock");
            return "rock";
        }
        else if(rnd_num == 1){
            Console.WriteLine("Computer's decision: paper");
            return "paper";
        }
        else{
            Console.WriteLine("Computer's decision: scissors");
            return "scissors";
        }
    }
}

