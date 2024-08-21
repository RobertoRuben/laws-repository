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
        public string operacion = "";
        public int idUsuarioSesion;
        public int idUsuario;

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
            LoadCboxTrabajadores();
            LoadCboxRoles();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadCboxTrabajadores()
        {
            try
            {
                cboxTrabajador.DataSource = _employeeService.GetNames();
                cboxTrabajador.DisplayMember = "FullName";
                cboxTrabajador.ValueMember = "CodTrabajador";
                cboxTrabajador.Texts = "Seleccione un trabajador";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void LoadCboxRoles()
        {
            try
            {
                cboxRol.DataSource = _rolService.GetAll();
                cboxRol.DisplayMember = "NombreDeRol";
                cboxRol.ValueMember = "CodRol";
                cboxRol.Texts = "Seleccione un rol";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new Usuario()
                {
                    CodUsuario = operacion == "Actualizar" ? idUsuario : 0,
                    CodRol = Convert.ToInt32(cboxRol.SelectedValue),
                    CodTrabajador = Convert.ToInt32(cboxTrabajador.SelectedValue),
                    Contraseña = tboxContraseña.Texts.Trim(),
                    Estado = rbtnActivo.Checked ? "Activo" : "Inactivo",
                    NombreUsuario = tboxUsuario.Texts.Trim()
                };

                if (operacion.Equals("Insertar"))
                {
                    string confirmacionContraseña = tboxConfirmarContraseña.Texts.Trim();
                    
                    if (user.Contraseña.Equals(confirmacionContraseña))
                    {
                        _userService.Insert(user, idUsuarioSesion);
                        OkMessage("Usuario registrado");
                        Close();
                    }
                    else
                    {
                        ErrorMessage("La contraseña no coincide con la confirmacion");
                    }
                }else if (operacion.Equals("Actualizar"))
                {
                    Console.WriteLine("Contraseña: " + user.Contraseña);
                    Console.WriteLine("Longitud de la contraseña: " + user.Contraseña.Length);

                    bool result = _userService.Update(user, idUsuarioSesion);
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
                    ErrorMessage("No se pudo actualizar los datos del trabajador.");
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

    }
}