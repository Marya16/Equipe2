using LiteDB;

namespace Modelos;
public class Produto
{
    [BsonId]
    public int ID  { get; set;}
    public string Fornecedor { get; set;}
    public string Marca { get; set;} 
    public string Unidade { get; set;}

}