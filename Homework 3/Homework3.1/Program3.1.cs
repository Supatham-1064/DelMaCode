class Program
{  
    static void Putflower(CircularLinkedList<char> FlowerList)
    {
        char inputFlower;  

            inputFlower = char.Parse(Console.ReadLine());
            
            if(inputFlower == 'J')
            {
                FlowerList.Add(inputFlower);
                Putflower(FlowerList);
            }
            else if(inputFlower == 'G')
            {
                FlowerList.Add(inputFlower);
                if(FlowerList.GetLength() >= 4)
                {                                    
                 if(
                    (FlowerList.Get(FlowerList.GetLength()-1) == FlowerList.Get(FlowerList.GetLength()-2))
                    &&(FlowerList.Get(FlowerList.GetLength()-1) == FlowerList.Get(FlowerList.GetLength()-3))
                    &&(FlowerList.Get(FlowerList.GetLength()-1) == FlowerList.Get(FlowerList.GetLength()-4)))
                  {
                    FlowerList.Remove(FlowerList.GetLength()-1);
                    Console.WriteLine("    Invalid pattern.");
                  }
                  else if(
                    (FlowerList.Get(FlowerList.GetLength()-1) == FlowerList.Get(0))
                    &&(FlowerList.Get(FlowerList.GetLength()-1) == FlowerList.Get(1))
                    &&(FlowerList.Get(FlowerList.GetLength()-1) == FlowerList.Get(2)))
                  {
                    FlowerList.Remove(FlowerList.GetLength()-1);
                    Console.WriteLine("    Invalid pattern.");
                  }
                  else if(
                    (FlowerList.Get(FlowerList.GetLength()-1) == FlowerList.Get(0))
                    &&(FlowerList.Get(FlowerList.GetLength()-1) == FlowerList.Get(1))
                    &&(FlowerList.Get(FlowerList.GetLength()-1) == FlowerList.Get(FlowerList.GetLength()-2)))
                  {
                    FlowerList.Remove(FlowerList.GetLength()-1);
                    Console.WriteLine("    Invalid pattern.");
                  }
                  else if(
                    (FlowerList.Get(FlowerList.GetLength()-1) == FlowerList.Get(0))
                    &&(FlowerList.Get(FlowerList.GetLength()-1) == FlowerList.Get(FlowerList.GetLength()-2))
                    &&(FlowerList.Get(FlowerList.GetLength()-1) == FlowerList.Get(FlowerList.GetLength()-3)))
                  {
                    FlowerList.Remove(FlowerList.GetLength()-1);
                    Console.WriteLine("    Invalid pattern.");
                  }
                  else if(FlowerList.Get(FlowerList.GetLength()-2) == 'R')
                  {
                    if(FlowerList.Get(FlowerList.GetLength()-1) == FlowerList.Get(FlowerList.GetLength()-3))
                    {
                       FlowerList.Remove(FlowerList.GetLength()-1);
                       Console.WriteLine("    Invalid pattern.");
                    }   
                  } 
                }                
                Putflower(FlowerList);  
            }
            else if(inputFlower == 'O')
            {
                FlowerList.Add(inputFlower);
                Putflower(FlowerList);   
            }
            else if(inputFlower == 'R')
            {
                FlowerList.Add(inputFlower);
                if(FlowerList.Get(FlowerList.GetLength()-1) == 'R')
                {
                 if(FlowerList.Get(0) == FlowerList.Get(FlowerList.GetLength()-2))
                 {
                   FlowerList.Remove(FlowerList.GetLength()-1);
                   Console.WriteLine("    Invalid pattern.");
                 }  
                 
                }
                else if(FlowerList.GetLength() >= 4)
                {
                 if(FlowerList.Get(FlowerList.GetLength()-2) == 'R')
                 {
                    if(FlowerList.Get(FlowerList.GetLength()-1) == FlowerList.Get(FlowerList.GetLength()-3))
                    {
                       FlowerList.Remove(FlowerList.GetLength()-1);
                       Console.WriteLine("    Invalid pattern.");
                    }   
                 }    

                }
                Putflower(FlowerList);
   
            }

            else if(FlowerList.Get(FlowerList.GetLength()-2) == 'R')
            {
                if(FlowerList.Get(FlowerList.GetLength()-1) == FlowerList.Get(FlowerList.GetLength()-3))
                    {
                       FlowerList.Remove(FlowerList.GetLength()-1);
                       Console.WriteLine("    Invalid pattern.");
                    }
                
            }    

            else if(inputFlower !='J'||inputFlower !='G'||inputFlower !='O'||inputFlower !='R')
            {
                Console.WriteLine("Invalid pattern.");
                
            }
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Let's ray Malay");
        Console.WriteLine("Put flower J,G,O,and R");
        Console.WriteLine("----------------------");
        CircularLinkedList<char> FlowerList = new CircularLinkedList<char>();
        Putflower(FlowerList);
        Console.WriteLine("----------------------");
        Console.WriteLine("WoW your Malay look sus like my code :-:");
        for(int i=0; i<FlowerList.GetLength(); i++)
        {
            Console.Write(FlowerList.Get(i));
        }

    }
 
}