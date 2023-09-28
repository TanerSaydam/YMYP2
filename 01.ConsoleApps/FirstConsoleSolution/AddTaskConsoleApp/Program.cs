using System.Threading.Tasks;
using TaskWithTimerConsoleApp;
using Task = TaskWithTimerConsoleApp.Task;

namespace AddTaskConsoleApp;

internal class Program
{    
    static void Main(string[] args)
    {
        Console.WriteLine("Merhaba, Zamanlanmış Görevlere hoş geldiniz! Ben TaskAI");  

        while (true)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin?");
            Console.WriteLine("1. Yeni Task Ata");
            Console.WriteLine("2. Mevcut Taskın Süresini Değiştir");
            Console.WriteLine("3. Taskı Sil");

            string selectString = Console.ReadLine();
            int select = 0;
            var response = int.TryParse(selectString, out select);
            if (response == false)
            {
                Console.WriteLine("Geçerli bir seçim yapmadınız. Lütfen tekrar deneyin!");
                continue;
            }

            if (select > 3)
            {
                Console.WriteLine("Liste dışından seçim yaptınız. Lütfen liste içiden seçim yapınız!");
                continue;
            }

            if (select == 1)
            {
                Console.WriteLine("Task adını yazın...");
                string taskAdi = Console.ReadLine();
                Console.WriteLine("Task açıklaması yazın...");
                string taskAciklamasi = Console.ReadLine();

            taskSuresiZiplamaNoktasi:;
                Console.WriteLine("Task süresini milisaniye cinsinden yazın...");
                string taskSuresiString = Console.ReadLine();
                int taskSuresi = 0;
                var response1 = int.TryParse(taskSuresiString, out taskSuresi);
                if (response1 == false)
                {
                    Console.WriteLine("Lütfen geçerli bir task süresi girin!");
                    goto taskSuresiZiplamaNoktasi;
                }

                TaskService.Tasks.Add(new Task() { Name = taskAdi, Description = taskAciklamasi, Duration = taskSuresi });                
            }
        }
    }    
}
