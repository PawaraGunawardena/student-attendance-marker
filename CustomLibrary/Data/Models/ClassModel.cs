using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLibrary
{
    public class ClassModel
    {
        int class_id;
        String subject;
        String date;
        String time;
        String teacher_name;
        String class_type;
        String class_year;


        public void set_class_id(int id)
        {
            class_id = id;
        }

        public int get_class_id()
        {
            return class_id;
        }

        public void set_subject(string subject)
        {
            this.subject = subject;
        }

        public string get_subject()
        {
            return this.subject;
        }

        public void set_date(string date)
        {
            this.date = date;
        }

        public string get_date()
        {
            return this.date;
        }

        public void set_time(string time)
        {
            this.time = time;
        }

        public string get_time()
        {
            return this.time;
        }
        public void set_teacher_name(string teacher_name)
        {
            this.teacher_name = teacher_name;
        }

        public string get_teacher_name()
        {
            return this.teacher_name;
        }

        public void set_class_type(string class_type)
        {
            this.class_type = class_type;
        }

        public string get_class_type()
        {
            return this.class_type;
        }
        public void set_class_year(String class_year)
        {
            this.class_year = class_year;
        }

        public String get_class_year()
        {
            return this.class_year;
        }

    }
}
