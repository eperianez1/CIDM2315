namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
     
     //QUESTION 1
        /*
     
      Console.WriteLine("Input an integer:");              
        string N = Console.ReadLine();
        int int_N = Convert.ToInt16(N);

        if(int_N%2==0 && int_N==2){                     //couldnt figure out the loops, sorry
            Console.WriteLine("N is prime");
        }
        else if(int_N%2==0){
            Console.WriteLine("N is non-prime");
        }
        else if(int_N%3==0 && int_N==3){
            Console.WriteLine("N is prime");
        }
        else if(int_N%3==0){
            Console.WriteLine("N is non-prime");
        }
        else if(int_N%5==0 && int_N==5){
            Console.WriteLine("N is prime");
        }
        else if(int_N%5==0){
            Console.WriteLine("N is non-prime");
        }
        else if(int_N%7==0 && int_N==7){
            Console.WriteLine("N is prime");
        }
        else if(int_N%7==0){
            Console.WriteLine("N is non-prime");
        }
        else if(int_N%11==0 && int_N==11){
            Console.WriteLine("N is prime");
        }
        else if(int_N%11==0){
            Console.WriteLine("N is non-prime");
        }
        else{
            Console.WriteLine("N is prime");
        }
      
        */


        //QUESTION 2
        /*
        Console.WriteLine("Assign an int value to N:");
        string N = Console.ReadLine();
        int int_N = Convert.ToInt16(N);

        for(int row = 0; row<int_N; row++){
            for(int col = 0; col<int_N; col++){
                Console.Write('#');
            }
            Console.WriteLine("");
        }

        */




        //QUESTION 3
        /*
        Console.WriteLine("Assign an int value to N:");
        string N = Console.ReadLine();
        int int_N = Convert.ToInt16(N);
        

        for(int row = 0; row<int_N; row++){
            for(int col = 0; col<=row; col++){
                Console.Write('*');
    
            }
            Console.WriteLine("");
            
        }
    
        */




        //BONUS
        /*
        Console.WriteLine("Assign an int value to N:");         //Cannot figure this problem out :(
        string N = Console.ReadLine();
        int int_N = Convert.ToInt16(N);
        
    
        for(int row = 1; row<=int_N; row++){
            if(row<=int_N){
                Console.Write("\t");
            }
            for(int col = 1; col<=row; col++){
                Console.Write(row);
    
            }
            Console.WriteLine(""); 
        }
        
        */
        
    }
}
