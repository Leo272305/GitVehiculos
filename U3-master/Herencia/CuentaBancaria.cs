class CuentaBancaria
{
    protected decimal saldo;

    public CuentaBancaria(decimal saldoInicial)
    {
        saldo = saldoInicial;
    }

    public void Depositar(decimal cantidad)
    {
        saldo += cantidad;
        Console.WriteLine($"Depósito de {cantidad} realizado. " +
            $"Nuevo saldo: {saldo}");
    }

    public virtual void Retirar(decimal cantidad)
    {
        if(cantidad <= saldo)
        {
            saldo -= cantidad;
            Console.WriteLine($"Retiro de {cantidad} realizado. " +
                $"Nuevo saldo: {saldo}");
        }
        else
        {
            Console.WriteLine("Fondos insuficientes");
        }
    }

    public decimal ObtenerSaldo()
    {
        return saldo;
    }
}

class CuentaAhorros : CuentaBancaria
{
    private decimal tasaInteres;
    public CuentaAhorros(decimal saldoInicial, decimal tasaInteres) 
        : base(saldoInicial)
    {
        this.tasaInteres = tasaInteres;
    }

    public void AplicarInteres()
    {
        decimal interes = saldo * tasaInteres;
        saldo += interes;
        Console.WriteLine($"Interés aplicado: {interes}. " +
            $"Nuevo saldo: {saldo}");
    }
}

class CuentaCorriente : CuentaBancaria
{
    private decimal limiteSobregiro;
    public CuentaCorriente(decimal saldoInicial, decimal limiteSobregiro) 
        : base(saldoInicial)
    {
        this.limiteSobregiro = limiteSobregiro;
    }

    public override void Retirar(decimal cantidad)
    {
        if(cantidad <= saldo + limiteSobregiro)
        {
            saldo -= cantidad;
            Console.WriteLine($"Retiro de {cantidad} realizado. " +
                $"Nuevo saldo: {saldo}");
        }
        else
        {
            Console.WriteLine("Excede el límite de sobregiro.");
        }
    }
}