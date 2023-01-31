using EX_08.Models;



Carro carro1 = new Carro("Preto", "Tesla", "hatch", 30, "Flex");

Console.WriteLine($"Cor do carro: {carro1.Cor}");
Console.WriteLine($"Marca: {carro1.Marca}");
Console.WriteLine($"Modelo: {carro1.Modelo}");
Console.WriteLine($"Capacidade do Tanque de combustível: {carro1.CapacidadeDoTanque} litros");
Console.WriteLine($"Tipo de combustível: {carro1.TipoDeCombustivel}");


carro1.Abastecer(10.50, "alcool");