using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new("123456789", "iPhone 13", "123456789012345", 128);
Nokia nokia = new("987654321", "Nokia 3310", "987654321098765", 16);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");
Console.WriteLine("Testes concluídos com sucesso!");
