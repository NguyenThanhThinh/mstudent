using System;

namespace ManagementStudent.Utilities.Exceptions
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
