// Apresentação do nosso programa! :)
Console.WriteLine("Seja Bem vindo! Esse é o nosso primeiro Desafio!!!");
Console.WriteLine("VAMOS COMEÇAR");

Console.WriteLine("Digite a idade da primeira pessoa: ");
var idade1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a idade da Segunda pessoa: ");
var idade2 = Convert.ToInt32(Console.ReadLine());

var maiorIdade1 = idade1 > idade2;
var maiorDeIdade1 = idade1 > 17;
var maiorDeIdade2 = idade2 > 17;

Console.WriteLine("A primeira pessoa é mais velho que a segunda?");
Console.WriteLine(maiorIdade1);

Console.WriteLine("A primeira pessoa é maior que 18 anos?");
Console.WriteLine(maiorDeIdade1);

Console.WriteLine("A segunda pessoa é maior que 18 anos?");
Console.WriteLine(maiorDeIdade2);




