using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        CentroDeAtencion centro = new CentroDeAtencion();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnIMportarSolicitudes_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;

                FileStream fs = null;

                try
                {
                    fs = new FileStream(path,FileMode.Open, FileAccess.Read);

                    centro.ImportarCsvSolicitudesEntranter(fs);    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (fs != null) fs.Close();
                }

                VerSolicitudesPendientes();
            }
        }
        protected void VerSolicitudesPendientes()
        {
            lsbVerSolicitudesImportadas.Items.Clear();
            LinkedListNode<Solicitud> nodo = centro.GetSolicitudPendiente();
           
            while (nodo != null)
            {
                lsbVerSolicitudesImportadas.Items.Add(nodo.Value);
                nodo = nodo.Next;
            }
        }
    }
}
