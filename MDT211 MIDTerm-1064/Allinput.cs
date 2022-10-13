public class Allinput{
    public static string InputFname() {
        Console.WriteLine("Prefix name Choose only");
        Console.WriteLine("[1)Mr. 2)Mrs. 3)Miss.]");
        int Cfname;
        Cfname = int.Parse(Console.ReadLine());
        switch(Cfname)
        {
            case 1 :Console.Write("Mr.");
                    return "Mr." ;
                break;
            case 2 :Console.Write("Mrs.");
                    return "Mrs.";
                break;
            case 3 :Console.Write("Miss.") ;
                    return "Miss.";
                break;    
            default: return null;
                break;
        }
        
        
    }
    public static string InputName() {
        Console.Write("Name :");

        return Console.ReadLine();
    }
    public static string InputSurname() {
        Console.Write("Surname :");

        return Console.ReadLine();
    }

    public static string InputAge() {
        Console.Write("Age :");

        return Console.ReadLine();
    }

    public static string InputAllergy() {
        Console.Write("Allergy : ");

        return Console.ReadLine();
    }

    public static string InputReligion() {
        Console.WriteLine("Religion Choose only");
        Console.WriteLine("[1)Buddhist 2)Christ 3)Islam 4)other]");
        int CRname;
        CRname = int.Parse(Console.ReadLine());
        switch(CRname)
        {
            case 1 :Console.WriteLine(":Buddhist");
                    return "Buddhist" ;
                break;
            case 2 :Console.WriteLine(":Christ");
                    return "Christ";
                break;
            case 3 :Console.WriteLine(":Islam") ;
                    return "Islam";
                break;
            case 4 :Console.WriteLine(":Other") ;
                    return "Other";
                break;    
            default: return null;
                break;
        }
    }

    public static string InputDev() {
        Console.Write("Dev: ");

        return Console.ReadLine();
    }
    public static string InputDev2() {
        Console.Write("Dev: ");

        return Console.ReadLine();
    }
    public static string InputCollegeID() {
        Console.Write("CollegeID: ");

        return Console.ReadLine();
    }

    public static string InputEducation() {
        Console.WriteLine("Education Choose only");
        Console.WriteLine("[1)High school 4 -2)High school 5 -3)High school 6] ");
        int CEname;
        CEname = int.Parse(Console.ReadLine());
        switch(CEname)
        {
            case 1 :Console.WriteLine(":High school 4");
                    return "High school 4" ;
                break;
            case 2 :Console.WriteLine(":High school 5");
                    return "High school 5";
                break;
            case 3 :Console.WriteLine(":High school 6") ;
                    return "High school 6";
                break;
            default: return null;
                break;
        }        
    }
    public static string InputSchool() {
        Console.Write("School: ");

        return Console.ReadLine();
    }

    public static string InputPosition() {
        Console.WriteLine("Position Choose only");
        Console.WriteLine("[1)Dean 2)Head of department 3)Full-time teacher] ");
        int CPname;
        CPname = int.Parse(Console.ReadLine());
        switch(CPname)
        {
            case 1 :Console.WriteLine(":Dean");
                    return "Dean" ;
                break;
            case 2 :Console.WriteLine(":Head of department");
                    return "Head of department";
                break;
            case 3 :Console.WriteLine(":Full-time teacher") ;
                    return "Full-time teacher";
                break;
            default: return null;
                break;

        }
    }
    public static string InputCar() {
        Console.Write("Bring a Car to camp?: ");

        return Console.ReadLine();
    }

}