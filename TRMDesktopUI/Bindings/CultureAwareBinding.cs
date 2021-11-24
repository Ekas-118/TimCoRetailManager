using System.Globalization;
using System.Windows.Data;

namespace TRMDesktopUI.Bindings
{
    /// <summary>
    /// Custom binding for when the correct culture is needed (e.g. when displaying date or currency)
    /// </summary>
    public class CultureAwareBinding : Binding
    {
        public CultureAwareBinding()
        {
            ConverterCulture = CultureInfo.CurrentCulture;
        }

        public CultureAwareBinding(string path) : base(path)
        {
            ConverterCulture = CultureInfo.CurrentCulture;
        }
    }
}
