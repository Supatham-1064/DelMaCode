using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public  class Person {
    private string fname;
    private string name;
    private string surname; 
    private string age;  
    private string allergy; 
    private string religion;

    public Person(string fname,string name, string surname, string age,
    string allergy,string religion) {
        this.fname = fname;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.allergy = allergy;
        this.religion = religion;
    }

    public string GetFname() {
        return this.fname;
    }
    public string GetName() {
        return this.name;
    }
    public string GetSurname() {
        return this.surname;
    }

    public string GetAge() {
        return this.age;
    }
    public string GetAllergye() {
        return this.allergy;
    }
    public string GetReligion() {
        return this.religion;
    }
}