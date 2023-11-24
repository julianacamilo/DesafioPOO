using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");

Smartphone nokia = new Nokia(numero: "0000000", modelo: "The First Model", iMEI: "000000", memoria: 128);

nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "1111111", modelo: "The Second Model", iMEI: "111111", memoria: 264);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("X");

