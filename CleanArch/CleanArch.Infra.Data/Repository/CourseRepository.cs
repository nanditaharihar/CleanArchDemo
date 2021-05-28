using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _context;
        public CourseRepository(UniversityDBContext ctx)
        {
            _context = ctx;
        }
        public IEnumerable<Course> GetCourses()
        {
          return _context.Courses;
        }
    }
}
