using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FMenu : Form
    {
        // --- VARIABLES PARA LA ANIMACIÓN ---
        private Timer animacionTimer = new Timer();
        private Panel panelAAnimar = null;
        private Panel panelPadreAAnimar = null;
        private bool expandiendo = false;
        private int alturaObjetivo = 0;
        private int velocidadAnimacion = 8;

        public FMenu()
        {
            InitializeComponent();
            ConfigurarAnimacion();
            PersonalizarDiseño();
        }
        private bool VerificarPermiso()
        {
            if (Program.rolUsuario == "Empleado")
            {
                MessageBox.Show("No tienes permisos suficientes para acceder a esta sección.",
                    "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // --- CÓDIGO PARA ELIMINAR EL PARPADEO (FLICKER) ---
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Activa el estilo WS_EX_COMPOSITED para dibujo suave
                return cp;
            }
        }

        private void ConfigurarAnimacion()
        {
            animacionTimer.Interval = 15;
            animacionTimer.Tick += AnimacionTimer_Tick;
        }

        // --- MOTOR AUTOMÁTICO DE CÁLCULO ---
        private int CalcularAlturaBase(Panel panel)
        {
            int altura = 0;
            foreach (Control c in panel.Controls)
            {
                if (c is Button) altura += c.Height;
            }
            return altura;
        }

        // --- 1. PERSONALIZAR DISEÑO ---
        private void PersonalizarDiseño()
        {
            // El sistema calcula solo cuánto mide cada menú principal
            PanelSubMenuMantenimientos.Tag = CalcularAlturaBase(PanelSubMenuMantenimientos);
            PanelSubMenuProcesos.Tag = CalcularAlturaBase(PanelSubMenuProcesos);
            PanelSubMenuConsultas.Tag = CalcularAlturaBase(PanelSubMenuConsultas);
            PanelSubMenuUsuarios.Tag = CalcularAlturaBase(PanelSubMenuUsuarios);
            PanelSubMenuAyuda.Tag = CalcularAlturaBase(PanelSubMenuAyuda);

            // NUEVO: Cálculo para el panel de Salida
            //PanelSubMenuSalida.Tag = CalcularAlturaBase(PanelSubMenuSalida);

            // Cálculo para los Sub-Sub Menús
            //PanelSubSubHistorial.Tag = CalcularAlturaBase(PanelSubSubHistorial);
            //PanelSubSubStock.Tag = CalcularAlturaBase(PanelSubSubStock);
            //PanelSubSubAuditoria.Tag = CalcularAlturaBase(PanelSubSubAuditoria);

            OcultarTodosLosMenus();
        }

        // --- 2. MÉTODOS DE LIMPIEZA ---
        private void OcultarTodosLosMenus()
        {
            PanelSubMenuMantenimientos.Height = 0;
            PanelSubMenuProcesos.Height = 0;
            PanelSubMenuConsultas.Height = 0;
            PanelSubMenuUsuarios.Height = 0;
            PanelSubMenuAyuda.Height = 0;
            //PanelSubMenuSalida.Height = 0; // NUEVO

            OcultarSubSubMenusAbiertos();
        }

        private void OcultarSubSubMenusAbiertos()
        {
            //PanelSubSubHistorial.Height = 0; PanelSubSubHistorial.Visible = false;
            //PanelSubSubStock.Height = 0; PanelSubSubStock.Visible = false;
            //PanelSubSubAuditoria.Height = 0; PanelSubSubAuditoria.Visible = false;
        }

        // --- 3. MOSTRAR MENÚS PRINCIPALES ---
        private void MostrarSubMenuConAnimacion(Panel subMenu)
        {
            if (animacionTimer.Enabled) return;

            // Si el menú que queremos abrir está cerrado (Height == 0)
            if (subMenu.Height == 0)
            {
                // BUSCAMOS si hay otro menú abierto para cerrarlo de inmediato
                Panel panelAbierto = ObtenerPanelAbierto();

                if (panelAbierto != null)
                {
                    panelAbierto.Height = 0;
                    panelAbierto.Visible = false;
                }

                panelAAnimar = subMenu;
                panelPadreAAnimar = null;
                expandiendo = true;
                alturaObjetivo = Convert.ToInt32(subMenu.Tag);
                subMenu.Visible = true;
                animacionTimer.Start();
            }
            else // Si el menú ya estaba abierto, simplemente lo cerramos con animación
            {
                panelAAnimar = subMenu;
                expandiendo = false;
                alturaObjetivo = 0;
                animacionTimer.Start();
            }
        }

        // --- 4. MOSTRAR SUB-SUB-MENÚS ---
        private void MostrarSubSubMenuConAnimacion(Panel subSubMenu, Panel panelPadre)
        {
            if (animacionTimer.Enabled) return;

            panelAAnimar = subSubMenu;
            panelPadreAAnimar = panelPadre;

            if (subSubMenu.Height == 0)
            {
                OcultarSubSubMenusAbiertos();
                panelPadre.Height = CalcularAlturaBase(panelPadre);
                expandiendo = true;
                alturaObjetivo = Convert.ToInt32(subSubMenu.Tag);
                subSubMenu.Visible = true;
                animacionTimer.Start();
            }
            else
            {
                expandiendo = false;
                alturaObjetivo = 0;
                animacionTimer.Start();
            }
        }

        // --- 5. MOTOR DE ANIMACIÓN (ANTI-RECORTE) ---
        private void AnimacionTimer_Tick(object sender, EventArgs e)
        {
            if (expandiendo)
            {
                panelAAnimar.Height += velocidadAnimacion;
                if (panelAAnimar.Height >= alturaObjetivo)
                {
                    panelAAnimar.Height = alturaObjetivo;
                    animacionTimer.Stop();
                }
            }
            else
            {
                panelAAnimar.Height -= velocidadAnimacion;
                if (panelAAnimar.Height <= 0)
                {
                    panelAAnimar.Height = 0;
                    panelAAnimar.Visible = false;
                    animacionTimer.Stop();
                }
            }
        }

        // --- 6. EVENTOS CLICK PRINCIPALES ---
        private void btnMantenimientos_Click(object sender, EventArgs e) => MostrarSubMenuConAnimacion(PanelSubMenuMantenimientos);
        private void btnProcesos_Click(object sender, EventArgs e) => MostrarSubMenuConAnimacion(PanelSubMenuProcesos);
        private void btnConsultasYReportes_Click(object sender, EventArgs e) => MostrarSubMenuConAnimacion(PanelSubMenuConsultas);

        private void btnUsuarios_Click(object sender, EventArgs e) => MostrarSubMenuConAnimacion(PanelSubMenuUsuarios);

        private void btnAyuda_Click(object sender, EventArgs e) => MostrarSubMenuConAnimacion(PanelSubMenuAyuda);

        // NUEVO: Click Salida
       // private void btnSalida_Click(object sender, EventArgs e) => MostrarSubMenuConAnimacion(PanelSubMenuSalida);

        // --- 7. EVENTOS CLICK SUB-SUB-MENÚS ---
        //private void btnHistorialClientes_Click(object sender, EventArgs e) => MostrarSubSubMenuConAnimacion(PanelSubSubHistorial, PanelSubMenuConsultas);
        //private void btnStockVideojuegos_Click(object sender, EventArgs e) => MostrarSubSubMenuConAnimacion(PanelSubSubStock, PanelSubMenuConsultas);
        //private void btnAuditoriaVentas_Click(object sender, EventArgs e) => MostrarSubSubMenuConAnimacion(PanelSubSubAuditoria, PanelSubMenuConsultas);

        // --- 8. ACCIONES FINALES ---
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Cerramos la aplicación completa
            Application.Exit();
        }

        private void btnManualUsuario_Click(object sender, EventArgs e) => MessageBox.Show("Abriendo Manual...");
        private void btnAcercaDe_Click(object sender, EventArgs e) => MessageBox.Show("TreeGames v1.0");

        // --- 9. ABRIR FORMULARIOS HIJOS ---
        private Form formularioActivo = null;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);
        private const int WM_SETREDRAW = 11;

        private void AbrirFormularioHijo(Form formularioHijo)
        {
            if (formularioActivo != null) formularioActivo.Close();

            // Congelamos el dibujo completamente
            SendMessage(this.Handle, WM_SETREDRAW, false, 0);

            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            formularioHijo.Visible = false;
            PanelContenedorFormularios.Controls.Add(formularioHijo);
            PanelContenedorFormularios.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Visible = true;

            // Descongelamos y redibujamos todo de golpe
            SendMessage(this.Handle, WM_SETREDRAW, true, 0);
            this.Refresh();
        }
        private void btnEmpleados_Click(object sender, EventArgs e) => AbrirFormularioHijo(new MantenimientoEmpleados());

        private Panel ObtenerPanelAbierto()
        {
            if (PanelSubMenuMantenimientos.Height > 0) return PanelSubMenuMantenimientos;
            if (PanelSubMenuProcesos.Height > 0) return PanelSubMenuProcesos;
            if (PanelSubMenuConsultas.Height > 0) return PanelSubMenuConsultas;
            if (PanelSubMenuUsuarios.Height > 0) return PanelSubMenuUsuarios;
            if (PanelSubMenuAyuda.Height > 0) return PanelSubMenuAyuda;
            //if (PanelSubMenuSalida.Height > 0) return PanelSubMenuSalida;
            return null;
        }

        // MÉTODOS TEMPORALES
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void FMenu_Load(object sender, EventArgs e) 
        {
            timer1.Interval = 1000;
            timer1.Start();

            lblNombreUsuario.Text = Program.nombreUsuario;
            lblRolUsuario.Text = Program.rolUsuario;
        }

        //timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        // --- MÉTODOS QUE EL DISEÑADOR SIGUE BUSCANDO (NO BORRAR) ---
        private void btnPlataformas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new MantenimientoPlataformas());
        }

        private void btnEmpleados_Click_1(object sender, EventArgs e)
        {
            if (!VerificarPermiso()) return;
            AbrirFormularioHijo(new MantenimientoEmpleados());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FRegistrarCompra());
        }


        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new MantenimientoClientes());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FBuscarEmpleado frm = new FBuscarEmpleado();
            frm.ShowDialog();
        }

        private void btnVideoJuegos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new MantenimientoVideojuegos());
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            FBuscarClientes frm = new FBuscarClientes();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FBuscarCategoria frm = new FBuscarCategoria();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FBuscarVideojuegos frm = new FBuscarVideojuegos();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FBuscarPlataformas frm = new FBuscarPlataformas();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FBuscarCompras frm = new FBuscarCompras();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FRegistrarCompra frm = new FRegistrarCompra();
            frm.ShowDialog();
        }

        private void PanelContenedorFormularios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            if (!VerificarPermiso()) return;
            AbrirFormularioHijo(new MantenimientoUsuarios());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new MantenimientoCategorias());
        }

        //Consultas:
        private void btnConsultasClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FConsultaClientes());
        }

        private void btnConsultasEmleados_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FConsultaEmpleados());
        }

        private void btnConsultaVideoJuegos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FConsultaVideojuegos());
        }

        private void btnConsultasCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FConsultaCategorias());
        }

        private void btnConsultaPlataformas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FConsultaPlataformas());
        }

        private void btnConsultaVentas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FConsultaMDCompra());
        }

        //acerca de
        private void button3_Click_1(object sender, EventArgs e)
        {
            FAcercade frm = new FAcercade();
            frm.ShowDialog();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir del sistema?", "TreeGames",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void PanelSuperior_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que Deseas Cerrar el Sistema?", "TreeGames",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }

}