using EX_11.Models;

Restaurante restaurante1 = new Restaurante("Mc Jhonsons", "São Paulo", 3);

Cliente cliente1 = new Cliente("José","São Paulo");
Cliente cliente2 = new Cliente("Maria","Rio de Janeiro");

restaurante1.EntregaPedido(cliente1);
restaurante1.EntregaPedido(cliente2);