
//Console.WriteLine("hello aptech students");
//Console.ReadLine();

//Console.WriteLine("hello aptech");




//for (int i = 1; i <=20; i++)
//{
//    Console.WriteLine("Over: "+i);
//    for (int j=1;j<=6;j++) {
//        Console.WriteLine("Over:" + i + " Ball:" + j);
//    }
//    Console.WriteLine("");


//}



//Console.WriteLine("Enter Your Age");
//int age = int.Parse(Console.ReadLine());

//if (age >= 18)
//{


//    Console.WriteLine("Your Age is :" + age + " You're Now Eligible for Applying Driving Liecense");
//}
//else {
//    Console.WriteLine("Your Age is :" + age + " You're Not Eligible for Applying Driving Liecense Please Try Again");
//}


//Console.WriteLine("are you want to close a program type Y / N");
//char character = char.Parse(Console.ReadLine());

//if (character== 'N' || character== 'n') {
//    Console.Clear();
//    Console.WriteLine("Welcome to Console App From Aptech Korangi Students");
//    Console.ReadKey();
//}




//string[] studentname = new string[10];
//studentname[0] = "Jasmin";
//studentname[1] = "Umair";
//studentname[2] = "Rehman";
//studentname[3] = "Asad";
//studentname[4] = "Ahmed";
//studentname[5] = "Arham";
//Console.WriteLine(studentname[0]);


//string[] studentname = {"Jasmin","Umair","Rehman","Asad","Ahmed","Arham"};


//foreach (string names in studentname) {

//    Console.WriteLine(names);

//}




//Console.WriteLine("hello aptech students");



//CLASS & OBJECTS





using System.Net.Http.Headers;

//class Student {
//    public string studentname;
//    public string studentemail;
//    public int studentage;

//    public void studentaction(string name , string email , int age) {

//        this.studentname = name;
//        this.studentemail = email;
//        this.studentage = age;


//    }
//    public void studentdetail() {


//        Console.WriteLine("Student Name: "+this.studentname);
//        Console.WriteLine("Student Email: "+this.studentemail);
//        Console.WriteLine("Student Age: "+this.studentage);
//    }



//}

class student
{
    public student()
    {
        Console.WriteLine("this is parameter less constructor !!! ");
    }
    public student(int a, int b)
    {
        Console.WriteLine("Your sum is : " + (a + b));
    }
    public student(string name)
    {
        Console.WriteLine("Your Name is : " + name);
    }
}

public class Program {
    public static void Main(String[] args) {

        //student obj = new student();

        //obj.name = "Jasmin Anjel";
        //obj.email = "jasmin@gmail.com";

        //Console.WriteLine(obj.name);
        //Console.WriteLine(obj.email);

        //Student obj = new Student();

        //obj.studentaction("umair","umair@gmail.com",20);
        //obj.studentdetail();

        //student obj = new student("jasmin",20);

        student st1 = new student();
        student st2 = new student("Muhammad Anees");

    }
}


















