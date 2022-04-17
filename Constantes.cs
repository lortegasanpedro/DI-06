using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_lortega
{
    public static class Constantes
    {
        public const int TIPO_EMPLEADO = 0;
        public const int TIPO_PRODUCTO = 1;
        public const int TIPO_CLIENTE = 2;
        public const int TIPO_ENVIO = 3;
        public const int TIPO_INFORMES = 4;


        public static string[] NOMBRES_INFORMES = { "Inf1VentasTotalesPorCategoriaYAgno.rpt",
                                                    "Inf2ProductosCompradosPorUnCliente.rpt",
                                                    "Inf3VentasTotalesPorCadaEmpleado.rpt",
                                                    "Inf4VentasTotalesPorClientes.rpt"};

        public static string[] TITULO_BOTONES_EMPLEADO = {"Total de ventas por empleado",
                                                    "Ventas totales por producto del empleado Nancy",
                                                    "Ventas totales por producto del empleado Janet",
                                                    "Ventas totales por producto del empleado Margaret",
                                                    "Ventas totales por producto del empleado Steve",
                                                    "Ventas totales por producto del empleado Michael",
                                                    "Ventas totales por producto del empleado Robert",
                                                    "Ventas totales por producto del empleado Laura",
                                                    "Ventas totales por producto del empleado Anne",
                                                    "Ventas totales por producto del empleado Andrew"};


        public static string[] TITULO_BOTONES_PRODUCTO = {"Productos más vendidos superiores a 1.000 unidades",
                                                    "Productos más vendidos superiores a 500 unidades",
                                                    "Productos vendidos inferiores a 1.000 unidades",
                                                    "Productos vendidos inferiores a 500 unidades",
                                                    "Productos con stock menor de 10",
                                                    "Productos con stock menor de 20",
                                                    "Productos con stock menor de 40",
                                                    "Productos con stock menor de 80",
                                                    "Productos con stock menor de 100"};

        public static string[] TITULO_BOTONES_CLIENTE = {"Ventas por clientes superiores a 10.000 euros",
                                                    "Ventas por clientes superiores a 20.000 euros",
                                                    "Ventas por clientes superiores a 40.000 euros",
                                                    "Ventas por clientes inferiores a 10.000 euros",
                                                    "Ventas por clientes inferiores a 5.000 euros",
                                                    "Ventas por clientes inferiores a 1.000 euros",
                                                    "Ventas por clientes inferiores a 500 euros"};

        public static string[] TITULO_BOTONES_ENVIO = {"Ventas totales por compania de envío",
                                                    "Ventas totales por pais",
                                                    "Ventas totales por ciudad"};


        public static string[] TITULO_BOTONES_INFORMES = {"Ventas Totales Por Categoría y Año",
                                                          "Productos Comprados Por un Cliente",
                                                          "Ventas Totales por Cada Empleado",
                                                          "Ventas Totales por Clientes"};

        public const int EMPLEADO_NANCY_ID = 1;
        public const int EMPLEADO_ANDREW_ID = 2;
        public const int EMPLEADO_JANET_ID = 3;
        public const int EMPLEADO_MARGARET_ID = 4;
        public const int EMPLEADO_STEVEN_ID = 5;
        public const int EMPLEADO_MICHAEL_ID = 6;
        public const int EMPLEADO_ROBERT_ID = 7;
        public const int EMPLEADO_LAURA_ID = 8;
        public const int EMPLEADO_ANNE_ID = 9;



    }
}
