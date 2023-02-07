using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.BusinessLogic
{
    public class BusinessLayer : IBusinessLayer
    {
        private MyDBContext _myDBContext;

        public BusinessLayer(MyDBContext myDBContext)
        {
            _myDBContext = myDBContext ?? throw new ArgumentNullException(nameof(myDBContext));
        }

        public async Task<List<Department>> GetDepartmentsAsync()
        {
            return await _myDBContext.Departments.ToListAsync();

        }
    }
}
