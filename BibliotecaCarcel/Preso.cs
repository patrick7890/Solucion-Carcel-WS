using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCarcel
{
    [Serializable]
    public class Preso
    {
        private const long serialVersionUID = 1L;
        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @Id @Basic(optional = false) @NotNull @Column(name = "ID_PRESO") private System.Nullable<short> idPreso;
        private short? idPreso;
        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @Basic(optional = false) @NotNull @Size(min = 1, max = 25) @Column(name = "NOMBRE_V") private String nombreV;
        private string nombreV;
        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @Basic(optional = false) @NotNull @Column(name = "SEXO_V") private System.Nullable<char> sexoV;
        private char? sexoV;
        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @Basic(optional = false) @NotNull @Column(name = "VISITA_V") private System.Nullable<char> visitaV;
        private char? visitaV;
        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @JoinColumn(name = "PENAL_ID_PENAL", referencedColumnName = "ID_PENAL") @ManyToOne(optional = false) private Penal penalIdPenal;
        private Penal penalIdPenal;

        public Preso()
        {
        }

        public Preso(short? idPreso)
        {
            this.idPreso = idPreso;
        }

        public Preso(short? idPreso, string nombreV, char? sexoV, char? visitaV)
        {
            this.idPreso = idPreso;
            this.nombreV = nombreV;
            this.sexoV = sexoV;
            this.visitaV = visitaV;
        }

        public virtual short? IdPreso
        {
            get
            {
                return idPreso;
            }
            set
            {
                this.idPreso = value;
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


        public virtual char? SexoV
        {
            get
            {
                return sexoV;
            }
            set
            {
                this.sexoV = value;
            }
        }


        public virtual char? VisitaV
        {
            get
            {
                return visitaV;
            }
            set
            {
                this.visitaV = value;
            }
        }


        public virtual Penal PenalIdPenal
        {
            get
            {
                return penalIdPenal;
            }
            set
            {
                this.penalIdPenal = value;
            }
        }


        public override int GetHashCode()
        {
            int hash = 0;
            hash += (idPreso != null ? idPreso.GetHashCode() : 0);
            return hash;
        }

        public override bool Equals(object @object)
        {
            // TODO: Warning - this method won't work in the case the id fields are not set
            if (!(@object is Preso))
            {
                return false;
            }
            Preso other = (Preso)@object;
            if ((this.idPreso == null && other.idPreso != null) || (this.idPreso != null && !this.idPreso.Equals(other.idPreso)))
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return nombreV;
        }

    }

}
