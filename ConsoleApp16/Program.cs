// See https://aka.ms/new-console-template for more information

namespace ProgramTest
{

    public class Program
    {
        public static void Main()
        {
            Save save = new Save();

            Person person = new Person(save);
            person.Name = "Some Name";
            person.Save();

        }
    }
    public class Person
    {
        private ISave _save;

        public string Name { get; set; }

        public Person(ISave save)
        {
            _save = save;
        
        }


        public void Save()
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentNullException("Name is null");
            }

            // save it to the DB
            // some code to save to the database
            _save.Save();
        }

    }

    public interface ISave
    {
        public void Save();
    }

    public class Save : ISave
    {
        void ISave.Save()
        {
            Console.WriteLine("I'm Saving to the database");
        }
    }

}