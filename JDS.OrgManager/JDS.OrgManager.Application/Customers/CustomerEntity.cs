﻿// Copyright ©2020 Jacobs Data Solutions

// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the
// License at

// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
// CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
using JDS.OrgManager.Application.Abstractions.Models;
using JDS.OrgManager.Application.Common.Addresses;
using JDS.OrgManager.Application.Common.Currencies;
using JDS.OrgManager.Application.Tenants;
using JDS.OrgManager.Domain.Common.People;
using System.Collections.Generic;

namespace JDS.OrgManager.Application.Customers
{
    public class CustomerEntity : AuditableDbEntity, IAddressEntity
    {
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public int AspNetUsersId { get; set; }

        public string City { get; set; }

        public int? CompanyId { get; set; }

        public CurrencyEntity Currency { get; set; }

        public string CurrencyCode { get; set; }

        public string FirstName { get; set; }

        public int Id { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string State { get; set; }

        public ICollection<TenantEntity> Tenants { get; set; }

        public Title? Title { get; set; }

        public string Zip { get; set; }

        public CustomerEntity()
        {
            Tenants = new HashSet<TenantEntity>();
        }
    }
}