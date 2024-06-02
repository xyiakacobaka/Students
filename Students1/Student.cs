using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Student
{
    public int Id { get; set; }
    public string LastName;
    public string lastname
    {
        get { return LastName; }
        set
        {
            bool success = !Int32.TryParse(lastname, out int x);
            if (success == true)
            { LastName = value; }
            else value = "";
        }
    }
    public string FirstName;
    public string firstname
    {
        get { return FirstName; }
        set
        {
            bool success = !Int32.TryParse(firstname, out int x);
            if (success == true)
            { FirstName = value; }
            else value = "";
        }
    }
    public string SecondName;
    public string secondname
    {
        get { return SecondName; }
        set
        {
            bool success = !Int32.TryParse(secondname, out int x);
            if (success == true)
            { SecondName = value; }
            else value = "";
        }
    }
    private int grade;
    public int Grade
    {
        get { return grade; }
        set
        {
            grade = value;
        }
    }

    public string Group;
    public string group
    {
        get { return Group; }
        set
        {
            Group = value;
        }
    }
    public Student(string LastName, string FirstName, string SecondName, string Grade, string Group)
    {
        this.FirstName = FirstName;
        this.SecondName = SecondName;
        this.LastName = LastName;
        this.Grade = Int16.Parse(Grade);
        this.Group = Group;
    }
    public Student()
    {
        FirstName = "";
        SecondName = "";
        LastName = "";
        Grade = 0;
        Group = "";
    }
}

