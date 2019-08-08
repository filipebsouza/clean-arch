using System.Collections.Generic;
using CleanArch.Domain.Models;

namespace Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}