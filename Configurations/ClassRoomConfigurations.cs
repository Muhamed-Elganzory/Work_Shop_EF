using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Model;

namespace WorkShop.Configurations;

public class ClassRoomConfigurations: IEntityTypeConfiguration <ClassRoom>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<ClassRoom> builder)
    {
        builder.HasKey(c => c.ClassRoomId);
        
        builder.Property(c => c.Building).IsRequired().HasColumnType("nvarchar(100)");
        
        builder.Property(c => c.RoomNumber).IsRequired().HasColumnType("nvarchar(50)");
        
        builder.Property(c=> c.Capacity).IsRequired();
        builder.HasCheckConstraint("CK_ClassRoom_Capacity", "[Capacity] > 0");
    }
}