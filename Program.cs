string op1 = "0";
while (op1 != "3"){
    Console.Clear();
    Console.WriteLine("MENU PRINCIPAL");
    Console.WriteLine("1 - Funções sem vetor");
    Console.WriteLine("2 - Funções com vetor");
    Console.WriteLine();
    Console.WriteLine("Digite a opção desejada:");
    op1 = Console.ReadLine();
    if (op1 == "1"){
        int n1 = 0;
        int n2 = 0;
        string op2 = 0;

        Console.WriteLine("Digite um número inicial: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o número final: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("O que deseja fazer com esses números? ");
        Console.WriteLine("1 - Crescente");
        Console.WriteLine("2 - Decrescente");
        Console.WriteLine("3 - Impares");
        Console.WriteLine("4 - Somatório");
        Console.Write("Opção desejada: ");
        op2 = Console.ReadLine();

        //opção 1
        if (op2 == "1" ){
            Console.WriteLine("Você escolheu Crescente");
            Crescente(n1,n2);
        }
        //opção 2
        Console.WriteLine("Você escolheu Decrescente");


        //funções
        void Crescente(int nI,int nF){
            if (nI <= nF){
                Console.WriteLine(nI, nF);
                
            }
        }
    }
}
