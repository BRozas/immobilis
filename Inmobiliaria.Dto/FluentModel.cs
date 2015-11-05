using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;

namespace Inmobiliaria.Dto
{
    public partial class FluentModel : OpenAccessContext
    {
        private static string connectionStringName = @"Immobilis";

        private static BackendConfiguration backend = GetBackendConfiguration();

        private static MetadataSource metadataSource = new FluentModelMetadataSource();

        public FluentModel()
            : base(connectionStringName, backend, metadataSource)
        { }

        public IQueryable<Persona> Personas
        {
            get
            {
                return this.GetAll<Persona>();
            }
        }

        public IQueryable<Contrato> Contratos
        {
            get
            {
                return this.GetAll<Contrato>();
            }
        }

        public IQueryable<Propiedad> Propiedades
        {
            get
            {
                return this.GetAll<Propiedad>();
            }
        }

        public static BackendConfiguration GetBackendConfiguration()
        {
            BackendConfiguration backend = new BackendConfiguration();
            backend.Backend = "Oracle";
            backend.ProviderName = "Oracle.ManagedDataAccess.Client";
            return backend;
        }
    }
}
