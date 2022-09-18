//exercicio 2, 4 e 5 tem retorno.
Console.WriteLine("MENU PRINCIPAL ");
Console.WriteLine("1 - Potencia");
Console.WriteLine("2 - Cubos");
Console.WriteLine("3 - Impares");
Console.WriteLine("4 - Somatório");
Console.Write("Opção desejada: ");
string op = Console.ReadLine();

    //opção 1
if (op == "1" ){
    Console.WriteLine("Você escolheu Potencia");

    Console.WriteLine("Digite um número: ");
    int x = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite outro número: ");
    int y = int.Parse(Console.ReadLine());

    Console.WriteLine(Potencia(x,y));
}
int Potencia(int x,int y){
    int r = 1;
    int m = x;
    if (y >= r){
        x = x * m;
        r = r + 1;
    }
    return x;
}
if (op == "2" ){
    Console.WriteLine("Você escolheu Cubos");
    Console.WriteLine("Digite um número: ");
    int n = int.Parse(Console.ReadLine());
    Cubos(n);
}
void Cubos(int n){
    int i= 1;
    if(i <= n){
        Console.WriteLine(i*i*i);
     }
}

if (op == "3" ){
    Console.WriteLine("Você escolheu MDC");
    Console.WriteLine("Digite um número: ");
    int x = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite outro número: ");
    int y = int.Parse(Console.ReadLine());

    Mdc(x,y);
}
int Mdc(int x,int y){
    if (x==y){
        return x;
    }
    else if(x<y){
        return Mdc(y,x);
    }
    else{
        return Mdc(x-y,y);
    }
}
if (op == "4" ){
    Console.WriteLine("Você escolheu Fibonacci");
    Console.WriteLine("Digite um número: ");
    int n = int.Parse(Console.ReadLine());
    Fibonacci(n);
}
int Fibonacci(int n){
    if (n == 0 && n == 1){
        Console.WriteLine(n);
    }
    else if (n >= 2){
        Console.WriteLine(Fibonacci(n-1) + Fibonacci(n-2));
    }
}
Console.ReadKey();