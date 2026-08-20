class Notif
{
    public  void Info()
    {
        string mess = Console.ReadLine();
        Console.WriteLine(mess);
    }
}
class Email : Notif
{
    public  void Info() 
    {
        string mess=Console.ReadLine();
        Console.WriteLine(mess);
    }
    public void Stady() { }
}
 


internal class Program
{
    private static void Main(string[] args)
    {
        //Person p = new Student();
        Student? s = new Student();
       // s = null;

      //  p.Info();

        // Student s = p as Student;
        s = null;
        //if (s != null)
        //{
        //    s.Stady();
        //}




     if (s is Person p)
        {
           p.Info();
        }

    }
}