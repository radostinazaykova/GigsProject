﻿using GigHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GigHub.Controllers.Api
{
    public class NotificationDto
    {
        public DateTime DateTime { get;  set; }
        public NotificationType Type { get; set; }
        public DateTime? OriginalDateTime { get;  set; }
        public string OriginalVanue { get;  set; }
        public GigDto Gig { get;  set; }
    }
}