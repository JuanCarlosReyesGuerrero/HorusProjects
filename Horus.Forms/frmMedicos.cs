using Horus.Businesslogic;
using Horus.Common.Clases;
using Horus.Common.Seguridad;
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
    public partial class FrmMedicos : Form
    {
        private Medico _medico;
        private readonly MedicoServices _medicoServices = new MedicoServices();
        public static PermisoOpcionMenu PermisoOpcionMenu { get; set; }

        public FrmMedicos()
        {
            InitializeComponent();
        }

        //private void Guardar()
        //{
        //    try
        //    {
        //        if (_medico == null) _medico = new Medico();                

        //        _medico.MedicoCodigo = this.txtCodigoInterno.Text;
        //        _medico.MedicoApellido1 = this.txtPrimerApellido.Text;
        //        _medico.MedicoApellido2 = this.txtSegundoApellido.Text;
        //        _medico.MedicoNombre1 = this.txtPrimerNombre.Text;
        //        _medico.MedicoNombre2 = this.txtSegundoNombre.Text;
        //        _medico.MedicoRegistroMedico = this.txtRegistroMedico.Text;
        //        _medico.MedicoIdentificacion = this.txtIdentificacion.Text;
        //        _medico.MedicoDireccion = this.txtDireccion.Text;
        //        _medico.MedicoEmail = this.txtEmail.Text;
        //        _medico.MedicoTelefono = this.txtTelefono.Text;
        //        _medico.MedicoCelular = this.txtCelular.Text;

        //        _medico.EspecialidadId = Convert.ToInt32(this.cboEspecialidad.SelectedValue);
        //        _medico.TipoIdentificacionId = Convert.ToInt32(this.cboTipoDocumento.SelectedValue);

        //        if (this.chkActivo.Checked)
        //        {
        //            _medico.MedicoActivo = Convert.ToBoolean(enumEstados.Activo);
        //        }
        //        else
        //        {
        //            _medico.MedicoActivo = Convert.ToBoolean(enumEstados.Inactivo);
        //        }

        //        _medico.MedicoUsuarioCrea = LoginInfo.vgUsuarioId;
        //        _medico.MedicoFechaCreacion = DateTime.Now;
        //        _medico.MedicoUsuarioModifica = LoginInfo.vgUsuarioId;
        //        _medico.MedicoFechaModificacion = DateTime.Now;

        //        _medicoServices.Registrar(_medico);

        //        if (_medicoServices.stringBuilder.Length != 0)
        //        {
        //            MessageBox.Show(_medicoServices.stringBuilder.ToString(), "Para continuar:");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Producto registrado/actualizado con éxito");

        //            TraerTodos();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
        //    }
        //}

        private void TraerTodos()
        {
            List<Medico> productos = _medicoServices.Todos();

            if (productos.Count > 0)
            {
                dtgMedicos.AutoGenerateColumns = false;
                dtgMedicos.DataSource = productos;
                dtgMedicos.Columns["columnId"].DataPropertyName = "Id";
                dtgMedicos.Columns["columnDescripcion"].DataPropertyName = "Descripcion";
                dtgMedicos.Columns["columnMarca"].DataPropertyName = "Marca";
                dtgMedicos.Columns["columnPrecio"].DataPropertyName = "Precio";
            }
            else
            {
                MessageBox.Show("No existen producto Registrado");
            }
        }

        private void FrmMedicos_Load(object sender, EventArgs e)
        {
            try
            {
                ClassValidaRoles classValidaRoles = new ClassValidaRoles();

                PermisoOpcionMenu = classValidaRoles.ValidaRoles(Convert.ToInt32(ClassEnumeraciones.enumOpcionesMenu.Medicos));

                if (PermisoOpcionMenu.UsuarioPermisoAcceso)
                {
                    //classDatos objDao = new classDatos();

                    SeleccionarEspecialidades();
                    //SeleccionarTipoIdentificacion();

                    //configurarGrilla();
                }
                else
                {
                    MessageBox.Show("No tiene permisos para realizar esta operación, por favor comuníquese con el administrador del sistema.", "Horus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ClassExcepciones exQSaludSA = new ClassExcepciones();
                exQSaludSA.EscribirExcepcion("Horus\\Formularios\\Medicos.cs", "Page_Load", ex);
                MessageBox.Show(ex.Message, "Horus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //private void TraerPorId(int id)
        //{
        //    try
        //    {
        //        _medico = _medicoServices.TraerPorId(id);

        //        if (_medico != null)
        //        {
        //            txtId.Text = Convert.ToString(_medico.Id);
        //            txtDescripcion.Text = _medico.Descripcion;
        //            txtMarca.Text = _medico.Marca;
        //            txtPrecio.Text = Convert.ToString(_medico.Precio);
        //        }
        //        else
        //            MessageBox.Show("El Producto solicitado no existe");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
        //    }
        //}

        //private void Eliminar(int id)
        //{
        //    try
        //    {
        //        _medicoServices.Eliminar(id);

        //        MessageBox.Show("Producto eliminado satisfactoriamente");

        //        TraerTodos();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
        //    }
        //}

        /// <summary>
        /// SeleccionarEspecialidades
        /// </summary>
        private void SeleccionarEspecialidades()
        {
            try
            {
                EspecialidadServices _especialidadServices = new EspecialidadServices();

                List<Especialidad> especialidad = _especialidadServices.SeleccionarEspecialidades();

                if (especialidad.Count > 0)
                {
                    this.cboEspecialidad.DataSource = especialidad;

                    this.cboEspecialidad.ValueMember = "EspecialidadId";
                    this.cboEspecialidad.DisplayMember = "EspecialidadNombre";

                    this.cboEspecialidad.SelectedValue = 0;
                }
                else
                {
                    this.cboEspecialidad.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                ClassExcepciones exCuiidoHc = new ClassExcepciones();
                exCuiidoHc.EscribirExcepcion("QSaludSA\\Formularios\\Medicos.aspx", "SeleccionarMunicipios", ex);
                MessageBox.Show(ex.Message, "QSalud", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
