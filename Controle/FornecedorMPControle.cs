using Modelos;

namespace Controles;

public class FornecedorMPControle : BaseControle
{
  //----------------------------------------------------------------------------

  public FornecedorMPControle() : base()
  {
    NomeDaTabela = "Fornecedor";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idFornecedorMP)
  {
    var collection = liteDB.GetCollection<FornecedorMP>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idFornecedorMP);
  }

  //----------------------------------------------------------------------------

  public virtual List<FornecedorMP>? LerTodos()
  {
    var tabela = liteDB.GetCollection<FornecedorMP>(NomeDaTabela);
    return new List<FornecedorMP>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idFornecedorMP)
  {
    var collection = liteDB.GetCollection<FornecedorMP>(NomeDaTabela);
    collection.Delete(idFornecedorMP);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(FornecedorMP fornecedorMP)
  {
    var collection = liteDB.GetCollection<FornecedorMP>(NomeDaTabela);
    collection.Upsert(fornecedorMP);
  }

  //----------------------------------------------------------------------------
}