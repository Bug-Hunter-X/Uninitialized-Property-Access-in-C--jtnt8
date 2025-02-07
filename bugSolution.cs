public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize the property before accessing it.
        MyProperty = 0; // or any other default value
        Console.WriteLine(MyProperty);
    }
}