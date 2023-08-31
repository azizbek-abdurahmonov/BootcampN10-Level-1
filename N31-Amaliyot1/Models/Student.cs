namespace N31_Amaliyot1.Models;

public class Student
{
    public int id { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string email { get; set; }
    public string gender { get; set; }
    public string birth_day { get; set; }
    public int speciality_id { get; set; }
    public int location_id { get; set; }
}