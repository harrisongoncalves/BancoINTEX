using System;
using System.Data.SqlClient;

namespace BancoINTEX.Model
{
    class Commands
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        SQL sql = new SQL();
        SqlDataReader dr;

        public string Cadastrar(string cpf, string nome, string senha, string confSenha)
        {
            tem = false;


            if (string.IsNullOrEmpty(nome))
            {
                return "Por favor, informe o seu nome.";
            }

            if (string.IsNullOrEmpty(cpf))
            {
                return "Por favor, informe o seu CPF.";
            }

            if (string.IsNullOrEmpty(senha))
            {
                return "Por favor, informe a sua senha.";
            }

            if (string.IsNullOrEmpty(confSenha))
            {
                return "Por favor, confirme a sua senha.";
            }

            string query = "SELECT COUNT(*) FROM loginsBANCO WHERE cpf = @cpf";
            using (SqlCommand command = new SqlCommand(query, sql.Conectar()))
            {
                command.Parameters.AddWithValue("@cpf", cpf);
                int count = (int)command.ExecuteScalar();

                if (count == 1)
                {
                    sql.Desconectar();
                    this.mensagem = "Você já está cadastrado no Banco INTEX.";
                    return mensagem;
                }
            }

            if (senha == confSenha)
            {
                string insertQuery = "INSERT INTO loginsBANCO (CPF, nome, senha) VALUES (@cpf, @nome, @senha)";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, sql.Conectar()))
                {
                    insertCommand.Parameters.AddWithValue("@cpf", cpf);
                    insertCommand.Parameters.AddWithValue("@nome", nome);
                    insertCommand.Parameters.AddWithValue("@senha", senha);
                    insertCommand.ExecuteNonQuery();

                    this.mensagem = "Cadastro realizado com sucesso!";
                    tem = true;
                }
            }
            else
            {
                this.mensagem = "As senhas não coincidem.";
            }

            sql.Desconectar();
            return mensagem;
        }


        public bool VerificarLogin(String cpf, String senha)
        {
            cmd.CommandText = "select * from loginsBANCO where cpf = @cpf and senha = @senha";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = sql.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                sql.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com banco de dados!";
            }
            return tem;
        }
    }
}
