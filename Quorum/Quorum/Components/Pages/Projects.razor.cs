using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace Quorum.Components.Pages
{
    public partial class Projects
    {
        [Inject]
        IDbContextFactory<AppDbContext> DbFactory { get; set;  } = default!;
        private List<Quorum.Projekt> projects;
        protected override async Task OnInitializedAsync()
        {
            await using var db = await DbFactory.CreateDbContextAsync();
            projects = await db.projekty.AsNoTracking().ToListAsync();
        }
    }
}
