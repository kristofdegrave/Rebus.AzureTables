﻿using NUnit.Framework;
using Rebus.Tests.Contracts.Sagas;

namespace Rebus.AzureTables.Tests.Contracts
{
    [TestFixture]
    public class SqlServerSagaStorageConcurrencyHandling : ConcurrencyHandling<AzureTablesSagaStorageFactory> { }
}