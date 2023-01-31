using EX_13.Models;

SmartWatch smartWatch1 = new SmartWatch("Samsung");

smartWatch1.Caminhar();
smartWatch1.Caminhar();
smartWatch1.Caminhar();
smartWatch1.Caminhar();
smartWatch1.Caminhar();

Console.WriteLine(smartWatch1.Pedometro);

smartWatch1.ResetOnMidnight();