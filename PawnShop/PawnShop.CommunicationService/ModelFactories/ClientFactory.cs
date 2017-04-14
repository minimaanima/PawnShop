using System.Collections.Generic;
using System.Linq;
using AutoMapper.QueryableExtensions;
using PawnShop.CommunicationService.Utilities;
using PawnShop.Data;
using PawnShop.Data.DTOs;

namespace PawnShop.CommunicationService.ModelFactories
{
    public static class ClientFactory
    {
        public static IEnumerable<ClientDto> GetClients()
        {
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
                        .ProjectTo<ClientDto>()
                        .ToList();

                return clients;
            }
        }
    }
}
