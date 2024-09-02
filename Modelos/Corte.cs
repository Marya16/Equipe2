using LiteDB;

namespace Modelos;
public class Corte : Registro
{
    [BsonId]
    public int ID  { get; set;}
    public string Descrição { get; set;}
    public int Código { get; set;}
    public int ID_Quantidade { get; set;}


}