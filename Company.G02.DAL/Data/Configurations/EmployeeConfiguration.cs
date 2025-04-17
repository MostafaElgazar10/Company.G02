using Company.G02.DAL.FOLDER_Models.ModelEmployees;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Company.G02.DAL.Data.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(E => E.name).IsRequired().HasColumnType("varchar (50)");
            builder.Property(E => E.Salary).HasColumnType("decimal(12,2)");
          /*  builder.Property(E => E.Gender)
                .HasConversion((EmpGender) => EmpGender.ToString(),
                _Gender => (Gender)Enum.Parse(typeof(Gender), _Gender)
                );*/

        }
    }


}

/*using Company.G02.DAL.FOLDER_Models.ModelEmployees;
using Company.G02.DAL.FOLDER_Models.ModelEmployees.Shared.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/