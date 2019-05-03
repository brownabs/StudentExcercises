﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercisesCLI.Models
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SlackHandle { get; set; }

        //T his is to hold the actual foreign key integer
        public int CohortId { get; set; }

        // This property is for storing the C# object representing the department
        public Cohort Cohort { get; set; }
    }
}
