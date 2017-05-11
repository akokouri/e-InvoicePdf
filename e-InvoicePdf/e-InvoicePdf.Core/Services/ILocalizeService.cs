using System.Globalization;

namespace e_InvoicePdf.Core.Services
{
    public interface ILocalizeService
    {
        CultureInfo GetCurrentCultureInfo();
    }
}
