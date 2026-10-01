Console.WriteLine("digite o valor da compra: ");
double valorCompra = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("digite o valor pago: ");
double valorPago = Convert.ToDouble(Console.ReadLine());

double troco = valorPago - valorCompra;
Console.WriteLine($"o troco é: {troco:F2}");
