﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KonSchool_Desktop.Pages
{
    public class Comparison1Model : PageModel
    {
        [BindProperty]
        public string MF_TS { get; set; }
        [BindProperty]
        public string MF_AA { get; set; }
        [BindProperty]
        public string MF_LA { get; set; }
        [BindProperty]
        public string MF_SA { get; set; }
        [BindProperty]
        public string MF_MP { get; set; }
        [BindProperty]
        public string MF_SE { get; set; }
        [BindProperty]
        public string TS_AA { get; set; }
        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();
            return RedirectToPage("/About");
        }

    }
}