using LiteDB;

namespace Modelos;
public class Estoque
{
   [BsonId]
    public int ID  { get; set;}
    public string NomedoProduto { get; set;}
    public int ID_Produto { get; set;}
    public decimal Preço { get; set;}

}