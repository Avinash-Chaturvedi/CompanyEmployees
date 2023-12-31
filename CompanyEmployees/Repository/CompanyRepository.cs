﻿using Contracts;
using Entities.Models;
using Repository;

public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
{
    public CompanyRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

    public IEnumerable<Company> GetAllCompanies(bool trackChanges) => 
        FindAll(trackChanges).OrderBy(c => c.Name).ToList();
}