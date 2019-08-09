using System.Collections.Generic;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public void Create(CourseViewModel vm)
        {
            _bus.SendCommand(new CreateCourseCommand
            (
                vm.Name,
                vm.Description,
                vm.ImageUrl
            ));
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}