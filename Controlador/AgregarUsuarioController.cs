using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Modelo;
using System.Data.Entity;

namespace Controlador
{
   public class AgregarUsuarioController
    {

        public async Task<int> GuardarUsuarioAsync(USUARIO Usuario)
        {
            try
            {

                using (SISTEMA_BMIEntities modelo = new SISTEMA_BMIEntities())
                {

                    modelo.USUARIO.Add(Usuario);
                    return await modelo.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                return 0;
            }


        }
    }
}
