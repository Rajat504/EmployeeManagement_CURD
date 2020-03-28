﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEmployeeRepository.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Rajat Ravindar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Repository.RepositoryInterface
{
    using Model;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// interface IRepo.
    /// </summary>
    public interface IEmployeeRepository
    {
        /// <summary>
        /// GetEmployee method.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Employee GetEmployee(int id);

        /// <summary>
        /// GetAllEmployees method.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Employee> GetAllEmployees();

        /// <summary>
        /// AddEmployee method.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        Task<int> AddEmployee(Employee employee);

        /// <summary>
        /// UpdateEmployee method.
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns></returns>
        Task<int> UpdateEmployee(Employee employeeChanges);

        /// <summary>
        /// DeleteEmployee method.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Employee DeleteEmployee(int id);
    }
}
