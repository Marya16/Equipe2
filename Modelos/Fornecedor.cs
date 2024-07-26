namespace Modelos;
public class Fornecedor
{ 
    string CNPJ;
    string Cidade;
    string Rua;
    string Email;

public void SetCNPJ (string CNPJ)    
{ 
    this.CNPJ = CNPJ;
}
public string GetCNPJ()
{ 
  return CNPJ;
}
 public void SetCidade (string Cidade)
{ 
    this.Cidade = Cidade;
}
public string GetCidade()
{
    return Cidade;
}
public void SetRua (string Rua)
{
    this.Rua = Rua;
}
public string GetRua ()
{ 
    return Rua;
}
public void SetEmail (string Email)
{ 
    this.Email = Email;
}
public string GetEmail ()
{ 
    return Email;
}
}