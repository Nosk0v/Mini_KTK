﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_KTK.Model
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserId { get; set; }
        public News(string title, string description, DateTime createDate, int userId) 
        {
            Title = title;
            Description = description;
            CreateDate = createDate;
            UserId = userId;
        }

    }
}
