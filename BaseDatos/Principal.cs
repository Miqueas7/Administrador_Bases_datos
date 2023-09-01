using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BaseDatos
{
    public partial class Principal : Form
    {
        public string Puerto; // Obtener el puerto ingresado por el usuario
        public string Usuario;
        public string Password;

        public Principal()
        {
            InitializeComponent();
            // Llamar a la función para listar las bases de datos al iniciar el formulario
            Puerto = TxtPuerto.Text;
            Usuario = TxtUsuario.Text;
            Password = TxtPassword.Text;
            ListarBasesDatos();
        }

        #region CONFIG
        private void ListarBasesDatos()
        {
            try
            {
                string connStr = $"Server=localhost;Port={Puerto};Uid={Usuario};Pwd={Password};";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string query = "SHOW DATABASES;";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            CmbBDBackup.Items.Clear(); // Limpiar lista antes de cargar nuevos valores
                            CmbBDRestaurar.Items.Clear();
                            while (reader.Read())
                            {
                                string dbName = reader.GetString(0);
                                CmbBDBackup.Items.Add(dbName);
                                CmbBDRestaurar.Items.Add(dbName);
                            }
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar bases de datos: {ex.Message}");
            }
        }

        private void CmdActualizar_Click(object sender, EventArgs e)
        {
            Puerto = TxtPuerto.Text;
            Usuario = TxtUsuario.Text;
            Password = TxtPassword.Text;
            ListarBasesDatos();
        }
        #endregion

        #region BACKUP
        private void CmdCarpetaBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                TxtCarpetaBackcup.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void CmdBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string BDBackup = CmbBDBackup.Text;
                string connStr = $"Server=localhost;Port={Puerto};Database={BDBackup};Uid={Usuario};Pwd={Password};";
                string backupFile = string.Format("{0}\\{1}_backup_{2:dd-MM-yyyy HH.mm}.sql", TxtCarpetaBackcup.Text, BDBackup, DateTime.Now);

                if (string.IsNullOrEmpty(BDBackup) || string.IsNullOrEmpty(TxtCarpetaBackcup.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(backupFile);
                            conn.Close();
                        }
                    }
                }
                MessageBox.Show("¡Bakcup exitoso! La base de datos ha sido respaldada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar el respaldo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region RESTAURAR
        private void CmdArchivoRestaurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TxtArchivoRestarurar.Text = openFileDialog.FileName;
            }
        }

        private void CmdRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                string BDARestaurar = CmbBDRestaurar.Text; //Base de datos que sera resturada.
                string BDRestaurar = TxtArchivoRestarurar.Text; //Base de datos con la que se restaurara.
                string connStr = $"Server=localhost;Port={Puerto};Database={BDARestaurar};Uid={Usuario};Pwd={Password};";

                if (string.IsNullOrEmpty(BDARestaurar) || string.IsNullOrEmpty(BDRestaurar))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ImportFromFile(BDRestaurar);
                            conn.Close();
                        }
                    }
                }
                MessageBox.Show("¡Restauración exitosa! La base de datos ha sido restaurada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la restauración: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        
    }
}
