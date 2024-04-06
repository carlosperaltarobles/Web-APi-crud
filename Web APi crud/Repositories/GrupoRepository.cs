using Web_APi_crud.Interfaces;
using Web_APi_crud.Models;

namespace Web_APi_crud.Repositories
{
    public class GrupoRepository : IGrupo
    {
        private List<Grupo> Grupos = new List<Grupo>
        {
            new Grupo { idGrupo = 1, idCarrera = 1, idMateria = 1, idProfesor = 1, Ciclo = 1, Annio = 2021 },
        };

        public int AgregarGrupo(Grupo grupo)
        {
            try
            {
                if (Grupos != null)
                {
                    grupo.idGrupo = Grupos.Last().idGrupo + 1;
                }

                Grupos.Add(grupo);
                return grupo.idGrupo;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ActualizarGrupo(int id, Grupo grupo)
        {
            try
            {
                int indice = Grupos.FindIndex(e => e.idGrupo == id);
                Grupos[indice] = grupo;
                return id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarGrupo(int id)
        {
            try
            {
                int indice = Grupos.FindIndex(e => e.idGrupo == id);
                if (indice != -1)
                {
                    Grupos.RemoveAt(indice);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Grupo> AllGrupos()
        {
            return Grupos;
        }

        public Grupo ConsultarGrupo(int id)
        {
            return Grupos.Find(e => e.idGrupo == id);
        }
    }
}
