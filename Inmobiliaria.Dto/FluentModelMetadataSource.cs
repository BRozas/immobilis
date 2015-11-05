using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Metadata.Fluent;

namespace Inmobiliaria.Dto
{
    public partial class FluentModelMetadataSource : FluentMetadataSource
    {
        protected override IList<MappingConfiguration> PrepareMapping()
        {
            List<MappingConfiguration> configuracionesMap = new List<MappingConfiguration>();

            MappingConfiguration<Persona> PersonaConfiguration = new MappingConfiguration<Persona>();
            PersonaConfiguration.MapType().ToTable("PERSONAS");
            PersonaConfiguration.HasProperty(c => c.PersonaId).IsIdentity(KeyGenerator.Autoinc);
            PersonaConfiguration.
                HasAssociation(prop => prop.Propiedades).WithOpposite(pers => pers.Persona).HasConstraint((pers, prop) => pers.PersonaId == prop.PersonaId);
            PersonaConfiguration.
                HasAssociation(pers => pers.Contratos).WithOpposite(pers => pers.Persona).HasConstraint((pers, prop) => pers.PersonaId == prop.PersonaId);
            configuracionesMap.Add(PersonaConfiguration);

            MappingConfiguration<Propiedad> PropiedadesConfiguration = new MappingConfiguration<Propiedad>();
            PropiedadesConfiguration.MapType().ToTable("PROPIEDADES");
            PropiedadesConfiguration.HasProperty(c => c.PropiedadId).IsIdentity(KeyGenerator.Autoinc);
            PropiedadesConfiguration.
                HasAssociation(prop => prop.Comuna).WithOpposite(c => c.Propiedades).HasConstraint((prop, c) => prop.ComunaId == c.Id);
            PropiedadesConfiguration.
                HasAssociation(prop => prop.Region).WithOpposite(r => r.Propiedades).HasConstraint((prop, r) => prop.RegionId == r.RegionId);
            PropiedadesConfiguration.
                HasAssociation(prop => prop.ConjuntoHabitacional).WithOpposite(conHab => conHab.Propiedades).HasConstraint((p, conHab) => p.ConjuntoHabitacionalId == conHab.ConjuntoHabitacionalId);
            PropiedadesConfiguration.
                HasAssociation(prop => prop.ServiciosDeMantenciones).WithOpposite(sm => sm.Propiedad).HasConstraint((prop, sw) => prop.PropiedadId == sw.PropiedadId);
            PropiedadesConfiguration.
                HasAssociation(prop => prop.Contratos).WithOpposite(c => c.Propiedad).HasConstraint((prop, c) => prop.PropiedadId == c.PropiedadId);
            configuracionesMap.Add(PropiedadesConfiguration);

            MappingConfiguration<Contrato> ContratoConfiguration = new MappingConfiguration<Contrato>();
            ContratoConfiguration.MapType().ToTable("CONTRATOS");
            ContratoConfiguration.HasProperty(c => c.ContratoId).IsIdentity(KeyGenerator.Autoinc);
            ContratoConfiguration.
                HasAssociation(c => c.Pagos).WithOpposite(pago => pago.Contrato).HasConstraint((c, pago) => c.ContratoId == pago.ContratoId);
            ContratoConfiguration.
                HasAssociation(c => c.Documentos).WithOpposite(d => d.Contrato).HasConstraint((c, d) => c.ContratoId == d.ContratoId);
            configuracionesMap.Add(ContratoConfiguration);

            MappingConfiguration<Notaria> NotariaConfiguration = new MappingConfiguration<Notaria>();
            NotariaConfiguration.MapType().ToTable("NOTARIAS");
            NotariaConfiguration.HasProperty(n => n.NotariaId).IsIdentity(KeyGenerator.Autoinc);
            NotariaConfiguration.
                HasAssociation(n => n.Contratos).WithOpposite(c => c.Notaria).HasConstraint((n, c) => n.NotariaId == c.NotariaId);
            configuracionesMap.Add(NotariaConfiguration);

            MappingConfiguration<ConservadorBienRaiz> ConservadorBienRaizConfiguration = new MappingConfiguration<ConservadorBienRaiz>();
            ConservadorBienRaizConfiguration.MapType().ToTable("CBRS");
            ConservadorBienRaizConfiguration.HasProperty(cbr => cbr.ConservadorBienRaizId).IsIdentity(KeyGenerator.Autoinc);
            ConservadorBienRaizConfiguration.
                HasAssociation(cbr => cbr.Contratos).WithOpposite(c => c.ConservadorBienRaiz).HasConstraint((cbr, c) => cbr.ConservadorBienRaizId == c.ConservadorBienRaizId);
            configuracionesMap.Add(ConservadorBienRaizConfiguration);

            MappingConfiguration<Convenio> ConvenioConfiguration = new MappingConfiguration<Convenio>();
            ConvenioConfiguration.MapType().ToTable("CONVENIOS");
            ConvenioConfiguration.HasProperty(c => c.ConvenioId).IsIdentity(KeyGenerator.Autoinc);
            ConvenioConfiguration.
                HasAssociation(c => c.Contratos).WithOpposite(contrato => contrato.Convenio).HasConstraint((c, contrato) => c.ConvenioId == contrato.ConvenioId);
            configuracionesMap.Add(ConvenioConfiguration);

            MappingConfiguration<DocumentoDigital> DocumentoConfiguration = new MappingConfiguration<DocumentoDigital>();
            DocumentoConfiguration.MapType().ToTable("DOCS_DIGITALES");
            DocumentoConfiguration.HasProperty(c => c.DocumentoId).IsIdentity(KeyGenerator.Autoinc);
            DocumentoConfiguration.
                HasAssociation(dd => dd.TipoDocumentoDigital).WithOpposite(tdd => tdd.DocumentosDigitales).HasConstraint((dd, tdd) => dd.TipoDocumentoDigitalId == tdd.TipoDocumentoDigitalId);
            configuracionesMap.Add(DocumentoConfiguration);

            MappingConfiguration<TipoDocumentoDigital> TipoDocumentoDigitalConfiguration = new MappingConfiguration<TipoDocumentoDigital>();
            TipoDocumentoDigitalConfiguration.MapType().ToTable("TIPOS_DOCS_D");
            TipoDocumentoDigitalConfiguration.HasProperty(tdd => tdd.TipoDocumentoDigitalId).IsIdentity(KeyGenerator.Autoinc);
            configuracionesMap.Add(TipoDocumentoDigitalConfiguration);

            MappingConfiguration<ServicioMantencion> ServicioMantencionConfiguration = new MappingConfiguration<ServicioMantencion>();
            ServicioMantencionConfiguration.MapType().ToTable("SERVICIOS_MANT");
            ServicioMantencionConfiguration.HasProperty(c => c.ServicioMantencionId).IsIdentity(KeyGenerator.Autoinc);
            configuracionesMap.Add(ServicioMantencionConfiguration);

            MappingConfiguration<Pago> PagoConfiguration = new MappingConfiguration<Pago>();
            PagoConfiguration.MapType().ToTable("PAGOS");
            PagoConfiguration.HasProperty(c => c.PagoId).IsIdentity(KeyGenerator.Autoinc);
            configuracionesMap.Add(PagoConfiguration);

            MappingConfiguration<Banco> BancoConfiguration = new MappingConfiguration<Banco>();
            BancoConfiguration.MapType().ToTable("BANCOS");
            BancoConfiguration.HasProperty(c => c.BancoId).IsIdentity(KeyGenerator.Autoinc);
            BancoConfiguration.
                HasAssociation(c => c.Contratos).WithOpposite(contrato => contrato.Banco).HasConstraint((c, contrato) => c.BancoId == contrato.BancoId);
            configuracionesMap.Add(BancoConfiguration);

            MappingConfiguration<ConjuntoHabitacional> ConjuntoHabitacionalConfiguration = new MappingConfiguration<ConjuntoHabitacional>();
            ConjuntoHabitacionalConfiguration.MapType().ToTable("CONJUNTOS_HAB");
            ConjuntoHabitacionalConfiguration.HasProperty(c => c.ConjuntoHabitacionalId).IsIdentity(KeyGenerator.Autoinc);
            configuracionesMap.Add(ConjuntoHabitacionalConfiguration);

            MappingConfiguration<Region> RegionConfiguration = new MappingConfiguration<Region>();
            RegionConfiguration.MapType().ToTable("REGIONES");
            RegionConfiguration.HasProperty(c => c.RegionId).IsIdentity(KeyGenerator.Autoinc);
            configuracionesMap.Add(RegionConfiguration);

            MappingConfiguration<Comuna> ComunaConfiguration = new MappingConfiguration<Comuna>();
            ComunaConfiguration.MapType().ToTable("COMUNAS");
            ComunaConfiguration.HasProperty(c => c.Id).IsIdentity(KeyGenerator.Autoinc);
            configuracionesMap.Add(ComunaConfiguration);

            return configuracionesMap;
        }

        //protected override MetadataContainer CreateModel()
        //{
        //    MetadataContainer container = base.CreateModel();
        //    container.DefaultMapping.NullForeignKey = true;
        //    return container;
        //}
    }
}
