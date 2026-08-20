using Biblioteca.Domínio;

Console.WriteLine("Hello, World!");

ItemAcervo Carrinhos = new Revista("Os carrinhos", "Video Brinquedo", new DateTime(2010, 5, 30)); // os carrinhos é melhor que a triologia carros

ItemAcervo MarcosEOs3Coisas = new Revista("Marcos e os 3 coisas", "Alguem aí", new DateTime(1234, 12, 31));

ItemAcervo JojoRef = new Livro("As aventuras estranhas de João Judiasco", "Um cara japonês bem legal", new DateTime(1234, 12, 31));

ItemAcervo Odisseia = new Livro("Odisséia", "Homero", new DateTime(1998, 5, 20));

ItemAcervo OsBarquinhos = new Dvd("Os Barquinhos", "Video Brinquedo", new DateTime(1234, 12, 31));

ItemAcervo Faust = new Livro("Fausto", "Johann Wolfgang von Goethe", new DateTime(1234, 12, 31));

ItemAcervo Joguin = new Dvd("Super Bomberman 4", "HudsonSoft", new DateTime(1234, 12, 31));

ItemAcervo Frifairi = new Dvd("Free Fire", "Garena", new DateTime(1234, 12, 31));

ItemAcervo Ref2 = new Revista("Mickey, Donald e Pateta em os três mosqueteiros", "Disney", new DateTime(1234, 12, 31));

ItemAcervo SemIdeia = new Livro("O titulo mais incrivel já visto pela face da terra", "Um cara legal", new DateTime(1234, 12, 31));

ItemAcervo Coraline = new Dvd("Coraline e o Mundo Secreto", "Laika", new DateTime(1234, 12, 31)); // se alguem chamar esse filme de ruim, eu vou odiar de forma pessoal :^)

Emprestimo Divida = new Emprestimo(Frifairi);

Divida.RegistrarDevolucao();