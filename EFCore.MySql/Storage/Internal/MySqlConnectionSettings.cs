// Copyright (c) Pomelo Foundation. All rights reserved.
// Licensed under the MIT. See LICENSE in the project root for license information.

using System.Data.Common;
using Mimer.Data.Client;

namespace Pomelo.EntityFrameworkCore.MySql.Storage.Internal
{
    public class MimerConnectionSettings
    {
        public MimerConnectionSettings()
        {
        }

        public MimerConnectionSettings(DbConnection connection)
            : this(connection.ConnectionString)
        {
        }

        public MimerConnectionSettings(string connectionString)
        {
            var csb = new MimerConnectionStringBuilder(connectionString);

            //if (csb.GuidFormat == MySqlGuidFormat.Default)
            //{
            //    GuidFormat = csb.OldGuids
            //        ? MySqlGuidFormat.LittleEndianBinary16
            //        : MySqlGuidFormat.Char36;
            //}
            //else
            //{
            //    GuidFormat = csb.GuidFormat;
            //}

            //TreatTinyAsBoolean = csb.TreatTinyAsBoolean;
        }

        //        public virtual MySqlGuidFormat GuidFormat { get; }
        public virtual bool TreatTinyAsBoolean { get; }

        protected bool Equals(MimerConnectionSettings other)
        {
            //    return GuidFormat == other.GuidFormat &&
            //           TreatTinyAsBoolean == other.TreatTinyAsBoolean;

            return false;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((MimerConnectionSettings)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return  397 ^ TreatTinyAsBoolean.GetHashCode();
            }
        }
    }
}
