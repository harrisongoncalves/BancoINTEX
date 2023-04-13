using System;

namespace BancoINTEX.Model
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public String cpfUsuario = "";
        Commands comando = new Commands();

        public bool EntrarNaConta(String cpf, String senha)
        {
            tem = comando.VerificarLogin(cpf, senha);
            if (!comando.mensagem.Equals(""))
            {
                this.mensagem = comando.mensagem;
            }
            return tem;
        }
        public String Cadastrar(String cpf, String nome, String senha, String confirmarSenha)
        {
            this.mensagem = comando.Cadastrar(cpf, nome, senha, confirmarSenha);
            if (comando.tem)
            {
                return mensagem;
            }
            this.tem = true;
            return mensagem;
        }

        public void PegarCPF(string cpf)
        {
            cpfUsuario = cpf;
        }
    }
}
