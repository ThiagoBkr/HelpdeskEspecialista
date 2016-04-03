namespace HelpdeskEspecialista.Classes
{
    public class ProblemaSintoma : BD.ProblemaSintoma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProblemaSintoma()
        {
            
        }

        public override string ToString()
        {
            return this.Id.ToString();
        }

    }
}
