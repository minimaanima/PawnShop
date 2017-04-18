<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using AutoMapper;
=======
﻿using System.Collections.Generic;
using System.Linq;
>>>>>>> df251bf378ce915a10bdb267680b3047ed4ddfee
using AutoMapper.QueryableExtensions;
using PawnShop.CommunicationService.Utilities;
using PawnShop.Data;
using PawnShop.Data.DTOs;
<<<<<<< HEAD
using PawnShop.Models.BusinessModels;
=======
>>>>>>> df251bf378ce915a10bdb267680b3047ed4ddfee
using PawnShop.Models.Enums;

namespace PawnShop.CommunicationService.ModelFactories
{
    public static class ContractFactory
    {
        public static IEnumerable<ContractDto> GetContracts(Status status = Status.All)
        {
            using (var context = new PawnShopContext())
            {
<<<<<<< HEAD
               MapperInitiliazer.InitiliazeContracts();

                if (status == Status.All)
                {
                    var contracts =
                        context.Contracts
                        //.Where(c => c.Employee.Office.Name == LoginUser.User.Office.Name)
=======
                if (status == Status.All)
                {
                    var contracts =
                        context.Contracts.Where(c => c.Employee.Office.Name == LoginUser.User.Office.Name)
                            .Select(c => new
                            {
                                ContractId = c.Id,
                                c.Client,
                                DateOfRegistrationAndExpiring =
                                c.StartDate.Date.ToString() + " - " + c.EndDate.Date.ToString(),
                                c.PropertyValue,
                                c.Interest,
                                (c.StartDate - c.EndDate).Days,
                                c.PledgedProperty,
                                c.Status
                            })
>>>>>>> df251bf378ce915a10bdb267680b3047ed4ddfee
                            .ProjectTo<ContractDto>()
                            .ToList();

                    return contracts;
                }

                var filtredContracts =
                        context.Contracts.Where(c => c.Employee.Office.Name == LoginUser.User.Office.Name && c.Status == status)
<<<<<<< HEAD
=======
                            .Select(c => new
                            {
                                ContractId = c.Id,
                                c.Client,
                                DateOfRegistrationAndExpiring =
                                c.StartDate.Date.ToString() + " - " + c.EndDate.Date.ToString(),
                                c.PropertyValue,
                                c.Interest,
                                (c.StartDate - c.EndDate).Days,
                                c.PledgedProperty,
                                c.Status
                            })
>>>>>>> df251bf378ce915a10bdb267680b3047ed4ddfee
                            .ProjectTo<ContractDto>()
                            .ToList();

                return filtredContracts;
            }
        }

        public static ContractDto GetContractById(int contractId)
        {
            using (var context = new PawnShopContext())
            {
                var contract = context.Contracts.Find(contractId);
                var contractDto = new ContractDto()
                {
                    ContractId = contract.Id,
<<<<<<< HEAD
                    Client = contract.Client.FirstName + " " + contract.Client.MiddleName + " " + contract.Client.LastName + Environment.NewLine + contract.Client.PersonalID,
=======
                    Client = contract.Client,
>>>>>>> df251bf378ce915a10bdb267680b3047ed4ddfee
                    DateOfRegistrationAndExpiring =
                                contract.StartDate.Date.ToString() + " - " + contract.EndDate.Date.ToString(),
                    PropertyValue = contract.PropertyValue,
                    Interest = contract.Interest,
                    Days = (contract.StartDate - contract.EndDate).Days,
                    PledgedProperty = contract.PledgedProperty,
                    Status = contract.Status

                };

                return contractDto;
            }
        }

        public static IEnumerable<ContractDto> GetContractsByClientsPersonalId(int personalId)
        {
            using (var context = new PawnShopContext())
            {
<<<<<<< HEAD
                MapperInitiliazer.InitiliazeContracts();

                var contracts = context.Contracts.Where(c => c.Employee.Office.Name == LoginUser.User.Office.Name && c.Client.PersonalID == personalId)
=======
                var contracts = context.Contracts.Where(c => c.Employee.Office.Name == LoginUser.User.Office.Name && c.Client.PersonalID == personalId)
                            .Select(c => new
                            {
                                ContractId = c.Id,
                                c.Client,
                                DateOfRegistrationAndExpiring =
                                c.StartDate.Date.ToString() + " - " + c.EndDate.Date.ToString(),
                                c.PropertyValue,
                                c.Interest,
                                (c.StartDate - c.EndDate).Days,
                                c.PledgedProperty,
                                c.Status
                            })
>>>>>>> df251bf378ce915a10bdb267680b3047ed4ddfee
                            .ProjectTo<ContractDto>()
                            .ToList();

                return contracts;
            }
        }

        public static IEnumerable<ContractDto> GetContractsByClientsName(string name)
        {
            using (var context = new PawnShopContext())
            {
<<<<<<< HEAD
                MapperInitiliazer.InitiliazeContracts();

                var contracts = context.Contracts.Where(c => c.Employee.Office.Name == LoginUser.User.Office.Name && string.Concat(c.Client.FirstName, " ", c.Client.MiddleName, " ", c.Client.LastName) == name)
=======
                var contracts = context.Contracts.Where(c => c.Employee.Office.Name == LoginUser.User.Office.Name && string.Concat(c.Client.FirstName, " ", c.Client.MiddleName, " ", c.Client.LastName) == name)
                            .Select(c => new
                            {
                                ContractId = c.Id,
                                c.Client,
                                DateOfRegistrationAndExpiring =
                                c.StartDate.Date.ToString() + " - " + c.EndDate.Date.ToString(),
                                c.PropertyValue,
                                c.Interest,
                                (c.StartDate - c.EndDate).Days,
                                c.PledgedProperty,
                                c.Status
                            })
>>>>>>> df251bf378ce915a10bdb267680b3047ed4ddfee
                            .ProjectTo<ContractDto>()
                            .ToList();

                return contracts;
            }
        }

        public static IEnumerable<ContractDto> GetContractsByTown(string town)
        {
            using (var context = new PawnShopContext())
            {
<<<<<<< HEAD
                MapperInitiliazer.InitiliazeContracts();

                var contracts = context.Contracts.Where(c => c.Employee.Office.Name == LoginUser.User.Office.Name && c.Employee.Office.Address.Town.Name == town)
=======
                var contracts = context.Contracts.Where(c => c.Employee.Office.Name == LoginUser.User.Office.Name && c.Employee.Office.Address.Town.Name == town)
                            .Select(c => new
                            {
                                ContractId = c.Id,
                                c.Client,
                                DateOfRegistrationAndExpiring =
                                c.StartDate.Date.ToString() + " - " + c.EndDate.Date.ToString(),
                                c.PropertyValue,
                                c.Interest,
                                (c.StartDate - c.EndDate).Days,
                                c.PledgedProperty,
                                c.Status
                            })
>>>>>>> df251bf378ce915a10bdb267680b3047ed4ddfee
                            .ProjectTo<ContractDto>()
                            .ToList();

                return contracts;
            }
        }

        public static IEnumerable<ContractDto> GetContractsByAddress(string address)
        {
            using (var context = new PawnShopContext())
            {
<<<<<<< HEAD
                MapperInitiliazer.InitiliazeContracts();

                var contracts = context.Contracts.Where(c => c.Employee.Office.Name == LoginUser.User.Office.Name && c.Client.Address.Text == address)
=======
                var contracts = context.Contracts.Where(c => c.Employee.Office.Name == LoginUser.User.Office.Name && c.Client.Address.Text == address)
                            .Select(c => new
                            {
                                ContractId = c.Id,
                                c.Client,
                                DateOfRegistrationAndExpiring =
                                c.StartDate.Date.ToString() + " - " + c.EndDate.Date.ToString(),
                                c.PropertyValue,
                                c.Interest,
                                (c.StartDate - c.EndDate).Days,
                                c.PledgedProperty,
                                c.Status
                            })
>>>>>>> df251bf378ce915a10bdb267680b3047ed4ddfee
                            .ProjectTo<ContractDto>()
                            .ToList();

                return contracts;
            }
        }
    }
}
