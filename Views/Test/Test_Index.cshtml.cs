using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace My1.Views.Test
{
    public class Test_Index : PageModel
    {
        private readonly ILogger<Test_Index> _logger;

        public Test_Index(ILogger<Test_Index> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public string PrintMessage()
        {
            return "<h1>Hello World!</h1><p>This is also one of my first webpage so let it loa please </p>";
        }
    }
}