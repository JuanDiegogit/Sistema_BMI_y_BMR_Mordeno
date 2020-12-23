using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Modelo;
using System.Data.Entity;
using System.Windows.Forms;

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
                    return (await modelo.SaveChangesAsync());
                }
            }
            catch (Exception)
            {
                return 0;
            }


        }

        public async Task<List<SEXO>> ObtenerSexoAsync()
        {
           
            try
            {
              
                using (SISTEMA_BMIEntities modelo = new SISTEMA_BMIEntities())
                {
                  
                    return (await modelo.SEXO.ToListAsync());
                
                }
           
            }
            catch (Exception)
            {
                return new List<SEXO>();
            }
            
        }
        public async Task<List<NIVEL_ACTIVIDAD>> ObtenerNivelesActividadAsync()
        {

            try
            {

                using (SISTEMA_BMIEntities modelo = new SISTEMA_BMIEntities())
                {

                    return (await modelo.NIVEL_ACTIVIDAD.ToListAsync());

                }

            }
            catch (Exception)
            {
                return new List<NIVEL_ACTIVIDAD>();
            }

        }
        public async Task<List<CATEGORIA>> ObtenerCategoriaAsync()
        {

            try
            {

                using (SISTEMA_BMIEntities modelo = new SISTEMA_BMIEntities())
                {

                    return (await modelo.CATEGORIA.ToListAsync());

                }

            }
            catch (Exception)
            {
                return new List<CATEGORIA>();
            }

        }

    }
}
