using Bootcamp_dotnet_smartphone.Models;

Console.WriteLine("IOS:");
IPhone ios = new IPhone("1234-5678", "IPhone X", "123456789", 60);
ios.Ligar();
ios.InstalarAplicacao("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Nokia:");
Nokia nokia= new Nokia("3216-5498", "Nokia 11", "789456123", 256);
nokia.Ligar();
nokia.InstalarAplicacao("Facebook");