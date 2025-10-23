using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    [Serializable]
    public class CentroDeAtencion
    {
        LinkedList<Solicitud> solicitudesEntrantes = new LinkedList<Solicitud>();
        Queue<Solicitud> colaDeAtencion = new Queue<Solicitud>();
        public void ImportarCsvSolicitudesEntranter(FileStream fs)
        {
            StreamReader sr = new StreamReader(fs);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {

                string linea = sr.ReadLine();
                Solicitud solicitud = new Solicitud();
                solicitud.Importar(linea);

                solicitudesEntrantes.AddLast(solicitud);
            }
            sr.Close();
        }

        public LinkedListNode<Solicitud> GetSolicitudPendiente()
        {
            return solicitudesEntrantes.First;
        }

        public void Atender(Solicitud solicitud)
        {
            if (solicitudesEntrantes.Remove(solicitud) == true)
            {

                colaDeAtencion.Enqueue(solicitud);
            }
        }
        public string[] VerDescripcionColaAtencion()
        {
            string[] descripcoiones = new string[colaDeAtencion.Count];
            int n = 0;
            foreach (Solicitud solicitud in colaDeAtencion)
            {
                descripcoiones[n++] = solicitud.ToString();

            }
            return descripcoiones;
        }
    }
}
