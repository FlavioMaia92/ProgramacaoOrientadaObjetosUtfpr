
const int MaximoDeCompromissos = 100;

string[] datas = new string[MaximoDeCompromissos];
//var horas = new string[MaximoDeCompromissos];

Console.WriteLine(" 1. Adicionar Compromisso");

var opcao = Console.Readline();

if (opcao=="1"){
    Console.Write;("Data: ");
    var dataInformada = Console.ReadLine();
    if (dataInformada != " ") {
        datas[0] = dataInformada;
        Console.WriteLine("Data " + dataInformada + " registrada com sucesso");  
    } else {
             Console.WriteLine("Data inválida");
             
    }
    
}