using DashBoard_DAL;
using DashBoard_lortega.VOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_BLL
{
    public class DashBoardBLL
    {
        public List<TotalVentasPorEmpleadoVO> ConsultaTodosEmpleados()
        {
            DashBoardDAL dashBoardDAL = new DashBoardDAL();
            return dashBoardDAL.ConsultaTodosEmpleados();
        }

        public List<EmpleadoConTotalVentasPorProductoVO> ConsultaEmpleadosConTotalVentasPorProducto(int idEmpleado)
        {
            DashBoardDAL dashBoardDAL = new DashBoardDAL();
            return dashBoardDAL.ConsultaEmpleadosConTotalVentasPorProducto(idEmpleado);
        }

        public List<ProductoMasVendidoVO> ConsultaProductosMasVendidos(int unidades, bool inferiores)
        {
            DashBoardDAL dashBoardDAL = new DashBoardDAL();
            return dashBoardDAL.ConsultaProductosMasVendidos(unidades, inferiores);
        }

        public List<ProductoConStockMenorVO> ConsultaProductosConStockMenor(int stock)
        {
            DashBoardDAL dashBoardDAL = new DashBoardDAL();
            return dashBoardDAL.ConsultaProductosConStockMenor(stock);
        }

        public List<ClientesConTotalCompraVO> ConsultaClientesConTotalCompras(int totalCompra, bool mayor)
        {
            DashBoardDAL dashBoardDAL = new DashBoardDAL();
            return dashBoardDAL.ConsultaClientesConTotalCompras(totalCompra, mayor);
        }

        public List<TotalEnviosPorCompanyVO> ConsultaTotalEnviosPorCompany()
        {
            DashBoardDAL dashBoardDAL = new DashBoardDAL();
            return dashBoardDAL.ConsultaTotalEnviosPorCompany();
        }

        public List<TotalEnviosPorPaisVO> ConsultaTotalEnviosPorPais()
        {
            DashBoardDAL dashBoardDAL = new DashBoardDAL();
            return dashBoardDAL.ConsultaTotalEnviosPorPais();
        }

        public List<TotalEnviosPorCiudadVO> ConsultaTotalEnviosPorCiudad()
        {
            DashBoardDAL dashBoardDAL = new DashBoardDAL();
            return dashBoardDAL.ConsultaTotalEnviosPorCiudad();
        }

    }
}
