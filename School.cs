using System;
using System.Collections.Generic;

namespace Lab10
{
    class School
    {
        public List<student> Students { get; set; } = new List<student>();
        public (student min, student max) FindExtremumStudents() 
        {
            int resultOfComparing;

            // нахождение самого продуктивного гука
            student bestStudent = Students[0];            
            foreach (student s in Students)
            {
                resultOfComparing = bestStudent.CompareTo(s);
                if (resultOfComparing < 0)
                {
                    bestStudent = s;
                }
                else if (resultOfComparing == 0)
                {
                    if ((int)s.position < (int)bestStudent.position)
                    {
                        bestStudent = s;
                    }
                }                
            }

            // нахождение засланного западными спецслужбами капиталиста, старающегося развалить
            // великий социалистический строй китайской НАРОДНОЙ республики
            student worstStudent = Students[0];
            foreach (student s in Students)
            {
                resultOfComparing = worstStudent.CompareTo(s);
                if (resultOfComparing > 0)
                {
                    worstStudent = s;
                }
                else if (resultOfComparing == 0)
                {
                    if ((int)s.position > (int)worstStudent.position)
                    {
                        worstStudent = s;
                    }
                }
            }
            (student, student) minMax = (worstStudent, bestStudent);
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
