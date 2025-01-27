﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;

namespace FlamingSoftHR.Client.Services
{
    public interface IJobService
    {
        Task<JobDataResult> GetJobs(int skip, int take);
        Task<IEnumerable<Job>> GetJobsByDepartment(int id);
        Task<Job> GetJob(int id);
        Task<Job> AddJob(Job jobToAdd);
        Task<Job> UpdateJob(Job jobToUpdate);
        Task DeleteJob(int id);
    }
}
