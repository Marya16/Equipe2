using LiteDB;

namespace Modelos;
public class Fornecedor
{ 
    [BsonId]
    public int ID  { get; set;}
    public string CNPJ { get; set;}
    public string Cidade { get; set;}
    public string Rua { get; set;}
    public string Email { get; set;}

}