using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
using AutoMapper;
=======
>>>>>>> df251bf378ce915a10bdb267680b3047ed4ddfee
using AutoMapper.QueryableExtensions;
using PawnShop.CommunicationService.Utilities;
using PawnShop.Data;
using PawnShop.Data.DTOs;
<<<<<<< HEAD
using PawnShop.Models.BusinessModels;
=======
>>>>>>> df251bf378ce915a10bdb267680b3047ed4ddfee

namespace PawnShop.CommunicationService.ModelFactories
{
    public static class ClientFactory
    {
        public static IEnumerable<ClientDto> GetClients()
        {
<<<<<<< HEAD
            MapperInitiliazer.InitializeClients();

            using (var context = new PawnShopContext())
            {
                var clients =
                    context.Clients
                    //.Where(
                    //        c => c.Contracts.Any(con => con.Employee.Office.Name == LoginUser.User.Office.Name))
=======
            using (var context = new PawnShopContext())
            {
                var clients =
                    context.Clients.Where(
                            c => c.Contracts.Any(con => con.Employee.Office.Name == LoginUser.User.Office.Name))
                        .Select(c => new
                        {
                            c.PersonalID,
                            FullName = string.Concat(c.FirstName, " ", c.MiddleName, " ", c.LastName),
                            c.PhoneNumber,
                            TownName = c.Address.Town.Name,
                            AddressName = c.Address.Text,
                            c.IDCardNumber,
                            c.RegistrationDate
                        })
>>>>>>> df251bf378ce915a10bdb267680b3047ed4ddfee
                        .ProjectTo<ClientDto>()
                        .ToList();

                return clients;
            }
        }
    }
}
