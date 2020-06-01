﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.TestUtilities;

namespace Microsoft.EntityFrameworkCore.Query
{
    public abstract class AsyncGearsOfWarQueryRelationalTestBase<TFixture> : AsyncGearsOfWarQueryTestBase<TFixture>
        where TFixture : GearsOfWarQueryFixtureBase, new()
    {
        protected AsyncGearsOfWarQueryRelationalTestBase(TFixture fixture)
            : base(fixture)
        {
        }

        protected virtual bool CanExecuteQueryString => false;

        protected override QueryAsserter CreateQueryAsserter(TFixture fixture)
            => new RelationalQueryAsserter(fixture, RewriteExpectedQueryExpression, RewriteServerQueryExpression, canExecuteQueryString: CanExecuteQueryString);
    }
}