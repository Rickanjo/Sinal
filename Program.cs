// Leia um número inteiro e exiba "Negativo", "Zero" ou "Positivo", conforme o caso.

Console.WriteLine("--- lendo número ---\n");

Console.Write("Digite um número inteiro: ");
int numint = int.Parse(Console.ReadLine()!);

if (numint < 0) {
    Console.WriteLine("\nNegativo");
}else if (numint == 0) {
    Console.WriteLine("\nero");
}else {
    Console.WriteLine("\nPositivo");
}



