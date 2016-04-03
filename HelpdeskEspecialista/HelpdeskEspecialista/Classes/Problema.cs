namespace HelpdeskEspecialista.Classes
{
    public class Problema : BD.Problema
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Problema()
        {
            
        }

        public override string ToString()
        {
            return this.Descricao;
        }
    }
}
