using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using Venda_Bovina;

public class Cadastro_Rebanho
{
    public string tipo { get; set; }
    public string animal { get; set; }//Bovino, Muares, Equinos.

    public  string sexo { get; set; }//femea ou macho

    public int numeracao = 0;
    public  string raca { get; set; }
    public  int idade { get; set; }
    public  double comprimento { get; set; }
    public  string coloracao { get; set; }
    public  string registro { get; set; }
    public  double altura { get; set; }
    public  string marca { get; set; }
    public  double genetica { get; set; }
    public  double preco { get; set; }
    public  double peso { get; set; }

    public static string respostaFinal { get; set; }

    public static double ValorRebanho { get; set; }

    public Cadastro_Rebanho()
    {
        
    }
    public Cadastro_Rebanho(int numeracao, string tipo, string sexo, string tipoAnimal, string raca, int idade, double comprimento, string coloracao, string registro, double altura, string marca, double genetica, double preco, double peso)
    {
        this.numeracao = numeracao;
        this.animal = tipo;
        this.sexo = sexo;
        this.tipo = tipoAnimal;
        this.raca = raca;
        this.idade = idade;
        this.comprimento = comprimento;
        this.coloracao = coloracao;
        this.registro = registro;
        this.altura = altura;
        this.marca = marca;
        this.genetica = genetica;
        this.peso = peso;
        this.preco = preco;
    }


    public static string Sexo(string tipo, string sexo, int idade)
    {
       
            if (tipo == "Muares")
            {
                if (sexo == "Femea")
                {
                    Cadastro_Rebanho.respostaFinal = "Mula";
                }
                else
                {
                    Cadastro_Rebanho.respostaFinal = "Burro";
                }
            }

        else if (tipo == "Bovinos")
        {
            if (idade >= 12 && sexo == "Femea")
            {
                Cadastro_Rebanho.respostaFinal = "Vaca";
            }
            else if (idade >= 12 && sexo != "Femea")
            {
                Cadastro_Rebanho.respostaFinal = "Boi";
            }
            else if (idade < 12 && sexo == "Macho")
            {
                Cadastro_Rebanho.respostaFinal = "Bezerro";
            }
            else if (idade < 12 && sexo == "Femea")
            {
                Cadastro_Rebanho.respostaFinal = "Bezerra";
            }
        }

        else if (tipo == "Equinos")
            {
                if (sexo == "Femea")
                {
                    Cadastro_Rebanho.respostaFinal = "Égua";

                }
                else
                {
                    Cadastro_Rebanho.respostaFinal = "Cavalo";
                }
            }
            return Cadastro_Rebanho.respostaFinal;
       

       
    }

    public string Registrado(string registrado)
    {
        if (this.registro == "sim")
        {
            return "Animal Registrado";
        }
        return "Animal não Registrado";
    }

    public static double PrecoRebanho(double pesoRebanho, string tipo, string sexo, int idade, double genetica)
    {
        double ValorRebanho = 0;
        double pesoArroba = pesoRebanho / 15;//1kg = 15 arrobas

        if (Cadastro_Rebanho.Sexo(tipo, sexo, idade) == "Boi")
        {
           ValorRebanho = pesoArroba * 208.90;
        }
        if (Cadastro_Rebanho.Sexo(tipo, sexo, idade) == "Vaca")
        {
            ValorRebanho = pesoArroba * 167.98;
        }
        if (Cadastro_Rebanho.Sexo(tipo, sexo, idade) == "Bezerro" || Cadastro_Rebanho.Sexo(tipo, sexo, idade) == "Bezerra")
        {
            ValorRebanho = pesoArroba * 190.80;
        }

        if (tipo == "Equinos" || tipo == "Muares")
        {
            ValorRebanho = genetica * 80000;
            return ValorRebanho;
        }
        return ValorRebanho;
    }





    public bool JsonSerealizarLista(List<Cadastro_Rebanho> lista, string path)
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

    public static List<Cadastro_Rebanho> JsonDesserealizarLista(string path)
    {
        var strJson = OpenFileEmpresa(path);
        if (strJson.Substring(0, 5) != "Falha")
        {
            return JsonConvert.DeserializeObject<List<Cadastro_Rebanho>>(strJson);
        }
        else
        {
            var listaempresas = new List<Cadastro_Rebanho>();
            Cadastro_Rebanho conexao = new Cadastro_Rebanho();
            listaempresas.Add(conexao);
            return listaempresas;
           
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
            MessageBox.Show(error.Message);
            return false;
        }
    }

}
