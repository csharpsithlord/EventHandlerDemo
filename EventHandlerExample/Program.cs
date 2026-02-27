// Main application
using EventHandlerExample;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Driver driver = new Driver();

        driver.DataChange += OnDataChanged;

        driver.Start();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

        driver.Stop();
    }

    static void OnDataChanged(object sender, TagEventArgs e)
    {
        Console.WriteLine($"Data Changed - Name: {e.Name}, Value: {e.Value}");
    }
}