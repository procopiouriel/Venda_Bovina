using System.Windows.Forms;
using Venda_Bovina;

public class Cadastro_Rebanho
{
    public  string tipo { get; set; }
    public string animal { get; set; }//Bovino, Muares, Equinos.

    public  string sexo { get; set; }//femea ou macho

    public  string Qani { get; set; }

    public static int numeracao { get; set; }
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
    public Cadastro_Rebanho(string tipo, string sexo, int numeracao, string raca, int idade, double comprimento, string coloracao, string registro, double altura, string marca, double genetica, double peso)
    {
        this.animal = tipo;
        this.sexo = sexo;
        Cadastro_Rebanho.numeracao = numeracao;
        this.raca = raca;
        this.idade = idade;
        this.comprimento = comprimento;
        this.coloracao = coloracao;
        this.registro = registro;
        this.altura = altura;
        this.marca = marca;
        this.genetica = genetica;
        this.peso = peso;
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
                if (sexo == "Femea")
                {
                    Cadastro_Rebanho.respostaFinal = "Vaca";
                }
                else if (sexo != "Femea")
                {
                    Cadastro_Rebanho.respostaFinal = "Boi";
                }
                else if (idade < 1)
                {
                    Cadastro_Rebanho.respostaFinal = "Bezerro";
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

    public static double PreçoRebanho(double pesoRebanho, string tipo, string sexo, int idade)
    {
        double ValorRebanho = 0;
        int pesoArroba = Convert.ToInt32(pesoRebanho / 15);//1kg = 15 arrobas

        if (Cadastro_Rebanho.Sexo(tipo, sexo, idade) == "Boi")
        {
           ValorRebanho = pesoArroba * 208.90;
        }
        if (Cadastro_Rebanho.Sexo(tipo, sexo, idade) == "Vaca")
        {
            ValorRebanho = pesoArroba * 167.98;
        }
        if (Cadastro_Rebanho.Sexo(tipo, sexo, idade) == "Bezerro")
        {
            ValorRebanho = pesoArroba * 190.80;
        }
        MessageBox.Show(ValorRebanho.ToString());

        return ValorRebanho;
    }

  /*- PREÇO:
 * Bezerro = 190,80 reais a arroba;
 * Vaca = 167,98 reais a arroba;
 * Boi = 208,90 reais a arroba;
 */
}
