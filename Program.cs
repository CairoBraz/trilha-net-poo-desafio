using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "9999999", modelo: "Nokia A", imei: "88888", memoria: 10);
nokia.Ligar();
nokia.InstalarAplicativo("Calendario");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone: ");
Smartphone iphone = new Iphone(numero: "3333333", modelo: "Iphone A", imei: "222222", memoria: 20);
iphone.Ligar();
iphone.InstalarAplicativo("Autenticador");
