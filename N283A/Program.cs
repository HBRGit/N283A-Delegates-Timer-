// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

System.Timers.Timer timer = new System.Timers.Timer(1000); // 1 second interval

//timer.Elapsed += (sender, e) => Console.WriteLine($"Timer elapsed at {DateTime.Now}");  // Using lambda expression
// or
timer.Elapsed +=OnTimedEvent;   // Using method group conversion

timer.AutoReset = true; // Repeatable timer
timer.Start();

Console.WriteLine("Timer started. Press any key to exit the program...");
Console.ReadKey();
void OnTimedEvent(object source, System.Timers.ElapsedEventArgs e)
{
    Console.WriteLine($"Timer elapsed at {DateTime.Now}");
}


