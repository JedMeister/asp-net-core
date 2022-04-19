using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TurnkeyExampleApp.Data;
using TurnkeyExampleApp.Models;

namespace TurnkeyExampleApp.Pages
{
    public class DBExampleModel : PageModel
    {
        private readonly ExampleContext _context;
        private readonly ILogger<DBExampleModel> _logger;

        public DBExampleModel(ILogger<DBExampleModel> logger, ExampleContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IList<ExampleThing>? ExampleThing = null;

        public async Task OnGetAsync()
        {
            ExampleThing = await _context.ExampleThings.ToListAsync();
        }
    }
}
