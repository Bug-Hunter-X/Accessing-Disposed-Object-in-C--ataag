public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a disposed object
        using (var context = new MyDbContext())
        {
            // ... some database operations ...
            var result = context.SomeTable.FirstOrDefault(); // Access the context within the using block
        }

        //The following line is removed because the context is disposed
        //var result = context.SomeTable.FirstOrDefault();
    }
}