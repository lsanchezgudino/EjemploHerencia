using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace EjemplodeHerencia
{
    class EmpleadoPorComision4
    {
        private string primerNombre;
        private string apellidoPaterno;
        private string numeroSeguroSocial;
        private decimal ventasBrutas; // ventas semanales totales
        private decimal tarifaComision; // porcentaje de comision
 
        // constructor con cinco parametros
        public EmpleadoPorComision4(string nombre, string apellido, string nss,
           decimal ventas, decimal tarifa)
        {
            // la llamada implícita al constructor del objeto se realiza aquí
            primerNombre = nombre;
            apellidoPaterno = apellido;
            numeroSeguroSocial = nss;
            VentasBrutas = ventas; // valida las ventas brutas a través de una propiedad
            TarifaComision = tarifa; // valida la tarifa de comisión a través de una propiedad
 
            Console.WriteLine("\nConstructor de EmpleadoPorComision4:\n" + this);
        } // fin del constructor de EmpleadoPorComision4 con cinco parámetros
 
        // propiedad de sólo lectura que obtiene el primer nombre del empleado por comisión
        public string PrimerNombre
        {
            get
            {
                return primerNombre;
            } // fin de get
        } // fin de la propiedad PrimerNombre
 
        // propiedad de sólo lectura que obtiene el apellid paterno del empleado por comisión
        public string ApellidoPaterno
        {
            get
            {
                return apellidoPaterno;
            } // fin de get
        } // fin de la propiedad ApellidoPaterno
 
        // propiedad de sólo lectura que obtiene el 
        // número de seguro social del empleado por comisión
        public string NumeroSeguroSocial
        {
            get
            {
                return numeroSeguroSocial;
            } // fin de get
        } // fin de la propiedad NumeroSeguroSocial
 
        // propiedad que obtiene y establece las ventas brutas del empleado por comisión
        public decimal VentasBrutas
        {
            get
            {
                return ventasBrutas;
            } // fin de get
            set
            {
                ventasBrutas = (value < 0) ? 0 : value;
            } // fin de set
        } // fin de la propiedad VentasBrutas
 
        // propiedad que obtiene y establece la tarifa de comisión de un empleado por comisión
        public decimal TarifaComision
        {
            get
            {
                return tarifaComision;
            } // fin de get
            set
            {
                tarifaComision = (value > 0 && value < 1) ? value : 0;
            } // fin de set
        } // fin de la propiedad TarifaComision
 
        // calcula el salario del empleado por comisión
        public virtual decimal Ingresos()
        {
            return TarifaComision * VentasBrutas;
        } // fin del método Ingresos
 
        // devuelve representación string del objeto EmpleadoPorComision
        public override string ToString()
        {
            return string.Format(
               "{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}",
               "empleado por comisión", PrimerNombre, ApellidoPaterno,
               "número de seguro social", NumeroSeguroSocial,
               "ventas brutas", VentasBrutas, "tarifa de comisión", TarifaComision);
        } // fin del método ToString
    }
}
 
