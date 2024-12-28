public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a disposed object
        using (var context = new MyDbContext())
        {
            // ... some database operations ...
        }

        // This will throw an exception because context is already disposed
        var result = context.SomeTable.FirstOrDefault();
    }
}