using System;
using System.Diagnostics;
using System.Net;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Автор: Павлов Матвей Сергеевич");
            Console.WriteLine("=== Генератор картинок по запросу (Версия 2) ===");
            Console.WriteLine("Напишите ключевой тэг, чтобы скачать картинку.");
            string tag = Console.ReadLine();
            string url = "https://loremflickr.com/500/500/" + tag;
            string fileName = tag + ".jpg";
            try
            {
                // WebClient - скачиваем файл
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(url, fileName);
                } 
                // Открываем картинку
                Process.Start(new ProcessStartInfo
                {
                    FileName = fileName,
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
