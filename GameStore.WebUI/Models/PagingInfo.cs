using System;

namespace GameStore.WebUI.Models
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }

        public String ParentPage { get; set; }

        public int ItemsPerPage { get; set; }

        public int CurrentPage { get; set; }

        public DateTime Created_at { get; set; }

        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
        }
    }
}