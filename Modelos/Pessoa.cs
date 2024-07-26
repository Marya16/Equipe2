namespace Modelos;
public class Pessoa 
{ 
   string Nome;
   string Sobrenome;
   string Telefone;
 
public void SetNome (string Nome)
{
   this.Nome = Nome;
}
public string GetNome ()
{ 
    return Nome;
}
public void SetSobrenome (string Sobrenome)
{ 
    this.Sobrenome = Sobrenome;  
}
public string GetSobrenome()
{ 
    return Sobrenome;
}
public void SetTelefone(string Telefone)
{ 
    this.Telefone = Telefone;
}
public string GetTelefone()
{ 
    return Telefone;
}
}