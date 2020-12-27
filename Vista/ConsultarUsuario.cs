using Controlador;
using Modelo.Modelo;
using Modelo.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class ConsultarUsuario : Form
    {
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
        public ConsultarUsuario()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        private async void LlenarComboGenero()
        {
            cmbGenero.DataSource = (await new ConsultarUsuarioController().ObtenerSexoAsync());
            cmbGenero.DisplayMember = "Sexo1";
            cmbGenero.ValueMember = "Sexo1";
        }
        private async void LlenarComboNivelActividad()
        {
            cmbFactorActividad.DataSource = (await new ConsultarUsuarioController().ObtenerNivelesActividadAsync());
            cmbFactorActividad.DisplayMember = "Nombre";
            cmbFactorActividad.ValueMember = "Nombre";
        }
        private async void LlenarComboCategoria()
        {
            cmbCategoria.DataSource = (await new ConsultarUsuarioController().ObtenerCategoriaAsync());
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "ID";
        }
        private async void LlenarTabla()
        {


            int categoriaID = 0;
            if (cmbFactorActividad.SelectedValue != null)
            {
                categoriaID = (int)cmbCategoria.SelectedValue;
            }
            CATEGORIA Categoria = (await new ConsultarUsuarioController().ObtenerCategoriaID(categoriaID));
           

            List<Usuario> lista_usuario = (await new ConsultarUsuarioController().ObtenerUsuarios()).Where(
                x=> (x.Genero == cmbGenero.SelectedValue.ToString() || cmbGenero.SelectedIndex==0 ) &&
                (x.Nivel_Actividad == cmbFactorActividad.SelectedValue.ToString() || cmbFactorActividad.SelectedIndex ==0)  &&
                ((Categoria!=null)?(x.BMI >= (double) Categoria.Minimo &&  x.BMI <= (double)Categoria.Maximo):true || cmbCategoria.SelectedIndex ==0)
            ).ToList();


            TablaUsuario.DataSource = lista_usuario;


        }
        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void ConsultarUsuario_Load(object sender, EventArgs e)
        {
            LlenarComboGenero();
            LlenarComboNivelActividad();
            LlenarComboCategoria();
            LlenarTabla();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            LlenarTabla();
        }

        private void ConsultarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
