using System.Data.Entity.ModelConfiguration;
using Integra.Dominio;

namespace Integra.Repositorio.EF.Configuracoes
{
    public class NotasFiscaisConfiguracao : EntityTypeConfiguration<NotaFiscal>
    {
        public NotasFiscaisConfiguracao()
        {
            HasKey(it => it.Codigo);
            HasRequired(it => it.Programa);
        }
    }
}