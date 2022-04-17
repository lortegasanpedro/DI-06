using DashBoard_BLL;
using DashBoard_lortega;
using DashBoard_lortega.VOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard_UI
{
    public partial class Form1 : Form
    {
        private int tipo = Constantes.TIPO_EMPLEADO;
        private const string ERROR_DASHBOARD = "Error DashBoard";
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectLBL(object sender)
        {

            if (sender is Label)
            {
                Label lbl = (Label)sender;
                lblProductos.BackColor = Color.White;
                lblClientes.BackColor = Color.White;
                lblEmpleados.BackColor = Color.White;
                lblEnvios.BackColor = Color.White;
                lblInformes.BackColor = Color.White;
                pBEmpleados.BorderStyle = BorderStyle.None;
                pBClientes.BorderStyle = BorderStyle.None;
                pBProductos.BorderStyle = BorderStyle.None;
                pBEnvios.BorderStyle = BorderStyle.None;
                pBInformes.BorderStyle = BorderStyle.None;
                lbl.BackColor = Color.DarkGray;
                if (lbl.Name == lblEmpleados.Name)
                {
                    pBEmpleados.BorderStyle = BorderStyle.Fixed3D;
                    this.chartNorthWind.Visible = true;

                } else if (lbl.Name == lblProductos.Name)
                {
                    pBProductos.BorderStyle = BorderStyle.Fixed3D;
                    this.chartNorthWind.Visible = true;

                } else if (lbl.Name == lblClientes.Name)
                {
                    pBClientes.BorderStyle = BorderStyle.Fixed3D;
                    this.chartNorthWind.Visible = true;

                } else if (lbl.Name == lblEnvios.Name)
                {
                    pBEnvios.BorderStyle = BorderStyle.Fixed3D;
                    this.chartNorthWind.Visible = true;
                }
                else if (lbl.Name == lblInformes.Name)
                {
                    pBInformes.BorderStyle = BorderStyle.Fixed3D;
                    this.chartNorthWind.Visible = false;
                }

            }
        }

        private void SelectPictureBox(object sender)
        {

            if (sender is PictureBox)
            {
                PictureBox pictureBox = (PictureBox)sender;
                pBEmpleados.BorderStyle = BorderStyle.None;
                pBClientes.BorderStyle = BorderStyle.None;
                pBProductos.BorderStyle = BorderStyle.None;
                pBEnvios.BorderStyle = BorderStyle.None;
                pBInformes.BorderStyle = BorderStyle.None;
                lblProductos.BackColor = Color.White;
                lblClientes.BackColor = Color.White;
                lblEmpleados.BackColor = Color.White;
                lblEnvios.BackColor = Color.White;
                lblInformes.BackColor = Color.White;
                pictureBox.BorderStyle = BorderStyle.Fixed3D;
                if (pictureBox.Name == pBEmpleados.Name)
                {
                    lblEmpleados.BackColor = Color.DarkGray;
                    this.chartNorthWind.Visible = true;
                }
                else if (pictureBox.Name == pBProductos.Name)
                {
                    lblProductos.BackColor = Color.DarkGray;
                    this.chartNorthWind.Visible = true;
                }
                else if (pictureBox.Name == pBClientes.Name)
                {
                    lblClientes.BackColor = Color.DarkGray;
                    this.chartNorthWind.Visible = true;
                }
                else if (pictureBox.Name == pBEnvios.Name)
                {
                    lblEnvios.BackColor = Color.DarkGray;
                    this.chartNorthWind.Visible = true;
                }
                else if (pictureBox.Name == pBInformes.Name)
                {
                    lblInformes.BackColor = Color.DarkGray;
                    this.chartNorthWind.Visible = false;
                }
            }
             
            }
        private void SelectButton(object sender)
        {

            if (sender is Button)
            {
                Button btnSelect = (Button)sender;
                btn1.BackColor = SystemColors.ControlLight;
                btn2.BackColor = SystemColors.ControlLight;
                btn3.BackColor = SystemColors.ControlLight;
                btn4.BackColor = SystemColors.ControlLight;
                btn5.BackColor = SystemColors.ControlLight;
                btn6.BackColor = SystemColors.ControlLight;
                btn7.BackColor = SystemColors.ControlLight;
                btn8.BackColor = SystemColors.ControlLight;
                btn9.BackColor = SystemColors.ControlLight;
                btn10.BackColor = SystemColors.ControlLight;
                btnSelect.BackColor = SystemColors.ControlDark;
            }
        }

        private void lblEnvios_Click(object sender, EventArgs e)
        {
            SelectLBL(sender);
            List<string> listTituloEnvios = Utilidades.ObtenerNombresBotones(Constantes.TIPO_ENVIO);
            OcultarBotones();
            tipo = Constantes.TIPO_ENVIO;
            PonerTituloBotones(listTituloEnvios, tipo);
        }


        private void lblEmpleados_Click(object sender, EventArgs e)
        {
            SelectLBL(sender);
            List<string> listTituloBotones = Utilidades.ObtenerNombresBotones(Constantes.TIPO_EMPLEADO);
            OcultarBotones();
            tipo = Constantes.TIPO_EMPLEADO;
            PonerTituloBotones(listTituloBotones, tipo);
        }

        private void lblProductos_Click(object sender, EventArgs e)
        {
            SelectLBL(sender);
            List<string> listTituloBotones = Utilidades.ObtenerNombresBotones(Constantes.TIPO_PRODUCTO);
            OcultarBotones();
            tipo = Constantes.TIPO_PRODUCTO;
            PonerTituloBotones(listTituloBotones, tipo);
        }

        private void lblClientes_Click(object sender, EventArgs e)
        {
            SelectLBL(sender);
            List<string> listTituloBotones = Utilidades.ObtenerNombresBotones(Constantes.TIPO_CLIENTE);
            OcultarBotones();
            tipo = Constantes.TIPO_CLIENTE;
            PonerTituloBotones(listTituloBotones, tipo);
        }


        private void pbEmpleados_Click(object sender, EventArgs e)
        {
            SelectPictureBox(sender);
            List<string> listTituloBotones = Utilidades.ObtenerNombresBotones(Constantes.TIPO_EMPLEADO);
            OcultarBotones();
            tipo = Constantes.TIPO_EMPLEADO;
            PonerTituloBotones(listTituloBotones,tipo);
            btn1.PerformClick();
        }

        private void pbEnvios_Click(object sender, EventArgs e)
        {
            SelectPictureBox(sender);
            List<string> listTituloEnvios = Utilidades.ObtenerNombresBotones(Constantes.TIPO_ENVIO);
            OcultarBotones();
            tipo = Constantes.TIPO_ENVIO;
            PonerTituloBotones(listTituloEnvios, tipo);
            btn1.PerformClick();
        }


        private void pBProductos_Click(object sender, EventArgs e)
        {
            SelectPictureBox(sender);
            List<string> listTituloBotones = Utilidades.ObtenerNombresBotones(Constantes.TIPO_PRODUCTO);
            OcultarBotones();
            tipo = Constantes.TIPO_PRODUCTO;
            PonerTituloBotones(listTituloBotones,tipo);
            btn1.PerformClick();
        }

        private void pBClientes_Click(object sender, EventArgs e)
        {
            SelectPictureBox(sender);
            List<string> listTituloBotones = Utilidades.ObtenerNombresBotones(Constantes.TIPO_CLIENTE);
            OcultarBotones();
            tipo = Constantes.TIPO_CLIENTE;
            PonerTituloBotones(listTituloBotones,tipo);
            btn1.PerformClick();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            SelectButton(sender);
            DashBoardBLL dashBoardBLL = new DashBoardBLL();
            try
            {
                if (tipo == Constantes.TIPO_EMPLEADO)
                {
                    List<TotalVentasPorEmpleadoVO> listTotalVentasPorEmpleado = dashBoardBLL.ConsultaTodosEmpleados();
                    Utilidades.ChartEmpleadoTotales(listTotalVentasPorEmpleado, this.chartNorthWind);

                }
                else if (tipo == Constantes.TIPO_PRODUCTO)
                {
                    List<ProductoMasVendidoVO> listaProductosMasVendidos = dashBoardBLL.ConsultaProductosMasVendidos(1000, false);
                    Utilidades.ChartProductosMasVendidos(listaProductosMasVendidos, this.chartNorthWind, 1000, false);
                }
                else if (tipo == Constantes.TIPO_CLIENTE)
                {
                    List<ClientesConTotalCompraVO> listaClientesConTotalCompra = dashBoardBLL.ConsultaClientesConTotalCompras(10000, true);
                    Utilidades.ChartClientesConTotalCompra(listaClientesConTotalCompra, this.chartNorthWind, 10000, true);
                }
                else if (tipo == Constantes.TIPO_ENVIO)
                {
                    List<TotalEnviosPorCompanyVO> listaTotalEnviosPorCompany = dashBoardBLL.ConsultaTotalEnviosPorCompany();
                    Utilidades.ChartTotalEnviosPorCompany(listaTotalEnviosPorCompany, this.chartNorthWind);
                }
                else if (tipo == Constantes.TIPO_INFORMES)
                {
                    Informes informes = new Informes();
                    informes.Informe = Constantes.NOMBRES_INFORMES[0];
                    informes.Show();
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message, ERROR_DASHBOARD, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            SelectButton(sender);
            DashBoardBLL dashBoardBLL = new DashBoardBLL();
            try
            {
                if (tipo == Constantes.TIPO_EMPLEADO)
                {
                    List<EmpleadoConTotalVentasPorProductoVO> listaEmpleadosConTotalVentasPorProducto = dashBoardBLL.ConsultaEmpleadosConTotalVentasPorProducto(Constantes.EMPLEADO_NANCY_ID);
                    Utilidades.ChartEmpleado(listaEmpleadosConTotalVentasPorProducto, this.chartNorthWind);

                }
                else if (tipo == Constantes.TIPO_PRODUCTO)
                {
                    List<ProductoMasVendidoVO> listaProductosMasVendidos = dashBoardBLL.ConsultaProductosMasVendidos(500, false);
                    Utilidades.ChartProductosMasVendidos(listaProductosMasVendidos, this.chartNorthWind, 500, false);
                }
                else if (tipo == Constantes.TIPO_CLIENTE)
                {
                    List<ClientesConTotalCompraVO> listaClientesConTotalCompra = dashBoardBLL.ConsultaClientesConTotalCompras(20000, true);
                    Utilidades.ChartClientesConTotalCompra(listaClientesConTotalCompra, this.chartNorthWind, 20000, true);
                }
                else if (tipo == Constantes.TIPO_ENVIO)
                {
                    List<TotalEnviosPorPaisVO> listaTotalEnviosPorPais = dashBoardBLL.ConsultaTotalEnviosPorPais();
                    Utilidades.ChartTotalEnviosPorPais(listaTotalEnviosPorPais, this.chartNorthWind);
                }
                else if (tipo == Constantes.TIPO_INFORMES)
                {
                    Informes informes = new Informes();
                    informes.Informe = Constantes.NOMBRES_INFORMES[1];
                    informes.Show();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message, ERROR_DASHBOARD, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            SelectButton(sender);
            DashBoardBLL dashBoardBLL = new DashBoardBLL();
            if (tipo == Constantes.TIPO_EMPLEADO)
            {
                List<EmpleadoConTotalVentasPorProductoVO> listaEmpleadosConTotalVentasPorProducto = dashBoardBLL.ConsultaEmpleadosConTotalVentasPorProducto(Constantes.EMPLEADO_JANET_ID);
                Utilidades.ChartEmpleado(listaEmpleadosConTotalVentasPorProducto, this.chartNorthWind);
            }
            else if (tipo == Constantes.TIPO_PRODUCTO)
            {
                List<ProductoMasVendidoVO> listaProductosMasVendidos = dashBoardBLL.ConsultaProductosMasVendidos(1000, true);
                Utilidades.ChartProductosMasVendidos(listaProductosMasVendidos, this.chartNorthWind, 1000, true);
            }
            else if (tipo == Constantes.TIPO_CLIENTE)
            {
                List<ClientesConTotalCompraVO> listaClientesConTotalCompra = dashBoardBLL.ConsultaClientesConTotalCompras(40000, true);
                Utilidades.ChartClientesConTotalCompra(listaClientesConTotalCompra, this.chartNorthWind, 40000, true);
            }
            else if (tipo == Constantes.TIPO_ENVIO)
            {
                List<TotalEnviosPorCiudadVO> listaTotalEnviosPorCiudad = dashBoardBLL.ConsultaTotalEnviosPorCiudad();
                Utilidades.ChartTotalEnviosPorCiudad(listaTotalEnviosPorCiudad, this.chartNorthWind);
            }
            else if (tipo == Constantes.TIPO_INFORMES)
            {
                Informes informes = new Informes();
                informes.Informe = Constantes.NOMBRES_INFORMES[2];
                informes.Show();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            SelectButton(sender);
            DashBoardBLL dashBoardBLL = new DashBoardBLL();
            try
            {
                if (tipo == Constantes.TIPO_EMPLEADO)
                {
                    List<EmpleadoConTotalVentasPorProductoVO> listaEmpleadosConTotalVentasPorProducto = dashBoardBLL.ConsultaEmpleadosConTotalVentasPorProducto(Constantes.EMPLEADO_MARGARET_ID);
                    Utilidades.ChartEmpleado(listaEmpleadosConTotalVentasPorProducto, this.chartNorthWind);
                }
                else if (tipo == Constantes.TIPO_PRODUCTO)
                {
                    List<ProductoMasVendidoVO> listaProductosMasVendidos = dashBoardBLL.ConsultaProductosMasVendidos(500, true);
                    Utilidades.ChartProductosMasVendidos(listaProductosMasVendidos, this.chartNorthWind, 500, true);
                }
                else if (tipo == Constantes.TIPO_CLIENTE)
                {
                    List<ClientesConTotalCompraVO> listaClientesConTotalCompra = dashBoardBLL.ConsultaClientesConTotalCompras(10000, false);
                    Utilidades.ChartClientesConTotalCompra(listaClientesConTotalCompra, this.chartNorthWind, 10000, false);
                }
                else if (tipo == Constantes.TIPO_INFORMES)
                {
                    Informes informes = new Informes();
                    informes.Informe = Constantes.NOMBRES_INFORMES[3];
                    informes.Show();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message, ERROR_DASHBOARD, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            SelectButton(sender);
            DashBoardBLL dashBoardBLL = new DashBoardBLL();

            try
            {
                if (tipo == Constantes.TIPO_EMPLEADO)
                {
                    List<EmpleadoConTotalVentasPorProductoVO> listaEmpleadosConTotalVentasPorProducto = dashBoardBLL.ConsultaEmpleadosConTotalVentasPorProducto(Constantes.EMPLEADO_STEVEN_ID);
                    Utilidades.ChartEmpleado(listaEmpleadosConTotalVentasPorProducto, this.chartNorthWind);

                }
                else if (tipo == Constantes.TIPO_PRODUCTO)
                {
                    List<ProductoConStockMenorVO> listaProductosConStockMenor = dashBoardBLL.ConsultaProductosConStockMenor(10);
                    Utilidades.ChartProductosConStockMenor(listaProductosConStockMenor, this.chartNorthWind, 10);
                }
                else if (tipo == Constantes.TIPO_CLIENTE)
                {
                    List<ClientesConTotalCompraVO> listaClientesConTotalCompra = dashBoardBLL.ConsultaClientesConTotalCompras(5000, false);
                    Utilidades.ChartClientesConTotalCompra(listaClientesConTotalCompra, this.chartNorthWind, 5000, false);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message, ERROR_DASHBOARD, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn6_Click(object sender, EventArgs e)
        {
            SelectButton(sender);
            DashBoardBLL dashBoardBLL = new DashBoardBLL();

            try
            {
                if (tipo == Constantes.TIPO_EMPLEADO)
                {
                    List<EmpleadoConTotalVentasPorProductoVO> listaEmpleadosConTotalVentasPorProducto = dashBoardBLL.ConsultaEmpleadosConTotalVentasPorProducto(Constantes.EMPLEADO_MICHAEL_ID);
                    Utilidades.ChartEmpleado(listaEmpleadosConTotalVentasPorProducto, this.chartNorthWind);

                }
                else if (tipo == Constantes.TIPO_PRODUCTO)
                {
                    List<ProductoConStockMenorVO> listaProductosConStockMenor = dashBoardBLL.ConsultaProductosConStockMenor(20);
                    Utilidades.ChartProductosConStockMenor(listaProductosConStockMenor, this.chartNorthWind, 20);
                }
                else if (tipo == Constantes.TIPO_CLIENTE)
                {
                    List<ClientesConTotalCompraVO> listaClientesConTotalCompra = dashBoardBLL.ConsultaClientesConTotalCompras(1000, false);
                    Utilidades.ChartClientesConTotalCompra(listaClientesConTotalCompra, this.chartNorthWind, 1000, false);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message, ERROR_DASHBOARD, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            SelectButton(sender);
            DashBoardBLL dashBoardBLL = new DashBoardBLL();

            try
            {
                if (tipo == Constantes.TIPO_EMPLEADO)
                {
                    List<EmpleadoConTotalVentasPorProductoVO> listaEmpleadosConTotalVentasPorProducto = dashBoardBLL.ConsultaEmpleadosConTotalVentasPorProducto(Constantes.EMPLEADO_ROBERT_ID);
                    Utilidades.ChartEmpleado(listaEmpleadosConTotalVentasPorProducto, this.chartNorthWind);
                }
                else if (tipo == Constantes.TIPO_PRODUCTO)
                {
                    List<ProductoConStockMenorVO> listaProductosConStockMenor = dashBoardBLL.ConsultaProductosConStockMenor(40);
                    Utilidades.ChartProductosConStockMenor(listaProductosConStockMenor, this.chartNorthWind, 40);
                }
                else if (tipo == Constantes.TIPO_CLIENTE)
                {
                    List<ClientesConTotalCompraVO> listaClientesConTotalCompra = dashBoardBLL.ConsultaClientesConTotalCompras(500, false);
                    Utilidades.ChartClientesConTotalCompra(listaClientesConTotalCompra, this.chartNorthWind, 500, false);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message, ERROR_DASHBOARD, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            SelectButton(sender);
            DashBoardBLL dashBoardBLL = new DashBoardBLL();

            try
            {
                if (tipo == Constantes.TIPO_EMPLEADO)
                {
                    List<EmpleadoConTotalVentasPorProductoVO> listaEmpleadosConTotalVentasPorProducto = dashBoardBLL.ConsultaEmpleadosConTotalVentasPorProducto(Constantes.EMPLEADO_LAURA_ID);
                    Utilidades.ChartEmpleado(listaEmpleadosConTotalVentasPorProducto, this.chartNorthWind);
                }
                else if (tipo == Constantes.TIPO_PRODUCTO)
                {
                    List<ProductoConStockMenorVO> listaProductosConStockMenor = dashBoardBLL.ConsultaProductosConStockMenor(80);
                    Utilidades.ChartProductosConStockMenor(listaProductosConStockMenor, this.chartNorthWind, 80);
                }
                else if (tipo == Constantes.TIPO_CLIENTE)
                {
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message, ERROR_DASHBOARD, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            SelectButton(sender);
            DashBoardBLL dashBoardBLL = new DashBoardBLL();
            try
            {
                if (tipo == Constantes.TIPO_EMPLEADO)
                {
                    List<EmpleadoConTotalVentasPorProductoVO> listaEmpleadosConTotalVentasPorProducto = dashBoardBLL.ConsultaEmpleadosConTotalVentasPorProducto(Constantes.EMPLEADO_ANNE_ID);
                    Utilidades.ChartEmpleado(listaEmpleadosConTotalVentasPorProducto, this.chartNorthWind);
                }
                else if (tipo == Constantes.TIPO_PRODUCTO)
                {
                    List<ProductoConStockMenorVO> listaProductosConStockMenor = dashBoardBLL.ConsultaProductosConStockMenor(100);
                    Utilidades.ChartProductosConStockMenor(listaProductosConStockMenor, this.chartNorthWind, 100);
                }
                else if (tipo == Constantes.TIPO_CLIENTE)
                {
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message, ERROR_DASHBOARD, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            SelectButton(sender);
            DashBoardBLL dashBoardBLL = new DashBoardBLL();
            try
            {
                if (tipo == Constantes.TIPO_EMPLEADO)
                {
                    List<EmpleadoConTotalVentasPorProductoVO> listaEmpleadosConTotalVentasPorProducto = dashBoardBLL.ConsultaEmpleadosConTotalVentasPorProducto(Constantes.EMPLEADO_ANDREW_ID);
                    Utilidades.ChartEmpleado(listaEmpleadosConTotalVentasPorProducto, this.chartNorthWind);
                }
                else if (tipo == Constantes.TIPO_PRODUCTO)
                {

                }
                else if (tipo == Constantes.TIPO_CLIENTE)
                {
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message, ERROR_DASHBOARD, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OcultarBotones()
        {
            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
            btn4.Visible = false;
            btn5.Visible = false;     
            btn6.Visible = false;
            btn7.Visible = false;
            btn8.Visible = false;        
            btn9.Visible = false;
            btn10.Visible = false;
        }

        private void PonerTituloBotones(List<string> listTituloBotones, int tipo)
        {
            int contador = 0;

            foreach (string tituloBoton in listTituloBotones)
            {
                Button btn = ObtenerBoton(contador, tipo);
                Utilidades.PonerTituloBoton(tituloBoton,btn);
                contador++;
            }
        }

        private Button ObtenerBoton(int indice, int tipo)
        {
            Button btn;
            switch (indice)
            {
                case 0:
                    btn = btn1;
                    break;
                case 1:
                    btn = btn2;
                    break;
                case 2:
                    btn = btn3;
                    break;
                case 3:
                    btn = btn4;
                    break;
                case 4:
                    btn = btn5;
                    break;
                case 5:                    
                    btn = btn6;
                    break;
                case 6:
                    btn = btn7;
                    break;
                case 7:
                    btn = btn8;
                    break;
                case 8:
                    btn = btn9;
                    break;
                case 9:
                    btn = btn10;
                    break;
                default:
                    btn = null;
                    break;
            }
            return btn;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectButton(this.btn1);
            List<string> listTituloBotones = Utilidades.ObtenerNombresBotones(Constantes.TIPO_EMPLEADO);
            OcultarBotones();
            tipo = Constantes.TIPO_EMPLEADO;
            PonerTituloBotones(listTituloBotones, tipo);
            DashBoardBLL dashBoardBLL = new DashBoardBLL();
            try
            {
                List<TotalVentasPorEmpleadoVO> listTotalVentasPorEmpleado = dashBoardBLL.ConsultaTodosEmpleados();
                Utilidades.ChartEmpleadoTotales(listTotalVentasPorEmpleado, this.chartNorthWind);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message, ERROR_DASHBOARD, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pbInformes_Click(object sender, EventArgs e)
        {

            SelectPictureBox(sender);
            List<string> listTituloBotones = Utilidades.ObtenerNombresBotones(Constantes.TIPO_INFORMES);
            OcultarBotones();
            tipo = Constantes.TIPO_INFORMES;
            PonerTituloBotones(listTituloBotones, tipo);
            btn1.PerformClick();

        }

        private void lblInformes_Click(object sender, EventArgs e)
        {
            SelectLBL(sender);
            List<string> listTituloInformes = Utilidades.ObtenerNombresBotones(Constantes.TIPO_INFORMES);
            OcultarBotones();
            tipo = Constantes.TIPO_INFORMES;
            PonerTituloBotones(listTituloInformes, tipo);

        }
    }
}
