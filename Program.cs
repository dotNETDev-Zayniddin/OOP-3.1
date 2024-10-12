/*
        O’quvchi classi yaratilsin. Uning Id(Guid), Ism(string), Familyasi(string), 
        sinfi(int), bahosi(enum) kabi fieldlari bo’lsin. Foydalanuvchi consolda baho kiritadi 
        va ushbu baho olgan o’quvchilar ro’yxati chiqib keladi.
        Ma’lumotlar bazasi sifatida list yoki arraydan foydalanishingiz mumkin.
*/
using System;
namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Students first = new Students();
            System.Console.WriteLine($"Ismi-familiyasi:\t\t\t\t\t\tBahosi");
            first.BindGrade();
            first.DisplayInfo();
        }
    }
}