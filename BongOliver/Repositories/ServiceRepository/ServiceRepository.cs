﻿using BongOliver.Models;
using Microsoft.EntityFrameworkCore;

namespace BongOliver.Repositories.ServiceRepository
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly DataContext _context;

        public ServiceRepository(DataContext context)
        {
            _context = context;
        }
        public void CreateService(Service service)
        {
            _context.Services.Add(service);
        }

        public void DeleteService(Service service)
        {
            _context.Services.Remove(service);
        }

        public Service GetServiceById(int id)
        {
            return _context.Services.Include(s => s.ServiceType).Include(s => s.Rates).FirstOrDefault(x => x.id == id);
        }

        public List<Service> GetServices(int? page = 1, int? pageSize = 10, string? key = "", string? sortBy = "id")
        {
            var query = _context.Services.Include(s => s.ServiceType).Include(s => s.Rates).AsQueryable();

            if (!string.IsNullOrEmpty(key))
            {
                query = query.Where(u => u.name.ToLower().Contains(key.ToLower()));
            }

            switch (sortBy)
            {
                case "name":
                    query = query.OrderBy(u => u.name);
                    break;
                case "price":
                    query = query.OrderBy(u => u.price);
                    break;
                default:
                    query = query.OrderBy(u => u.id);
                    break;
            }
            if (page == null || pageSize == null || sortBy == null) { return query.ToList(); }
            else
                return query.Skip((page.Value - 1) * pageSize.Value).Take(pageSize.Value).ToList();
        }

        public int GetTotal()
        {
            return _context.Services.Count();
        }

        public List<ServiceType> GetTypes()
        {
            return _context.ServiceTypes.ToList();
        }

        public bool IsSaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        public void UpdateService(Service service)
        {
            _context.Services.Update(service);
        }
    }
}
