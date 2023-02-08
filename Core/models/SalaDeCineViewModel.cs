using myERP.Core.Enums;

namespace myERP.Core.models
{
    public class SalaDeCineViewModel
    {

        public int Id { get; set; }
        public decimal Precio { get; set; }

        public TipoSalaDeCine TipoSalaDeCine { get; set; }

        public int CineId { get; set; }

    }
}
