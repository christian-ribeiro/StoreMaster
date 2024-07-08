﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace StoreMaster.Infrastructure.Extension
{
    public static class EFExtension
    {
        public static IQueryable<TEntry> IncludeVirtualProperties<TEntry>(this IQueryable<TEntry> query) where TEntry : class
        {
            var entityType = typeof(TEntry);
            var properties = entityType.GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(p => !p.IsDefined(typeof(NotMappedAttribute)) && p.GetGetMethod()?.IsVirtual == true && (typeof(IEnumerable<>).IsAssignableFrom(p.PropertyType) || p.PropertyType.IsClass));

            foreach (var property in properties)
            {
                query = query.Include(property.Name);
            }

            return query;
        }
    }
}