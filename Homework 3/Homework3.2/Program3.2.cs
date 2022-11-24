class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Fruit factory");
        Console.WriteLine("Size of fruits is L,M,S"); 
        Console.WriteLine("-----------------------");
        Queue<char> FruitList = new Queue<char>();
        while(true) 
        {
            char fruit_Check;
            fruit_Check = char.Parse(Console.ReadLine());
            {
               if (fruit_Check == 'L')
                {      
                    FruitList.Push('1');
                }
                else if (fruit_Check == 'M')
                {
                    FruitList.Push('2');
                }
                else if (fruit_Check == 'S')
                {
                    FruitList.Push('3');
                }
                else if(fruit_Check != 'L'&&fruit_Check != 'M'&&fruit_Check != 'S')
                {
                    break;
                }
            }  
        }

        
        for (int i =0 ;i<FruitList.GetLength(); i++)
        {
            if (FruitList.Get(i) == '1')
            {
                FruitList.Push('2');
                FruitList.Push('2');
            }
            else if (FruitList.Get(i) == '2')
            {
                FruitList.Push('3');
                FruitList.Push('3');
                FruitList.Push('3');
            }
        }


        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("The process has finished.Let's eat slice of fruits!");
        for (int i =0 ;i<FruitList.GetLength(); i++)
        {
          Console.Write(FruitList.Get(i));
        } 
    }
}