namespace Golf___Spa_Resort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input.ToLower() != "end")
            {
                string[] inputArr = input.Split();
                switch (inputArr.Length)
                {
                    case 2:
                        Guest guest = new Guest(inputArr[0], inputArr[1]);
                        Console.WriteLine(guest.NewGuest());
                        break;
                    case 3:
                        Member member = new Member(inputArr[0], inputArr[1], int.Parse(inputArr[2]));
                        if(int.Parse(inputArr[2]) % 2 == 0)
                        {
                            Console.WriteLine(member.GetMemberCard("spa"));
                            break;
                        }
                        Console.WriteLine(member.GetMemberCard("fitness"));
                        break;
                    case 4:
                        Employee employee = new Employee(inputArr[0], inputArr[1], inputArr[2], int.Parse(inputArr[3]));
                        Console.WriteLine(employee.StartWorkingDay());
                    break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
