using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    struct student: IComparable
    {
        public uint number;
        public uint countPhone;
        public uint countLunch;
        public Position position;

        public int CompareTo(object studentObj)
        {
            student st = (student)(studentObj as student?);
            int phoneComparing = this.countPhone.CompareTo(st.countPhone);
            if (phoneComparing == 0)
            {
                return ((int)this.position).CompareTo((int)st.position);
            }
            else
            {
                return phoneComparing;
            }
        }
    }
}
