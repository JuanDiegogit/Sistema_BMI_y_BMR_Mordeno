using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class MensajeModerno : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

      
        public static  int MENSAJE_ERROR = 1;
        public static  int MENSAJE_EXITO = 2;
        public static  int MENSAJE_INFORMATIVO = 3;
        public static  int MENSAJE_ADVERTENCIA = 4;
        public const int TIPO_MENSAJE_DEFAULT = 2;
        private Form formularioBloquear = null;
        public MensajeModerno(String Mensaje, int Tipo = TIPO_MENSAJE_DEFAULT,Form formulario = null)
        {
            InitializeComponent();
            label1.Text = Mensaje;
            formularioBloquear = formulario;
            formularioBloquear.Enabled = false;
            if (Tipo == MENSAJE_EXITO)
            {
                PBImagen.Image = global::Vista.Properties.Resources.cheque;
            }
            else if (Tipo == MENSAJE_ERROR)
            {
                PBImagen.Image = global::Vista.Properties.Resources.cancelar;
            }
            else if (Tipo == MENSAJE_INFORMATIVO) {
                PBImagen.Image = global::Vista.Properties.Resources.informacion;
            } else if (Tipo == MENSAJE_ADVERTENCIA)
            {
                PBImagen.Image = global::Vista.Properties.Resources.advertencia;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MensajeModerno_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblMensaje_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Imagen_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();

           
        }

        private void txtMensaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void MensajeModerno_FormClosed(object sender, FormClosedEventArgs e)
        {
            formularioBloquear.Enabled = true;
        }
    }
}
