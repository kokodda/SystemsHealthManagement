using System.Data.Entity.ModelConfiguration;
using Integra.Dominio;

namespace Integra.Repositorio.EF.Configuracoes
{
    public class FaturaConfiguracao : EntityTypeConfiguration<Fatura>
    {
        public FaturaConfiguracao()
        {
            HasKey(it => it.Codigo);
            HasRequired(it => it.Programa);
        }
    }
}