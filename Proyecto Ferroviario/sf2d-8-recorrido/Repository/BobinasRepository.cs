using inter.icrud;
using models.bobina;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using util.conexion;

namespace repository.bobinas;

/// <summary>
/// Se puede apreciar que los siguientes metodos son iguales.
/// </summary>

public class BobinasRepository : ICrud<Bobina>
{

    /// <summary>
    /// Agregamos datos a la BD
    /// </summary>
    /// <param name="t"></param>
    /// <returns>Task</returns>

    public async Task AddAsync(Bobina t)
    {

        using (var conn = new SqlConnection(ConexionBD._connectionString)) // Conexion a la BD.
        {
            await conn.OpenAsync(); // Abrimos la BD
            var query = "INSERT INTO bobinas (NRO) values(@NRO)"; // Ejecutamos la query
            using (var command = new SqlCommand(query, conn)) 
            {
                command.Parameters.AddWithValue("@NRO", t.Nro);
                await command.ExecuteNonQueryAsync(); // No retorna valor
            }

        }


    }

    /// <summary>
    ///  Eliminamos por id en la BD.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>

    public async Task DeleteAsync(int id)
    {

        using (var conn = new SqlConnection(ConexionBD._connectionString))
        {
            await conn.OpenAsync(); // Abrimos la BD.
            var query = "DELETE FROM bobinas WHERE id = @ID"; // Ejecutamos la query

            using (var command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@ID", id);
                await command.ExecuteNonQueryAsync(); // No retorna valor

            }

        }

    }

    /// <summary>
    /// Al ser un select, retorna valor
    /// </summary>
    /// <returns>List<Bobinas></returns>

    public async Task<IEnumerable<Bobina>> GetAllAsync()
    {

        var bobinas = new List<Bobina>(); // Declaramos una lista

        using (var conn = new SqlConnection(ConexionBD._connectionString)) 
        {
            await conn.OpenAsync(); // Abrimos ala conexion

            var query = "SELECT ID,NRO FROM bobinas";

            using (var command = new SqlCommand(query, conn))
            using (var reader = await command.ExecuteReaderAsync()) // Al hacer un ExecuteReaderAsync retorna un valor de tipo reader.
            {
                while (await reader.ReadAsync()) // Leemos el reader con sus datos que hay en la BD.
                {
                    bobinas.Add(new Bobina // se agrega a la lista
                    {
                        IdBobina = reader.GetInt32(0),
                        Nro = reader.GetInt32(1)
                    });
                }
            }

        }
        return bobinas;
    }

    /// <summary>
    /// Devuelve una Bobina dependiendo el Id que se pase
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Bobina</returns>

    public async Task<Bobina> GetByIdAsync(int id)
    {

        Bobina bobina = null;

        using (var conn = new SqlConnection(ConexionBD._connectionString))
        {
            await conn.OpenAsync();
            var query = "SELECT * FROM bobinas where id = @ID";
            using (var command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@ID", id);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        bobina = new Bobina()
                        {
                            IdBobina = reader.GetInt32(0),
                            Nro = reader.GetInt32(1)
                        };
                    }
                }

            }
        }

        return bobina;


    }

    /// <summary>
    /// Actualiza la bobina pasada por parametro
    /// </summary>
    /// <param name="t"></param>
    public async Task UpdateAsync(Bobina t)
    {

        using (var conn = new SqlConnection(ConexionBD._connectionString))
        {
            await conn.OpenAsync();

            var query = "UPDATE bobinas SET NRO = @NRO where id = @ID";

            using (var command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@NRO", t.Nro);
                command.Parameters.AddWithValue("@ID", t.IdBobina);

                await command.ExecuteNonQueryAsync();
            }

        }

    }

    /// <summary>
    /// Muestra las bobinas.
    /// </summary>
    public async Task MostrarBobinasAsync()
    {
        var repository = new BobinasRepository();
        var bobinas = repository.GetAllAsync().Result;

        foreach (var bobina in bobinas)
        {
            Console.WriteLine("ID: " + bobina.IdBobina + " NRO: " + bobina.Nro);
        }


    }

}
