﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using VehicleApp.Service.Interfaces;
using VehicleApp.Service.Models;

namespace VehicleApp.Service
{
    public class VehicleMakeService : IVehicleMakeService
    {
        private VehicleDbContext context;
        public VehicleMakeService(VehicleDbContext context)
        {
            this.context = context;
        }
        public List<VehicleMake> Get(int? page, string searchTerm)
        {
            // Need to implement paging and filtering in future
            var model = context.Makes.Where(vehicle => searchTerm == null || vehicle.Name.StartsWith(searchTerm))
                .OrderBy(vehicle => vehicle.Name)
                .ToList();
            return model;
        }

        public void Create(VehicleMake vehicleMake)
        {
            context.Makes.Add(vehicleMake);
            context.SaveChanges();
        }

        public VehicleMake Edit(int? Id)
        {
            var model = context.Makes.Find(Id);
            return model;
        }
        public void Edit(VehicleMake vehicleMake)
        {
            context.Entry(vehicleMake).State = EntityState.Modified;
            context.SaveChanges();
        }

        public VehicleMake Delete(int? Id)
        {
            return context.Makes.Find(Id);
        }
        public void DeleteConfirmed(int? Id)
        {
            VehicleMake vehicleMake = context.Makes.Find(Id);
            context.Makes.Remove(vehicleMake);
            context.SaveChanges();
        }
    }
}
