
using System;

class Program
{

    static void Letloop(Tree<string> Name_employee)
    {

    }
    static void Main(string[] args)
    {
        Tree<string> Name_employee = new Tree<string>();      

        Console.WriteLine("----------------------");


        string Name_List = (Console.ReadLine());
        int Number_name = int.Parse(Console.ReadLine());

        if(Number_name > 0)
        {
            int range = -1;
            int loopcount = Number_name;
            for(int i=0; i<(loopcount); i++)
            {
               Name_employee.AddChild(range,(Name_List));
               range++;
               Name_List = (Console.ReadLine());
               Number_name = int.Parse(Console.ReadLine());
              

               if(Number_name > 0)
                {                   
                    loopcount = Number_name;
                    for(int r=0; r<(loopcount); r++)
                    {
                        Name_employee.AddSibling(range,(Name_List));
                        range++;
                        Name_List = (Console.ReadLine());
                        Number_name = int.Parse(Console.ReadLine());
                    }
                }

            }
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("Input Name who la work");
            Name_List = (Console.ReadLine());
            Console.WriteLine("----------------------");
            
              
            for(int f=0; f<(Name_employee.GetLength()); f++)
            {
                
                if(Name_employee.Get(f) != Name_List)
                {
                    Console.WriteLine(Name_employee.Get(f));
                }
                else
                {
                    break;
                }
            }

            
        }
        else
        {
            Console.WriteLine("YAY input wrong");
        }
        





        // Stack<string> Name_List = new Stack<string>();
        // Stack<int> Number_name = new Stack<int>();


        // Name_List.Push("Tim");
        // Number_name.Push(2);
        // Name_List.Push("Nhong");
        // Number_name.Push(2);
        // Name_List.Push("Nap");
        // Number_name.Push(0);
        // Name_List.Push("Net");
        // Number_name.Push(0);
        // Name_List.Push("Bas");
        // Number_name.Push(1);
        // Name_List.Push("Toddy");
        // Number_name.Push(0);

        // Console.WriteLine(Name_List.Get(0));
        // Console.WriteLine(Name_List.Get(1));
        // Console.WriteLine(Name_List.Get(2));
        // Console.WriteLine(Name_List.Get(3));

       
        // Name_employee.AddChild(-1,Name_List.Pop());
        // Name_employee.AddChild(0,"Nhong");
        // Name_employee.AddChild(1,"Nap");

        

        // Name_employee.AddSibling(0,"Net");
        // Name_employee.AddSibling(1,"Bas");


        // Console.WriteLine("After adding 'G'");
        // for(int i=0; i<(Name_employee.GetLength()); i++)
        // {
        //     Console.WriteLine(Name_employee.Get(i));
        // }


    }
    
}