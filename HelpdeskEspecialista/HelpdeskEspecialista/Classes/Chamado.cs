using System;


namespace HelpdeskEspecialista.Classes
{
    public class Chamado : BD.Chamado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Chamado()
        {

        }

        public override string ToString()
        {
            return String.Format("Chamado num: {0}", this.Id);
        }
    }
}
