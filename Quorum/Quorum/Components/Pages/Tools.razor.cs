using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace Quorum.Components.Pages
{
    public partial class Tools
    {
        [Inject]
        IDbContextFactory<AppDbContext> DbFactory { get; set; } = default!;

        private List<Quorum.Tools> toolz;

        protected override async Task OnInitializedAsync()
        {
            await using var db = await DbFactory.CreateDbContextAsync();
            toolz = await db.toolsy.AsNoTracking().ToListAsync();
        }
    }
}
