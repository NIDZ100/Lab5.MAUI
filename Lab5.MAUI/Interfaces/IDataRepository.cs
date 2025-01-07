using Lab5.MAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab5.MAUI.Interfaces
{
    public interface IDataRepository
    {
        Task<Owner[]> GetOwnersAsync();

        Task<Animal[]> GetOwnerAnimalsAsync(int ownerId);

        Task DeleteAnimal(int ownerId, int animalId);
        Task UpdateOwnerAsync(Owner owner);

    }
}
