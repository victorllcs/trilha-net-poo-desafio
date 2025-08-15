using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


//Nokia
Nokia tijolao = new Nokia("31999973592", "Tijolão", "122444", "8GB");
tijolao.Ligar();
tijolao.ReceberLigacao();
tijolao.InstalarAplicativo("Jogo da Velha");

//Iphone
Iphone proMax14 = new Iphone("31999973592", "Pro Max 14", "122555", "252GB");
proMax14.Ligar();
proMax14.ReceberLigacao();
proMax14.InstalarAplicativo("Jogo da Velha");