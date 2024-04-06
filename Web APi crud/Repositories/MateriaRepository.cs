using Web_APi_crud.Interfaces;
using Web_APi_crud.Models;

namespace Web_APi_crud.Repositories
{
    public class MateriaRepository : IMateria
    {
        private List<Materia> materias = new List<Materia>
        {
            new Materia {idMateria = 1, nombre = "Matematicas"},
        };
        public int AgregarMateria(Materia materia)
        {
            try
            {
                materias.Add(materia);
                return 1;
            }
            catch (Exception)
            {
               throw;
            }
        }

        public int ActualizarMateria(int id, Materia materia)
        {
            try
            {
                int indice = materias.FindIndex(e => e.idMateria == id);
                materias[indice] = materia;
                return id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarMateria(int id)
        {
           try
            {
                int indice = materias.FindIndex(e => e.idMateria == id);
                if (indice != -1)
                {
                     materias.RemoveAt(indice);
                     return true;
                }
                return false;
              }
              catch (Exception)
            {
                throw;
              }
        }

        public List<Materia> Materias()
        {
           try
            {
                return materias;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Materia ConsultarMateria(int id)
        {
            try
            {
                Materia materia = materias.Find(e => e.idMateria == id);
                return materia;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
