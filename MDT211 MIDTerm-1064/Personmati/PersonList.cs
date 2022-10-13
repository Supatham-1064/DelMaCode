using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PersonList {
    private List<Person> personList;

    public PersonList() {
        this.personList = new List<Person>();
    }

    public void AddNewPerson(Person person) {
        this.personList.Add(person);
    }


    public void FetchPersonList() {
        
        foreach(Person person in this.personList) {
            if (person is Student) {
                Console.WriteLine("{0}:{1}:{2} \n Type: Student \n", person.GetFname(),person.GetName(),person.GetSurname());
            } else if (person is Teacher) {
                Console.WriteLine("{0}:{1}:{2} \n Type: Teacher \n", person.GetName(),person.GetName(),person.GetSurname());
            }else if (person is College) {
                Console.WriteLine("{0}:{1}:{2} \n Type: College \n", person.GetName(),person.GetName(),person.GetSurname());
            }
        }
        Console.Write("Please put any word to next :");
        string Next;
        Next = (Console.ReadLine());
        Program.BackToMainMenu();   
    }
    public void FetchPersonList2() {
        
        foreach(Person person in this.personList) {
            if (person is Student) {
                Console.WriteLine("{0}:{1}:{2} \n Type: Student \n", person.GetFname(),person.GetName(),person.GetSurname());
            } else if (person is Teacher) {
                Console.WriteLine("{0}:{1}:{2} \n Type: Teacher \n", person.GetName(),person.GetName(),person.GetSurname());
            }else if (person is College) {
                Console.WriteLine("{0}:{1}:{2} \n Type: College \n", person.GetName(),person.GetName(),person.GetSurname());
            }
        }
        Console.Write("Please put any word to next :");
        string Next;
        Next = (Console.ReadLine());
        Program.BackToMainMenu2();   
    }
}