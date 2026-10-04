using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_HW14
{
    internal class Converter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is ProductCategory category)
            {
                switch (category)
                {
                    case ProductCategory.Еда:
                        return "Еда";
                    case ProductCategory.БытоваяТехника:
                        return "Бытовая техника";
                    case ProductCategory.БытоваяХимия:
                        return "Бытовая химия";
                    default:
                        return null;
                }
            }
            return null;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
