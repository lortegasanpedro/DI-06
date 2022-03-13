using DashBoard_lortega.VOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DashBoard_lortega
{
    public static class Utilidades
    {

        public static void ChartTotalEnviosPorCiudad(List<TotalEnviosPorCiudadVO> listaTotalEnviosPorCiudad, Chart chartNorthWind)
        {
            List<string> x1 = new List<string>();
            List<decimal> y1 = new List<decimal>();
            foreach (TotalEnviosPorCiudadVO totalEnviosPorCiudad in listaTotalEnviosPorCiudad)
            {
                x1.Add(totalEnviosPorCiudad.ShipCity);
                y1.Add(totalEnviosPorCiudad.TotalEnviosCiudad);
            }
            chartNorthWind.Series["Series1"].Points.DataBindXY(x1.ToArray(), y1.ToArray());
            chartNorthWind.Series["Series1"].IsVisibleInLegend = false;
            chartNorthWind.ChartAreas[0].AxisX.Title = "Ciudad";
            chartNorthWind.ChartAreas[0].AxisY.Title = "Ventas totales por ciudad";
            chartNorthWind.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chartNorthWind.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chartNorthWind.Titles[0].Text = "Ventas totales por ciudad";
            chartNorthWind.Titles[0].Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
        }



        public static void ChartTotalEnviosPorPais(List<TotalEnviosPorPaisVO> listaTotalEnviosPorPais, Chart chartNorthWind)
        {
            List<string> x1 = new List<string>();
            List<decimal> y1 = new List<decimal>();
            foreach (TotalEnviosPorPaisVO totalEnviosPorPaisVO in listaTotalEnviosPorPais)
            {
                x1.Add(totalEnviosPorPaisVO.ShipCountry);
                y1.Add(totalEnviosPorPaisVO.TotalEnviosPais);
            }
            chartNorthWind.Series["Series1"].Points.DataBindXY(x1.ToArray(), y1.ToArray());
            chartNorthWind.Series["Series1"].IsVisibleInLegend = false;
            chartNorthWind.ChartAreas[0].AxisX.Title = "Pais";
            chartNorthWind.ChartAreas[0].AxisY.Title = "Ventas totales por país";
            chartNorthWind.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chartNorthWind.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chartNorthWind.Titles[0].Text = "Ventas totales por país";
            chartNorthWind.Titles[0].Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
        }

        public static void ChartTotalEnviosPorCompany(List<TotalEnviosPorCompanyVO> listaTotalEnviosPorCompany, Chart chartNorthWind)
        {
            List<string> x1 = new List<string>();
            List<decimal> y1 = new List<decimal>();
            foreach (TotalEnviosPorCompanyVO totalEnviosPorCompanyVO in listaTotalEnviosPorCompany)
            {
                x1.Add(totalEnviosPorCompanyVO.CompanyName);
                y1.Add(totalEnviosPorCompanyVO.TotalEnviosCompany);
            }
            chartNorthWind.Series["Series1"].Points.DataBindXY(x1.ToArray(), y1.ToArray());
            chartNorthWind.Series["Series1"].IsVisibleInLegend = false;
            chartNorthWind.ChartAreas[0].AxisX.Title = "Compañia";
            chartNorthWind.ChartAreas[0].AxisY.Title = "Ventas totales por compañia";
            chartNorthWind.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chartNorthWind.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chartNorthWind.Titles[0].Text = "Ventas totales por compañia de envío";
            chartNorthWind.Titles[0].Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
        }

        public static void ChartClientesConTotalCompra(List<ClientesConTotalCompraVO> listaClientesConTotalCompra, Chart chartNorthWind, int totalCompra, bool mayor)
        {
            List<string> x1 = new List<string>();
            List<decimal> y1 = new List<decimal>();
            foreach (ClientesConTotalCompraVO clientesConTotalCompraVO in listaClientesConTotalCompra)
            {
                x1.Add(clientesConTotalCompraVO.CustomerID.ToString());
                y1.Add(clientesConTotalCompraVO.TotalCompra);
            }
            chartNorthWind.Series["Series1"].Points.DataBindXY(x1.ToArray(), y1.ToArray());
            chartNorthWind.Series["Series1"].IsVisibleInLegend = false;
            chartNorthWind.ChartAreas[0].AxisX.Title = "Compañia";
            chartNorthWind.ChartAreas[0].AxisY.Title = "Ventas totales por cliente";
            chartNorthWind.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chartNorthWind.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            string mayInf = mayor == true ? "superiores" : "inferiores";
            chartNorthWind.Titles[0].Text = "Ventas por clientes " + mayInf + " a " + totalCompra + " euros";
            chartNorthWind.Titles[0].Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
        }


        public static void ChartProductosConStockMenor(List<ProductoConStockMenorVO> listaProductosConStockMenor, Chart chartNorthWind, int stock)
        {
            List<string> x1 = new List<string>();
            List<decimal> y1 = new List<decimal>();
            foreach (ProductoConStockMenorVO productoConStockMenor in listaProductosConStockMenor)
            {
                x1.Add(productoConStockMenor.ProductName);
                y1.Add(productoConStockMenor.UnitsInStock);
            }
            chartNorthWind.Series["Series1"].Points.DataBindXY(x1.ToArray(), y1.ToArray());
            chartNorthWind.Series["Series1"].IsVisibleInLegend = false;
            chartNorthWind.ChartAreas[0].AxisX.Title = "Producto";
            chartNorthWind.ChartAreas[0].AxisY.Title = "Stock";
            chartNorthWind.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chartNorthWind.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chartNorthWind.Titles[0].Text = "Productos con stock menor de " + stock;
            chartNorthWind.Titles[0].Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
        }

        public static void ChartProductosMasVendidos(List<ProductoMasVendidoVO> listaProductosMasVendidos, Chart chartNorthWind, int unidades, bool inferiores)
        {
            List<string> x1 = new List<string>();
            List<decimal> y1 = new List<decimal>();
            foreach (ProductoMasVendidoVO productoMasVendido in listaProductosMasVendidos)
            {
                x1.Add(productoMasVendido.ProductName);
                y1.Add(productoMasVendido.VentasUnidadesTotales);
            }
            chartNorthWind.Series["Series1"].Points.DataBindXY(x1.ToArray(), y1.ToArray());
            chartNorthWind.Series["Series1"].IsVisibleInLegend = false;
            chartNorthWind.ChartAreas[0].AxisX.Title = "Producto";
            chartNorthWind.ChartAreas[0].AxisY.Title = "Ventas totales";
            chartNorthWind.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chartNorthWind.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            string infSup = inferiores == true ? "inferiores" : "superiores";
            chartNorthWind.Titles[0].Text = "Productos más vendidos " + infSup + " a " + unidades + " unidades";
            chartNorthWind.Titles[0].Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
        }

        public static void ChartEmpleadoTotales(List<TotalVentasPorEmpleadoVO> listTotalVentasPorEmpleado, Chart chartNorthWind)
        {
            List<string> x1 = new List<string>();
            List<decimal> y1 = new List<decimal>();
            foreach (TotalVentasPorEmpleadoVO totalVentasPorEmpleado in listTotalVentasPorEmpleado)
            {
                x1.Add(totalVentasPorEmpleado.FirstName);
                y1.Add(totalVentasPorEmpleado.VentasTotales);
            }
            chartNorthWind.Series[0].Name = "Series1";
            chartNorthWind.Series["Series1"].Points.DataBindXY(x1.ToArray(), y1.ToArray());
            chartNorthWind.Series["Series1"].IsVisibleInLegend = true;
            chartNorthWind.ChartAreas[0].AxisX.Title = "Empleado";
            chartNorthWind.ChartAreas[0].AxisY.Title = "Ventas totales";
            chartNorthWind.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chartNorthWind.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chartNorthWind.Titles[0].Text ="Ventas totales por cada empleado";
            chartNorthWind.Titles[0].Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);

        }
        public static void ChartEmpleado(List<EmpleadoConTotalVentasPorProductoVO> listaEmpleadosConTotalVentasPorProducto, Chart chartNorthWind)
        {
            List<string> x1 = new List<string>();
            List<decimal> y1 = new List<decimal>();
            string nombreVendedor = "";
            foreach (EmpleadoConTotalVentasPorProductoVO empleadoConTotalVentasPorProducto in listaEmpleadosConTotalVentasPorProducto)
            {
                x1.Add(empleadoConTotalVentasPorProducto.ProductName);
                y1.Add(empleadoConTotalVentasPorProducto.VentasTotales);
                nombreVendedor = empleadoConTotalVentasPorProducto.FirstName;
            }
            chartNorthWind.Series["Series1"].Points.DataBindXY(x1.ToArray(), y1.ToArray());
            chartNorthWind.Series["Series1"].IsVisibleInLegend = false;
            chartNorthWind.ChartAreas[0].AxisX.Title = "Producto";
            chartNorthWind.ChartAreas[0].AxisY.Title = "Ventas totales";
            chartNorthWind.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chartNorthWind.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chartNorthWind.Titles[0].Text = "Ventas totales por producto del empleado " + nombreVendedor + " con ventas superiores a 200";
            chartNorthWind.Titles[0].Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
        }

        public static List<string> ObtenerNombresBotones(int tipo)
        {
            List<string> listNombresBotones; // = new List<string>();
            switch (tipo) {

                case Constantes.TIPO_EMPLEADO: // Empleados
                    // code block
                    listNombresBotones = ObtenerListaTituloBotones(Constantes.TITULO_BOTONES_EMPLEADO);
                    break;
                case Constantes.TIPO_PRODUCTO: // Productos
                    // code block
                    listNombresBotones = ObtenerListaTituloBotones(Constantes.TITULO_BOTONES_PRODUCTO);
                    break;
                case Constantes.TIPO_CLIENTE: // Clientes
                    // code block
                    listNombresBotones = ObtenerListaTituloBotones(Constantes.TITULO_BOTONES_CLIENTE);
                    break;
                case Constantes.TIPO_ENVIO: // Clientes
                    // code block
                    listNombresBotones = ObtenerListaTituloBotones(Constantes.TITULO_BOTONES_ENVIO);
                    break;
                default:
                    // code block
                    listNombresBotones = new List<string>();
                    break;

            }
            return listNombresBotones;
        }

        public static void PonerTituloBoton(string titulo, Button boton)
        {
            if (boton != null)
            {
                boton.Text = titulo;
                boton.Visible = true;
            }
        }

        private static List<string> ObtenerListaTituloBotones(string[] tituloBotones)
        {
            List<string> listNombresBotones = new List<string>();
            foreach (string titulo in tituloBotones)
            {
                listNombresBotones.Add(titulo);
            }
            return listNombresBotones;
        }

    }
}
