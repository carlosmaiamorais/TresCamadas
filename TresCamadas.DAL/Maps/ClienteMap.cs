using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TresCamadas.Model;

namespace TresCamadas.DAL.Maps
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            //configurar nome da tabela
            builder.ToTable("CLIENTE");

            //configurar a chave primária
            builder.HasKey(x => x.Id);

            //configurar as colunas
            builder.Property(x => x.Id).HasColumnName("ID").IsRequired();
            builder.Property(x => x.Cpf).HasColumnName("CPF").IsRequired();
            builder.Property(x => x.Nome).HasColumnName("NOME").IsRequired();
            builder.Property(x => x.DataNascimento).HasColumnName("DATA_NASC").IsRequired();
            builder.Property(x => x.Idade).HasColumnName("IDADE").IsRequired();

            //mapemaento ONE TO MANY ( 1 pra muitos ) 
        }
    }
}
