﻿using System.Data;
using FluentMigrator;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Customers;
using Nop.Data.Extensions;

namespace Nop.Data.Migrations.Catalog
{
    [Migration(637097608748261631)]
    public  class AddBackInStockSubscriptionCustomerFK : AutoReversingMigration
    {
        #region Methods

        public override void Up()
        {
            this.AddForeignKey(nameof(BackInStockSubscription)
                , nameof(BackInStockSubscription.CustomerId)
                , nameof(Customer)
                , nameof(Customer.Id)
                , Rule.Cascade);
        }

        #endregion
    }
}