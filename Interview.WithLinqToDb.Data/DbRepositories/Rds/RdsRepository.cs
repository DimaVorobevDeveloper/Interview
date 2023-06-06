using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Data;
using Microsoft.Extensions.Configuration;
using DataModels;

namespace Interview.WithLinqToDb.Data.DbRepositories.Rds
{
    public class RdsRepository
    {
        private readonly IConfiguration _configuration;
        
        private readonly StationsKppDB _connection;

        private StationsKppDB GetDb() => new StationsKppDB();

        public RdsRepository(StationsKppDB st)
        {
            _connection = st;
            // _configuration = configuration;
        }


        public async Task<List<ActionEvent>> GetActionEventsAsync()
        {
            await using var db = _connection; //  GetDb();

            return await db.ActionEvents.ToListAsync().ConfigureAwait(false);
        }
    }
}
