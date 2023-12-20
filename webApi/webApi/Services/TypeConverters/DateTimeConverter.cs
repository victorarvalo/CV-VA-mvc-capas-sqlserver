using AutoMapper;
using System.Globalization;

namespace webApi.Services.TypeConverters
{
    public class DateTimeConverter : IValueConverter<string, DateTime>
    {
        public DateTime Convert(string source, ResolutionContext context)
        {
            string[] formats = { "dd/MM/yyyy" };
            var dateTime = DateTime.ParseExact(source, formats, new CultureInfo("en-US"), DateTimeStyles.None);
            return dateTime;//System.Convert.ToDateTime(source);
        }
    }
}
