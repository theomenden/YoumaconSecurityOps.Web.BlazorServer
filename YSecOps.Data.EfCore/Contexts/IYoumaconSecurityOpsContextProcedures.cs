﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
namespace YSecOps.Data.EfCore.Contexts;

    public partial interface IYoumaconSecurityOpsContextProcedures
    {
        Task<int> p_AddPronounsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> p_AddStaffRolesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> p_AddStaffTypesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<p_AddStartingLocationsResult>> p_AddStartingLocationsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }