class Student {
 

public string fullname { get; set; }

public int age { get; set; }

public int grade { get; set; }




 public  string Study() {
    return $"{fullname} is studying.";

  }
  public void SetGrade(int newGrade){

   grade=newGrade;

  }
  public int GetGrade(){
      
      return grade;
  }

  public Student(){

  } 
 
  public Student(string fn,int rakam){
    fullname=fn;
    age=rakam;
  }
   public Student(string fn,int rakam,int lavel){
    fullname=fn;
    age=rakam;
    grade=lavel;

  }







}