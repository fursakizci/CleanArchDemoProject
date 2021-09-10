using ClearArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearArch.Application.Interfaces
{
    public interface ICourseService
    {
        public CourseViewModel GetCourses();
    }
}
