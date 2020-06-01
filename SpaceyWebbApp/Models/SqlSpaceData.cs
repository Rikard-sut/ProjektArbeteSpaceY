using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceyWebbApp.Models
{
    /// <summary>
    /// Class for SqlInteractions with our database.
    /// </summary>
    public class SqlSpaceData
    {
        private readonly SpaceyDbContext db;

        public SqlSpaceData(SpaceyDbContext db)
        {
            this.db = db;
        }
    }
}
