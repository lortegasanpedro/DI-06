using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_lortega
{
	public static class ConstantesSQL
	{
		public const string sqlTodosEmpleadosConTotalVentas = "SELECT [Northwind].[dbo].[Employees].[EmployeeID] " +
													",[Northwind].[dbo].[Employees].[LastName] " +
													",[Northwind].[dbo].[Employees].[FirstName] " +
													",sum([Northwind].[dbo].[Products].[UnitPrice]) AS VentasTotales " +
													"		FROM[Northwind].[dbo].[Employees] INNER JOIN[Northwind].[dbo].[Orders] " +
																"ON[Northwind].[dbo].[Employees].[EmployeeID]=[Northwind].[dbo].[Orders].[EmployeeID] " +
																"INNER JOIN[Northwind].[dbo].[Order Details] " +
																"ON[Northwind].[dbo].[Orders].OrderID = [Northwind].[dbo].[Order Details].OrderID " +
																"INNER JOIN[Northwind].[dbo].[Products] " +
																"ON[Northwind].[dbo].[Order Details].ProductID = [Northwind].[dbo].[Products].[ProductID] " +
																		  "GROUP BY[Northwind].[dbo].[Employees].[EmployeeID] " +
																				",[Northwind].[dbo].[Employees].[LastName] " +
																				",[Northwind].[dbo].[Employees].[FirstName];";
		// Comentario de prueba

		// Comentario de prueba 2

		public const string sqlEmpleadoConTotalVentasPorProducto = "SELECT [Northwind].[dbo].[Employees].[EmployeeID] " +
																	",[Northwind].[dbo].[Employees].[LastName] " +
																	",[Northwind].[dbo].[Employees].[FirstName] " +
																	",[Northwind].[dbo].[Products].[ProductID] " +
																	",[Northwind].[dbo].[Products].[ProductName] " +
																	",sum([Northwind].[dbo].[Products].[UnitPrice]) AS VentasTotales " +
																	"		FROM[Northwind].[dbo].[Employees] INNER JOIN[Northwind].[dbo].[Orders] " +
																				"ON[Northwind].[dbo].[Employees].[EmployeeID]=[Northwind].[dbo].[Orders].[EmployeeID] " +
																				"INNER JOIN[Northwind].[dbo].[Order Details] " +
																				"ON[Northwind].[dbo].[Orders].OrderID = [Northwind].[dbo].[Order Details].OrderID " +
																				"INNER JOIN[Northwind].[dbo].[Products] " +
																				"ON[Northwind].[dbo].[Order Details].ProductID = [Northwind].[dbo].[Products].[ProductID] " +
																				"WHERE[Northwind].[dbo].[Employees].[EmployeeID] = @idEmpleado " +
																						  "GROUP BY[Northwind].[dbo].[Employees].[EmployeeID] " +
																								",[Northwind].[dbo].[Employees].[LastName] " +
																								",[Northwind].[dbo].[Employees].[FirstName] " +
																								",[Northwind].[dbo].[Products].[ProductID] " +
																								",[Northwind].[dbo].[Products].[ProductName] " +
																								" HAVING SUM([Northwind].[dbo].[Products].[UnitPrice]) > 200;";

		public const string sqlProductosMasVendidos = "SELECT [Northwind].[dbo].[Products].[ProductID] " +
															   " ,[Northwind].[dbo].[Products].[ProductName] " +
															   " ,SUM([Northwind].[dbo].[Order Details].[Quantity]) as VentasUnidadesTotales " +
															   "       FROM[Northwind].[dbo].[Products] " +
															   "       INNER JOIN[Northwind].[dbo].[Order Details] " +
															   "       ON[Northwind].[dbo].[Products].[ProductID] = [Northwind].[dbo].[Order Details].[ProductID] " +
															   "         group by[Northwind].[dbo].[Products].[ProductID] " +
															   "            ,[Northwind].[dbo].[Products].[ProductName] " +
															   "         HAVING SUM([Northwind].[dbo].[Order Details].[Quantity]) > @unidades;";

		public const string sqlProductosMasVendidosInferiores = "SELECT [Northwind].[dbo].[Products].[ProductID] " +
																	   " ,[Northwind].[dbo].[Products].[ProductName] " +
																	   " ,SUM([Northwind].[dbo].[Order Details].[Quantity]) as VentasUnidadesTotales " +
																	   "       FROM[Northwind].[dbo].[Products] " +
																	   "       INNER JOIN[Northwind].[dbo].[Order Details] " +
																	   "       ON[Northwind].[dbo].[Products].[ProductID] = [Northwind].[dbo].[Order Details].[ProductID] " +
																	   "         group by[Northwind].[dbo].[Products].[ProductID] " +
																	   "            ,[Northwind].[dbo].[Products].[ProductName] " +
																	   "         HAVING SUM([Northwind].[dbo].[Order Details].[Quantity]) < @unidades;";

		public const string sqlProductosConStockMenor = "SELECT [ProductID]" +
																 " ,[ProductName]" +
																 " ,[UnitsInStock]" +
																 " FROM [Northwind].[dbo].[Products] where [UnitsInStock] < @stock ;";

		public const string sqlClientesConTotalComprasMayor = "SELECT DISTINCT " +
															"[Northwind].[dbo].[Customers].[CustomerID] " +
															",[Northwind].[dbo].[Customers].[CompanyName] " +
															",SUM ( ([Northwind].[dbo].[Order Details].[UnitPrice] * [Northwind].[dbo].[Order Details].[Quantity]) ) as TotalCompra " +
															"FROM [Northwind].[dbo].[Customers] " +
																   "INNER JOIN [Northwind].[dbo].[Orders] " +
																   "ON [Northwind].[dbo].[Customers].[CustomerID] = [Northwind].[dbo].[Orders].[CustomerID] " +
																   "INNER JOIN [Northwind].[dbo].[Order Details] " +
																   "ON [Northwind].[dbo].[Orders].[OrderID] = [Northwind].[dbo].[Order Details].[OrderID] " +
																   "INNER JOIN [Northwind].[dbo].[Products] " +
																   "ON [Northwind].[dbo].[Order Details].[ProductID] = [Northwind].[dbo].[Products].[ProductID] " +
																   "GROUP BY [Northwind].[dbo].[Customers].[CustomerID] " +
																			",[Northwind].[dbo].[Customers].[CompanyName] " +
																   "HAVING SUM ( ([Northwind].[dbo].[Order Details].[UnitPrice] * [Northwind].[dbo].[Order Details].[Quantity]) ) > @totalCompra";


		public const string sqlClientesConTotalComprasMenor = "SELECT DISTINCT " +
																"[Northwind].[dbo].[Customers].[CustomerID] " +
																",[Northwind].[dbo].[Customers].[CompanyName] " +
																",SUM ( ([Northwind].[dbo].[Order Details].[UnitPrice] * [Northwind].[dbo].[Order Details].[Quantity]) ) as TotalCompra " +
																"FROM [Northwind].[dbo].[Customers] " +
																	   "INNER JOIN [Northwind].[dbo].[Orders] " +
																	   "ON [Northwind].[dbo].[Customers].[CustomerID] = [Northwind].[dbo].[Orders].[CustomerID] " +
																	   "INNER JOIN [Northwind].[dbo].[Order Details] " +
																	   "ON [Northwind].[dbo].[Orders].[OrderID] = [Northwind].[dbo].[Order Details].[OrderID] " +
																	   "INNER JOIN [Northwind].[dbo].[Products] " +
																	   "ON [Northwind].[dbo].[Order Details].[ProductID] = [Northwind].[dbo].[Products].[ProductID] " +
																	   "GROUP BY [Northwind].[dbo].[Customers].[CustomerID] " +
																				",[Northwind].[dbo].[Customers].[CompanyName] " +
																	   "HAVING SUM ( ([Northwind].[dbo].[Order Details].[UnitPrice] * [Northwind].[dbo].[Order Details].[Quantity]) ) < @totalCompra";


		public const string sqlTotalEnviosPorCompany = "SELECT  [ShipperID] " +
													   ",[CompanyName] " +
													   ",SUM(([Northwind].[dbo].[Products].[UnitPrice] *[UnitsInStock]) ) AS TotalEnviosPorCompany " +
													   "FROM[Northwind].[dbo].[Shippers] " +
													   "INNER JOIN[Northwind].[dbo].[Orders] " +
													   "ON[Northwind].[dbo].[Shippers].[ShipperID] = [Northwind].[dbo].[Orders].[ShipVia] " +
													   "INNER JOIN[Northwind].[dbo].[Order Details] " +
													   "ON[Northwind].[dbo].[Orders].[OrderID] = [Northwind].[dbo].[Order Details].[OrderID] " +
													   "INNER JOIN[Northwind].[dbo].[Products] " +
													   "ON[Northwind].[dbo].[Order Details].[ProductID] = [Northwind].[dbo].[Products].[ProductID] " +
															//"WHERE[Northwind].[dbo].[Products].[ProductID] IN(1,2,3,4,5,6) " +
															"GROUP BY  [ShipperID] " +
																	 ",[CompanyName] " +
																	 "ORDER BY[ShipperID] DESC ";

		public const string sqlTotalEnviosPorPais = "SELECT [ShipCountry] " +
											   ",SUM(([Northwind].[dbo].[Products].[UnitPrice] *[UnitsInStock]) ) AS TotalEnviosPorPais " +
											   "FROM[Northwind].[dbo].[Shippers] " +
											   "INNER JOIN[Northwind].[dbo].[Orders] " +
											   "ON[Northwind].[dbo].[Shippers].[ShipperID] = [Northwind].[dbo].[Orders].[ShipVia] " +
											   "INNER JOIN[Northwind].[dbo].[Order Details] " +
											   "ON[Northwind].[dbo].[Orders].[OrderID] = [Northwind].[dbo].[Order Details].[OrderID] " +
											   "INNER JOIN[Northwind].[dbo].[Products] " +
											   "ON[Northwind].[dbo].[Order Details].[ProductID] = [Northwind].[dbo].[Products].[ProductID] " +
													//"WHERE[Northwind].[dbo].[Products].[ProductID] IN(1,2,3,4,5,6) " +
													"GROUP BY  [ShipCountry] ";

		public const string sqlTotalEnviosPorCiudad = "SELECT [ShipCity] " +
									   ",SUM(([Northwind].[dbo].[Products].[UnitPrice] *[UnitsInStock]) ) AS TotalEnviosPorPais " +
									   "FROM[Northwind].[dbo].[Shippers] " +
									   "INNER JOIN[Northwind].[dbo].[Orders] " +
									   "ON[Northwind].[dbo].[Shippers].[ShipperID] = [Northwind].[dbo].[Orders].[ShipVia] " +
									   "INNER JOIN[Northwind].[dbo].[Order Details] " +
									   "ON[Northwind].[dbo].[Orders].[OrderID] = [Northwind].[dbo].[Order Details].[OrderID] " +
									   "INNER JOIN[Northwind].[dbo].[Products] " +
									   "ON[Northwind].[dbo].[Order Details].[ProductID] = [Northwind].[dbo].[Products].[ProductID] " +
											//"WHERE[Northwind].[dbo].[Products].[ProductID] IN(1,2,3,4,5,6) " +
											"GROUP BY [ShipCity] ";

	}
}
