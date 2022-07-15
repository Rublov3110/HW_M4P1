using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_M4L3
{
    public sealed class Program
    {
        internal static void Main(string[] args)
        {
            using (ApplicationContext context = new ApplicationContextFactory().CreateDbContext(Array.Empty<string>()))
            {
                

            }
        }
    }
}
