using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Show();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
           txtNombre.Text = "";
           txtNombre.ForeColor = Color.White;
           lblNombre.Visible = true;
           lblNombre.Location= new Point(lblNombre.Location.X,0);
            
             
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == String.Empty)
            {
              
                for (int i = 0; i < 30; i++)
                {
                    lblNombre.Location = new Point(lblNombre.Location.X, lblNombre.Location.Y + 1);
                    Thread.Sleep(5);

                }
                txtNombre.ForeColor = Color.Gray;
                txtNombre.Text = "Nombre Del Usuario";
                lblNombre.Visible = false;
            }
        }

        private void btnMaximizarRestaurar_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
         
        }

        private void panelPrincipalContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lineShape2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

       
        private void txtApellido_Enter(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtApellido.ForeColor = Color.White;
            lblApellido.Visible = true;
            lblApellido.Location = new Point(lblApellido.Location.X, 86);
        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == String.Empty)
            {

                for (int i = 0; i < 30; i++)
                {
                    lblApellido.Location = new Point(lblApellido.Location.X, lblApellido.Location.Y + 1);
                    Thread.Sleep(5);

                }
                txtApellido.ForeColor = Color.Gray;
                txtApellido.Text = "Apellido Del Usuario";
                lblApellido.Visible = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AgregarUsuario_Resize(object sender, EventArgs e)
        {
            if(panelPrincipalContenedor.MaximumSize.Width == panelPrincipalContenedor.Width)
            {
                panelPrincipal.Padding = new Padding((int)((this.Width-panelPrincipalContenedor.Width)/2), 10, 20, 10);
            }
            else
            {
                panelPrincipal.Padding = new Padding(20, 10, 20, 10);
            }
           
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int errores = 0;
            List<string> mensajesErrores = new List<string>();
            if(nupPeso.Value < 1 && nupEstatura.Value < 1)
            {
                errores += 2;
                mensajesErrores.Add("Debe seleccionar un Peso y estatura mayor a cero(0)");
            }
            else
            {
                if (nupPeso.Value < 1)
                {
                    errores++;
                    mensajesErrores.Add("Debe seleccionar un Peso mayor a cero(0)");
                }
                if (nupEstatura.Value < 1)
                {
                    errores++;
                    mensajesErrores.Add("Debe seleccionar una estatura mayor a cero(0)");
                }
            }

            if (txtNombre.Text =="Nombre Del Usuario" && txtApellido.Text == "Apellido Del Usuario")
            {
                errores += 2;
                mensajesErrores.Add("Debe llenar nombre y apellido");
            }
            else
            {
                if (txtNombre.Text == "Nombre Del Usuario")
                {
                    errores++;
                    mensajesErrores.Add("Debe llenar el nombre");
                }
                if (txtApellido.Text == "Nombre Del Usuario")
                {
                    errores++;
                    mensajesErrores.Add("Debe llenar el apellido");
                }
            }



            if (errores > 0)
            {
                String MensajeFinal = "";
                if(errores > 1)
                {
                    MensajeFinal += "Se presentaron los siguientes errores\n\n";
                }
                foreach(String mensaje in mensajesErrores)
                {
                    MensajeFinal += "- "+mensaje+"\n";
                }
              
                 new MensajeModerno(MensajeFinal,MensajeModerno.MENSAJE_ERROR,this) {  StartPosition = FormStartPosition.CenterScreen }.Show();
               
                return;
            }
        }
    }
}
