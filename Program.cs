using DesafioPOO.Models;

Iphone iphoneDeVictor = new Iphone(numero:"4002-8922", modelo:"iphone14", imei:"490154203237518", memoria:16);
iphoneDeVictor.Ligar();
iphoneDeVictor.ReceberLigacao();
iphoneDeVictor.InstalarAplicativo("Imessage");

Console.WriteLine();

Nokia nokiaDeEduardo = new Nokia(numero:"0800-777-7000", modelo:"nokia3310", imei:"352684072891234", memoria:2);
nokiaDeEduardo.Ligar();
nokiaDeEduardo.ReceberLigacao();
nokiaDeEduardo.InstalarAplicativo("Opera Mini");