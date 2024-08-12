using LiteDB;

namespace Modelos;
public class Pedido
{
    [BsonId]
   public int ID { get; set;}
   public string Nome { get; set;}
   public int ID_Quantidade { get; set;}
   public string Desconto { get; set;}
   public decimal Valor { get; set;}
   public string Marca { get; set;}
   public string Prazo { get; set;}
} 