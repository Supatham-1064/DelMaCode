public class College: Person {
    private string collegeID;
    private string dev;

    public College(string fname,string name, string surname, string age,string allergy,
    string religion,string collegeID,string dev)
    : base(fname,name,surname,age,allergy,religion)
     {
        this.collegeID = collegeID;
        this.dev = dev;
    }
}