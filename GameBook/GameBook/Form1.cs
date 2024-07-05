using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LimparForm()
        {
            txConsulta.Clear();
            txConsultarGenero.Clear();
            txConsultarHoras.Clear();
            txConsultarJogo.Clear();
            txConsultarPlataforma.Clear();
            txHoras.Clear();
            txIdAvaliacao.Clear();
            txIdGenero.Clear();
            txIdPlataforma.Clear();
            txInsertGenero.Clear();
            txInsertPlataforma.Clear();
            txLancamento.Clear();
            txNome.Clear();
            cbAvaliacao.Text = string.Empty;
            cbGenero.Text = string.Empty;
            cbPlataforma.Text = string.Empty;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.gameDataSet.Generos);
            // TODO: This line of code loads data into the 'gameDataSet.Plataformas' table. You can move, or remove it, as needed.
            this.plataformasTableAdapter.Fill(this.gameDataSet.Plataformas);
            // TODO: This line of code loads data into the 'gameDataSet.Avaliacoes' table. You can move, or remove it, as needed.
            this.avaliacoesTableAdapter.Fill(this.gameDataSet.Avaliacoes);

            LimparForm();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }


        //INSERTS

        private void btInsert_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool OK = true;

            string connectionString = Properties.Settings.Default.GameConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("InserirJogo", conn);
            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.AddWithValue("@NomeJogo", Convert.ToString(txNome.Text));
            comm.Parameters.AddWithValue("@HorasJogadas", Convert.ToInt32(txHoras.Text));
            comm.Parameters.AddWithValue("@Lancamento", Convert.ToString(txLancamento.Text));
            comm.Parameters.AddWithValue("@IdGenero", Convert.ToInt32(txIdGenero.Text));
            comm.Parameters.AddWithValue("@IdPlataforma", Convert.ToInt32(txIdPlataforma.Text));
            comm.Parameters.AddWithValue("@IdAvaliacao", Convert.ToInt32(txIdAvaliacao.Text));

            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    OK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Tenta executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    OK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                if (OK == true)
                {
                    MessageBox.Show("Jogo Cadastrado!",
                            "INSERT",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    LimparForm();

                    try
                    {
                        string query = "SELECT * FROM Jogos";
                        comm = new SqlCommand(query, conn);

                        SqlDataAdapter da = new SqlDataAdapter(comm);
                        DataTable dt = new DataTable();
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        da.Fill(dt);
                        GridView1.DataSource = dt;
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao executar comando SQL",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o BD
            }
        }

        private void btInsertGenero_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool OK = true;

            string connectionString = Properties.Settings.Default.GameConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("InserirGenero", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@NomeGenero", Convert.ToString(txInsertGenero.Text));

            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    OK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Tenta executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    OK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                if (OK == true)
                {
                    MessageBox.Show("Gênero Cadastrado!",
                            "INSERT",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    LimparForm();

                    try
                    {
                        string query = "SELECT * FROM Generos";
                        comm = new SqlCommand(query, conn);

                        SqlDataAdapter da = new SqlDataAdapter(comm);
                        DataTable dt = new DataTable();
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        da.Fill(dt);
                        GridView1.DataSource = dt;
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao executar comando SQL",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o BD
            }
        }

        private void btInsertPlataforma_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool OK = true;

            string connectionString = Properties.Settings.Default.GameConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("InserirPlataforma", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@NomePlataforma", Convert.ToString(txInsertPlataforma.Text));

            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    OK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Tenta executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    OK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                if (OK == true)
                {
                    MessageBox.Show("Plataforma Cadastrada!",
                            "INSERT",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    LimparForm();

                    try
                    {
                        string query = "SELECT * FROM Plataformas";
                        comm = new SqlCommand(query, conn);

                        SqlDataAdapter da = new SqlDataAdapter(comm);
                        DataTable dt = new DataTable();
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        da.Fill(dt);
                        GridView1.DataSource = dt;
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao executar comando SQL",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o BD
            }
        }

        // DELETES
        private void btDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool OK = true;

            string connectionString = Properties.Settings.Default.GameConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("ExcluirJogo", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@NomeJogoEx", Convert.ToString(txNome.Text));

            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    OK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Tenta executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    OK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                if (OK == true)
                {
                    MessageBox.Show("Jogo Excluído!",
                            "DELETE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    LimparForm();

                    try
                    {
                        string query = "SELECT * FROM Jogos";
                        comm = new SqlCommand(query, conn);

                        SqlDataAdapter da = new SqlDataAdapter(comm);
                        DataTable dt = new DataTable();
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        da.Fill(dt);
                        GridView1.DataSource = dt;
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao executar comando SQL",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o BD
            }
        }

        private void btDeleteGenero_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool OK = true;

            string connectionString = Properties.Settings.Default.GameConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("ExcluirGenero", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@NomeGenEx", Convert.ToString(txInsertGenero.Text));

            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    OK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Tenta executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    OK = false;

                    MessageBox.Show("O gênero informado está presente em registros de jogos existentes, não é possível excluí-lo! :)",
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    LimparForm();
                }

                if (OK == true)
                {
                    MessageBox.Show("Gênero Excluído!",
                            "DELETE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    LimparForm();

                    try
                    {
                        string query = "SELECT * FROM Generos";
                        comm = new SqlCommand(query, conn);

                        SqlDataAdapter da = new SqlDataAdapter(comm);
                        DataTable dt = new DataTable();
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        da.Fill(dt);
                        GridView1.DataSource = dt;
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao executar comando SQL",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o BD
            }
        }

        private void btDeletePlataforma_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool OK = true;

            string connectionString = Properties.Settings.Default.GameConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("ExcluirPlataforma", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@NomePlatEx", Convert.ToString(txInsertPlataforma.Text));

            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    OK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Tenta executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    OK = false;

                    MessageBox.Show("A plataforma informada está presente em registros de jogos existentes, não é possível excluí-la! :)",
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    LimparForm();
                }

                if (OK == true)
                {
                    MessageBox.Show("Plataforma Excluída!",
                            "DELETE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    LimparForm();

                    try
                    {
                        string query = "SELECT * FROM Plataformas";
                        comm = new SqlCommand(query, conn);

                        SqlDataAdapter da = new SqlDataAdapter(comm);
                        DataTable dt = new DataTable();
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        da.Fill(dt);
                        GridView1.DataSource = dt;
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao executar comando SQL",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o BD
            }
        }

        //CONSULTAS
        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (txConsulta.Text == "")
            {
                SqlConnection conn;
                SqlCommand comm;

                string connectionString = Properties.Settings.Default.GameConnectionString;

                conn = new SqlConnection(connectionString);

                comm = new SqlCommand("SELECT * FROM Jogos", conn);

                try
                {
                    // Tenta abrir uma conexão com o BD
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao tentar executar o comando SQL",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(comm);
                        DataTable dt = new DataTable();
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        da.Fill(dt);
                        GridView1.DataSource = dt;

                        conn.Close();

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao tentar executar o comando SQL",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao executar comando SQL",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                SqlConnection conn;
                SqlCommand comm;
                bool OK = true;
                SqlDataReader reader;

                string connectionString = Properties.Settings.Default.GameConnectionString;

                conn = new SqlConnection(connectionString);

                comm = new SqlCommand("SELECT J.Nome_Jogo, J.Horas_Jogadas, J.Ano_Lancamento, J.ID_Genero, J.ID_Plataforma, J.ID_Avaliacao, " +
                    "Generos.Nome_Genero, Plataformas.Nome_Plataforma, Avaliacoes.Descricao " +
                    "FROM Jogos AS J " +
                    "INNER JOIN Generos ON Generos.ID_Genero = J.ID_Genero " +
                    "INNER JOIN Plataformas ON Plataformas.ID_Plataforma = J.ID_Plataforma " +
                    "INNER JOIN Avaliacoes ON Avaliacoes.ID_Avaliacao = J.ID_Avaliacao " +
                    "AND J.Nome_Jogo = @JogoConsultar", conn);

                comm.Parameters.Add("@JogoConsultar", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@JogoConsultar"].Value = txConsulta.Text;

                try
                {
                    // Tenta abrir uma conexão com o BD
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception error)
                    {
                        OK = false;

                        MessageBox.Show(error.Message,
                            "Erro ao tentar abrir uma conexão com o Banco de Dados",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    // Tenta executar o comando SQL
                    try
                    {
                        reader = comm.ExecuteReader();

                        if (reader.Read())
                        {
                            MessageBox.Show("Esse jogo já está cadastrado!",
                            "SELECT",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                            txNome.Text = reader["Nome_Jogo"].ToString();
                            txLancamento.Text = reader["Ano_Lancamento"].ToString();
                            cbGenero.Text = reader["Nome_Genero"].ToString();
                            cbPlataforma.Text = reader["Nome_Plataforma"].ToString();
                            txHoras.Text = reader["Horas_Jogadas"].ToString();
                            cbAvaliacao.Text = reader["Descricao"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Jogo não Cadastrado!",
                            "SELECT",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                            //Limpar o Form
                            LimparForm();
                        }

                        reader.Close();
                    }
                    catch (Exception error)
                    {
                        OK = false;

                        MessageBox.Show(error.Message,
                            "Erro ao tentar executar o comando SQL",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch { }
                finally
                {
                    conn.Close(); // Fecha a conexão com o BD
                }
            }
        }

        private void btConsultarGenero_Click(object sender, EventArgs e)
        {
            if (txConsultarGenero.Text == "")
            {
                MessageBox.Show("Digite o gênero que deseja pesquisar!",
                            "CONSULTAR",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection conn;
                SqlCommand comm;
                bool OK = true;
                SqlDataReader reader;

                string connectionString = Properties.Settings.Default.GameConnectionString;

                conn = new SqlConnection(connectionString);

                comm = new SqlCommand("SELECT G.Nome_Genero " +
                    "FROM Generos AS G " +
                    "WHERE G.Nome_Genero = @GeneroConsultar", conn);

                comm.Parameters.Add("@GeneroConsultar", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@GeneroConsultar"].Value = txConsultarGenero.Text;

                try
                {
                    // Tenta abrir uma conexão com o BD
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception error)
                    {
                        OK = false;

                        MessageBox.Show(error.Message,
                            "Erro ao tentar abrir uma conexão com o Banco de Dados",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    // Tenta executar o comando SQL
                    try
                    {
                        reader = comm.ExecuteReader();

                        if (reader.Read())
                        {
                            MessageBox.Show("Esse gênero já está cadastrado!",
                            "SELECT",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                            txInsertGenero.Text = reader["Nome_Genero"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Gênero não Cadastrado!",
                            "SELECT",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                            //Limpar o Form
                            LimparForm();
                        }

                        reader.Close();
                    }
                    catch (Exception error)
                    {
                        OK = false;

                        MessageBox.Show(error.Message,
                            "Erro ao tentar executar o comando SQL",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch { }
                finally
                {
                    conn.Close(); // Fecha a conexão com o BD
                }
            }
        }

        private void btConsultarPlataforma_Click(object sender, EventArgs e)
        {
            if (txConsultarPlataforma.Text == "")
            {
                MessageBox.Show("Digite a plataforma que deseja pesquisar!",
                            "CONSULTAR",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection conn;
                SqlCommand comm;
                bool OK = true;
                SqlDataReader reader;

                string connectionString = Properties.Settings.Default.GameConnectionString;

                conn = new SqlConnection(connectionString);

                comm = new SqlCommand("SELECT P.Nome_Plataforma " +
                    "FROM Plataformas AS P " +
                    "WHERE P.Nome_Plataforma = @PlataformasConsultar", conn);

                comm.Parameters.Add("@PlataformasConsultar", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@PlataformasConsultar"].Value = txConsultarPlataforma.Text;

                try
                {
                    // Tenta abrir uma conexão com o BD
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception error)
                    {
                        OK = false;

                        MessageBox.Show(error.Message,
                            "Erro ao tentar abrir uma conexão com o Banco de Dados",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    // Tenta executar o comando SQL
                    try
                    {
                        reader = comm.ExecuteReader();

                        if (reader.Read())
                        {
                            MessageBox.Show("Essa plataforma já está cadastrada!",
                            "SELECT",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                            txInsertPlataforma.Text = reader["Nome_Plataforma"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Gênero não Cadastrado!",
                            "SELECT",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                            //Limpar o Form
                            LimparForm();
                        }

                        reader.Close();
                    }
                    catch (Exception error)
                    {
                        OK = false;

                        MessageBox.Show(error.Message,
                            "Erro ao tentar executar o comando SQL",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch { }
                finally
                {
                    conn.Close(); // Fecha a conexão com o BD
                }
            }
        }

        //UPDATES
        private void btUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool OK = true;

            string connectionString = Properties.Settings.Default.GameConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("AlterarJogo", conn);
            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.AddWithValue("@NomeAlt", Convert.ToString(txConsulta.Text));
            comm.Parameters.AddWithValue("@NomeJogo", Convert.ToString(txNome.Text));
            comm.Parameters.AddWithValue("@HorasJogadas", Convert.ToInt32(txHoras.Text));
            comm.Parameters.AddWithValue("@Lancamento", Convert.ToString(txLancamento.Text));
            comm.Parameters.AddWithValue("@IdGenero", Convert.ToInt32(txIdGenero.Text));
            comm.Parameters.AddWithValue("@IdPlataforma", Convert.ToInt32(txIdPlataforma.Text));
            comm.Parameters.AddWithValue("@IdAvaliacao", Convert.ToInt32(txIdAvaliacao.Text));

            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    OK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Tenta executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    OK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                if (OK == true)
                {
                    MessageBox.Show("Jogo Alterado!",
                            "UPDATE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    LimparForm();

                    try
                    {
                        string query = "SELECT * FROM Jogos";
                        comm = new SqlCommand(query, conn);

                        SqlDataAdapter da = new SqlDataAdapter(comm);
                        DataTable dt = new DataTable();
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        da.Fill(dt);
                        GridView1.DataSource = dt;
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao executar comando SQL",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o BD
            }
        }

        private void btUpdateGenero_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool OK = true;

            string connectionString = Properties.Settings.Default.GameConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("AlterarGenero", conn);
            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.AddWithValue("@NomeAltGen", Convert.ToString(txConsultarGenero.Text));
            comm.Parameters.AddWithValue("@NomeGenero", Convert.ToString(txInsertGenero.Text));

            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    OK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Tenta executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    OK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                if (OK == true)
                {
                    MessageBox.Show("Gênero Alterado!",
                            "UPDATE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    LimparForm();

                    try
                    {
                        string query = "SELECT * FROM Generos";
                        comm = new SqlCommand(query, conn);

                        SqlDataAdapter da = new SqlDataAdapter(comm);
                        DataTable dt = new DataTable();
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        da.Fill(dt);
                        GridView1.DataSource = dt;
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao executar comando SQL",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o BD
            }
        }

        private void btUpdatePlataforma_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool OK = true;

            string connectionString = Properties.Settings.Default.GameConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("AlterarPlataforma", conn);
            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.AddWithValue("@NomeAltPla", Convert.ToString(txConsultarPlataforma.Text));
            comm.Parameters.AddWithValue("@NomePlataforma", Convert.ToString(txInsertPlataforma.Text));

            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    OK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Tenta executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    OK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                if (OK == true)
                {
                    MessageBox.Show("Plataforma Alterada!",
                            "UPDATE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    LimparForm();

                    try
                    {
                        string query = "SELECT * FROM Plataformas";
                        comm = new SqlCommand(query, conn);

                        SqlDataAdapter da = new SqlDataAdapter(comm);
                        DataTable dt = new DataTable();
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        da.Fill(dt);
                        GridView1.DataSource = dt;
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao executar comando SQL",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o BD
            }
        }

        // CARD HORAS
        private void btMaisJogado_Click(object sender, EventArgs e)
        {
            string nomeJogo = "";

            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.GameConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("SELECT dbo.JogoComMaisHorasJogadas()", conn);

            // Tenta abrir uma conexão com o BD
            try
            {
                conn.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,
                    "Erro ao tentar executar o comando SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            try
            {
                nomeJogo = Convert.ToString(comm.ExecuteScalar());


                MessageBox.Show("O jogo com mais horas jogadas é... " + nomeJogo + "!!! :)",
                            "Jogo Mais Jogado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception error)
            {
                MessageBox.Show(error.Message,
                   "Erro ao executar comando SQL",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            try
            {
                string query = "SELECT Jogos.Nome_jogo, Jogos.Horas_Jogadas FROM Jogos";
                comm = new SqlCommand(query, conn);

                SqlDataAdapter da = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                da.Fill(ds);
                da.Fill(dt);
                GridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,
                    "Erro ao executar comando SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btTotalHoras_Click(object sender, EventArgs e)
        {
            int horas = 0;

            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.GameConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("SELECT dbo.SomaTotalHorasJogadas()", conn);

                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    horas = Convert.ToInt32(comm.ExecuteScalar());


                    MessageBox.Show("O total de horas jogadas é... " + horas + "!!! :)",
                                    "Total de horas jogadas",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    string query = "SELECT Jogos.Nome_jogo, Jogos.Horas_Jogadas FROM Jogos";
                    comm = new SqlCommand(query, conn);

                    SqlDataAdapter da = new SqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    da.Fill(dt);
                    GridView1.DataSource = dt;

                    conn.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao executar comando SQL",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        private void btConsultarHorasJogo_Click(object sender, EventArgs e)
        {
            int horas = 0;

            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.GameConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("SELECT dbo.TotalHorasPorJogo(@NomeJogo)", conn);
            comm.Parameters.AddWithValue("@NomeJogo", Convert.ToString(txConsultarHoras.Text));

            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    horas = Convert.ToInt32(comm.ExecuteScalar());

                    MessageBox.Show("O total de horas jogadas é... " + horas + "!!! :)",
                                "Total de horas por jogo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("O jogo pesquisado não está cadastrado :(",
                        "Erro ao executar comando SQL",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    string query = "SELECT Jogos.Nome_jogo, Jogos.Horas_Jogadas FROM Jogos";
                    comm = new SqlCommand(query, conn);

                    SqlDataAdapter da = new SqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    da.Fill(dt);
                    GridView1.DataSource = dt;

                    conn.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao executar comando SQL",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,
                    "Erro ao executar comando SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void btSomarHoras_Click(object sender, EventArgs e) {

            SqlConnection conn;
            SqlCommand comm;
            bool OK = true;

            string connectionString = Properties.Settings.Default.GameConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("AdicionarHoras", conn);
            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.AddWithValue("@NomeJogo", Convert.ToString(txNome.Text));
            comm.Parameters.AddWithValue("@Horas", Convert.ToString(txHoras.Text));

            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    OK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Tenta executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    OK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                if (OK == true)
                {
                    MessageBox.Show("Horas Atualizadas! :)",
                            "UPDATE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    LimparForm();

                    try
                    {
                        string query = "SELECT Jogos.Nome_jogo, Jogos.Horas_Jogadas FROM Jogos";
                        comm = new SqlCommand(query, conn);

                        SqlDataAdapter da = new SqlDataAdapter(comm);
                        DataTable dt = new DataTable();
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        da.Fill(dt);
                        GridView1.DataSource = dt;
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao executar comando SQL",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o BD
            }
        }

        // CARD CONSULTAS
        private void btConsultarAno_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.GameConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("SELECT * FROM dbo.PesquisarJogosPorAno(@Ano)", conn);
            comm.Parameters.AddWithValue("@Ano", Convert.ToString(txConsultarJogo.Text));

            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
           
                try
                {                  
                    SqlDataAdapter da = new SqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    da.Fill(dt);
                    GridView1.DataSource = dt;

                    conn.Close();

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Não há nenhum jogo cadastrado que foi lançado no ano pesquisado :(",
                        "Erro ao executar comando SQL",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,
                    "Erro ao executar comando SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btConsultarNome_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.GameConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("SELECT * FROM dbo.PesquisarJogosPorNome(@NomeJogo)", conn);
            comm.Parameters.AddWithValue("@NomeJogo", Convert.ToString(txConsultarJogo.Text));

            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    da.Fill(dt);
                    GridView1.DataSource = dt;

                    conn.Close();

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Não há nenhum jogo cadastrado que possua os caracteres informados :(",
                        "Erro ao executar comando SQL",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,
                    "Erro ao executar comando SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewLogs_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.GameConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("SELECT B.ID_Jogo, B.Nome_Jogo, B.Data_Operacao FROM BackupJogos AS B", conn);
           
            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    da.Fill(dt);
                    GridView1.DataSource = dt;

                    conn.Close();

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,
                    "Erro ao executar comando SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    } 
}











    