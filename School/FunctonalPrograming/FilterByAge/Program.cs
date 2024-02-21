namespace FilterByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];
            for(int i = 0; i < n; i++)
            {
                people[i] = new Person();
                string[] guy = Console.ReadLine().Split(", ");
                people[i].name = guy[0];
                people[i].age = int.Parse(guy[1]);

            }
            string olderOrYonger = Console.ReadLine();
            int AgeGap = int.Parse(Console.ReadLine());
            string nameAndAge = Console.ReadLine();
            if(olderOrYonger == "older")
            {
                people = people.Where(x => x.age >= AgeGap).ToArray();
            }
            else
            {
                people = people.Where(x => x.age < AgeGap).ToArray();
            }
            foreach(Person person in people)
            {
                if (nameAndAge.Contains("name") && nameAndAge.Contains("age"))
                {
                    Console.WriteLine($"{person.name} - {person.age}");
                }
                else if (nameAndAge.Contains("age"))
                {
                    Console.WriteLine(person.age);
                }
                else
                {
                    Console.WriteLine(person.name);
                }
            }
        }
        
    }
    
}