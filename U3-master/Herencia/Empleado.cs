class Empleado
{
    public string Nombre { get; set; }
    public int HorasTrabajadas { get; set; }
    public decimal TarifaPorHora { get; set; }

    public Empleado(string nombre, int horasTrabajadas, 
        decimal tarifaPorHora)
    {
        Nombre = nombre;
        HorasTrabajadas = horasTrabajadas;
        TarifaPorHora = tarifaPorHora;
    }

    public virtual decimal CalcularSalario()
    {
        return HorasTrabajadas * TarifaPorHora;
    }
}

class EmpleadoTiempoCompleto : Empleado
{
    public EmpleadoTiempoCompleto(string nombre, int horasTrabajadas, 
        decimal tarifaPorHora) : base(nombre, horasTrabajadas, tarifaPorHora)
    {
    }

    public override decimal CalcularSalario()
    {
        decimal salarioBase = base.CalcularSalario();
        return salarioBase + 1000; // Bono fijo para empleados a tiempo completo
    }
}

class EmpleadoContratista : Empleado
{
    public EmpleadoContratista(string nombre, int horasTrabajadas, 
        decimal tarifaPorHora) : base(nombre, horasTrabajadas, tarifaPorHora)
    {
    }
    public override decimal CalcularSalario()
    {
        decimal salarioBase = base.CalcularSalario();
        decimal retencion = salarioBase * 0.1m; // Retención de impuestos del 10%
        return salarioBase - retencion;
    }
}