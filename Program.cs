namespace GA_AbstractClass_Hafsa
{
    //hafsa m
    //02/10/24

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Person class
            //Person person = new Person("John Doe", 12345);

            // Call the GetDetails method and display the output
            //string details = person.GetDetails();

            //Console.WriteLine(details);

            // Create a new Professor object
            Professor professor1 = new Professor("Dr. Smith", 101, "Computer Science");

            // Call the GetDetails method to get information about the professor
            string professorInfo = professor1.GetDetails();

            // Output the information
            Console.WriteLine("Professor Information:");
            Console.WriteLine(professorInfo);

            // Create a list to hold Person objects, renamed as "schoolDatabase"
            List<Person> schoolDatabase = new List<Person>();

            // Add two instances of each derived class
            schoolDatabase.Add(new Student("John Doe", 12345, 3.8));
            schoolDatabase.Add(new Student("Alice Smith", 67890, 3.5));
            schoolDatabase.Add(new Professor("Dr. Smith", 101, "Computer Science"));
            schoolDatabase.Add(new Professor("Dr. Johnson", 102, "Mathematics"));
            schoolDatabase.Add(new Faculty("Jane Brown", 201, "Librarian"));
            schoolDatabase.Add(new Faculty("Mike Davis", 202, "Admissions"));
            schoolDatabase.Add(new Faculty("Bulls", 1, "Red"));
            schoolDatabase.Add(new Faculty("Laker", 6, "Yellow"));


            // Loop through the list and display information for each person
            foreach (var person in schoolDatabase)
            {
                Console.WriteLine(person.GetDetails());
                Console.WriteLine();
            }

            Console.ReadLine();


        }//main


    }//class


}//namespace

