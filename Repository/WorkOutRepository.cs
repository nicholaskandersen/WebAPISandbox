using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class WorkOutRepository : RepositoryBase<WorkOut>, IWorkOutRepository
    {
        public WorkOutRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}
