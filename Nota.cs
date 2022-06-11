namespace _4_menu_opcoes
{
    public abstract class Nota
    {
        public Nota(double valor, int peso)
        {
            Valor = valor;
            Peso = peso;
        }
        public double Valor { get; protected set; }
        public int Peso { get; protected set; }
    }
}
