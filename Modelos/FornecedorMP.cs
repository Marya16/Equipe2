using LiteDB;

namespace Modelos;

public class FornecedorMP
{
    [BsonId]
    public int ID  { get; set;}
    public int ID_Fornecedor { get; set;}
    public int ID_Materiaprima { get; set;}

}