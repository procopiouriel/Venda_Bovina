using Newtonsoft.Json;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Formatting = Newtonsoft.Json.Formatting;

public class Fazendeiro
{
    public string Foto { get; set; }
    public string Nome { get; set; }

    public string Senha { get; set; }
    public int Idade { get; set; }

    public string Cpf { get; set; }
    public string Cnpj { get; set; }

    public double PropriedadeR { get; set; }

    public int CabecaG { get; set; }

    public string Marca { get; set; }

    public Fazendeiro()
    {

    }
    public Fazendeiro(string foto, string nome, string senha, int idade, string cpf, string cnpj, double propiedadeR, int cabecaG, string marca)
    {
        this.Foto = foto;
        this.Nome = nome;
        this.Senha = senha;
        this.Idade = idade;
        this.Cpf = cpf;
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


    public bool JsonSerealizarListaUsuario(List<Fazendeiro> lista, string path)
    {
        var strJson = JsonConvert.SerializeObject(lista, Formatting.Indented);
        return SaveFileEmpresa(strJson, path);
    }

    private static string OpenFileEmpresa(string path)
    {
        try
        {
            var strJson = "";
            using (StreamReader sw = new StreamReader(path))
            {
                strJson = sw.ReadToEnd();
            }
            return strJson;
        }
        catch (Exception ex)
        {
            return "Falha: " + ex.Message;
        }
    }

    public static List<Fazendeiro> JsonDesserealizarListaUsuario(string path)
    {
        var strJson = OpenFileEmpresa(path);
        if (strJson.Contains("Falha"))
        {
            var listaempresas = new List<Fazendeiro>();
            Fazendeiro conexao = new Fazendeiro();
            listaempresas.Add(conexao);
            return listaempresas;
        }
        else
        {

            return JsonConvert.DeserializeObject<List<Fazendeiro>>(strJson);

        }
    }

    private bool SaveFileEmpresa(string strJson, string path)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(strJson);
            }

            return true;
        }
        catch (Exception error)
        {
            return false;
        }
    }
}

