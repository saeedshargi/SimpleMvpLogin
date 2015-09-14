using System.Data.Entity.ModelConfiguration;

namespace SimpleMvpLogin.Model
{
    public class MembershipMap : EntityTypeConfiguration<Membership>
    {
        public MembershipMap()
        {
            //Key
            HasKey(c => c.UserName);

            //Properties
            Property(c => c.UserName)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("UserName");

            Property(c => c.Password)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("Password");

            //Table Mapping
            ToTable("Membership");
        }
    }
}