using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "999990000", modelo: "Modelo 1", imei: "1234567899", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Nokia(numero: "011112222", modelo: "Modelo 2", imei: "9912345678", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
