using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLibrary
{
    public class TeacherModel
    {
        int teacher_id;
        String teacher_name;
        String sex { set; get; }

        public void set_teacher_id(int id)
        {
            teacher_id = id;
        }

        public int get_teacher_id( )
        {
            return teacher_id;
        }

        public void set_teacher_name(string name)
        {
            this.teacher_name = name;
        }

        public string get_teacher_name( )
        {
            return this.teacher_name;
        }


        public void set_teacher_sex(string sex)
        {
            this.sex = sex;
        }

        public string get_teacher_sex( )
        {
            return this.sex;
        }
    }

}
