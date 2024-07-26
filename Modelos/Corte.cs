namespace Modelos;
public class Corte
{
    int ID;
    string Descrição;
    int Código;
    int ID_Quantidade;

public void SetID (int ID)
{
    this.ID = ID;
}
public int GetID ()
{
    return ID;
}  
public void SetDescrição (string Descrição)  
{
    this.Descrição = Descrição;
}
public string GetDescrição ()
{
    return Descrição;
}
public void SetCódigo (int Código)
{
    this.Código = Código;
}
public int GetCódigo ()
{
    return Código;
}
public void SetID_Quantidade (int ID_Quantidade)
{
    this.ID_Quantidade = ID_Quantidade;
}
public int SetID_Quantidade ()
{
    return ID_Quantidade;
}
}