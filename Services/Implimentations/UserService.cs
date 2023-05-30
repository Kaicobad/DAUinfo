
using DAUinfo.ApplicationDbContext;
using DAUinfo.Model;
using DAUinfo.Model.DTO;
using DAUinfo.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DAUinfo.Services.Implimentations
{
    public class UserService : IUser
    {
        private readonly ApplicationDbContext.ApplicationDbContext _dbContext;

        public UserService(ApplicationDbContext.ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpPost("addUser")]
        public async Task<User> AddUser(User user)
        {
            try
            {
                await _dbContext.User.AddAsync(user);
                await _dbContext.SaveChangesAsync();
                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("getall")]
        public async Task<List<User>> GetAllUser()
        {
            try
            {
                var userinfo = await _dbContext.User.ToListAsync();
                return userinfo;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
