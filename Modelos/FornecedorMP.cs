using LiteDB;

namespace Modelos;

public class FornecedorMP : Registro
{
    [BsonId]
    public int ID  { get; set;}
    public int ID_Fornecedor { get; set;}
    public int ID_Materiaprima { get; set;}

}