using DashBoard_lortega;
using DashBoard_lortega.VOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_DAL
{
    public class DashBoardDAL
    {
        //string conectionString = @"Data Source=192.168.0.19;Initial catalog=Northwind;User ID=lortega;Password=P@ssw0rd";
        string conectionString = @"Data Source=localhost;Initial catalog=Northwind;User ID=di;Password=1234";

        public List<TotalVentasPorEmpleadoVO> ConsultaTodosEmpleados()
        {
            return ConsTodosEmpleados();
            
        }

        public List<EmpleadoConTotalVentasPorProductoVO> ConsultaEmpleadosConTotalVentasPorProducto(int idEmpleado)
        {
            return ConsEmpleadosConTotalVentasPorProducto(idEmpleado);
        }

        public List<ProductoMasVendidoVO> ConsultaProductosMasVendidos(int unidades, bool inferiores)
        {
            return ConsProductosMasVendidos(unidades, inferiores);
        }

        public List<ProductoConStockMenorVO> ConsultaProductosConStockMenor(int stock)
        {
            return ConsProductosConStockMenor(stock);
        }

        public List<ClientesConTotalCompraVO> ConsultaClientesConTotalCompras(int totalCompra, bool mayor)
        {
            return ConsClientesConTotalCompras(totalCompra, mayor);
        }

        public List<TotalEnviosPorCompanyVO> ConsultaTotalEnviosPorCompany()
        {
            return ConsTotalEnviosPorCompany();
        }

        public List<TotalEnviosPorPaisVO> ConsultaTotalEnviosPorPais()
        {
            return ConsTotalEnviosPorPais();
        }

        public List<TotalEnviosPorCiudadVO> ConsultaTotalEnviosPorCiudad()
        {
            return ConsTotalEnviosPorCiudad();
        }


        /**
         * Metodos de consulta 
         *
         */
        private List<TotalEnviosPorCiudadVO> ConsTotalEnviosPorCiudad()
        {
            List<TotalEnviosPorCiudadVO> listaTotalEnviosPorCiudad = new List<TotalEnviosPorCiudadVO>();

            using (SqlConnection conn = new SqlConnection(conectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(ConstantesSQL.sqlTotalEnviosPorCiudad, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TotalEnviosPorCiudadVO totalEnviosPorCiudadVO = new TotalEnviosPorCiudadVO();
                            totalEnviosPorCiudadVO.ShipCity = reader.GetString(0);
                            totalEnviosPorCiudadVO.TotalEnviosCiudad = reader.GetDecimal(1);
                            Console.WriteLine(reader.GetValue(0) + " \t" + reader.GetValue(1));
                            listaTotalEnviosPorCiudad.Add(totalEnviosPorCiudadVO);
                        }
                    }
                }
            }
            return listaTotalEnviosPorCiudad;
        }

        private List<TotalEnviosPorPaisVO> ConsTotalEnviosPorPais()
        {
            List<TotalEnviosPorPaisVO> listaTotalEnviosPorPais = new List<TotalEnviosPorPaisVO>();

            using (SqlConnection conn = new SqlConnection(conectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(ConstantesSQL.sqlTotalEnviosPorPais, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TotalEnviosPorPaisVO totalEnviosPorPaisVO = new TotalEnviosPorPaisVO();
                            totalEnviosPorPaisVO.ShipCountry= reader.GetString(0);
                            totalEnviosPorPaisVO.TotalEnviosPais = reader.GetDecimal(1);
                            Console.WriteLine(reader.GetValue(0) + " \t" + reader.GetValue(1));
                            listaTotalEnviosPorPais.Add(totalEnviosPorPaisVO);
                        }
                    }
                }
            }
            return listaTotalEnviosPorPais;
        }

        private List<TotalEnviosPorCompanyVO> ConsTotalEnviosPorCompany()
        {
            List<TotalEnviosPorCompanyVO> listaTotalEnviosPorCompany = new List<TotalEnviosPorCompanyVO>();

            using (SqlConnection conn = new SqlConnection(conectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(ConstantesSQL.sqlTotalEnviosPorCompany, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TotalEnviosPorCompanyVO totalEnviosPorCompanyVO = new TotalEnviosPorCompanyVO();
                            totalEnviosPorCompanyVO.ShipperID = reader.GetInt32(0);
                            totalEnviosPorCompanyVO.CompanyName = reader.GetString(1);
                            totalEnviosPorCompanyVO.TotalEnviosCompany = reader.GetDecimal(2);
                            Console.WriteLine(reader.GetValue(0) + " \t" + reader.GetValue(1) + " \t" +
                                              reader.GetValue(2));
                            listaTotalEnviosPorCompany.Add(totalEnviosPorCompanyVO);
                        }
                    }
                }
            }
            return listaTotalEnviosPorCompany;
        }

        private List<ClientesConTotalCompraVO> ConsClientesConTotalCompras(int totalCompra, bool mayor)
        {
            List<ClientesConTotalCompraVO> listaClientesConTotalCompra = new List<ClientesConTotalCompraVO>();

            using (SqlConnection conn = new SqlConnection(conectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = mayor==true ? ConstantesSQL.sqlClientesConTotalComprasMayor : ConstantesSQL.sqlClientesConTotalComprasMenor;
                    cmd.Parameters.AddWithValue("@totalCompra", totalCompra);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClientesConTotalCompraVO clientesConTotalCompraVO = new ClientesConTotalCompraVO();

                            clientesConTotalCompraVO.CustomerID = reader.GetString(0);
                            clientesConTotalCompraVO.CompanyName = reader.GetString(1);
                            clientesConTotalCompraVO.TotalCompra = reader.GetDecimal(2);
                            Console.WriteLine(reader.GetValue(0) + " \t" + reader.GetValue(1) + " \t" +
                                              reader.GetValue(2));
                            listaClientesConTotalCompra.Add(clientesConTotalCompraVO);
                        }
                    }
                }
            }
            return listaClientesConTotalCompra;
        }


        private List<ProductoConStockMenorVO> ConsProductosConStockMenor(int stock)
        {
            List<ProductoConStockMenorVO> listaProductosConStockMenor = new List<ProductoConStockMenorVO>();

            using (SqlConnection conn = new SqlConnection(conectionString))
            {
                conn.Open();
                   using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = ConstantesSQL.sqlProductosConStockMenor;
                    cmd.Parameters.AddWithValue("@stock", stock);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProductoConStockMenorVO productoConStockMenorVO = new ProductoConStockMenorVO();
                            productoConStockMenorVO.ProductID = reader.GetInt32(0);
                            productoConStockMenorVO.ProductName = reader.GetString(1);
                            productoConStockMenorVO.UnitsInStock = reader.GetInt16(2);
                            Console.WriteLine(reader.GetValue(0) + " \t" + reader.GetValue(1) + " \t" +
                                              reader.GetValue(2));
                            listaProductosConStockMenor.Add(productoConStockMenorVO);
                        }
                    }
                }
            }
            return listaProductosConStockMenor;
        }

        private List<EmpleadoConTotalVentasPorProductoVO> ConsEmpleadosConTotalVentasPorProducto(int idEmpleado)
        {
            List<EmpleadoConTotalVentasPorProductoVO> listaEmpleadosConTotalVentasPorProducto = new List<EmpleadoConTotalVentasPorProductoVO>();

            using (SqlConnection conn = new SqlConnection(conectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = ConstantesSQL.sqlEmpleadoConTotalVentasPorProducto;
                    cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmpleadoConTotalVentasPorProductoVO empleadoConTotalVentasPorProducto = new EmpleadoConTotalVentasPorProductoVO();
                            empleadoConTotalVentasPorProducto.EmployeeID = reader.GetInt32(0);
                            empleadoConTotalVentasPorProducto.LastName = reader.GetString(1);
                            empleadoConTotalVentasPorProducto.FirstName = reader.GetString(2);
                            empleadoConTotalVentasPorProducto.ProductID = reader.GetInt32(3);
                            empleadoConTotalVentasPorProducto.ProductName = reader.GetString(4);
                            empleadoConTotalVentasPorProducto.VentasTotales = reader.GetDecimal(5);
                            Console.WriteLine(reader.GetValue(0) + " \t" + reader.GetValue(1) + " \t" + 
                                              reader.GetValue(2) + " \t" + reader.GetValue(3) + " \t" +
                                              reader.GetValue(4) + " \t" + reader.GetValue(5));
                            listaEmpleadosConTotalVentasPorProducto.Add(empleadoConTotalVentasPorProducto);
                        }
                    }
                }
            }
            return listaEmpleadosConTotalVentasPorProducto;
        }

        private List<TotalVentasPorEmpleadoVO> ConsTodosEmpleados()
        {
            List<TotalVentasPorEmpleadoVO> listaVentasPorEmpleado = new List<TotalVentasPorEmpleadoVO>();

            using (SqlConnection conn = new SqlConnection(conectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(ConstantesSQL.sqlTodosEmpleadosConTotalVentas, conn))
                {   
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TotalVentasPorEmpleadoVO totalVentasPorEmpleado = new TotalVentasPorEmpleadoVO();
                            totalVentasPorEmpleado.EmployeeID = reader.GetInt32(0);
                            totalVentasPorEmpleado.LastName = reader.GetString(1);
                            totalVentasPorEmpleado.FirstName = reader.GetString(2);
                            totalVentasPorEmpleado.VentasTotales = reader.GetDecimal(3);
                            Console.WriteLine(reader.GetValue(0) + " \t" + reader.GetValue(1) + " \t" + reader.GetValue(2) + " \t" + reader.GetValue(3));
                            listaVentasPorEmpleado.Add(totalVentasPorEmpleado);
                        }
                    }
                }
            }
            return listaVentasPorEmpleado;
        }
        
        private List<ProductoMasVendidoVO> ConsProductosMasVendidos(int unidades, bool inferiores)
        {
            List<ProductoMasVendidoVO> listaProductosMasVendidos = new List<ProductoMasVendidoVO>();

            using (SqlConnection conn = new SqlConnection(conectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = inferiores==true ? ConstantesSQL.sqlProductosMasVendidosInferiores : ConstantesSQL.sqlProductosMasVendidos;
                    cmd.Parameters.AddWithValue("@unidades", unidades);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProductoMasVendidoVO productoMasVendido = new ProductoMasVendidoVO();
                            productoMasVendido.ProductID = reader.GetInt32(0);
                            productoMasVendido.ProductName = reader.GetString(1);
                            productoMasVendido.VentasUnidadesTotales = reader.GetInt32(2);
                            Console.WriteLine(reader.GetValue(0) + " \t" + reader.GetValue(1) + " \t" + reader.GetValue(2));
                            listaProductosMasVendidos.Add(productoMasVendido);
                        }
                    }
                }
            }
            return listaProductosMasVendidos;
        }

    }
}
