namespace StudentAttendanceConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        //string[] students = new string[4]; //array
        List<Student> students = new()
        {
            new Student()
            {
                No = 1,
                Name = "Taner Saydam",
                Class = "2A",
                DateOfBirth = Convert.ToDateTime("03.09.1989"),
            },
            new Student()
            {
                No = 2,
                Name = "Ahmet Yalın",
                Class = "2A",
                DateOfBirth = Convert.ToDateTime("01.01.1988")
            }
        };


        var student = new Student()
        {
            No = 3,
            Name = "Mehmet Can Ünaldı",
            Class = "2A",
            DateOfBirth = Convert.ToDateTime("01.02.1989")
        };

        students.Add(student);


        Console.WriteLine("Hi, this is my studens!");
        foreach(var s in students)
        {
            //            Console.WriteLine($@"
            //Number: {s.No}
            //Name: {s.Name}
            //Class: {s.Class},
            //Date Of Birth: {s.DateOfBirth}
            //------------------");
            Console.WriteLine($"{s.No}. {s.Name}");
        }

        while(true)
        {
            //Tüm öğrenciler sınıfta mı kontrolü yapıyoruz.
            foreach(var s in students)
            {
                if(s.IsInClass == false)
                {
                    goto start;
                }
            }

            Console.WriteLine("Tüm öğrenciler sınıfta!");
            break;
            //Tüm öğrenciler sınıfta mı kontrolü yapıyoruz.


        start:;
            Console.WriteLine("Tell me who is in class?");
            string noString = Console.ReadLine();
            int no = 0;
            //Burada yazılan değerin numaratik olup olmadığını kontrol ediyoruz.
            bool result = int.TryParse(noString, out no);
            if (!result)
            {
                Console.WriteLine("Please write an number!");
                continue;
            }
            //Burada yazılan değerin numaratik olup olmadığını kontrol ediyoruz.


            //Burada yazığımız numaraya ait bir öğrenci olup olmadığını kontrol ediyoruz
            result = students.Any(x=> x.No == no); //lambda expression
            if (!result)
            {
                Console.WriteLine("The number you entered doesn't belong to our class. Please try again!");
                continue;
            }
            //Burada yazığımız numaraya ait bir öğrenci olup olmadığını kontrol ediyoruz


            //Yazdığımız numaraya ait öğrencinin zaten sınıfta olarak işaretlenip işaretlenmediğini kontrol ediyoruz
            Student st = students.FirstOrDefault(p=> p.No == no);
            if (st.IsInClass)
            {
                Console.WriteLine("This student already in class!");
                continue;
            }
            //Yazdığımız numaraya ait öğrencinin zaten sınıfta olarak işaretlenip işaretlenmediğini kontrol ediyoruz

            //Öğrenciyi sınıfta var olarak işaretliyoruz
            st.IsInClass = true;
            Console.WriteLine($"{st.Name} sınıfta olarak işaretlendi.");
            //Öğrenciyi sınıfta var olarak işaretliyoruz
        }







        //int kontrolü ile sıfıtaki öğrencinin numarasını isteyin
        //int değer girilmezse hata fırlatın
        //değer int ise sınıftaki öğrenci numaralarında bu değeri arayın ve eğer böyle numaralı bir öğrenci yoksa hata fırlatın
        //eğer öğrenci varsa ekranda şu öğrenci sınıfta olarak işaretli yazsın ve sonra başka kim sınıfta diye sorsun
        //Aşağıdaki bonus ödevler için arrayler kullanmalısınız ya da listeler
        //Bonus ödev: Eğer öğrenci zaten sınıfta işaretlendiyse o zaman tekrar işretlemesin ve hata versin
        //Bonus ödev: tüm öğrenciler sınıfta olarak işaretlenirse uygulama tüm öğrenciler sınıfta desin ve kapansın
    }
}


//access modifier => erişim belirleyicisi
internal class Student
{
    public int No { get; set; }
    public string Name { get; set; } //property, TitleCase
    public string Class { get; set; }
    public DateTime DateOfBirth { get; set; }
    public bool IsInClass { get; set; } = false;
}