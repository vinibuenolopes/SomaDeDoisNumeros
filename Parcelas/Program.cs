double valorCompra, numeroParcelas;
Console.WriteLine("Digite o número de vezes pelo qual deseja parcelar");
numeroParcelas = double.Parse(Console.ReadLine());
if (numeroParcelas > 5){
    Console.WriteLine("Parcelamos em até 5 vezes apenas");
}else
{
    Console.WriteLine("Digite o valor da compra");
    valorCompra = double.Parse(Console.ReadLine());
    Console.WriteLine("Cada parcela custará {0:N} reais e serão {1} meses até o fim das parcelas",(valorCompra/numeroParcelas),numeroParcelas);
}

