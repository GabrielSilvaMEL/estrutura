string op1 = "0";
while (op1 != "3"){
    Console.Clear();
    Console.WriteLine("MENU PRINCIPAL");
    Console.WriteLine("1 - Funções sem vetor");
    Console.WriteLine("2 - Funções com vetor");
    Console.WriteLine();
    Console.WriteLine("Digite a opção desejada:");
    op1 = Console.ReadLine();
    int x = 0;
    if (op1 == "1"){
        int n1 = 0;
        int n2 = 0;
        string op2 = "0";
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
        if (op2 == "2" ){
        Console.WriteLine("Você escolheu Decrescente");
        Decrescente(n1,n2);
        }
        if (op2 == "3" ){
        Console.WriteLine("Você escolheu Impares");
        Impares(n1,n2);
        } 

        if (op2 == "4" ){
            
        Console.WriteLine("Você escolheu somatória");
        Somatorio(n1,n2);
        Console.WriteLine("A Soma dos números entre "+n1 + " e " +n2+ " é: "+x);
        }      
    }
    //funções
        void Crescente(int nI,int nF){
            if (nI <= nF){
                Console.WriteLine(nI);
                Crescente(nI + 1, nF);
                Console.ReadKey();
            }    
            
        }
        void Decrescente(int nI,int nF){
            if (nI<=nF){
                Console.WriteLine(nF);
                Decrescente(nI,nF - 1);               
            }
        }
        void Impares(int nI, int nF){
            if (nI % 2 != 0){
                Console.WriteLine("Seu número é ímpar");
                Console.WriteLine(nI);
            }
        }
        void Somatorio(int nI,int nF){
            while (nI<=nF){
                x = (x + nF);
                nF = nF -1; 
                Console.WriteLine(x);         
            }
        }
    Console.ReadKey();
}
