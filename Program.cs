using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("1111", "Modelo 1", "2314213", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone("2222", "Modelo 2", "768678658", 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");