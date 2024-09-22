namespace Homework4;

class Program
{
    static void Main(string[] args)
    {   
     

        //QUESTION 1
        /*

        static int Compare(int a, int b){
            
            if(a>b){
                Console.WriteLine($"The largest number is: {a}");
                return a;
            }

            else{
                Console.WriteLine($"The largest number is: {b}");
                return b; 
            }
        }
        
        Console.WriteLine("Input integer a");
        string int_x = Console.ReadLine();
        int x = Convert.ToInt16(int_x);
        
        Console.WriteLine("Input integer b");
        string int_y = Console.ReadLine();
        int y = Convert.ToInt16(int_y);
       
        Console.WriteLine($"a={x}; b={y}");
        Compare(x,y);

        */






        //QUESTION 2
        /*
        
        Console.WriteLine("Input integer N:");
        string N_int = Console.ReadLine();
        int int_N = Convert.ToInt16(N_int);

        Console.WriteLine("Left or Right?");
        string LeftRight = Console.ReadLine();

        NumShape(int_N, LeftRight);
        
        
        
        
        static void NumShape(int N, string shape)
        {
            if(shape == "Left"){
            Console.WriteLine($"N is: {N}; shape is {shape}");
            for(int row = 0; row<N; row++){
                for(int col = 0; col<=row; col++){
                Console.Write('*');
    
            }
            Console.WriteLine("");
            }
        }


        
        else if(shape == "Right"){
        Console.WriteLine($"N is: {N}; shape is {shape}");
            
            for(int row = 0; row<N; row++){
                for(int space = 0; space < N-row; space++){
                    Console.Write(' ');
            }
                    for(int col = 0; col<=row; col++){
                Console.Write('*');
    
            }
            Console.WriteLine("");
            
        }
        
    }

} 
    */

}
}