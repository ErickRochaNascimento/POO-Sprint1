using System;

contaBancaria contaBancaria1 = new contaBancaria();
contaBancaria1.NomeTitular = "Erick Nascimento";
contaBancaria1.NumeroConta = 2026020001;
contaBancaria1.Saldo = 5000;


contaBancaria contaBancaria2 = new contaBancaria();
contaBancaria2.NomeTitular = "Matheus Luciano";
contaBancaria2.NumeroConta = 2026020002;
contaBancaria2.Saldo = 2000;

contaBancaria1.AdicionarContaCorrente(contaBancaria1);


contaBancaria1.ExibirInformacaoConta();
contaBancaria2.ExibirInformacaoConta();


