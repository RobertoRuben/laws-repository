using System;
using System.Reflection;
using System.Windows.Forms;
using BusinessLayer.Exceptions;
using BusinessLayer.Services;
using BusinessLayer.Utilities;
using EntitiesLayer.Entities;

namespace PresentationLayer.Forms.User
{
    public partial class UserDataForm : Form
    {
        public string operation = "";
        public int userSesionId;
        public int UserId;

        private readonly UserService _userService;
        private readonly EmployeeService _employeeService;
        private readonly RolService _rolService;
        
        public UserDataForm(UserService userService, EmployeeService employeeService, RolService rolService)
        {
            InitializeComponent();
            SetDoubleBuffered(this);
            _userService = userService;
            _employeeService = employeeService;
            _rolService = rolService;
            LoadEmployees();
            LoadRoles();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadEmployees()
        {
            try
            {
                cboxEmployee.DataSource = _employeeService.GetNames();
                cboxEmployee.DisplayMember = "FullName";
                cboxEmployee.ValueMember = "CodEmployee";
                cboxEmployee.Texts = "Seleccione un trabajador";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void LoadRoles()
        {
            try
            {
                cboxRol.DataSource = _rolService.GetAll();
                cboxRol.DisplayMember = "RolName";
                cboxRol.ValueMember = "CodRol";
                cboxRol.Texts = "Seleccione un rol";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new EntitiesLayer.Entities.User()
                {
                    CodUser = operation == "Actualizar" ? UserId : 0,
                    CodRol = Convert.ToInt32(cboxRol.SelectedValue),
                    CodEmployee = Convert.ToInt32(cboxEmployee.SelectedValue),
                    Password = tboxPassword.Texts.Trim(),
                    State = rbtnActivate.Checked ? "Activo" : "Inactivo",
                    UserName = tboxUser.Texts.Trim()
                };

                if (operation.Equals("Insertar"))
                {
                    string passwordConfirm = tboxConfirm.Texts.Trim();
                    
                    if (user.Password.Equals(passwordConfirm))
                    {
                        _userService.Insert(user, userSesionId);
                        OkMessage("Usuario registrado");
                        Close();
                    }
                    else
                    {
                        ErrorMessage("La contraseña no coincide con la confirmacion");
                    }
                }else if (operation.Equals("Actualizar"))
                {
                    bool result = _userService.Update(user, userSesionId);
                    if (result)
                    {
                        OkMessage("Usuario actualizado con éxito.");
                        Close();
                    }
                    else
                    {
                        ErrorMessage("No se pudo actualizar los datos del usuario.");
                    }
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
        private void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void OkMessage(string message)
        {
            MessageBox.Show(message, "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private static void SetDoubleBuffered(Control control)
        {
            // Usando reflexión para obtener acceso a la propiedad DoubleBuffered
            PropertyInfo propInfo = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            propInfo.SetValue(control, true, null);

            // Aplicar a todos los controles anidados
            foreach (Control ctrl in control.Controls)
            {
                SetDoubleBuffered(ctrl);
            }
        }

    }
}