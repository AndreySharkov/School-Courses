using ConsoleApp13;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EIGNValidator
{
    internal class EGNValidator : IEGNValidator
    {
        private readonly Dictionary<string, (int from, int to)> cityCodes = new()
        {
            { "Благоевград", (0, 43) },
            { "Бургас", (44, 93) },
            { "Варна", (94, 139) },
            { "Велико Търново", (140, 169) },
            { "Видин", (170, 183) },
            { "Враца", (184, 217) },
            { "Габрово", (218, 233) },
            { "Кърджали", (234, 281) },
            { "Кюстендил", (282, 301) },
            { "Ловеч", (302, 319) },
            { "Монтана", (320, 341) },
            { "Пазарджик", (342, 377) },
            { "Перник", (378, 395) },
            { "Плевен", (396, 435) },
            { "Пловдив", (436, 501) },
            { "Разград", (502, 527) },
            { "Русе", (528, 555) },
            { "Силистра", (556, 575) },
            { "Сливен", (576, 601) },
            { "Смолян", (602, 623) },
            { "София – град", (624, 721) },
            { "София – окръг", (722, 751) },
            { "Стара Загора", (752, 789) },
            { "Добрич", (790, 821) },
            { "Търговище", (822, 843) },
            { "Хасково", (844, 871) },
            { "Шумен", (872, 903) },
            { "Ямбол", (904, 925) },
            { "Друг", (926, 999) }
        };

        public EGNValidator() { }

        public bool Validate(string egn)
        {
            if (egn.Length != 10 || !egn.All(char.IsDigit))
                return false;

            var (isValidDate, _) = TryParseBirthDate(egn.Substring(0, 6));
            if (!isValidDate)
            { 
                return false; 
            }

            int checksum = CalculateChecksum(egn.Substring(0, 9));
            int controlDigit = int.Parse(egn[9].ToString());

            return checksum == controlDigit;
        }


        public string[] Generate(DateTime birthDate, string city, bool isMale)
        {
            List<string> result = new List<string>();

            if (!cityCodes.TryGetValue(city, out var range))
                return result.ToArray();

            string datePart = EncodeDate(birthDate);

            for (int i = range.from; i <= range.to; i++)
            {
                int genderOffset = isMale ? (i % 2 == 0 ? 0 : 1) : (i % 2 == 1 ? 0 : 1);
                int finalCode = i + genderOffset;
                if (finalCode > range.to) break;

                string regionPart = finalCode.ToString("D3");
                string partialEGN = datePart + regionPart;
                
                int checksum = CalculateChecksum(partialEGN);
                string fullEGN = partialEGN + checksum.ToString();

                result.Add(fullEGN);
            }

            return result.ToArray();
        }

        private string EncodeDate(DateTime birthDate)
        {
            int year = birthDate.Year % 100;
            int month = birthDate.Month;
            if (birthDate.Year < 1900)
            {
                month += 20; 
            }
            else if (birthDate.Year >= 2000) 
            {
                month += 40;
            }
            return $"{year:D2}{month:D2}{birthDate.Day:D2}";
        }

        private (bool, DateTime) TryParseBirthDate(string datePart)
        {
            int year = int.Parse(datePart.Substring(0, 2));
            int month = int.Parse(datePart.Substring(2, 2));
            int day = int.Parse(datePart.Substring(4, 2));
            int century;

            if (month >= 1 && month <= 12)
            {
                century = 1900;
            }
            else if (month >= 21 && month <= 32)
            {
                century = 1800;
                month -= 20;
            }
            else if (month >= 41 && month <= 52)
            {
                century = 2000;
                month -= 40;
            }
            else
            {
                return (false, DateTime.MinValue);
            }

            try
            {
                DateTime date = new DateTime(century + year, month, day);
                return (true, date);
            }
            catch
            {
                return (false, DateTime.MinValue);
            }
        }


        private int CalculateChecksum(string digits)
        {
            int[] weights = { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                sum += (digits[i] - '0') * weights[i];
            }

            int result = sum % 11;
            return result == 10 ? 0 : result;
        }
    }
}
