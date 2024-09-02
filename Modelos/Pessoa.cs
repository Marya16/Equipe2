using LiteDB;

namespace Modelos;
public class Pessoa : Registro
{ 
   [BsonId]
   public int ID  { get; set;}
   public string Nome { get; set;}
   public string Sobrenome { get; set;}
   public string Telefone { get; set;}
 
}