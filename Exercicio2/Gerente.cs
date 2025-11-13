namespace Heranca
{
    public class Gerente : Funcionarios
    {
        public int Bonus;
        public double SalarioBase;

        public double CalcularSalario()
        {
            SalarioBase = SalarioBase + Bonus;
            
            return SalarioBase;
        }
    }
}