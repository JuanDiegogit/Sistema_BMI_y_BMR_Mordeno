using Controlador;
using Modelo.Modelo;
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
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 10;

            switch (m.Msg)
            {
                case 0x0084/*NCHITTEST*/ :
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x01/*HTCLIENT*/)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13/*HTTOPLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12/*HTTOP*/ ;
                            else
                                m.Result = (IntPtr)14/*HTTOPRIGHT*/ ;
                        }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10/*HTLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2/*HTCAPTION*/ ;
                            else
                                m.Result = (IntPtr)11/*HTRIGHT*/ ;
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16/*HTBOTTOMLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15/*HTBOTTOM*/ ;
                            else
                                m.Result = (IntPtr)17/*HTBOTTOMRIGHT*/ ;
                        }
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- use 0x20000 
                return cp;
            }
        }
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
                this.Padding = new Padding(0);
                this.btnMaximizarRestaurar.Image = global::Vista.Properties.Resources.Restaurar;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Padding = new Padding(1);
                this.btnMaximizarRestaurar.Image = global::Vista.Properties.Resources.Maximizar;
            }
         
        }

       
        private void txtApellido_Enter(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtApellido.ForeColor = Color.White;
            lblApellido.Visible = true;
            lblApellido.Location = new Point(lblApellido.Location.X, 75);
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
        private async void llenarComboSexo()
        {
           
            cmbGenero.DataSource = await new AgregarUsuarioController().ObtenerSexoAsync();
            cmbGenero.DisplayMember = "Sexo1";
            cmbGenero.ValueMember = "ID";
        }

        private async void llenarComboNivelActividad()
        {
            
            cmbNivelActividad.DataSource = await new AgregarUsuarioController().ObtenerNivelesActividadAsync();
            cmbNivelActividad.DisplayMember = "Nombre";
            cmbNivelActividad.ValueMember = "Descripcion";
        }

        private async void btnCalcular_Click(object sender, EventArgs e)
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
            

            if (errores > 0)
            {
                String MensajeFinal = "";
                if(errores > 1)
                {
                    MensajeFinal += "Se presentaron las siguientes advertencias\n\n";
                }
                foreach(String mensaje in mensajesErrores)
                {
                    MensajeFinal += "- "+mensaje+"\n";
                }
              
                 new MensajeModerno(MensajeFinal,MensajeModerno.MENSAJE_ADVERTENCIA,this) {  StartPosition = FormStartPosition.CenterScreen }.Show();
               
                return;
            }
            nupBMI.Value = nupPeso.Value / ((nupEstatura.Value / 100) * (nupEstatura.Value / 100));
            if ((int)cmbGenero.SelectedValue==1)
            {
                nupBMR.Value = 66 + ((decimal)13.7 * nupEstatura.Value) + ((decimal)5 * nupEstatura.Value) - ((decimal)6.8 * (DateTime.Now.Year - DateFechaNacimiento.Value.Year));

            }
            else
            {
                nupBMR.Value = 655 + ((decimal)9.6 * nupEstatura.Value) + ((decimal)1.8 * nupEstatura.Value) - ((decimal)4.7 * (DateTime.Now.Year - DateFechaNacimiento.Value.Year));
            }
            txtaNivelActividad.Text = cmbNivelActividad.SelectedValue.ToString();
            lblEstadoPeso.Text = "";
            foreach (CATEGORIA cat in  (await new AgregarUsuarioController().ObtenerCategoriaAsync()))
            {
                if(nupBMI.Value>=cat.Minimo && nupBMI.Value <= cat.Maximo)
                {
                    lblEstadoPeso.Text = cat.Nombre;
                    return;
                }
            }
            

        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            llenarComboSexo();
            llenarComboNivelActividad();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            int errores = 0;
            List<string> mensajesErrores = new List<string>();

            if (txtNombre.Text == "Nombre Del Usuario" && txtApellido.Text == "Apellido Del Usuario")
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
                if (errores > 1)
                {
                    MensajeFinal += "Se presentaron las siguientes advertencias\n\n";
                }
                foreach (String mensaje in mensajesErrores)
                {
                    MensajeFinal += "- " + mensaje + "\n";
                }

                new MensajeModerno(MensajeFinal, MensajeModerno.MENSAJE_ADVERTENCIA, this) { StartPosition = FormStartPosition.CenterScreen }.Show();

                return;
            }

            btnCalcular_Click(sender, e);
            int sexoID = (int)cmbGenero.SelectedValue;
            int nivelActividad = (await new AgregarUsuarioController().ObtenerNivelesActividadAsync()).FirstOrDefault(x=>x.Descripcion == cmbNivelActividad.SelectedValue.ToString()).ID;

            if ((await new AgregarUsuarioController().GuardarUsuarioAsync(new USUARIO() {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                BMI = nupBMI.Value,
                BMR = nupBMR.Value,
                Estatura = nupEstatura.Value,
                FechaNacimiento = DateFechaNacimiento.Value,
                NivelActividad = (int?) nivelActividad,
                Peso = nupPeso.Value,
                SexoID = sexoID
            })) > 0)
            {
                new MensajeModerno("Se ha guardado correctamente", MensajeModerno.MENSAJE_EXITO, this) { StartPosition = FormStartPosition.CenterScreen }.Show();
                foreach (Control control in panelPrincipalContenedor.Controls)
                {
                    if(control is TextBox)
                    {
                        control.Text = "";
                    }else if(control is ComboBox)
                    {
                        (control as ComboBox).SelectedIndex = 0;
                    }
                    else if (control is NumericUpDown)
                    {
                        (control as NumericUpDown).Value = 0;
                    }
                    else if (control is DateTimePicker)
                    {
                        (control as DateTimePicker).Value = DateTime.Now;
                    }
                }
                txtNombre_Leave(sender,e);
                txtApellido_Leave(sender,e);
            }
            else
            {
                new MensajeModerno("No se ha guardado", MensajeModerno.MENSAJE_ERROR, this) { StartPosition = FormStartPosition.CenterScreen }.Show();

            }
        }
    }
}
