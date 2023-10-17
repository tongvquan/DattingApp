using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class PaginationHeader
    {
        public PaginationHeader(int currentPage, int itemsPerpage, int totalItems, int totalPages)
        {
            CurrentPage = currentPage;
            ItemsPerpage = itemsPerpage;
            TotalPages = totalPages;
            TotalItems = totalItems;
        }

        public int CurrentPage { get; set; }
        public int ItemsPerpage { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
        
    }
}