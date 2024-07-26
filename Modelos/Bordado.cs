namespace Modelos;
 public class Bordado
 {
    int ID;
    string Produto;
    int ID_Quantidade;
    string Entrada;
    string Prazo;

public void SetID (int ID)
{
    this.ID = ID;
}
public int GetID ()
{  
    return ID;
}
public void SetProduto (string Produto)
{
    this.Produto = Produto;
}
public string GetProduto ()
{
    return Produto;
}
public void SetID_Quantidade (int ID_Quantidade)
{ 
    this.ID_Quantidade = ID_Quantidade;
}
public int GetID_Quantidade ()
{
    return ID_Quantidade; 
}
public void SetEntrada (string Entrada)
{
    this.Entrada = Entrada;
}
public string GetEntrada ()
{
    return Entrada;
}
 }