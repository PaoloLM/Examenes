namespace ExamenU2Web2_Lizarraga.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Operacion")]
    public partial class Operacion
    {
        [Key]
        public int operacion_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal operador1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal operador2 { get; set; }

        public int tipooperacion_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal resultado { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha { get; set; }

        public TimeSpan? hora { get; set; }

        [StringLength(10)]
        public string estado { get; set; }

        public virtual TipoOperacion TipoOperacion { get; set; }
        
        
        public List<Operacion> Listar()
        {
            var operacion = new List<Operacion>();

            try
            {
                using (var db = new Datos())
                {                    
                    operacion = db.Operacion.Include("TipoOperacion").ToList();
                }
            }
            catch (Exception e)
            {
                throw;
            }

            return operacion;
        }



        public List<Operacion> BuscarTipo(string criterio)
        {
            var operacion = new List<Operacion>();

            try
            {
                using (var db = new Datos())
                {
                    operacion = db.Operacion.Include("TipoOperacion")
                        .Where(x => x.TipoOperacion.nombre.Contains(criterio))
                        .ToList();
                }
            }
            catch (Exception e)
            {
                throw;
            }

            return operacion;
        }



        public List<Operacion> BuscarFecha(string criterio)
        {
            var operacion = new List<Operacion>();

            try
            {
                using (var db = new Datos())
                {
                    operacion = db.Operacion.Include("TipoOperacion")
                        .Where(x => x.fecha.ToString().Contains(criterio))
                        .ToList();
                }
            }
            catch (Exception e)
            {
                throw;
            }

            return operacion;
        }



        public void Guardar()
        {
            DateTime now = DateTime.Now;
            
            try
            {
                using (var db = new Datos())
                {
                    if (this.operacion_id > 0)
                    {
                        if (this.tipooperacion_id == 1)
                        {
                            this.resultado = this.operador1 + this.operador2;
                        }

                        if (this.tipooperacion_id == 2)
                        {
                            this.resultado = this.operador1 - this.operador2;
                        }

                        if (this.tipooperacion_id == 3)
                        {
                            this.resultado = this.operador1 * this.operador2;
                        }

                        if (this.tipooperacion_id == 4)
                        {
                            this.resultado = this.operador1 / this.operador2;
                        }

                        TimeSpan ts = new TimeSpan(now.Hour, now.Minute, now.Second);
                        this.fecha = Convert.ToDateTime(now.ToString("yyyy/MM/dd"));
                        this.hora = ts;

                        db.Entry(this).State = EntityState.Modified;
                    }

                    else
                    {
                        if (this.tipooperacion_id == 1)
                        {
                            this.resultado = this.operador1 + this.operador2;
                        }

                        if (this.tipooperacion_id == 2)
                        {
                            this.resultado = this.operador1 - this.operador2;
                        }

                        if (this.tipooperacion_id == 3)
                        {
                            this.resultado = this.operador1 * this.operador2;
                        }

                        if (this.tipooperacion_id == 4)
                        {
                            this.resultado = this.operador1 / this.operador2;
                        }

                        TimeSpan ts = new TimeSpan(now.Hour, now.Minute, now.Second);
                        this.fecha = Convert.ToDateTime(now.ToString("yyyy/MM/dd"));
                        this.hora = ts;

                        db.Entry(this).State = EntityState.Added;
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public Operacion Obtener(int id)
        {
            var operacion = new Operacion();

            try
            {
                using (var db = new Datos())
                {
                    operacion = db.Operacion.Include("TipoOperacion")
                        .Where(x => x.operacion_id == id)
                        .SingleOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return operacion;
        }


        public void Eliminar()
        {
            try
            {
                using (var db = new Datos())
                {
                    db.Entry(this).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
