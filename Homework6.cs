namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
    
    //QUESTION 1

       Professor Alice = new Professor();
       Alice.profName = "Alice";
       Alice.classTeach = "Java";
       Alice.SetSalary(9000);

       Professor Bob = new Professor();
       Bob.profName = "Bob";
       Bob.classTeach = "Math";
       Bob.SetSalary(8000);

       Student Lisa = new Student();
       Lisa.studentName = "Lisa";
       Lisa.classEnroll = "Java";
       Lisa.SetGrade(90);

       Student Tom = new Student();
       Tom.studentName = "Tom";
       Tom.classEnroll = "Math";
       Tom.SetGrade(80);



        //QUESTION 2
       
        static void ProfStatement(string prname,string clstch, double sal){
            Console.WriteLine($"Professor {prname} teaches {clstch}, and the salary is: {sal}");
        }
        
        static void StuStatement(string stname, string clsen, double gpa){
            Console.WriteLine($"Student {stname} enrolls {clsen}, and the grade is: {gpa}");
        }

        static void SalDif(string prof1n, string prof2n, double prof1, double prof2){
            double diff = prof1 - prof2;
            Console.WriteLine($"The salary difference between {prof1n} and {prof2n} is: {diff}");
        }

        static void TtlGrde(string stu1n, string stu2n, double stu1, double stu2){
            double Total = stu1 + stu2;
            Console.WriteLine($"The total grade of {stu1n} and {stu2n} is: {Total}");
        }

        ProfStatement(Alice.profName, Alice.classTeach, Alice.GetSalary());
        ProfStatement(Bob.profName, Bob.classTeach, Bob.GetSalary());
        StuStatement(Lisa.studentName, Lisa.classEnroll, Lisa.GetGrade());
        StuStatement(Tom.studentName, Tom.classEnroll, Tom.GetGrade());
        SalDif(Alice.profName, Bob.profName, Alice.GetSalary(), Bob.GetSalary());
        TtlGrde(Lisa.studentName, Tom.studentName, Lisa.GetGrade(), Tom.GetGrade());



    }
}


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