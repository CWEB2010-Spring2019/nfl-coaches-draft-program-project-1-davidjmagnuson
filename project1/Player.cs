using System;
namespace project1
{
    public class Player
    {
        public int idNumber { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public string school { get; set; }
        public int salary { get; set; }
        public string ranking { get; set; }

        public Player(string name, string position, string school, int salary, string ranking, int idNumber)
        {
            this.idNumber = idNumber;
            this.name = name;
            this.position = position;
            this.school = school;
            this.salary = salary;
            this.ranking = ranking;
        }

        public override string ToString()
        {
            return String.Format(idNumber + ". " + name + " (" + ranking + ") " + position + " - " + school + " - " + "$" + salary);
        }
    }//end of class Player
}
