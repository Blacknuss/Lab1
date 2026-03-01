using System;
using System.Diagnostics;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Автор: Павлов Матвей Сергеевич");
            Console.WriteLine("=== Генератор картинок по запросу (Версия 1) ===");
            Console.WriteLine("Напишите ключевой тэг, чтобы найти и открыть картинку в браузере.");
            string keyword = "https://loremflickr.com/500/500/" + Console.ReadLine();
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = keyword,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.WriteLine("Нажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}
