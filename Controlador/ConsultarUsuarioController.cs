using Modelo.Modelo;
using Modelo.Vista;
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
        public async Task<List<Usuario>> ObtenerUsuarios()
        {
            try
            {

                using (SISTEMA_BMIEntities modelo = new SISTEMA_BMIEntities())
                {
                    return (await modelo.USUARIO.ToListAsync()).Select(x => new Usuario {
                        Nombre = x.Nombre,
                        ID = x.ID,
                        Apellido = x.Apellido,
                        BMI = (double)x.BMI,
                        BMR = (double)x.BMR,
                        Edad = DateTime.Now.Year - x.FechaNacimiento.Value.Year,
                        Estatura = (double) x.Estatura,
                        Genero = x.SEXO.Sexo1,
                        Nivel_Actividad = x.NIVEL_ACTIVIDAD.Nombre,
                        Peso = (double)x.Peso

                    } ).ToList();
                }
            }
            catch (Exception)
            {
                return default(List<Usuario>);
            }


        }


        public async Task<List<NIVEL_ACTIVIDAD>> ObtenerNivelesActividadAsync()
        {

            try
            {

                using (SISTEMA_BMIEntities modelo = new SISTEMA_BMIEntities())
                {
                    List<NIVEL_ACTIVIDAD> niveles = (await modelo.NIVEL_ACTIVIDAD.ToListAsync());
                    niveles.Insert(0,new NIVEL_ACTIVIDAD() {ID =0, Nombre ="Todas" });
                    return niveles;

                }

            }
            catch (Exception)
            {
                return new List<NIVEL_ACTIVIDAD>();
            }

        }
        public async Task<List<SEXO>> ObtenerSexoAsync()
        {

            try
            {

                using (SISTEMA_BMIEntities modelo = new SISTEMA_BMIEntities())
                {
                    List<SEXO> generos = (await modelo.SEXO.ToListAsync());
                    generos.Insert(0,new SEXO() {ID = 0,Sexo1 ="Cualquiera" });
                    return generos;

                }

            }
            catch (Exception)
            {
                return new List<SEXO>();
            }

        }


        public async Task<List<CATEGORIA>> ObtenerCategoriaAsync()
        {

            try
            {

                using (SISTEMA_BMIEntities modelo = new SISTEMA_BMIEntities())
                {
                    List<CATEGORIA> categorias = (await modelo.CATEGORIA.ToListAsync());
                    categorias.Insert(0,new CATEGORIA() {ID =0,Nombre = "Todas" });
                    return categorias;

                }

            }
            catch (Exception)
            {
                return new List<CATEGORIA>();
            }

        }

        public async Task<CATEGORIA> ObtenerCategoriaID(int ID)
        {
            try
            {

                using (SISTEMA_BMIEntities modelo = new SISTEMA_BMIEntities())
                {

                    return (await modelo.CATEGORIA.FirstOrDefaultAsync(x=>x.ID == ID)) ;

                }

            }
            catch (Exception)
            {
                return new CATEGORIA();
            }

        }

    }
}
