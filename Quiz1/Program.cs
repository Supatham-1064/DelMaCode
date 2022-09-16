using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class programluk{
    public static void Main(string[] args) {
        int Choss;
        Console.WriteLine("**********------------------------**********");
        Console.WriteLine("*/           Choose your menu             /*");
        Console.WriteLine("*/1.Basic information of each university  /*");
        Console.WriteLine("*/2.University representative information /*");
        Console.WriteLine("*/3.Information on the electricity        /*");
        Choss = int.Parse(Console.ReadLine());
        switch(Choss)
        {
            case 1 : datatable.Printbasicmoo();
                break;
            case 2 : datatable.PrintTanmoo();
                break;
            case 3 : datatable.PrintElbill();
                break;    
            default: Console.WriteLine("*******Error Try again*******");
                break;
        }


    }

}