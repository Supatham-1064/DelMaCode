public class Student: Person  {
    private string education;
    private string school;

    public Student(string fname,string name, string surname, string age,
    string allergy,string religion,string education,string school)
    : base(fname,name,surname,age,allergy,religion) {
        this.education = education;
        this.school = school;
    }
}