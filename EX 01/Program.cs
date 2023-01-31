using EX_01.Models;


//Instancia o objeto boletim, com erros na definição de ano e semestre.
Boletim boletim1 = new Boletim("Joãozinho",1960,15);

//define as médias por materia do boletim
boletim1.DefinirNotas(10, 9, 8, 7, 6, 5);

Console.WriteLine($"\nPressione qualquer tecla para ver o boletim de {boletim1.NomeDoAluno}");
Console.ReadKey();
Console.Clear();

//método para ver as médias no boletim
boletim1.VerBoletim();