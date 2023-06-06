using DataModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;

namespace Interview.WithLinqToDb.Data.Standard.DbRepositories.KPP
{
    public class KppRepository
    {
        private readonly IConfiguration _configuration;
        private readonly StationsKPP14DB _connection;

        private StationsKPP14DB GetDb() => new StationsKPP14DB();

        public KppRepository(StationsKPP14DB st)
        {
            _connection = st;
            // _configuration = configuration;
        }


        public async Task<List<ActionEvent>> GetActionEventsAsync()
        {
            using (var db = _connection)//  GetDb();
                return await db.ActionEvents.ToListAsync().ConfigureAwait(false);
        }
    }
}
