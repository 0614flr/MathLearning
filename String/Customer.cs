namespace String;

public class Customer
{
    public string address;
    public int age = 10;
    public string byYime;
    public string name;

    public void Show()
    {
        Console.WriteLine("名字" + name);
    }
}

public class GeWu
{
    public void Show1(Customer customer)
    {
        Console.WriteLine(customer.age);
    }

    public void Show1()
    {
        throw new NotImplementedException();
    }
}