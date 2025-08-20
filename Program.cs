using DesafioPOO.Models;

Iphone iphone = new Iphone("+55019999334455", "iPhone 16 - Pro Max", "000-Imei", 256);
Nokia nokia = new Nokia("+55011992870090", "Nokia Tijolão", "111-Imei", 128);

Console.WriteLine("Qual aplicativo você deseja instalar?");

string nomeApp = Console.ReadLine();
Console.WriteLine("\n");

Console.WriteLine($"Smartphone iPhone:");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo(nomeApp);

Console.WriteLine("\n");

Console.WriteLine($"Smartphone Nokia:");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo(nomeApp);