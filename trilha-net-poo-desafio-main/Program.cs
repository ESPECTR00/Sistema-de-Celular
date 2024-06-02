using DesafioPOO.Models;

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "40028922", modelo: "nokia tijolão", imei: "Gmatr40220", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("");

Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone(numero: "(11) 97141-9974", modelo: "Iphone 15", imei: "Geymer4020", memoria: 1064);
iphone.InstalarAplicativo("Facebook");
iphone.ReceberLigacao();

