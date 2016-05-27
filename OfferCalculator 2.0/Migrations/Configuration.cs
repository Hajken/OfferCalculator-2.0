namespace OfferCalculator_2._0.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OfferCalculator_2._0.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OfferCalculator_2._0.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Items.AddOrUpdate(
             p => p.ID,
             new ItemModels { ID = 1,  TypeOfWork = "Profilierad takplåt" },
             new ItemModels { ID = 2,  TypeOfWork = "Hörnlister" },
             new ItemModels { ID = 3,  TypeOfWork = "Smyglister" },
             new ItemModels { ID = 4,  TypeOfWork = "Pilaster" },
             new ItemModels { ID = 5,  TypeOfWork = "Taklist" },
             new ItemModels { ID = 6,  TypeOfWork = "Nocklist" },
             new ItemModels { ID = 7,  TypeOfWork = "Stödlist" },
             new ItemModels { ID = 8,  TypeOfWork = "Kassetter" },
             new ItemModels { ID = 9,  TypeOfWork = "Skivtäckning-vägg " },
             new ItemModels { ID = 10, TypeOfWork = "Bandtäckning-vägg" },
             new ItemModels { ID = 11, TypeOfWork = "Skivtäckning-tak-dubbelfalsad" },
             new ItemModels { ID = 12, TypeOfWork = "Bandtäckning-tak-dubbelfalsad" },
             new ItemModels { ID = 13, TypeOfWork = "Täckning-Takkupa" },
             new ItemModels { ID = 14, TypeOfWork = "Täckning-Torn" },
             new ItemModels { ID = 15, TypeOfWork = "Täckning-Burspråk" },
             new ItemModels { ID = 16, TypeOfWork = "Inlagning" },
             new ItemModels { ID = 17, TypeOfWork = "Gavelskiva-1-Dels enkelfalsad" },
             new ItemModels { ID = 18, TypeOfWork = "Krönlist 2-dels dubbelfalsad" },
             new ItemModels { ID = 19, TypeOfWork = "Krönlist 3-dels dubbelfalsad" },
             new ItemModels { ID = 20, TypeOfWork = "Hängskiva dubbelfalsad" },
             new ItemModels { ID = 21, TypeOfWork = "Fönsterbläck sluss/fals" },
             new ItemModels { ID = 22, TypeOfWork = "Fasadlist/sockellist sluss/fals" },
             new ItemModels { ID = 23, TypeOfWork = "Tröskelbleck sluss/fals" },
             new ItemModels { ID = 24, TypeOfWork = "Ståndskiva" },
             new ItemModels { ID = 25, TypeOfWork = "Fotplåt papp & tegeltak" },
             new ItemModels { ID = 26, TypeOfWork = "Fotränna" },
             new ItemModels { ID = 27, TypeOfWork = "Gesimsränna" },
             new ItemModels { ID = 28, TypeOfWork = "Vinkelränna EF" },
             new ItemModels { ID = 29, TypeOfWork = "Stuprör" },
             new ItemModels { ID = 30, TypeOfWork = "Hängränna halvrund (rund)" },
             new ItemModels { ID = 31, TypeOfWork = "Hängränna rektangulär (kantig)" },
             new ItemModels { ID = 32, TypeOfWork = "Helbeslagning på plåttak" },
             new ItemModels { ID = 33, TypeOfWork = "Helbeslagning på tegel och papptak" },
             new ItemModels { ID = 34, TypeOfWork = "Nederbeslag på tegel och papptak" },
             new ItemModels { ID = 35, TypeOfWork = "Överbeslag" },
             new ItemModels { ID = 36, TypeOfWork = "Underbeslag på tegel och papptak" },
             new ItemModels { ID = 37, TypeOfWork = "Takfönster på tegel och papptak" },
             new ItemModels { ID = 38, TypeOfWork = "Ventilationshuv cirkl eller rektangulär" },
             new ItemModels { ID = 39, TypeOfWork = "Taklucka" },
             new ItemModels { ID = 40, TypeOfWork = "Stosar (stospanna) runda och kantiga tom 130cm" }, 
             new ItemModels { ID = 50, TypeOfWork = "Målning av garnering(lister)" },
             new ItemModels { ID = 51, TypeOfWork = "Målning av rör och ränna" },
             new ItemModels { ID = 52, TypeOfWork = "Målning på tak och vägg" },
             new ItemModels { ID = 53, TypeOfWork = "Isolering" },
             new ItemModels { ID = 54, TypeOfWork = "Reglar och Balk" },
             new ItemModels { ID = 55, TypeOfWork = "Rostfri typ 2B" },
             new ItemModels { ID = 56, TypeOfWork = "Taksäkerhet" },
             new ItemModels { ID = 57, TypeOfWork = "Invändig täckning" },
             new ItemModels { ID = 58, TypeOfWork = "Tak och väggelement" },
             new ItemModels { ID = 59, TypeOfWork = "Tegeltak" },
             new ItemModels { ID = 60, TypeOfWork = "Takpapp och takduk" },
             new ItemModels { ID = 61, TypeOfWork = "HEA balk/pelare" },
             new ItemModels { ID = 62, TypeOfWork = "UNP balk/pelare" },
             new ItemModels { ID = 63, TypeOfWork = "UNP portomfattning och avväxling" },
             new ItemModels { ID = 64, TypeOfWork = "VKR balk/pelare " },
             new ItemModels { ID = 65, TypeOfWork = "VKR konsoler portomfattning" },
             new ItemModels { ID = 66, TypeOfWork = "L-vinkelstång" },
             new ItemModels { ID = 67, TypeOfWork = "L-konsol & portomfattning" },
             new ItemModels { ID = 68, TypeOfWork = "L-avväxling" },
             new ItemModels { ID = 69, TypeOfWork = "T-stång" },
             new ItemModels { ID = 70, TypeOfWork = "Z-stång" },
             new ItemModels { ID = 71, TypeOfWork = "Plattstång" },
             new ItemModels { ID = 72, TypeOfWork = "Rundstång" },
             new ItemModels { ID = 73, TypeOfWork = "Kvadratstång" },
             new ItemModels { ID = 74, TypeOfWork = "U-stång" },
             new ItemModels { ID = 75, TypeOfWork = "Ämnesrör" },
             new ItemModels { ID = 76, TypeOfWork = "Sömlösa rör" },
             new ItemModels { ID = 77, TypeOfWork = "Plåt & durk" },
             new ItemModels { ID = 78, TypeOfWork = "Stålfackvärk" }
           );
        }
    }
}
