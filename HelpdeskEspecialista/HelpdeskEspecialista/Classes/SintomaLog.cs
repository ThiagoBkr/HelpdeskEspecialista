namespace HelpdeskEspecialista.Classes
{
    public class SintomaLog : BD.SintomaLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SintomaLog()
        {

        }

        public override string ToString()
        {
            return this.Id.ToString();
        }
    }
}
