namespace Homework9;

using System;
using System.Collections.Generic; 
class Program
{
    static void Main(string[] args)
    {

        //QUESTION 2

        Student Alice = new Student(111, "Alice");
        Student Bob = new Student(222, "Bob");
        Student Cathy = new Student(333, "Cathy");
        Student David = new Student(444, "David");

       
        //QUESTION 3

        Dictionary<string,double> gradebook = new Dictionary<string,double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);


        //QUESTION 4

        if(gradebook.ContainsKey("Tom") == false){
            gradebook.Add("Tom", 3.3);
        }
        

        //METHOD FOR GPA AVERAGE // QUESTION 5/6
        
        static void AverageGPA(Dictionary<string,double> gradebook)
        {
        double totalGpa = 0;
        int Count = 0;
            foreach(var Gpa in gradebook){
                 totalGpa += Gpa.Value;
                 Count++;
        }
            if(Count>0){
                double Avg_Gpa = totalGpa/Count;
                Console.WriteLine($"\nThe Average GPA is: {Avg_Gpa}");


                    //CODE FOR PRINTING STUDENT INFO ABOVE GPA AVERAGE
                    foreach(Student BetterStu in Student.student_list){
                        if( gradebook[BetterStu.GiveStuName()] > Avg_Gpa){
                            BetterStu.PrintInfo();
                        }
            
            }
            
            
        }
        }

        foreach(Student stu in Student.student_list){
            stu.PrintInfo();
        }

        AverageGPA(gradebook);


    }
}


class Student{
    private int studentID {get;set;}
    private string studentName  {get;set;}
    public static List<Student> student_list = new List<Student>();
   
    public void PrintInfo(){
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }

    public Student(int inputID, string inputName){

        studentID = inputID;
        studentName = inputName;
        student_list.Add(this);
    }


    //USED ONLY FOR #6
    public string GiveStuName(){
        return studentName;
    }


}