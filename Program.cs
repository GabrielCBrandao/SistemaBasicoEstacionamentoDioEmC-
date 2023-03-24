// Abaixo segue um exemplo de código que você pode ou não utilizar
    System.Console.WriteLine("Bem vindo ao estacionamento da DIO");

    System.Console.WriteLine("Escolha o veículo: 1-Carro 2-Moto 3-Outros 4-Sair");

    string opcao= Console.ReadLine();

switch (opcao)
{ 
    case "1":
        System.Console.WriteLine("Você escolheu a opção carro, digite a placa do veículo: ");
        string placa = Console.ReadLine();
        int tempo = 2;
        int valor = 5;
        int totalAPagar= tempo*valor;
        System.Console.WriteLine($"O Veiculo de placa {placa} permaneceu em nosso estacionamento por {tempo}horas e o valor total ficou em R$:{totalAPagar}");
        Thread.Sleep(2000);
        System.Console.WriteLine("Pagando......");
        Thread.Sleep(2000);
        System.Console.WriteLine("Pagamento efetuado, obrigado e volte sempre!");
        break;

        case "2":
        System.Console.WriteLine("Você escolheu a opção moto, digite a placa do veículo: ");
        string placaMoto = Console.ReadLine();
        int tempoMoto = 4;
        int valorMoto = 2;
        int totalAPagarMoto= tempoMoto*valorMoto;
        System.Console.WriteLine($"O Veiculo de placa {placaMoto} permaneceu em nosso estacionamento por {tempoMoto}horas e o valor total ficou em R$:{totalAPagarMoto}");
         Thread.Sleep(2000);
        System.Console.WriteLine("Pagando......");
         Thread.Sleep(2000);
        System.Console.WriteLine("Pagamento efetuado, obrigado e volte sempre!");
        break;
        
        case "3":
        System.Console.WriteLine("Você escolheu a opção outro, digite a placa do veículo: ");
        string placaOutro = Console.ReadLine();
        int tempoOutro = 3;
        int valorOutro = 2;
        int totalAPagarOutro= tempoOutro*valorOutro;
        System.Console.WriteLine($"O Veiculo de placa {placaOutro} permaneceu em nosso estacionamento por {tempoOutro}horas e o valor total ficou em R$:{totalAPagarOutro}");
         Thread.Sleep(2000);
         System.Console.WriteLine("Pagando......");
         Thread.Sleep(2000);
         System.Console.WriteLine("Pagamento efetuado, obrigado e volte sempre!");
         break;

         case "4":
         System.Console.WriteLine("Sistema encerrando...");
          Thread.Sleep(2000);
         System.Console.WriteLine("Volte sempre!!");
          Thread.Sleep(2000);
          break;
        
        
    

}



