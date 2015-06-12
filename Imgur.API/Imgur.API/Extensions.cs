using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imgur.API
{
    static class Extensions
    {
        public static void ReportSafe<T>(this IProgress<T> progress, T value)
        {
            if (progress != null)
            {
                progress.Report(value);
            }
        }

        public static string EmptyIfNull(this string target)
        {
            return target == null ? "" : target;
        }

        public static string EmptyIfNull(this bool? target)
        {
            return target.HasValue ? target.Value.ToString() : "";
        }

        public static string EmptyIfNull(this DateTime? target)
        {
            return target.HasValue ? target.Value.ToString() : "";
        }

    }
}
