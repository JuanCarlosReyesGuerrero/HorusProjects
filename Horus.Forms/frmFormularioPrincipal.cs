using System;
using System.Windows.Forms;

namespace HorusProjects
{
    public partial class frmFormularioPrincipal : Form
    {
        public frmFormularioPrincipal()
        {
            InitializeComponent();
        }

        #region DECLARACION DE FORMULARIOS

        //Perfiles frmPerfiles;
        //Login frmLogin;
        //Usuarios frmUsuarios;
        //ModuloFacturacion frmModuloFacturacion;
        //Contratos frmContratos;
        //Procedimientos frmProcedimientos;
        //Hospital frmHospital;
        frmMedicos frmMedicos;

        Form llamarFormulario = new Form();

        #endregion

        #region EVENTOS

        /// <summary>
        /// Cargue inicial del formulario principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFormularioPrincipal_Load(object sender, EventArgs e)
        {
            this.tssUsuario.Text = "Usuario: ";
            this.tssFechaActual.Text = Convert.ToString(DateTime.Now);
        }

        /// <summary>
        /// Valida cuando se cierra el formulario principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFormularioPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!vTemp)
            {
                DialogResult result = MessageBox.Show("¿Esta seguro de salir del programa?.", "Horus", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    vTemp = true;

                    Application.Exit();
                }
            }
        }

        /// <summary>
        /// Valida cuando se cierra el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalirDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Valida cuando se cierra el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmUsuarios = new Formularios.Usuarios();
            //cargarUnFormulario(frmPerfiles, this);
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPerfiles = new Formularios.Perfiles();
            //cargarUnFormulario(frmPerfiles, this);
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            //if (frmPerfiles != null)
            //    frmPerfiles.GuardarEditar();

            //if (frmModuloFacturacion != null)
            //    frmModuloFacturacion.GuardarEditar();

            //if (frmContratos != null)
            //    frmContratos.GuardarEditar();

            //if (frmHospital != null)
            //    frmHospital.GuardarEditar();
        }

        private void toolStripNuevo_Click(object sender, EventArgs e)
        {
            //if (frmPerfiles != null)
            //    frmPerfiles.Nuevo();

            //if (frmModuloFacturacion != null)
            //    frmModuloFacturacion.Nuevo();

            //if (frmContratos != null)
            //    frmContratos.Nuevo();
        }

        private void toolStripBuscar_Click(object sender, EventArgs e)
        {
            //if (frmPerfiles != null)
            //    frmPerfiles.Buscar();

            //if (frmModuloFacturacion != null)
            //    frmModuloFacturacion.Buscar();

            //if (frmContratos != null)
            //    frmContratos.Buscar();
        }      

        bool vTemp = false;

        
        private void facturaciónGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmModuloFacturacion = new Formularios.ModuloFacturacion();
            //cargarUnFormulario(frmModuloFacturacion, this);
        }

        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmContratos = new Formularios.Contratos();
            //cargarUnFormulario(frmContratos, this);
        }

        #endregion

        #region PROCEDIMIENTOS

        /// <summary>
        /// Con este médodo se carga un solo formulario
        /// </summary>
        /// <param name="frmhijo">The frmhijo.</param>
        /// <param name="frmPadre">The FRM padre.</param>
        public void cargarUnFormulario(Form frmhijo, Form frmPadre)
        {
            bool cargado = false;

            foreach (Form vFormulario in frmPadre.MdiChildren)
            {
                if (llamarFormulario.Text == frmhijo.Text)
                {
                    cargado = true;
                    break;
                }
            }
            if (!cargado)
            {
                frmhijo.MdiParent = frmPadre;
                frmhijo.Show();
            }
        }

        #endregion

        /// <summary>
        /// Abre el formulario de medicos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MédicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedicos = new frmMedicos();
            cargarUnFormulario(frmMedicos, this);
        }


    }
}
