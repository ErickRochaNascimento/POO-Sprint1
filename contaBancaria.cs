using System;

class contaBancaria
{
    private List<ContaCorrente> contascorrente = new List<ContaCorrente>();


    public string NomeTitular { get; set; }
    public int NumeroConta { get; set; }
    public decimal Saldo { get; set; }



    public void ExibirInformacaoConta()
    {
        Console.WriteLine($"Conta informações: \n Nome titular: {NomeTitular} \n Numero conta: {NumeroConta} \n Saldo: {Saldo}");
    }

  

}