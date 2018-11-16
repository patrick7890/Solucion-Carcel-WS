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
        //ORIGINAL LINE: @Basic(optional = false) @NotNull @Size(min = 1, max = 25) @Column(name = "NOMBRE_V") private String nombre;
        private string nombre;
        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @Basic(optional = false) @NotNull @Column(name = "SEXO_V") private System.Nullable<char> sexo;
        private char? sexo;
        //JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
        //ORIGINAL LINE: @Basic(optional = false) @NotNull @Column(name = "VISITA_V") private System.Nullable<char> visita;
        private char? visita;
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

        public Preso(short? idPreso, string nombre, char? sexo, char? visita)
        {
            this.idPreso = idPreso;
            this.nombre = nombre;
            this.sexo = sexo;
            this.visita = visita;
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


        public virtual string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                this.nombre = value;
            }
        }


        public virtual char? Sexo
        {
            get
            {
                return sexo;
            }
            set
            {
                this.sexo = value;
            }
        }


        public virtual char? Visita
        {
            get
            {
                return visita;
            }
            set
            {
                this.visita = value;
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
            return nombre;
        }

    }

}
