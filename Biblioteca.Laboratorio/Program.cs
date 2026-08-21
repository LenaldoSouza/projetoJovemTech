using Biblioteca.Domínio;

Livro livroNovo = new Livro("O Cortiço", "Aluísio Azevedo", new DateTime(1234 / 12 / 01));
Revista revistaNova = new Revista("Piauí", "Alvinegra", new DateTime(1234 / 12 / 01));
Console.WriteLine($"Cena 6 - {livroNovo.Titulo} e o Id {livroNovo.Id}, " +
                  $"{revistaNova.Titulo} e o Id {revistaNova.Id}");


