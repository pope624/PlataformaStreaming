﻿using SampleAPI.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SampleAPI.Domain.Infrastructure.Repositories
{
    public interface ISubjectRepository
    {
        Task CreateSubjectAsync(Subject subject);
        Task DeleteSubjectAsync(Subject subject);
        Task UpdateSubjectAsync(Subject subject);
    }
}