namespace AulaPOO_Heranca.classes
{
    public class PessoaFisica : Pessoa                                          //subclasse
    {
        public string cpf;
        public string rg;

        public bool ValidarCPF(string documento){

            // DarBoasVindas("Paulo");

            // nome = "Fulano";   
            
            if(documento != ""){
                return true;
            }

            return true;
        }
    }
}