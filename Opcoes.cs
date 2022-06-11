namespace _4_menu_opcoes
{
    public class Opcoes
    {
        public Opcoes(string descricao, string valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public string Descricao { get; private set; }
        public string Valor { get; private set; }
    }
}
