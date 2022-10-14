using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum MenuNoLog{
    RegisterMenu = 1,
    GetListPersons,
    NewLogin
}
enum MenuLogin{
    RegisterMenu = 1,
    ShowaCollege,
    ShowaStudent,
    ShowaTeacher,
    NewLogout
}

public class Program {
    
    
    static PersonList personList;

    static void Main(string[] args) {
        PreparePersonListWhenProgramIsLoad();
        PrintMenuScreen();
    }

    static void PrintMenuScreen() {
        Console.Clear();

        PrintListMenuNoLogin();
        InputMenuNoLogFromKeyboard();
    }

    static void PrintListMenuNoLogin(){
        Console.WriteLine("/*************************/");
        Console.WriteLine(" Welcome to Idia Camp 2022");
        Console.WriteLine("1.Register for Idia Camp");
        Console.WriteLine("2.Show List Persons");
        Console.WriteLine("3.Login");
        Console.WriteLine("/*************************/");
    }
    static void InputMenuNoLogFromKeyboard() {
        Console.Write("Please input Menu:");
        MenuNoLog menu1 = (MenuNoLog)(int.Parse(Console.ReadLine()));

        PresentMenu(menu1);
    }
     static void PresentMenu(MenuNoLog menu1) {
        switch (menu1) {
            case MenuNoLog.RegisterMenu:
                ShowRegisterScreen();
                break;
            case MenuNoLog.GetListPersons:
                ShowPersons();
                break;
            case MenuNoLog.NewLogin:
                ShowNewLoginScreen();
                break;  
            default:
                break;
        }
    }

    static void ShowRegisterScreen() {
        Console.Clear();
        PrintRegisterListMenu();
    }
    static void ShowNewLoginScreen() {
        Console.Clear();
        ShowLoginScreen();
        PrintListMenuLogin();
        InputMenuLoginFromKeyboard();
    }
    static void ShowLoginScreen() {
        Console.Clear();
        PrintHeaderLoginScreen();
        string userNamename = InputNameFromKeyboard();
        if (userNamename == "exit") { 
            BackToMainMenu();
        }
        string password = InputPasswordFromKeyboard();

  
        
    }
    public static string InputNameFromKeyboard() {
        Console.Write("Input Email: ");

        return Console.ReadLine();
    }

    public static string InputPasswordFromKeyboard() {
        Console.Write("Input Password: ");

        return Console.ReadLine();
    }

    static void PrintHeaderLoginScreen() {
        Console.WriteLine("Login Screen");
        Console.WriteLine("------------"); 
    }



    static void PrintRegisterListMenu(){
        int Choss;
        Console.WriteLine("/*************************/");
        Console.WriteLine("1. Registration new Student");
        Console.WriteLine("2. Registration new Teacher");
        Console.WriteLine("3. Registration new College");
        Console.WriteLine("/*************************/");
        Choss = int.Parse(Console.ReadLine());
            switch (Choss) {
            case 1:
                ShowInputRegistrationNewStudentScreen();
                break;
            case 2:
                ShowInputRegistrationNewTeacherScreen();
                break;
            case 3:
                ShowInputRegistrationNewCollegeScreen();
                break;    
            default:
                break;
        }
    }
    

    static void PrintListMenuLogin(){
        Console.Clear();
        Console.WriteLine("/*************************/");
        Console.WriteLine("1.Register for Idia Camp");
        Console.WriteLine("2.Show all College");
        Console.WriteLine("3.Show all Student");
        Console.WriteLine("4.Show all Teacher");
        Console.WriteLine("5.Logout");
        Console.WriteLine("/*************************/");
    }
    static void InputMenuLoginFromKeyboard() {
        Console.Write("Please input Menu:");
        MenuLogin menu2 = (MenuLogin)(int.Parse(Console.ReadLine()));

        PresentMenu2(menu2);
    }
     static void PresentMenu2(MenuLogin menu2) {
        switch (menu2) {
            case MenuLogin.RegisterMenu:
                ShowRegisterScreen();
                break;
            case MenuLogin.ShowaCollege:
                ShowPersons2();
                break;
            case MenuLogin.ShowaStudent:
                ShowPersons2();
                break;
            case MenuLogin.ShowaTeacher:
                ShowPersons2();
                break;
            case MenuLogin.NewLogout:
                BackToMainMenu();;
                break;  
            default:
                break;
        }
    }

    static void ShowPersons() {
        Console.WriteLine("Show Persons");
        Console.WriteLine("************");

        Program.personList.FetchPersonList();
    }
    static void ShowPersons2() {
        Console.WriteLine("Show Persons");
        Console.WriteLine("************");

        Program.personList.FetchPersonList2();
    }

    public static void ShowInputRegistrationNewTeacherScreen() {
        Console.Clear();

        PrintHeaderRegistrationTeacher();

        int totalNewTeacher = TotalNewTeacher();
        inputNewTeacherFromKeyboard(totalNewTeacher);
    }

    public static void ShowInputRegistrationNewStudentScreen() {
        Console.Clear();

        PrintHeaderRegisterStudent();
          
        int totalNewStudent = TotalNewStudent();
        InputNewStudentFromKeyboard(totalNewStudent);
    }

    public static void ShowInputRegistrationNewCollegeScreen() {
        Console.Clear();

        PrintHeaderRegisterCollege();

        int totalNewCollege = TotalNewCollege();
        inputNewCollegeFromKeyboard(totalNewCollege);
    }
    // static void ShowNumberPersons() {
        
    //     Console.WriteLine("Show Number Persons");
    //     Console.WriteLine("/*****************/");
    //     Console.WriteLine("Type: Teacher \n amount :{0} \n ",totalNewTeacher);
    //     Console.WriteLine("Type: Student \n amount :{0} \n ",totalNewStudent);
    //     Console.WriteLine("Type: College \n amount :{0} \n ",totalNewCollege);
    //     Console.Write("Please put any word to next :");
    //     string Next;
    //     Next = (Console.ReadLine());
    //     BackToMainMenu();
    // }
     
    

    static void PrintHeaderRegistrationTeacher() {
        Console.WriteLine("Register New Teacher");
        Console.WriteLine("*********************");
    }

    static void PrintHeaderRegisterStudent() {
        Console.WriteLine("Register New Student");
        Console.WriteLine("*********************");
    }

    static void PrintHeaderRegisterCollege() {
        Console.WriteLine("Register New College");
        Console.WriteLine("*********************");
    }

    public static int TotalNewStudent() {
        Console.Write("Input Total new Student: ");
        
        return int.Parse(Console.ReadLine());
    }
    
    

    public static int TotalNewTeacher() {
        Console.Write("Input Total new Teacher: ");
        
        return int.Parse(Console.ReadLine());
    }
   

    public static int TotalNewCollege() {
        Console.Write("Input Total new College: ");
        
        return int.Parse(Console.ReadLine());
    }
   

    static void InputNewStudentFromKeyboard(int totalNewStudent) {
        for(int i = 0; i < totalNewStudent; i++) {
            Console.Clear();
            PrintHeaderRegisterStudent();
            

            Student student = new Student(
            Allinput.InputFname(),
            Allinput.InputName(),
            Allinput.InputSurname(),
            Allinput.InputAge(),
            Allinput.InputAllergy(),
            Allinput.InputReligion(),

            Allinput.InputEducation(),
            Allinput.InputSchool() 
            );

            Program.personList.AddNewPerson(student);
        }

        BackToMainMenu();
    }

    static void inputNewTeacherFromKeyboard(int totalNewTeacher) {
          for(int i = 0; i < totalNewTeacher; i++) {
            Console.Clear();
            PrintHeaderRegistrationTeacher();
            

            Teacher teacher = new Teacher(
            Allinput.InputFname(),
            Allinput.InputName(),
            Allinput.InputSurname(),
            Allinput.InputAge(),
            Allinput.InputAllergy(),
            Allinput.InputReligion(),

            Allinput.InputPosition(),
            Allinput.InputCar(),
            Allinput.InputDev2()
            );

            Program.personList.AddNewPerson(teacher);
        }

        BackToMainMenu();
    }

    static void inputNewCollegeFromKeyboard(int totalNewCollege) {
          for(int i = 0; i < totalNewCollege; i++) {
            Console.Clear();
            PrintHeaderRegisterCollege();
            

            College college = new College(
            Allinput.InputFname(),
            Allinput.InputName(),
            Allinput.InputSurname(),
            Allinput.InputAge(),
            Allinput.InputAllergy(),
            Allinput.InputReligion(),

            Allinput.InputCollegeID(),
            Allinput.InputDev()
            );

            Program.personList.AddNewPerson(college);
        }

        BackToMainMenu();
    }

    public static void BackToMainMenu() {
        Console.Clear();
        PrintListMenuNoLogin();
        InputMenuNoLogFromKeyboard();
    }
    public static void BackToMainMenu2() {
        Console.Clear();
        PrintListMenuLogin();
        InputMenuLoginFromKeyboard();
    }

    public static void PreparePersonListWhenProgramIsLoad() {
        Program.personList = new PersonList();
    }

    
}