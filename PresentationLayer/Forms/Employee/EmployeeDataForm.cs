using System;
using System.Windows.Forms;
using BusinessLayer.Exceptions;
using BusinessLayer.Services;
using BusinessLayer.Utilities;
using EntitiesLayer.Entities;

namespace PresentationLayer.Forms.Employee
{
    public partial class EmployeeDataForm : Form
    {
        public string operacion = "";
        public int idUsuario;
        public int idEmpleado;

        private readonly EmployeeService _employeeService;
        public EmployeeDataForm(EmployeeService employeeService)
        {
            InitializeComponent();
            _employeeService = employeeService;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var trabajador = new Trabajador()
                {
                    CodTrabajador = operacion == "Actualizar" ? idEmpleado : 0,
                    Dni = Convert.ToInt32(tboxDni.Texts.Trim()),
                    Nombre = TextTransformer.TransformToTitleCase(tboxNombre.Texts.Trim()),
                    ApellidoPaterno = TextTransformer.CapitalizeFirstLetter(tboxApellidoPaterno.Texts.Trim()),
                    ApellidoMaterno = TextTransformer.CapitalizeFirstLetter(tboxApellidoMaterno.Texts.Trim()),
                    Sexo = rbtnMasculino.Checked ? 'M' : rbtnFemenino.Checked ? 'F' : '\0'
                };

                if (operacion.Equals("Insertar"))
                {
                    _employeeService.Insert(trabajador, idUsuario);
                    OkMessage("Trabajador registrado");
                    Close();
                }
                else if (operacion.Equals("Actualizar"))
                {
                    bool result = _employeeService.Update(trabajador, idUsuario);
                    if (result)
                    {
                        OkMessage("Trabajador actualizado con éxito.");
                        Close();
                    }
                    else
                    {
                        ErrorMessage("No se pudo actualizar los datos del trabajador.");
                    }
                }
                else
                {
                    ErrorMessage("Operacion invalida");
                }

                ClearForm();

            }
            catch (ValidationException ex)
            {
                ErrorMessage($"Error de validación: {ex.Message}");
            }
            catch (BusinessException ex)
            {
                ErrorMessage($"Error de negocio: {ex.Message}");
            }
            catch (Exception ex)
            {
                ErrorMessage($"Error inesperado: {ex.Message}");
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void OkMessage(string message)
        {
            MessageBox.Show(message, "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ClearForm()
        {
            tboxDni.Clear();
            tboxNombre.Clear();
            tboxApellidoPaterno.Clear();
            tboxApellidoMaterno.Clear();
            rbtnFemenino.Checked = false;
            rbtnMasculino.Checked = false;
        }
    }
}