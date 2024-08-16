using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia =new Nokia("123456789", "Nokia 3310", "123456789", "16GB");
Iphone iphone = new Iphone("987654321", "Iphone 12", "987654321", "128GB");

Console.WriteLine("Teste da classe Nokia:");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nTeste da classe Iphone:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("Testes finalizados.");