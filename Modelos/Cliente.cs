namespace Modelos;
public class Cliente: Pessoa
{ 
    string CPF;

public void SetCPF (string CPF)  
{ 
    this.CPF = CPF;
}  
public string GetCPF ()
{ 
    return CPF;
}
}