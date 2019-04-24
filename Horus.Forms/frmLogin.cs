using Horus.Businesslogic;
using Horus.Common.Utilidades;
using Horus.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorusProjects
{
    public partial class FrmLogin : Form
    {
        private readonly UsuarioServices _usuarioServices = new UsuarioServices();

        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que sale de la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Formulario principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.txtLogin.Focus();

            //TraerIPS();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TraerUsuario();

                this.txtPassword.Focus();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            TraerUsuarioLogin();
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnAceptar.Focus();
            }
        }

        /// <summary>
        /// TraerUsuarioLogin
        /// </summary>
        private void TraerUsuarioLogin()
        {
            try
            {
                string usrLogin = this.txtLogin.Text;
                string usrPassword = this.txtPassword.Text;

                Usuario dsUsuarioLogin = _usuarioServices.TraerUsuariosLogin(usrLogin);
                PermisoOperacion dsUsuariosPermisoOperacion = _usuarioServices.TraerUsuariosPermisoOperacion(usrLogin);
                PermisoOpcionMenu dsUsuariosPermisoMenu = _usuarioServices.TraerUsuariosPermisoMenu(usrLogin);

                if (dsUsuarioLogin != null)
                {
                    this.txtNombre.Text = dsUsuarioLogin.UsuarioNombre;

                    if (_usuarioServices.ValidarHashUsuario(usrLogin, usrPassword))
                    {
                        //Login del usuario
                        LoginInfo.VgUsuarioCodigo = dsUsuarioLogin.UsuarioCodigo;

                        //Id del usuario
                        LoginInfo.VgUsuarioId = dsUsuarioLogin.UsuarioId;

                        //Tabla de permisos de las operaciones
                        LoginInfo.VgPermisoOperaciones = dsUsuariosPermisoOperacion;

                        //Tabla de permisos de opciones de los roles
                        LoginInfo.VgPermisosRoles = dsUsuariosPermisoMenu;


                        FrmFormularioPrincipal frmPrincipal = new FrmFormularioPrincipal();

                        frmPrincipal.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta.", "Horus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no existe.", "Horus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                classExcepciones exCuiidoHc = new classExcepciones();
                exCuiidoHc.EscribirExcepcion("CuiidoHC\\Formularios\\Entrada.cs", "TraerUsuarioLogin", ex);
            }
        }

        /// <summary>
        /// TraerUsuario
        /// </summary>
        private void TraerUsuario()
        {
            try
            {
                string usrLogin = this.txtLogin.Text;

                Usuario dsUsuarioLogin = _usuarioServices.TraerUsuariosLogin(usrLogin);

                if (dsUsuarioLogin != null)
                {
                    this.txtNombre.Text = dsUsuarioLogin.UsuarioNombre;
                }
                else
                {
                    this.txtNombre.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                classExcepciones exCuiidoHc = new classExcepciones();
                exCuiidoHc.EscribirExcepcion("CuiidoHC\\Formularios\\Entrada.cs", "TraerUsuarioLogin", ex);
            }
        }
    }
}
