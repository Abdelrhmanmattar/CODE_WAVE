using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE11
{
    public enum Security
    {
        Guest=0,
        Developer,
        Secretary,
        DBA
    }
    public class Employee
    {
        //REQUIRE FIELDS
        public Guid Id;
        public string Name;
        public Security Security_Level;
        public int Salary;
        public DateTime DateTime;
        private string gender_field;


        //this property will check value first before set it to gender_field
        //if value !="M"/"F" it will throw Exception
        public string Gender { get => gender_field;
            set {
                if (value != "M" && value != "F")
                    throw new Exception("Should enter M-->MALE / F-->FEMALE");
                gender_field = value;
            }
        }
        public Employee(Guid guid, string name, Security security, int salary, DateTime dateTime, string gender)
        {
            this.Id = guid;
            this.Name = name;
            this.Security_Level = security;
            this.Salary = salary;
            this.DateTime = dateTime;
            this.Gender = gender;
        }
        public override string ToString()
        {
            return String.Format("[{0}] {1} {2}  {3:C}  {4}  {5}",
                Id, Name.PadRight(10,' '), Security_Level.ToString().PadRight(10), Salary, DateTime, Gender);
        }
    }
}
