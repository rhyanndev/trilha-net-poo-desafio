using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Iphone:\n");

Smartphone iphone = new Iphone(numero:"1234567", modelo:"iPhone X", imei:"123456789012345", memoria:256);

iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");


Console.WriteLine("Smartphone Nokia:\n");
Smartphone nokia = new Nokia(numero:"9876543", modelo:"Nokia 8", imei:"987654321098765", memoria:64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");