namespace Cod3rsGrowth.Dominio
{
    public class Personagem
    {
        private int id;
        private string nome;
        private int idRaca;

        enum nomeClasse
        {
            Arqueiro,
            Guerreiro,
            Mago,
            Ladrao,
            Curandeiro
        };

        private decimal peso;
        private decimal altura;
        private DateTime dataDeRegistro;

    }
}
