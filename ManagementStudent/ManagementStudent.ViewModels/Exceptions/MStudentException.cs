using System;

namespace ManagementStudent.ViewModels.Exceptions
{
    public class MStudentException: Exception
    {
        public MStudentException()
        {
        }

        public MStudentException(string message)
            : base(message)
        {
        }

        public MStudentException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
