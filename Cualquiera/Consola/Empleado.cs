//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Consola
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        private DateTime ingreso;
        private DateTime egreso;
        private int sucursal;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            this.Encargadoes = new HashSet<Encargado>();
        }

        public Empleado(int id, string nombre, string apellido, DateTime ingreso, DateTime egreso, bool estado, string telefono, string cuil, int sucursal)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            this.ingreso = ingreso;
            this.egreso = egreso;
            Estado = estado;
            Telefono = telefono;
            Cuil = cuil;
            this.sucursal = sucursal;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public System.DateTime Fecha_de_Ingreso { get; set; }
        public Nullable<System.DateTime> Fecha_de_Egreso { get; set; }
        public bool Estado { get; set; }
        public string Telefono { get; set; }
        public string Cuil { get; set; }
        public int Id_Sucursal { get; set; }
    
        public virtual Sucursal Sucursal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Encargado> Encargadoes { get; set; }
    }
}
