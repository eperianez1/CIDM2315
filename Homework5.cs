namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        
        //METHOD FOR QUESTIONS 1 AND 2

        static int CompareInt(int a, int b, int c = 0, int d = 0)
        {
            if(a>b){
                return a;
            }
            else{
                return b;
            }
            if(c>d){
                return c;
            }
            else{
                return d;
            }
            
        }



        //QUESTION 1
        /*
        Console.WriteLine("Input Integer a:");
        string int_w = Console.ReadLine();
        int w = Convert.ToInt16(int_w);

        Console.WriteLine("Input Integer b:");
        string int_x = Console.ReadLine();
        int x = Convert.ToInt16(int_x);

        Console.WriteLine($"a={w}; b={x}");
        int max = CompareInt(w,x);
        
        Console.WriteLine($"The largest number is: {max}");
        */


        //QUESTION 2
        /*
        Console.WriteLine("Input Integer a:");
        string int_w = Console.ReadLine();
        int w = Convert.ToInt16(int_w);

        Console.WriteLine("Input Integer b:");
        string int_x = Console.ReadLine();
        int x = Convert.ToInt16(int_x);

        Console.WriteLine("Input integer c:");
        string int_y = Console.ReadLine();
        int y = Convert.ToInt16(int_y);

        Console.WriteLine("Input integer d:");
        string int_z = Console.ReadLine();
        int z = Convert.ToInt16(int_z);

        Console.WriteLine($"a={w}; b={x}; c={y}; d={z}");

        int max_1 = CompareInt(w,x);
        int max_2 = CompareInt(y,z);
        int max_3= CompareInt(max_1, max_2);

        Console.WriteLine($"The largest number is: {max_3}");
        */





        //QUESTION 3
        /*
       
        static bool checkAge(int birth_year){
        int age = 2024 - birth_year;
        
        if(age >= 18)
        {
            return true;
        }
        else{
            Console.WriteLine("Could not create an account!");
            return false;
        }
        }


        static string createAccount(string password, string secpass){
        if(password == secpass){
            Console.WriteLine("Account Created Successfully!");
            return password;
        }
        else{
            Console.WriteLine("Wrong Password!");
            return password;
        }
        }


        Console.WriteLine("Enter your username:");
        string username = Console.ReadLine();

        Console.WriteLine("Enter your password:");
        string password = Console.ReadLine();

        Console.WriteLine("Enter your password again:");
        string secpass = Console.ReadLine();

        Console.WriteLine("Enter your birthyear:");
        string birthyear = Console.ReadLine();
        int birth_year = Convert.ToInt16(birthyear);

        if(checkAge(birth_year)){
            createAccount(password,secpass);
        }    
        else{
        }

        */


        
    }
}
