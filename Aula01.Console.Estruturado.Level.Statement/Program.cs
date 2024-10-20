const int MaximoDeCompromissos = 100;

string[] datas = new string[MaximoDeCompromissos];
// var horas = new string[MaximoDeCompromissos];

System.Console.WriteLine(" 1. Adicionar Compromisso");

var opcao = Console.Readline();

if (opcao=="1"){
    System.Console.Write;("Data: ");
    var dataInformada = System.Console.ReadLine();
    if (dataInformada != ""){
        datas[0] = dataInformada;
        System.Console.WriteLine("Data " + dataInformada + " registrada com sucesso");  
    } else {
             System.Console.WriteLine("Data inválida");
             
    }
    
}