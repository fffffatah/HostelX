using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLib
{
    public class Tenant
    {
        public string TenantId { get; set; }
        public string TenantFirstName { get; set; }
        public string TenantLastName { get; set; }
        public string TenantPhone { get; set; }
        public string TenantEmail { get; set; }
        public string TenantAddress { get; set; }
        public string TenantInstitution { get; set; }
        public string TenantPass { get; set; }
        public string TenantProfileImage { get; set; }
        public string TenantGender { get; set; }
        public string HostelId { get; set; }
    }
}
