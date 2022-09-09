Console.WriteLine("Digite um número: ");
    int x = int.Parse(Console.ReadLine());
//exercicio 2, 4 e 5 tem retorno.
Console.WriteLine("Digite outro número: ");
    int y = int.Parse(Console.ReadLine());

Console.WriteLine("O que deseja fazer com esses números? ");
Console.WriteLine("1 - Potencia");
Console.WriteLine("2 - Decrescente");
Console.WriteLine("3 - Impares");
Console.WriteLine("4 - Somatório");
Console.Write("Opção desejada: ");
string op = Console.ReadLine();

        //opção 1
if (op == "1" ){
    
    Console.WriteLine("Você escolheu Potencia");
    Console.WriteLine(Potencia(x,y));
}

function Potencia(x,y){
    int r = 0;
    int m = x;
    if (y>=r){
        x = x * m;
        r = r + 1;
    }
    return x;
}
if (op == "2" ){
    
    Console.WriteLine("Você escolheu Iterativa");
    Console.WriteLine(Iterativa(x,y));
}