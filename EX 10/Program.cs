using EX_10.Models;

Pessoa pessoa1 = new Pessoa("João", 30, "masculino",1);
Pessoa pessoa2 = new Pessoa("Maria", 28, "feminino",2);
Pessoa pessoa3 = new Pessoa("José", 27, "masculino",3);

List<Pessoa> ListaPessoas = new List<Pessoa>() {pessoa1,pessoa2,pessoa3};

Sorteio sorteio1 = new Sorteio("Sorteio Aleatório", ListaPessoas);

sorteio1.SorteiaPremio();