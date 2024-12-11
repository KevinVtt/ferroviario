using inter.icrud;
using models.linea;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using util.conexion;

namespace repository.lineaRepository
{
    public class LineasRepository : ICrud<Linea>
    {
        public async Task AddAsync(Linea t)
        {

            using(var conn = new SqlConnection(ConexionBD._connectionString))
            {
                await conn.OpenAsync();
                var query = "INSERT INTO LINEAS( NOMBRE_LINEAS ) VALUES(@NOMLIN)";
                using(var command = new SqlCommand(query, conn))
                {

                    command.Parameters.AddWithValue("@NOMLIN", t.NombreLinea);
                    await command.ExecuteNonQueryAsync();
                }

            }

        }

        public async Task DeleteAsync(int id)
        {

            using (var conn = new SqlConnection(ConexionBD._connectionString))
            {
                await conn.OpenAsync();
                var query = "DELETE FROM LINEAS where id = @id";
                using(var command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", id);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<IEnumerable<Linea>> GetAllAsync()
        {

            List<Linea> listLinea = new List<Linea>();

            using (var conn = new SqlConnection(ConexionBD._connectionString))
            {
                await conn.OpenAsync();
                var query = "SELECT * FROM LINEAS";
                using (var command = new SqlCommand(query,conn))
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync()) { }
                    {
                        listLinea.Add(new Linea
                        {
                            IdLinea = reader.GetInt32(0),
                            NombreLinea = reader.GetString(1)
                        });
                    }
                }
                
            }

            return listLinea;

        }

        public Task<Linea> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Linea t)
        {
            throw new NotImplementedException();
        }
    }
}
