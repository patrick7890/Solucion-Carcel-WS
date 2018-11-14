using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCarcel
{
    [Serializable]
    public class Visita
    {

        private const long serialVersionUID = 1L;
        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @Id @Basic(optional = false) @NotNull @Size(min = 1, max = 25) @Column(name = "ID_VISITA") private String idVisita;
        private string idVisita;
        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @Basic(optional = false) @NotNull @Size(min = 1, max = 255) @Column(name = "OBSERVACION") private String observacion;
        private string observacion;
        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @Basic(optional = false) @NotNull @Size(min = 1, max = 25) @Column(name = "NOMBRE_V") private String nombreV;
        private string nombreV;
        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @Basic(optional = false) @NotNull @Column(name = "EDAD") private short edad;
        private short edad;
        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @Basic(optional = false) @NotNull @Column(name = "TIEMPO_VISITA") private short tiempoVisita;
        private short tiempoVisita;
        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @JoinColumn(name = "HORARIO_ID_HORARIO", referencedColumnName = "ID_HORARIO") @ManyToOne(optional = false) private Horario horarioIdHorario;
        private Horario horarioIdHorario;
        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @JoinColumn(name = "PRESO_ID_PRESO", referencedColumnName = "ID_PRESO") @ManyToOne(optional = false) private Preso presoIdPreso;
        private Preso presoIdPreso;

        public Visita()
        {
        }

        public Visita(string idVisita)
        {
            this.idVisita = idVisita;
        }

        public Visita(string idVisita, string observacion, string nombreV, short edad, short tiempoVisita)
        {
            this.idVisita = idVisita;
            this.observacion = observacion;
            this.nombreV = nombreV;
            this.edad = edad;
            this.tiempoVisita = tiempoVisita;
        }

        public Visita(string id, string observacion, string nombre, short edad)
        {
            this.idVisita = id;
            this.observacion = observacion;
            this.nombreV = nombre;
            this.edad = edad;
        }

        public virtual string IdVisita
        {
            get
            {
                return idVisita;
            }
            set
            {
                this.idVisita = value;
            }
        }


        public virtual string Observacion
        {
            get
            {
                return observacion;
            }
            set
            {
                this.observacion = value;
            }
        }


        public virtual string NombreV
        {
            get
            {
                return nombreV;
            }
            set
            {
                this.nombreV = value;
            }
        }


        public virtual short Edad
        {
            get
            {
                return edad;
            }
            set
            {
                this.edad = value;
            }
        }


        public virtual short TiempoVisita
        {
            get
            {
                return tiempoVisita;
            }
            set
            {
                this.tiempoVisita = value;
            }
        }


        public virtual Horario HorarioIdHorario
        {
            get
            {
                return horarioIdHorario;
            }
            set
            {
                this.horarioIdHorario = value;
            }
        }


        public virtual Preso PresoIdPreso
        {
            get
            {
                return presoIdPreso;
            }
            set
            {
                this.presoIdPreso = value;
            }
        }


        public override int GetHashCode()
        {
            int hash = 0;
            hash += (!string.ReferenceEquals(idVisita, null) ? idVisita.GetHashCode() : 0);
            return hash;
        }

        public override bool Equals(object @object)
        {
            // TODO: Warning - this method won't work in the case the id fields are not set
            if (!(@object is Visita))
            {
                return false;
            }
            Visita other = (Visita)@object;
            if ((string.ReferenceEquals(this.idVisita, null) && !string.ReferenceEquals(other.idVisita, null)) || (!string.ReferenceEquals(this.idVisita, null) && !this.idVisita.Equals(other.idVisita)))
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return "dto.entidad.Visita[ idVisita=" + idVisita + " ]";
        }

    }

}

