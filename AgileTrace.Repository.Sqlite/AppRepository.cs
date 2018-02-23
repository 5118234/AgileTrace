﻿using AgileTrace.IRepository;
using System;
using AgileTrace.Entity;
using Microsoft.EntityFrameworkCore;
using AgileTrace.Repository.Common;

namespace AgileTrace.Repository.Sqlite
{
    public class AppRepository : BaseRepository<App>, IAppRepository
    {
        public AppRepository(ISqliteDbContext dbContext) : base(dbContext as DbContext)
        {
        }
    }
}
