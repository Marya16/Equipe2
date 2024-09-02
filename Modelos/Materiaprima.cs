using LiteDB;

namespace Modelos;

public class Materiaprima : Registro
{
    [BsonId]
    public int ID  { get; set;}
    public string Nome { get; set;}
    public string Marca { get; set;}
    public int ID_Materiaprima { get; set;}
    public string Unidadedemedida { get; set;}

}