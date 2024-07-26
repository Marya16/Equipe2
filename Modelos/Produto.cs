namespace Modelos;
public class Produto
{
    string Fornecedor;
    string Marca;
    string Unidade;

public void SetFornecedor (string Fornecedor)   
{
    this.Fornecedor = Fornecedor;
} 
public string GetFornecedor ()
{ 
    return Fornecedor;
}

public void SetMarca (string Marca)
{ 
    this.Marca = Marca;
}
public string GetMarca () 
{
    return Marca;
}
public void SetUnidade (string Unidade)
{ 
    this.Unidade = Unidade;
}
public string GetUnidade ()
{
    return Unidade;
}
}