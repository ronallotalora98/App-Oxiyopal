using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

public static class ModelBuilderExtensions
{
    /// <summary>
    /// Avoids the table pluralizing 
    /// </summary>
    /// <param name="modelBuilder"></param>
    public static void RemovePluralizingTableNameConvention(this ModelBuilder modelBuilder)
    {
        foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
        {
            entity.Relational().TableName = entity.ClrType.Name;
        }
    }
}
