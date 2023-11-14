namespace AccessModifierProject.ConsoleApp.Models1;

class Test2 //factory pattern
{
    private Test2(string internalProperty)
    {
        InternalProperty = internalProperty;
    }
    public string PublicProperty { get; private set; }
    internal string InternalProperty { get; init; }
    private string PrivateProperty { get; set; }
    protected string ProtectedProperty { get; set; }


    public static Test2 Create(string internalProperty)
    {
        return new Test2(internalProperty);
    }

    public void Update(string property)
    {
        PublicProperty = property;
    }
}