using Common.ViewModel;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel
{
    public class CourseViewModel : BaseViewModel
    {
        public CourseViewModel(Course course) : base(course)
        {
            CourseName = course.CourseName;
            Topic = course.Topic;
            IsFree = course.IsFree;
        }

        public string CourseName { get; set; }
        public string Topic { get; set; }
        public bool IsFree { get; set; }
    }
}
