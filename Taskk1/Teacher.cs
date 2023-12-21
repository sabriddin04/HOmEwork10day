class Teacher
{
    string fullname;
    string subject;
    int experience;


    public string Teach (){

        return $"{fullname}teaching {subject}.";
     }
public void SetExperience(int years)
{

    experience = years;
}
public int GetExperience()
{

    return experience;
}
public Teacher()
{

}
public Teacher(string name, string predmet)
{
    fullname = name;
    subject = predmet;

}
public Teacher(string name, string predmet, int rakam)
{
    fullname = name;
    subject = predmet;
    experience = rakam;
}
public string sabrjan()
{
    return $"Fulname: {fullname}\nsubject: {subject} \nexperience: {experience}";

     


}
}