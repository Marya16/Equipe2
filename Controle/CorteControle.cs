using Modelos;

namespace Controles;

public class CorteControle : BaseControle
{
  //----------------------------------------------------------------------------

  public CorteControle() : base()
  {
    NomeDaTabela = "Corte";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCorte)
  {
    var collection = liteDB.GetCollection<Corte>(NomeDaTabela);
    return collection.FindOne(d => d.ID == idCorte);
  }

  //----------------------------------------------------------------------------

  public virtual List<Corte>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Corte>(NomeDaTabela);
    return new List<Corte>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCorte)
  {
    var collection = liteDB.GetCollection<Corte>(NomeDaTabela);
    collection.Delete(idCorte);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Corte corte)
  {
    var collection = liteDB.GetCollection<Corte>(NomeDaTabela);
    collection.Upsert(corte);
  }

  //----------------------------------------------------------------------------
}