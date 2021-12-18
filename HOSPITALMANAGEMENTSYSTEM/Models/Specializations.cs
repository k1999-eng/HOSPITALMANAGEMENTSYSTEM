﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HOSPITALMANAGEMENTSYSTEM.Models
{
    public class Specializations
    {
        public int spclId { get; set; }
        public string specializationName { get; set; }
    }
    public enum Special
    {
        GeneralPhysicians,
        Pediatricians,
        GeneralSurgeon,
        Cardiologist,
        Dentist,
        Dermatologists,
        Gynecologist,
        ENTSpecialist,
    }
}
