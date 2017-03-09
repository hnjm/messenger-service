﻿using MessangerService.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerService.Data.Migration
{
    class Configuration : DbMigrationsConfiguration<SqlDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "MessengerService.Data.ApplicationDbContext";
        }

        protected override void Seed(SqlDbContext context)
        {
        }
    }
}
