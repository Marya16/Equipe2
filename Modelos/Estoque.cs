namespace Modelos;
public class Estoque
{
    string NomedoProduto;
    int ID_Produto;
    decimal Preço;

public void SetNomedoProduto (string NomedoProduto)
 { 
    this.NomedoProduto = NomedoProduto;
 }
 public string GetNomedoProduto ()
 {
    return NomedoProduto;
 }
 public void SetID_Produto (int ID_Produto)
 {
    this.ID_Produto = ID_Produto;
 }
 public int GetID_Produto ()
 { 
    return ID_Produto;
 }
 public void SetPreço (decimal Preço)
{
    this.Preço = Preço;
}
public decimal GetPreço ()
{
    return Preço;
}
}