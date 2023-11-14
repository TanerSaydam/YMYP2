namespace AccessModifierProject.ConsoleApp.Models1;
public class Test1
{
    public string PublicProperty { get; init; }
    internal string InternalProperty { get; } = "1"; //set kısmı readonly
    private string PrivateProperty { get; set; }
    protected string ProtectedProperty { get; set; } = string.Empty;

}

public class TestInhreit : Test1
{
    public string NewPublicProtectedProperty { get; set; }
    public TestInhreit()
    {
        //Test4 test4 = new();
        //Test4.Method();
        Test4 test4 = Test4.Method("Değer");
        //test4.Name = "Test";
        test4.ChangeName("Yeni Değer");

        NewPublicProtectedProperty = ProtectedProperty;
    }
}

public class Test4
{
    private Test4(string name)
    {
        if(name.Length < 3)
        {
            throw new Exception("Hata!");
        }

        //kalan iş kuralları

        Name = name;
    }
    public string Name { get; private set; }
    public static Test4 Method(string value)
    {
        //ek iş kuralları

        return new(value);
    }

    public void ChangeName(string name)
    {
        //iş kuralları
        Deneme deneme = new("Taner", "Saydam", "Kayseri", "Software Developer");
        //deneme.Name = "asdasd";
        DenemeRecord record = new("Taner", "Saydam", "Kayseri", "Software Developer");
        //record.Name = "asd";
        Name = name;
    }
}

public sealed record DenemeRecord(
    string Name,
    string LastName,
    string Address,
    string Profession);

public sealed record DenemeRecord2
{
    public DenemeRecord2(string name, string lastName, string address, string profession)
    {
        Name = name;
        LastName = lastName;
        Address = address;
        Profession = profession;
    }

    public string Name { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string Profession { get; set; }
}
public sealed class Deneme
{
    public Deneme(string name, string lastName, string address, string profession)
    {
        Name = name;
        LastName = lastName;
        Address = address;
        Profession = profession;
    }

    public string Name { get; init; }
    public string LastName { get; init; }
    public string Address { get; init; }
    public string Profession { get; init; }
}

