public class Venda
{
    public double saldo = 10000;

    public double valorAnimal;

    public List<string> venda = new List<string>();

  



    public void Comercio()
    {
        if (saldo >= valorAnimal)
        {
            saldo -= valorAnimal;
            
            MessageBox.Show("Compra efetuada!");
        }

        else
        {
            MessageBox.Show("Saldo insuficiente!");
        }
    }
}