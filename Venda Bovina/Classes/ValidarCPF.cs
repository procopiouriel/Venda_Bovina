
using System;
using System.Windows.Forms;

public static class Validacoes
{
    public static bool ValidaCPF(string cpf)
    {
        
        cpf = cpf.Replace(".", "");
        cpf = cpf.Replace("-", "");
        if (cpf.Length != 11)
        {
            return false;
        }
        else
        {
            int soma = 0;
            int soma2 = 0;
            for (int i = 0; i < cpf.Length - 1; i++)
            {
                if (i < 9)
                {
                    soma += Convert.ToInt32(cpf[i].ToString()) * (10 - i);
                }
                soma2 += Convert.ToInt32(cpf[i].ToString()) * (11 - i);
            }

            int resto = soma % 11;
            if (resto < 2 && Convert.ToInt32(cpf[9].ToString()) != 0)
            {
                return false;
            }
            else
            {
                if (Convert.ToInt32(cpf[9].ToString()) != (11 - resto))
                {
                    return false;
                }
            }
            int resto2 = soma2 % 11;
            if (resto2 < 2 && Convert.ToInt32(cpf[10].ToString()) != 0)
            {
                return false;
            }
            else
            {
                if (Convert.ToInt32(cpf[10].ToString()) != (11 - resto2))
                {
                    return false;
                }
            }
        }
        return true;
    }
}