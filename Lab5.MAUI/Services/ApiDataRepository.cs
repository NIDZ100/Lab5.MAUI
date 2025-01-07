using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.MAUI.Interfaces;
using Lab5.MAUI.Models;

namespace Lab5.MAUI.Services
{
    public class ApiDataRepository : IDataRepository
    {
        private readonly IOwnerApiClient _ownerApiClient;

        public ApiDataRepository(IOwnerApiClient apiClient)
        {
            _ownerApiClient = apiClient;
        }

        public async Task DeleteAnimal(int ownerId, int animalId)
        {
            await _ownerApiClient
                .DeleteItemAsync($"{OwnerApiConstants.OwnersUrl}/{ownerId}/{OwnerApiConstants.AnimalsUrl}/{animalId}");
        }

        public async Task<Animal[]> GetOwnerAnimalsAsync(int ownerId)
        {
            var result = await _ownerApiClient
                .GetItemsAsync<Animal>($"{OwnerApiConstants.OwnersUrl}/{ownerId}/{OwnerApiConstants.AnimalsUrl}");
            return result;
        }

        public async Task<Owner[]> GetOwnersAsync()
        {
            var result = await _ownerApiClient.GetItemsAsync<Owner>(OwnerApiConstants.OwnersUrl);
            return result;
        }

        public async Task UpdateOwnerAsync(Owner owner)
        {
            await _ownerApiClient.UpdateItem<Owner>($"{OwnerApiConstants.OwnersUrl}/{owner.Id}", owner);
        }
    }
}
