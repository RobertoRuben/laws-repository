using System;
using System.Windows.Forms;
using BusinessLayer.Exceptions;
using BusinessLayer.Services;
using BusinessLayer.Utilities;

namespace PresentationLayer.Forms.Employees
{
    public partial class EmployeeDataForm : Form
    {
        public string operation = "";
        public int userId;
        public int employeeId;

        private readonly EmployeeService _employeeService;
        public EmployeeDataForm(EmployeeService employeeService)
        {
            InitializeComponent();
            _employeeService = employeeService;
            
            this.Shown += new EventHandler(EmployeeDataForm_Shown);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var employee = new EntitiesLayer.Entities.Employee
                {
                    CodEmployee = operation == "Actualizar" ? employeeId : 0,
                    Dni = Convert.ToInt32(tboxDni.Texts.Trim()),
                    EmployeeName = TextTransformer.TransformToTitleCase(tboxName.Texts.Trim()),
                    PaternalSurname = TextTransformer.CapitalizeFirstLetter(tboxFaternalLastName.Texts.Trim()),
                    MaternalSurname = TextTransformer.CapitalizeFirstLetter(tboxMaternalLastName.Texts.Trim()),
                    Gender = rbtnMale.Checked ? 'M' : rbtnFemale.Checked ? 'F' : '\0'
                };

                if (operation.Equals("Insertar"))
                {
                    _employeeService.Insert(employee, userId);
                    OkMessage("Employee registrado");
                    Close();
                }
                else if (operation.Equals("Actualizar"))
                {
                    bool result = _employeeService.Update(employee, userId);
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
        private void ExitBtn_Click(object sender, EventArgs e)
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
        private void EmployeeDataForm_Shown(object sender, EventArgs e)
        {
            tboxDni.SetFocus();
        }
    }
}