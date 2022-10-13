public class Teacher: Person {
    private string position;
    private string car;
    private string dev2;

    public Teacher(string fname,string name, string surname, string age,
    string allergy,string religion,string position,string car,string dev2)
    : base(fname,name,surname,age,allergy,religion) {
        this.position = position;
        this.car = car;
        this.dev2 = dev2;
    }
}