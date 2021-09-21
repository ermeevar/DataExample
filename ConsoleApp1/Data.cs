using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class Data
    {

        public static Subject SubjectData { get; } = new Subject("Математика");

        public static List<Subject> GetSubject()
        {
            List<Subject> subjects = new List<Subject>()
            {
                new Subject("Математика"),
                new Subject("Русский"),
                new Subject("ывпы"),
                new Subject("ыа"),
                new Subject("ыа"),
                new Subject("йфка"),
            };

            return subjects;
        }
    }
}
