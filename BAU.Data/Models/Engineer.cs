﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BAU.Data.Models
{
    /*  Engineer

        Author: Chris Fildes
        Date: 22/02/2018
        Description: Data Model for Engineer
    */

    public class Engineer
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Is Available?")]
        public bool IsAvailable { get; set; }

        public virtual ICollection<SupportSlot> SupportSlots { get; set; }
    }
}
