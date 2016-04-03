namespace HelpdeskEspecialista.Classes
{
    public class Sintoma : BD.Sintoma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sintoma()
        {
            
        }

        public override string ToString()
        {
            return this.Descricao;
        }
    }
}
