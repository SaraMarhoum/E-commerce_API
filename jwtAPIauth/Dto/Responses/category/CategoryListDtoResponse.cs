﻿using jwtAPIauth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using jwtAPIauth.Dto.Responses.category;
using System.Threading.Tasks;

namespace jwtAPIauth.Dto.Responses
{
    public class CategoryListDtoResponse : PagedDto
    {
        public IEnumerable<CategoryDto> Categories { get; set; }


        public static CategoryListDtoResponse Build(List<Models.Category> categories,
                string basePath,
                int currentPage, int pageSize, int totalItemCount)
        {
           
            return new CategoryListDtoResponse
            {
                PageMeta = new PageMeta(categories.Count, basePath, currentPageNumber: currentPage, requestedPageSize: pageSize,
                    totalItemCount: totalItemCount),
            };
        }
    }
}
