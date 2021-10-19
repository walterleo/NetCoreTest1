using System;

namespace NetCoreTest1.Models
{
    public class School
    {
        public string SchoolId { get; set; }
        public string Nombre { get; set; }
        public int AnoFundacion { get; set; }

        //public bool ShowSchoolId => !string.IsNullOrEmpty(RequestId);
    }
}
