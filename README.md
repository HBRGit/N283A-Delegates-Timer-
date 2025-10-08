# N283A-Delegates-Timer-
Opgave fra Bogen om C#

Skabe en konsol app der anvender en System.Timers.Timer til at udføre en handling hvert sekund. Handlingen skal være at udskrive den nuværende tid på konsollen.
Brug System.Timers.Timer, og bind en metode til Elapsed-hændelsen. Brug evt. følgende skabelon kode
Prøv følgende kode og se hvad der sker, når timeren udløber hvert sekund
```csharp
System.Timers.Timer timer = new System.Timers.Timer(1000); // Timer sat til at udløbe hvert sekund (1000 ms)
timer.Elapsed += OnTimedEvent;
timer.AutoReset = true;
timer.Enabled = true;

Console.WriteLine("Timer startet. Tryk 'Enter' for at stoppe.");
Console.ReadLine();

static void OnTimedEvent(Object source, ElapsedEventArgs e)
{
    Console.WriteLine("Nuværende tid: " + DateTime.Now.ToString("HH:mm:ss"));
}
```
Læg mærke til at OnTimedEvent-metoden bindes til Elapsed-delegaten med += syntaksen. Dette skyldes, at der i virkeligheden er tale om et event, som bruges til at håndtere periodiske handlinger med en timer.
