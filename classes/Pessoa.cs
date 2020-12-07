namespace AulaPOO_Heranca.classes
{
    public class Pessoa          //super classe
    {
        public string nome;

        public string  DarBoasVindas(string nomeUsuario)
        {
            return "Seja bem vindo(A) ao nosso sistema, "+nomeUsuario;
        }
    }
}