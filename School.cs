using System;
using System.Collections.Generic;

namespace Lab10
{
    class School
    {
        public List<student> Students { get; set; } = new List<student>();
        public (student min, student max) FindExtremumStudents() 
        {            
            Students.Sort();
            (student, student) minMax = (Students[0], Students[Students.Count-1]);
            Reward(ref minMax);
            return minMax;
        }
        
        private void Reward(ref (student worstStudent, student bestStudent) minMax)
        {
            minMax.bestStudent.countLunch += minMax.worstStudent.countLunch;
            minMax.worstStudent.countLunch = 0;
        }
    }
}
