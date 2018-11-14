using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCarcel
{
    [Serializable]
    public class Penal
    {
        private const long serialVersionUID = 1L;
        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @Id @Basic(optional = false) @NotNull @Column(name = "ID_PENAL") private System.Nullable<short> idPenal;
        private short? idPenal;
        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @Basic(optional = false) @NotNull @Size(min = 1, max = 25) @Column(name = "DESCRIPCION") private String descripcion;
        private string descripcion;
        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @OneToMany(cascade = javax.persistence.CascadeType.ALL, mappedBy = "penalIdPenal") private java.util.List<Preso> presoList;
        private IList<Preso> presoList;

        public Penal()
        {
        }

        public Penal(short? idPenal)
        {
            this.idPenal = idPenal;
        }

        public Penal(short? idPenal, string descripcion)
        {
            this.idPenal = idPenal;
            this.descripcion = descripcion;
        }

        public virtual short? IdPenal
        {
            get
            {
                return idPenal;
            }
            set
            {
                this.idPenal = value;
            }
        }


        public virtual string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }


        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @XmlTransient public java.util.List<Preso> getPresoList()
        public virtual IList<Preso> PresoList
        {
            get
            {
                return presoList;
            }
            set
            {
                this.presoList = value;
            }
        }


        public override int GetHashCode()
        {
            int hash = 0;
            hash += (idPenal != null ? idPenal.GetHashCode() : 0);
            return hash;
        }

        public override bool Equals(object @object)
        {
            // TODO: Warning - this method won't work in the case the id fields are not set
            if (!(@object is Penal))
            {
                return false;
            }
            Penal other = (Penal)@object;
            if ((this.idPenal == null && other.idPenal != null) || (this.idPenal != null && !this.idPenal.Equals(other.idPenal)))
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return descripcion;
        }


    }
}
