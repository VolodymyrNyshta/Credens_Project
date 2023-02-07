using WebApplication2.Models;

namespace WebApplication2.BusinessLogic
{
    public interface IBusinessLayer
    {
        Task<List<Department>> GetDepartmentsAsync();
    }
}