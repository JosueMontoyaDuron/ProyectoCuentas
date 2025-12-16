namespace Cuentas.Models
{
    public class Cuenta
    {
        public int Id { get; set; }
        public string numero { get; set; }
        public string descripcion { get; set; }
        public double creditos { get; set; }
        public double debitos { get; set; }
        public double balance { get; set; }

        public Cuenta()
        {
            this.creditos = 0;
            this.debitos = 0;
            this.balance = 0;
        }

        public Cuenta(int Id, string numero, string descripcion, double creditos, double debitos, double balance)
        {
            this.numero = numero;
            this.descripcion = descripcion;
            this.creditos = creditos;
            this.debitos = debitos;
            this.balance = balance;
        }
        public void setBalance()
        {
            this.balance = this.creditos - this.debitos;
        }
        public void setCredito(double credito)
        {
            this.creditos += credito;
        }   
        public void setDebito(double monto)
        {  
            this.debitos += monto; 
        }
    }
}
