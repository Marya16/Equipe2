using LiteDB;

namespace Modelos;
public class Costura
{
    [BsonId]
    public int ID { get; set;}
    public string Produto { get; set;}
    public int ID_Quantidade { get; set;}
    public string Entrada { get; set;}
    public string Prazo { get; set;}

}