using Microsoft.Extensions.DependencyInjection;
using ZadaniaDomowe.Data;

namespace ZadaniaDomowe.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<ZadanieDane>();

            if (context.Zadanie.Any())
            {
                return;
            }

            context.Zadanie.AddRange(
                new Zadanie
                {
                    Opis = "Zrobić Projekt MVC",
                    Termin = DateTime.Parse("2026-06-20"),
                    Wykonane = false
                }
            );
            context.SaveChanges();
        }
    }
}