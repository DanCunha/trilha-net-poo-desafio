using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("123456","Modelo 6120", "1111111111", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("5585236","14 Pro Max", "5555555555", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");