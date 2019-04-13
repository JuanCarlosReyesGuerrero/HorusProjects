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
    public partial class frmLogin : Form
    {
        private readonly UsuarioServices<Usuario> _usuarioServices = new UsuarioServices<Usuario>();

        public frmLogin()
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

            TraerIPS();
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

        private void TraerUsuarioLogin()
        {
            try
            {
                string usrLogin = this.txtLogin.Text;
                string usrPassword = this.txtPassword.Text;

                DataTable dsUsuarioLogin = _usuarioServices.TraerUsuariosLogin(usrLogin);
                DataTable dsUsuariosPermisoOperacion = _usuarioServices.TraerUsuariosPermisoOperacion(usrLogin);
                DataTable dsUsuariosPermisoMenu = _usuarioServices.TraerUsuariosPermisoMenu(usrLogin);

                if (dsUsuarioLogin.Rows.Count > 0)
                {
                    if (_usuarioServices.ValidarHashUsuario(usrLogin, usrPassword))
                    {
                        //Login del usuario
                        LoginInfo.vgUsuarioCodigo = Convert.ToString(dsUsuarioLogin.Rows[0]["UsuarioCodigo"]);

                        //Id del usuario
                        LoginInfo.vgUsuarioId = Convert.ToInt32(dsUsuarioLogin.Rows[0]["UsuarioId"]);

                        //Id de la clínica
                        LoginInfo.vgHospitalId = Convert.ToString(dsUsuarioLogin.Rows[0]["HospitalId"]);

                        //Tabla de permisos de las operaciones
                        LoginInfo.vgPermisoOperaciones = dsUsuariosPermisoOperacion;

                        //Tabla de permisos de opciones de los roles
                        LoginInfo.vgPermisosRoles = dsUsuariosPermisoMenu;


                        FormularioPrincipal frmPrincipal = new FormularioPrincipal();
                        //frmPrincipal.MdiParent = this.MdiParent;
                        frmPrincipal.Show();

                        this.Hide();
                        //this.Close();
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
                if (ex.Message == "Subproceso anulado.")
                {
                }
                else
                {
                    classUtilidades objGUI = new classUtilidades();
                    MessageBox.Show(ex.Message);
                    classExcepciones exCuiidoHc = new classExcepciones();
                    exCuiidoHc.EscribirExcepcion("CuiidoHC\\Formularios\\Entrada.cs", "TraerUsuarioLogin", ex);
                }
            }
        }

        private void TraerUsuario()
        {
        }

        private void TraerIPS()
        {

        }
    }
}
