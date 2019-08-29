using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLibrary
{
    public class StudentAttendanceModel
    {
        String student_id;
        String student_name;
        String entered_date;
        String entered_time;
        String class_id;

        public void set_student_id(String id)
        {
            student_id = id;
        }

        public String get_student_id()
        {
            return student_id;
        }

        public void set_student_name(String student_name)
        {
            this.student_name = student_name;
        }

        public String get_student_name()
        {
            return student_name;
        }

        public void set_entered_date(String entered_date)
        {
            this.entered_date = entered_date;
        }

        public String get_entered_date()
        {
            return entered_date;
        }

        public void set_entered_time(String entered_time)
        {
            this.entered_time = entered_time;
        }

        public String get_entered_time()
        {
            return entered_time;
        }

        public void set_class_id(String class_id)
        {
            this.class_id = class_id;
        }

        public String get_class_id()
        {
            return class_id;
        }
    }
}
