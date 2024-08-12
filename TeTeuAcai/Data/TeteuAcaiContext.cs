using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TeTeuAcai.Data;

public class TeteuAcaiContext : IdentityDbContext
{
    public TeteuAcaiContext(DbContextOptions<TeteuAcaiContext> options) : base(options)
    {
    }
}
