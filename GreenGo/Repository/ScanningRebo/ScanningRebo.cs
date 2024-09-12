using GreenGo.Context;

namespace GreenGo.Repository.ScanningRebo
{
    public class ScanningRebo:IScanningRebo
    {
		private readonly GreenGoDbContext _context;
		public ScanningRebo(GreenGoDbContext context)
		{
			_context = context;
		}
	}
}
