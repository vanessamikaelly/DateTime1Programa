using System;

public class Calculo 
{
    public static int Calculo2(DateTime dataNasc)
    {
        DateTime dataAtual = DateTime.Today;
        int idade = dataAtual.Year - dataNasc.Year;

        
        if (dataNasc.Date > dataAtual.AddYears(-idade))

            idade--;

        return idade;
    }
    

}
