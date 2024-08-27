using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClientesDAO
    {
        const String conexao = @"data source=LAB10-14;initial catalog=AulaADO;integrated security=true";

        public void inserir(Clientes obj)
        {
            SqlConnection con = new SqlConnection(conexao);
            con.Open();
            //Comando
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Clientes (Nome, DataNascimento) " + "values (@nome, @datanascimento)";
            cmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = obj.Nome;
            cmd.Parameters.Add("@datanascimento", System.Data.SqlDbType.DateTime).Value = obj.DataNascimento;
            //Executar
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void alterar(Clientes obj)
        {
            SqlConnection con = new SqlConnection(conexao);
            con.Open();
            //Comando
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update Clientes set Nome = @nome, " + " DataNascimento = @datanascimento where ID = @id";
            cmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = obj.Nome;
            cmd.Parameters.Add("@datanascimento", System.Data.SqlDbType.DateTime).Value = obj.DataNascimento;
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = obj.ID;
            //Executar
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void excluir(Clientes obj)
        {
            SqlConnection con = new SqlConnection(conexao);
            con.Open();
            //Comando
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from Clientes where id= @id";
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = obj.ID;
            //Executar
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public Clientes consultar(int id)
        {
            Clientes obj = null;

            SqlConnection con = new SqlConnection(conexao);
            con.Open();
            //Comando
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Clientes where id = @id";
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                //Dados
                obj = new Clientes();
                obj.ID = int.Parse(dr["ID"].ToString());
                obj.Nome = dr["Nome"].ToString();
                obj.DataNascimento = DateTime.Parse(dr["DataNascimento"].ToString());
            }
            dr.Close();
            con.Close();
            return obj;
        }

        public List <Clientes> consultar(String nome)
        {
            List<Clientes> lista = new List<Clientes>();

            SqlConnection con = new SqlConnection(conexao);
            con.Open();
            //Comando
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Clientes where Nome like @nome";
            cmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = nome + "%";

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Clientes obj = new Clientes();
                obj.ID = int.Parse(dr["ID"].ToString());
                obj.Nome = dr["Nome"].ToString();
                obj.DataNascimento = DateTime.Parse(dr["DataNascimento"].ToString());
                lista.Add(obj);
            }
            dr.Close();

            con.Close();

            return lista;
        }

    }
}
