namespace Modelos;

public class Materiaprima
{
    string Nome;
    string Marca;
    int ID_Materiaprima;
    string Unidadedemedida;

public void SetNome (string Nome)
{
    this.Nome = Nome;
}
public string GetNome ()
{
    return Nome;
}
public void SetMarca (string Marca)
{
    this.Marca = Marca;
}
public string GetMarca ()
{
    return Marca;
}
public void SetID_Materiaprima (int ID_Materiaprima)
{
    this.ID_Materiaprima = ID_Materiaprima;
}
public int GetID_Materiaprima ()
{
    return ID_Materiaprima;
}
public void SetUnidadedemedida (string Unidadedemedida)
{
    this.Unidadedemedida = Unidadedemedida;
}
public string GetUnidadedemedida ()
{
    return Unidadedemedida;
}
}