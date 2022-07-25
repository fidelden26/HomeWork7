namespace HomeWork7
{
    public class Belarusisians
    {
        public string FirstName { get; private set; }
        public string Surname { get; private set; }

        public Belarusisians(string firstName, string surname)
        {
            FirstName = firstName;
            Surname = surname;
        }

        public override string ToString()
        {
            return FirstName + " " + Surname;
        }
    }
}