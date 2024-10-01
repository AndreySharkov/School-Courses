namespace SoftUni_Course_Planner
{
    internal class Program
    {
        static void Main()
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();

            string command;
            while ((command = Console.ReadLine())?.ToLower() != "course start")
            {
                string[] commandArgs = command.Split(":");
                string action = commandArgs[0];

                switch (action?.ToLower())
                {
                    case "add":
                        AddLesson(schedule, commandArgs[1]);
                        break;

                    case "insert":
                        int indexInsert = int.Parse(commandArgs[2]);
                        InsertLesson(schedule, commandArgs[1], indexInsert);
                        break;

                    case "remove":
                        RemoveLesson(schedule, commandArgs[1]);
                        break;

                    case "swap":
                        SwapLessons(schedule, commandArgs[1], commandArgs[2]);
                        break;

                    case "exercise":
                        AddExercise(schedule, commandArgs[1]);
                        break;
                }
            }

            PrintSchedule(schedule);
        }

        static void AddLesson(List<string> schedule, string lesson)
        {
            if (!schedule.Contains(lesson))
            {
                schedule.Add(lesson);
            }
        }

        static void InsertLesson(List<string> schedule, string lesson, int index)
        {
            if (!schedule.Contains(lesson) && index >= 0 && index < schedule.Count)
            {
                schedule.Insert(index, lesson);
            }
        }

        static void RemoveLesson(List<string> schedule, string lesson)
        {
            int lessonIndex = schedule.IndexOf(lesson);
            if (lessonIndex != -1)
            {
                schedule.RemoveAt(lessonIndex);
                RemoveExercise(schedule, lessonIndex);
            }
        }

        static void SwapLessons(List<string> schedule, string lesson1, string lesson2)
        {
            int index1 = schedule.IndexOf(lesson1);
            int index2 = schedule.IndexOf(lesson2);

            if (index1 != -1 && index2 != -1)
            {
                schedule[index1] = lesson2;
                schedule[index2] = lesson1;

                SwapExercises(schedule, index1, index2);
            }
        }

        static void AddExercise(List<string> schedule, string lesson)
        {
            int lessonIndex = schedule.IndexOf(lesson);
            if (lessonIndex != -1 && !schedule.Contains(lesson + "-Exercise"))
            {
                schedule.Insert(lessonIndex + 1, lesson + "-Exercise");
            }
            else if (lessonIndex == -1)
            {
                schedule.Add(lesson);
                schedule.Add(lesson + "-Exercise");
            }
        }

        static void RemoveExercise(List<string> schedule, int lessonIndex)
        {
            if (lessonIndex + 1 < schedule.Count && schedule[lessonIndex + 1].EndsWith("-Exercise"))
            {
                schedule.RemoveAt(lessonIndex + 1);
            }
        }

        static void SwapExercises(List<string> schedule, int index1, int index2)
        {
            if (index1 + 1 < schedule.Count && schedule[index1 + 1].EndsWith("-Exercise"))
            {
                string exercise1 = schedule[index1 + 1];
                schedule.RemoveAt(index1 + 1);
                schedule.Insert(index2 + 1, exercise1);
            }

            if (index2 + 1 < schedule.Count && schedule[index2 + 1].EndsWith("-Exercise"))
            {
                string exercise2 = schedule[index2 + 1];
                schedule.RemoveAt(index2 + 1);
                schedule.Insert(index1 + 1, exercise2);
            }
        }

        static void PrintSchedule(List<string> schedule)
        {
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
    }
}