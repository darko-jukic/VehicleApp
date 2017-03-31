﻿using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleApp.Repository.Models;
using VehicleApp.Service.Model.Common;

namespace VehicleApp.Repository.Interfaces
{
    public interface IVehicleMakeRepository : IRepository<VehicleMake>
    {
        Task<IEnumerable<IVehicleMake>> GetPage(int? page, string searchBy, string searchTerm, string sortBy);
        //VehicleMake Add(VehicleMake vehicleMake);
        //Task<VehicleMake> Edit(int? Id);
        //void EditAsync(VehicleMake vehicleMake);
        //Task<VehicleMake> Delete(int? Id);
        //Task DeleteAsync(int? Id);
        //Task SaveAsync();
    }
}
