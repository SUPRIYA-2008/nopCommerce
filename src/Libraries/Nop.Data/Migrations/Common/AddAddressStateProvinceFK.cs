﻿using FluentMigrator;
using Nop.Core.Domain.Common;
using Nop.Core.Domain.Directory;
using Nop.Data.Extensions;

namespace Nop.Data.Migrations.Common
{
    [Migration(637097696240659481)]
    public class AddAddressStateProvinceFK : AutoReversingMigration
    {
        #region Methods

        public override void Up()
        {
            this.AddForeignKey(nameof(Address)
                , nameof(Address.StateProvinceId)
                , nameof(StateProvince)
                , nameof(StateProvince.Id));
        }

        #endregion
    }
}