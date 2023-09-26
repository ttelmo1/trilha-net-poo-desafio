using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("999999999", "Nokia 3310", "123456789", 16);
Iphone iphone = new Iphone("999999999", "Iphone 11", "987654321", 64);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
