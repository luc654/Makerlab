using DotNetEnv;
using Microsoft.EntityFrameworkCore;

namespace Makerlab.Infrastructure;

public class MakerLabDBContext :DbContext
{
    public MakerLabDBContext(DbContextOptions<MakerLabDBContext> options) : base(options) { }

}
