﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Savant.Pulse.DataModels.ReferenceData.Extensions
{
    public static class Extensions
    {

        public static IEnumerable<string> FindPrimaryKeyNames<T>(this DbContext dbContext, T entity)
        {
            return from p in dbContext.FindPrimaryKeyProperties(entity)
                select p.Name;
        }

        public static IEnumerable<object> FindPrimaryKeyValues<T>(this DbContext dbContext, T entity)
        {
            return from p in dbContext.FindPrimaryKeyProperties(entity)
                select entity.GetPropertyValue(p.Name);
        }

        static IReadOnlyList<IProperty> FindPrimaryKeyProperties<T>(this DbContext dbContext, T entity)
        {
            return dbContext.Model.FindEntityType(typeof(T)).FindPrimaryKey().Properties;
        }

        static object GetPropertyValue<T>(this T entity, string name)
        {
            return entity.GetType().GetProperty(name).GetValue(entity, null);
        }

    }
}
