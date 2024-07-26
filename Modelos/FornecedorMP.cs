namespace Modelos;

public class FornecedorMP
{
    int ID_Fornecedor;
    int ID_Materiaprima;

public void SetID_Fornecedor (int ID_Fornecedor) 
{
    this.ID_Fornecedor =  ID_Fornecedor;
}  
public int GetID_Fornecedor ()
{
    return ID_Fornecedor;
}
public void SetID_Materiaprima (int ID_Materiaprima)
{
    this.ID_Materiaprima = ID_Materiaprima;
}
public int GetID_Materiaprima (int ID_Materiaprima)
{
    return ID_Materiaprima;
}
}