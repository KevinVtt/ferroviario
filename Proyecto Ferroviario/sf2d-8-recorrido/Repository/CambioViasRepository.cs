using inter.icrud;
using models.cambiovia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using repository.bobinas;
using util.conexion;

namespace repository.cambiovias
{
    public class CambioViasRepository : ICrud<CambioVia>
    {


        public async Task AddAsync(CambioVia t)
        {

            using (var conn = new SqlConnection(ConexionBD._connectionString))
            {
                conn.OpenAsync();
                var query = "INSERT INTO CAMBIO_VIAS (NRO,ID_PROX_IMG1,ID_PROX_IMG2,OPCION_CMB) VALUES(@NRO,@IDPROXIMG1,@IDPROXIMG2,@OPCCMB)";
                using(var command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@NRO", t.Nro);
                    command.Parameters.AddWithValue("@IDPROXIMG1", t.IdProximaImg);
                    command.Parameters.AddWithValue("@IDPROXIMG2", t.IdProximaImg2);
                    command.Parameters.AddWithValue("@OPCCMB", t.OpcionCmb);
                    
                    await command.ExecuteNonQueryAsync();
                }
            }

        }

        public async Task DeleteAsync(int id)
        {
            using(var conn = new SqlConnection(ConexionBD._connectionString))
            {
                conn.OpenAsync();
                var query = "DELETE FROM CAMBIO_VIAS where id = @ID";
                using(var command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID",id);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<IEnumerable<CambioVia>> GetAllAsync()
        {

            var cambiosVias = new List<CambioVia>();

            using (var conn = new SqlConnection(ConexionBD._connectionString))
            {
                conn.OpenAsync();
                var query = "SELECT * FROM CAMBIO_VIAS as cv inner join VIA_DETALLE as vd on cv.ID_PROX_IMG1 = vd.ID_TREN AND cv.ID_PROX_IMG2 = vd.ID_TREN";
                using(var command = new SqlCommand(query,conn))
                {
                    using(var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            cambiosVias.Add(new CambioVia()
                            {
                                IdCambioVia = reader.GetInt32(0),
                                Nro = reader.GetInt32(1),
                                IdProximaImg = reader.GetInt32(2),
                                IdProximaImg2 = reader.GetInt32(3),
                                OpcionCmb = reader.GetInt32(4),
                            });
                        }
                    }
                }
            }
            return cambiosVias;

        }

        public async Task<CambioVia> GetByIdAsync(int id)
        {
            CambioVia cambioVia = null;

            using(var conn = new SqlConnection(ConexionBD._connectionString))
            {
                conn.OpenAsync();

                var query = "SELECT * FROM CAMBIO_VIAS WHERE ID = @ID";

                using (var command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", id);

                    using(var reader = await command.ExecuteReaderAsync())
                    {
                        if(await reader.ReadAsync())
                        {
                            cambioVia = new CambioVia()
                            {
                                IdCambioVia = reader.GetInt32(0),
                                Nro = reader.GetInt32(1),
                                IdProximaImg = reader.GetInt32(2),
                                IdProximaImg2 = reader.GetInt32(3),
                                OpcionCmb = reader.GetInt32(4)
                            };
                        }
                    }

                }

            }

            return cambioVia;

        }

        public async Task UpdateAsync(CambioVia t)
        {
            using (var conn = new SqlConnection(ConexionBD._connectionString))
            {
                conn.OpenAsync();
                var query = "UPDATE CAMBIO_VIAS set NRO = @NRO, ID_PROX_IMG1 = @IDPROXIMG1, ID_PROX_IMG2 = @IDPROXIMG2, OPCION_CMB = @OPCCMB WHERE ID = @ID";
                using (var command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@NRO",t.Nro);
                    command.Parameters.AddWithValue("@IDPROXIMG1", t.IdProximaImg);
                    command.Parameters.AddWithValue("@IDPROXIMG2", t.IdProximaImg2);
                    command.Parameters.AddWithValue("@OPCCMB",t.OpcionCmb);
                    command.Parameters.AddWithValue("@ID",t.IdCambioVia);
                    
                    await command.ExecuteNonQueryAsync();
                    
                }

            }
        }
    }
}
