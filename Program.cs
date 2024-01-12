using DesafioPOO.Models;

//  Realizando os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "(11) 999-9999", modelo: "Modelo Y", imei: "111111111", memoria: 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("Whatsapp");
        Console.WriteLine("\n");


        Console.WriteLine("Smartphone iPhone:");
        Smartphone iphone = new Iphone(numero: "(13) 000-0000", modelo: "Modelo Z", imei: "222222222", memoria: 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");