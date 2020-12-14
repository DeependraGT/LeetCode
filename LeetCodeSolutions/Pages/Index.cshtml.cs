using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Algorithms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LeetCodeSolutions.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            ListNode l1 = new ListNode(2, null);
            Solution2.InsertNode(l1, 4);
            Solution2.InsertNode(l1, 3);

            ListNode l2 = new ListNode(5, null);
            Solution2.InsertNode(l2, 6);
            Solution2.InsertNode(l2, 4);



            Solution2 sol = new Solution2();
            sol.AddTwoNumbers(l1, l2);
        }
        
       


    }
}
