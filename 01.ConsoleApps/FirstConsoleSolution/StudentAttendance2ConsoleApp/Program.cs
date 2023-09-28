namespace StudentAttendance2ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new();

        students.Add(new Student() { No = 100, Name = "Taner Saydam", IsInClass = false });

        var student1 = new Student()
        {
            No = 200,
            Name = "Elif",
            IsInClass = false,
        };
        students.Add(student1);

        students.Add(new Student() { No = 300, Name = "Emre Can T.", IsInClass = false });

        Console.WriteLine("Merhaba, yoklama uygulamasına hoş geldiniz!");
        Thread.Sleep(1000);
        Console.WriteLine("Ben yoklama kontrol yapay zekasıyım. Adım YoklamaAI");
        Thread.Sleep(1000);
        Console.WriteLine("Öğrencileriniz sırayla gelecek, sınıfta olup olmadığı sorusuna (e) Evet ya da (h) Hayır olarak cevap vermelisiniz.");
        Thread.Sleep(1000);
        Console.WriteLine("Tüm öğrenciler için bu cevaplandıktan sonra, size öğrenci listesinin son durumunu göstereceğim.");
        Thread.Sleep(1000);
        Console.WriteLine("------------------------------------------------------");

        for (int i = 0; i < students.Count; i++)
        {
            Student st = students[i];
        donus_noktasi:;
            Console.WriteLine($"{st.No}. {st.Name} sınıfta mı?");
            Console.WriteLine("(e) Evet, (h) Hayır");
            string response = Console.ReadLine();           

            if (response == "e")            
                st.IsInClass = true;            
            else if(response == "h")        
                st.IsInClass = false;
            else
            {
                Console.WriteLine("e ya da h ile cevap vermelisiniz. Lütfen tekrar deneyin!");
                goto donus_noktasi;
            }
            Thread.Sleep(300);

        }
        Console.WriteLine("------------------------------------------------------");
        Thread.Sleep(1000);
        Console.WriteLine("Yoklama başarıyla tamamlandı. Öğrenci  listesini ekrana getiriyorum...");
        Thread.Sleep(1000);
        students.ForEach(st =>
        {
            //if (st.IsInClass)
            //    Console.WriteLine($"{st.Name} sınıfta");
            //else
            //{
            //    Console.WriteLine($"{st.Name} sınıfta değil");
            //}

            //ternary operatörü / single if line
            Console.WriteLine($"{st.No}. {st.Name} {(st.IsInClass == true ? "sınıfta" : "sınıfta değil")}");
        });
    }
}
