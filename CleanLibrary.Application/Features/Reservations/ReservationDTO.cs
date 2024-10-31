﻿using CleanLibrary.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLibrary.Application.Features.Reservations
{
    public class ReservationDTO
    {
        public required int BookId { get; set; }
        public BookType BookType { get; set; }
        public string ReservationStartDate { get; set; }
        public string ReservationEndDate { get; set; }

        public bool QuickPickup { get; set; }
    }
}
