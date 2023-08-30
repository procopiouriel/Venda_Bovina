using Newtonsoft.Json;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Formatting = Newtonsoft.Json.Formatting;

public class Fazendeiro
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public static string Cpf { get; set; }

    public string Cnpj { get; set; }

    public double PropriedadeR { get; set; }

    public int CabecaG { get; set; }

    public string Marca { get; set; }

    public Fazendeiro()
    {

    }
    public Fazendeiro(string nome, int idade, string cpf, string cnpj, double propiedadeR, int cabecaG, string marca)
    {
        this.Nome = nome;
        this.Idade = idade;
        Fazendeiro.Cpf = cpf;
        this.Cnpj = cnpj;
        this.PropriedadeR = propiedadeR;
        this.CabecaG = cabecaG;
        this.Marca = marca;
        

    }

    public string MarcaGado(string nome)
    {
        try
        {
            string[] split = nome.Split(" ");
            if (split.Length > 2)
            {
                string nome1 = split[0];
                string nome2 = split[1];
                string marca = (nome1[0] + nome2[0].ToString()).ToUpper();
                return marca;
            }
            return null;
        }
        catch (Exception error)
        {
        }
        return null;
    }

    public static string PrimeiroNome(string nome)
    {
        try
        {
            string[] split = nome.Split(" ");

            string nome1 = split[0];


            return nome1;

        }
        catch (Exception error)
        {
        }
        return null;
    }


    
}

