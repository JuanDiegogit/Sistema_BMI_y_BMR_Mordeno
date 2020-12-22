using Modelo.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ConsultarUsuarioController
    {
        public async Task<List<USUARIO>> ObtenerUsuarios()
        {
            try
            {

                using (SISTEMA_BMIEntities modelo = new SISTEMA_BMIEntities())
                {
                    return await modelo.USUARIO.ToListAsync();
                }
            }
            catch (Exception)
            {
                return default(List<USUARIO>);
            }


        }
    }
}
