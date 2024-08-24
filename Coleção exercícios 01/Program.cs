/*Coleção de exercicios 01*/
//Exercícios 01
//string curso = "C# - Criando primeira aplicação";
//string nome = "Julio";
//string sobrenome = "Gomes Pena";

//Console.WriteLine(curso);
//Console.WriteLine("Instrutor 01" + " " + "Instrutor 02");



//Exercícios 02

//int notaMedia = 7;

//if (notaMedia >= 5)
//{ 
//    Console.WriteLine("Nota suficiente para aprovação");
//}



//Exercícios 03
//string[] linguagens = { "C#", "Java", "Javascript", "C++", "React", "C", "PHP", "HTML", "CSS"};

//Console.WriteLine("Digite um índice de acesso a array");
//int indiceAcesso = int.Parse(Console.ReadLine()!);

//Console.WriteLine(linguagens[indiceAcesso]);



//Exercícios 04
//int numeroSorteado = sortearNumero(1, 11);
//int chute;
//bool acertou = false;

//Console.WriteLine(numeroSorteado);

//Console.WriteLine("Jogo do número sorteado! Tente acertar, digite um número.");

//while(acertou == false)
//{

//    chute = int.Parse(Console.ReadLine()!);

//    if (chute == numeroSorteado)
//    {
//        acertou = true;
//        Console.WriteLine("Parabéns! Você ganhou!");
//    }
//    else if (chute > numeroSorteado) Console.WriteLine("Tente novamente, dessa vez um número MENOR.");
//    else if (chute < numeroSorteado) Console.WriteLine("Tente novamente, dessa vez um número MAIOR.");
//    else if (chute == 0) Console.WriteLine("Tente novamente, dessa vez digite um número!")aa;

//}


//int sortearNumero(int min, int max)
//{
//    Random r = new Random();
//    int numero = r.Next(min, max);
//    return numero;
//}