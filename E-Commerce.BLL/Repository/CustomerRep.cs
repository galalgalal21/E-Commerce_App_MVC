using AutoMapper;
using E_Commerce.BLL.Interface;
using E_Commerce.DAL.Database;
using E_Commerce.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BLL.Repository
{
    public class CustomerRep : ICustomerRep
    {
        private readonly IMapper mapper;

        private readonly Context context;

        public CustomerRep(Context _context)
        {
            context = _context;
        }
        public Customer Create(Customer obj)
        {
            context.Add(obj);
            context.SaveChanges();
            return obj;
        }

        public void Delete(int id)
        {
            var customer = GetById(id);
            context.Customers.Remove(customer);
            context.SaveChanges();
        }

        public Customer Edit(Customer obj)
        {

            var customer = GetById(obj.id);

            customer.address = obj.address;
            customer.email = obj.email;
            customer.name = obj.name;
            customer.phone = obj.phone;
            customer.Oreders = obj.Oreders;


            context.Customers.Update(customer);
            context.SaveChanges();

            // v customerVM = mapper.Map<CustomerVM>(customer);
            return customer;


        }

        public List<Customer> Get()
        {
            var data = context.Customers.Include(i => i.Oreders).ToList();
            return data;
        }

        public Customer getbyEmail(string email)
        {
            Customer customer = context.Customers.FirstOrDefault(c => c.email == email);
            return customer;
        }

        public Customer GetById(int id)
        {

            Customer customer = context.Customers.Include(i => i.Oreders).FirstOrDefault(x => x.id == id);
            return customer;

        }


    }
}
