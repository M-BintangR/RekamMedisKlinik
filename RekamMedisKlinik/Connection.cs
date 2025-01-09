using MySql.Data.MySqlClient;
using System.Data;

namespace RekamMedisKlinik
{
    internal class Connection
    {
        private static readonly string connectionString = "SERVER=localhost;port=3306;database=prime_care_clinic;UID=root;";
        private readonly MySqlConnection conn;

        public Connection()
        {
            conn = new MySqlConnection(connectionString);
        }

        private void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Koneksi berhasil dibuka.");
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Terjadi kesalahan saat ingin akses database : {err.Message}", "Error Database");
                    Console.WriteLine($"Error membuka koneksi: {err.Message}");
                }
            }
        }


        /// <summary>
        /// Menutup koneksi dari database.
        /// </summary>
        private void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Menambahkan data ke tabel tertentu.
        /// </summary>
        /// <param name="tableName">Nama tabel.</param>
        /// <param name="columns">Dictionary dengan pasangan kolom dan nilainya.</param>
        /// <returns>True jika berhasil, false jika gagal.</returns>
        public bool AddData(string tableName, Dictionary<string, object> columns)
        {
            try
            {
                OpenConnection();

                string columnsPart = string.Join(", ", columns.Keys);
                string valuesPart = string.Join(", ", columns.Keys.Select(k => "@" + k));

                string query = $"INSERT INTO {tableName} ({columnsPart}) VALUES ({valuesPart})";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    foreach (var column in columns)
                    {
                        cmd.Parameters.AddWithValue($"@{column.Key}", column.Value);
                    }

                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query yang Anda eksekusi sepertinya salah", "Error MySQL");
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        /// <summary>
        /// Mengupdate data di tabel tertentu.
        /// </summary>
        /// <param name="tableName">Nama tabel.</param>
        /// <param name="columns">Dictionary dengan pasangan kolom dan nilainya.</param>
        /// <param name="condition">Kondisi untuk update, misalnya "id = @id".</param>
        /// <param name="conditionParams">Parameter untuk kondisi.</param>
        /// <returns>True jika berhasil, false jika gagal.</returns>
        public bool UpdateData(string tableName, Dictionary<string, object> columns, string condition, Dictionary<string, object> conditionParams)
        {
            try
            {
                OpenConnection();

                string setPart = string.Join(", ", columns.Keys.Select(k => $"{k} = @{k}"));
                string query = $"UPDATE {tableName} SET {setPart} WHERE {condition}";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    foreach (var column in columns)
                    {
                        cmd.Parameters.AddWithValue($"@{column.Key}", column.Value);
                    }

                    if (conditionParams != null)
                    {
                        foreach (var param in conditionParams)
                        {
                            cmd.Parameters.AddWithValue($"@{param.Key}", param.Value);
                        }
                    }

                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query yang Anda eksekusi sepertinya salah", "Error MySQL");
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        /// <summary>
        /// Menghapus data dari tabel tertentu, termasuk relasi terkait.
        /// </summary>
        /// <param name="tableName">Nama tabel.</param>
        /// <param name="condition">Kondisi untuk penghapusan, misalnya "id = @id".</param>
        /// <param name="conditionParams">Parameter untuk kondisi.</param>
        /// <returns>True jika berhasil, false jika gagal.</returns>
        public bool DeleteData(string tableName, string condition, Dictionary<string, object> conditionParams)
        {
            try
            {
                OpenConnection();

                string query = $"DELETE FROM {tableName} WHERE {condition}";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (conditionParams != null)
                    {
                        foreach (var param in conditionParams)
                        {
                            cmd.Parameters.AddWithValue($"@{param.Key}", param.Value);
                        }
                    }

                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query yang Anda eksekusi sepertinya salah", "Error MySQL");
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<Dictionary<string, object>> ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();

            try
            {
                OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Menambahkan parameter ke query
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue($"@{param.Key}", param.Value);
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var row = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[reader.GetName(i)] = reader.GetValue(i);
                            }
                            result.Add(row);
                        }
                    }
                }

                return result; // Mengembalikan data hasil query
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }


        internal object ExecuteScalar(string query)
        {
            try
            {
                OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }


    }
}
