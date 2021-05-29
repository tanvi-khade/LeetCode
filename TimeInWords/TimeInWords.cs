using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TimeInWords
{
    public static class TimeInWords
    {
        private static string HoursInWords(int hours)
        {
            if (hours < 1 || hours > 12)
                throw new InvalidOperationException();

            return NumberToWordsMap[hours];
        }

        private static string MinutesInWord(int minutes)
        {
            if (minutes < 0 || minutes > 59)
                throw new InvalidOperationException();

            string minutesInWord;

            if (minutes == 30)
                minutesInWord = "half";
            else if (minutes == 45 || minutes == 15)
                minutesInWord = "quarter";
            else if (minutes > 30)
                minutesInWord = $"{NumberToWordsMap[60 - minutes]} minutes";
            else
            {
                minutesInWord = $"{NumberToWordsMap[minutes]}";
                if (minutes == 1)
                    minutesInWord += " minute";
                else
                    minutesInWord += " minutes";

            }

            return minutesInWord;
        }

        public static string Convert(int hours, int minutes)
        {
            string result;
            var hoursInWords = HoursInWords(hours);

            if (minutes == 0)
                result = $"{hoursInWords} o' clock";
            else
            {
                var minutesInWords = MinutesInWord(minutes);
                if (minutes > 30)
                {
                    hoursInWords = HoursInWords(++hours);
                    result = $"{minutesInWords} to {hoursInWords}";
                }
                else
                {
                    result = $"{minutesInWords} past {hoursInWords}";
                }
            }

            return result;
        }

        private static void InitalizeNumberToWordsMap()
        {
            NumberToWordsMap = new Dictionary<int, string>();

            NumberToWordsMap.Add(1, "one");

            NumberToWordsMap.Add(2, "two");

            NumberToWordsMap.Add(3, "three");

            NumberToWordsMap.Add(4, "four");

            NumberToWordsMap.Add(5, "five");

            NumberToWordsMap.Add(6, "six");

            NumberToWordsMap.Add(7, "seven");

            NumberToWordsMap.Add(8, "eight");

            NumberToWordsMap.Add(9, "nine");

            NumberToWordsMap.Add(10, "ten");

            NumberToWordsMap.Add(11, "eleven");

            NumberToWordsMap.Add(12, "twelve");

            NumberToWordsMap.Add(13, "thirteen");

            NumberToWordsMap.Add(14, "fourteen");

            NumberToWordsMap.Add(15, "fifteen");

            NumberToWordsMap.Add(16, "sixteen");

            NumberToWordsMap.Add(17, "seventeen");

            NumberToWordsMap.Add(18, "eighteen");

            NumberToWordsMap.Add(19, "nineteen");

            NumberToWordsMap.Add(20, "twenty");

            NumberToWordsMap.Add(21, "twenty one");

            NumberToWordsMap.Add(22, "twenty two");

            NumberToWordsMap.Add(23, "twenty three");

            NumberToWordsMap.Add(24, "twenty four");

            NumberToWordsMap.Add(25, "twenty five");

            NumberToWordsMap.Add(26, "twenty six");

            NumberToWordsMap.Add(27, "twenty seven");

            NumberToWordsMap.Add(28, "twenty eight");

            NumberToWordsMap.Add(29, "twenty nine");

            NumberToWordsMap.Add(30, "thirty");
        }

        static TimeInWords()
        {
            InitalizeNumberToWordsMap();
        }

        private static Dictionary<int, string> NumberToWordsMap;

    }
}
