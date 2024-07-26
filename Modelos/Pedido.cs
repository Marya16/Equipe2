namespace Modelos;
public class Pedido
{
    int ID;
    string Nome;
    int ID_Quantidade;
    string Desconto;
    decimal Valor;
    string Marca;
    string Prazo;

public void SetID (int ID)
{
    this.ID = ID;
}
public int GetID ()
{
    return ID;
}
public void SetNome (string Nome)
{
    this.Nome = Nome;
}
public string GetNome ()
{
    return Nome;
}
public void SetID_Quantidade (int ID_Quantidade )
{
     this.ID_Quantidade = ID_Quantidade;
}
public int GetID_Quantidade ()
{
    return ID_Quantidade;
}
public void SetDesconto (string Desconto)
{
    this.Desconto = Desconto;
}
public string GetDesconto ()
{
    return Desconto;
}
public void SetValor (decimal Valor)
{
    this.Valor = Valor;
}
public decimal GetValor ()
{
    return Valor;
}
public void SetMarca (string Marca)
{
    this.Marca = Marca;
}
public string GetMarca ()
{
    return Marca;
}
public void SetPrazo (string Prazo)
{
    this.Prazo = Prazo;
}
public string GetPrazo ()
{
    return Prazo;
}
} 