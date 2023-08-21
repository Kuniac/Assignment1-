using System;
using System.IO;
using System.Linq;

namespace Assignment1_안수환_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("텍스트 파일의 경로를 입력하세요:");
            string file = Console.ReadLine();
            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                Array.Sort(lines, StringComparer.Ordinal); //사전식 정렬

                for (int i = 0; i < lines.Length; i++)
                {
                    int totalCharacters = lines[i].Length; //글자수
                    int uppercaseCount = lines[i].Count(char.IsUpper); //대문자 개수
                    int specialcaseCount = totalCharacters - lines[i].Count(char.IsLetterOrDigit); //특수문자 수
                    Console.WriteLine($"{totalCharacters} {uppercaseCount} {specialcaseCount} {lines[i]}");
                }
            }
            else
            {
                Console.WriteLine("파일이 존재하지 않습니다.");
            }
            Console.ReadKey();

        }
    }
}


