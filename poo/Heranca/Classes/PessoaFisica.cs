namespace Heranca.Classes
{
    public class PessoaFisica : Pessoa
    {
        public string cpf;
        public string rg;
        public bool ValidarCPF(string documento)
        {   
            if(documento != ""){
                return true;
            }
            return false;
        }
    }
}