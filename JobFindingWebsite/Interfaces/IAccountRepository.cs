﻿using JobFindingWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobFindingWebsite.Interfaces
{
    public interface IAccountRepository
    {
        public Task<IEnumerable<AppUser>> GetAllUsers();
        public Task<AppUser?> GetUserById(string Id);
        public Task<IEnumerable<Company>> GetAllCompanies();
        public Task<Company?> GetCompanyById(string Id);
        public Task<Account?> GetAccountById(string Id);
        public bool Update(Account account);
        public bool UpdateUser(AppUser user);
        public bool UpdateCompany(Company company);
        public bool Save();

    }
}
