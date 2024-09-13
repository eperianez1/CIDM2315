namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        //PART 1
        /*

        Console.WriteLine("Please input a latter grade:");
        string letter_grade = Console.ReadLine();

        if(letter_grade == "A"){
            Console.WriteLine("GPA Point: 4");
        }

        else if(letter_grade == "B"){
            Console.WriteLine("GPA Point: 3");
        }

        else if(letter_grade == "C"){
            Console.WriteLine("GPA Point: 2");
        }

        else if(letter_grade == "D"){
            Console.WriteLine("GPA Point: 1");
        }

        else if(letter_grade == "F"){
            Console.WriteLine("GPA Point: 0");
        }

        else{
            Console.WriteLine("Wrong Letter Grade!");
        }
           
            */



        //PART 2
         /*    

        Console.WriteLine("Please input the first num:");
        string num_1 = Console.ReadLine();
        Console.WriteLine("Please input second num:");
        string num_2 = Console.ReadLine();
        Console.WriteLine("Please input third num:");
        string num_3 = Console.ReadLine();

        int first = Convert.ToInt16(num_1);
        int second = Convert.ToInt16(num_2);
        int third = Convert.ToInt16(num_3);

        if(first < second){
            if(first < third){
                Console.WriteLine($"The smallest num is {num_1}");
            }
            else{
                Console.WriteLine($"The smallest num is {num_3}");
            }
        }

        else{
            if(second < third){
                Console.WriteLine($"The smallest num is {num_2}");
            }
            else{
                Console.WriteLine($"The smallest value is {num_3}");
            }
        }

                    */



            //BONUS
            /*

            Console.WriteLine("Please input a year:");
            string year = Console.ReadLine();
            int year_int = Convert.ToInt16(year);

            if(year_int%4 == 0){
                Console.WriteLine($"{year_int} is a leap year");
            }
            
            else{
                Console.WriteLine($"{year_int} is NOT a leap year");
            }

            */

}
}