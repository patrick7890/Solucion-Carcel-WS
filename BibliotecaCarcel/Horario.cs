using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCarcel
{
    [Serializable]
    public class Horario
    {

        private const long serialVersionUID = 1L;
        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @Id @Basic(optional = false) @NotNull @Column(name = "ID_HORARIO") private System.Nullable<short> idHorario;
        private short? idHorario;
        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @Basic(optional = false) @NotNull @Size(min = 1, max = 25) @Column(name = "DESCRIPCION_H") private String descripcionH;
        private string descripcionH;
        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @Basic(optional = false) @NotNull @Column(name = "MINUTOS") private short minutos;
        private short minutos;
        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @OneToMany(cascade = javax.persistence.CascadeType.ALL, mappedBy = "horarioIdHorario") private java.util.List<Visita> visitaList;
        private IList<visita> visitaList;

        public Horario()
        {
        }

        public Horario(short? idHorario)
        {
            this.idHorario = idHorario;
        }

        public Horario(short? idHorario, string descripcionH, short minutos)
        {
            this.idHorario = idHorario;
            this.descripcionH = descripcionH;
            this.minutos = minutos;
        }

        public virtual short? IdHorario
        {
            get
            {
                return idHorario;
            }
            set
            {
                this.idHorario = value;
            }
        }


        public virtual string DescripcionH
        {
            get
            {
                return descripcionH;
            }
            set
            {
                this.descripcionH = value;
            }
        }


        public virtual short Minutos
        {
            get
            {
                return minutos;
            }
            set
            {
                this.minutos = value;
            }
        }


        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @XmlTransient public java.util.List<Visita> getVisitaList()
        public virtual IList<visita> VisitaList
        {
            get
            {
                return visitaList;
            }
            set
            {
                this.visitaList = value;
            }
        }


        public override int GetHashCode()
        {
            int hash = 0;
            hash += (idHorario != null ? idHorario.GetHashCode() : 0);
            return hash;
        }

        public override bool Equals(object @object)
        {
            // TODO: Warning - this method won't work in the case the id fields are not set
            if (!(@object is Horario))
            {
                return false;
            }
            Horario other = (Horario)@object;
            if ((this.idHorario == null && other.idHorario != null) || (this.idHorario != null && !this.idHorario.Equals(other.idHorario)))
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return ""+descripcionH;
        }

    }

}

