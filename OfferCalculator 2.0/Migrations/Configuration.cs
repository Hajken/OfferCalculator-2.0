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
             new ItemModels { ID = 1,  TypeOfWork = "Profilierad takpl�t" },
             new ItemModels { ID = 2,  TypeOfWork = "H�rnlister" },
             new ItemModels { ID = 3,  TypeOfWork = "Smyglister" },
             new ItemModels { ID = 4,  TypeOfWork = "Pilaster" },
             new ItemModels { ID = 5,  TypeOfWork = "Taklist" },
             new ItemModels { ID = 6,  TypeOfWork = "Nocklist" },
             new ItemModels { ID = 7,  TypeOfWork = "St�dlist" },
             new ItemModels { ID = 8,  TypeOfWork = "Kassetter" },
             new ItemModels { ID = 9,  TypeOfWork = "Skivt�ckning-v�gg " },
             new ItemModels { ID = 10, TypeOfWork = "Bandt�ckning-v�gg" },
             new ItemModels { ID = 11, TypeOfWork = "Skivt�ckning-tak-dubbelfalsad" },
             new ItemModels { ID = 12, TypeOfWork = "Bandt�ckning-tak-dubbelfalsad" },
             new ItemModels { ID = 13, TypeOfWork = "T�ckning-Takkupa" },
             new ItemModels { ID = 14, TypeOfWork = "T�ckning-Torn" },
             new ItemModels { ID = 15, TypeOfWork = "T�ckning-Burspr�k" },
             new ItemModels { ID = 16, TypeOfWork = "Inlagning" },
             new ItemModels { ID = 17, TypeOfWork = "Gavelskiva-1-Dels enkelfalsad" },
             new ItemModels { ID = 18, TypeOfWork = "Kr�nlist 2-dels dubbelfalsad" },
             new ItemModels { ID = 19, TypeOfWork = "Kr�nlist 3-dels dubbelfalsad" },
             new ItemModels { ID = 20, TypeOfWork = "H�ngskiva dubbelfalsad" },
             new ItemModels { ID = 21, TypeOfWork = "F�nsterbl�ck sluss/fals" },
             new ItemModels { ID = 22, TypeOfWork = "Fasadlist/sockellist sluss/fals" },
             new ItemModels { ID = 23, TypeOfWork = "Tr�skelbleck sluss/fals" },
             new ItemModels { ID = 24, TypeOfWork = "St�ndskiva" },
             new ItemModels { ID = 25, TypeOfWork = "Fotpl�t papp & tegeltak" },
             new ItemModels { ID = 26, TypeOfWork = "Fotr�nna" },
             new ItemModels { ID = 27, TypeOfWork = "Gesimsr�nna" },
             new ItemModels { ID = 28, TypeOfWork = "Vinkelr�nna EF" },
             new ItemModels { ID = 29, TypeOfWork = "Stupr�r" },
             new ItemModels { ID = 30, TypeOfWork = "H�ngr�nna halvrund (rund)" },
             new ItemModels { ID = 31, TypeOfWork = "H�ngr�nna rektangul�r (kantig)" },
             new ItemModels { ID = 32, TypeOfWork = "Helbeslagning p� pl�ttak" },
             new ItemModels { ID = 33, TypeOfWork = "Helbeslagning p� tegel och papptak" },
             new ItemModels { ID = 34, TypeOfWork = "Nederbeslag p� tegel och papptak" },
             new ItemModels { ID = 35, TypeOfWork = "�verbeslag" },
             new ItemModels { ID = 36, TypeOfWork = "Underbeslag p� tegel och papptak" },
             new ItemModels { ID = 37, TypeOfWork = "Takf�nster p� tegel och papptak" },
             new ItemModels { ID = 38, TypeOfWork = "Ventilationshuv cirkl eller rektangul�r" },
             new ItemModels { ID = 39, TypeOfWork = "Taklucka" },
             new ItemModels { ID = 40, TypeOfWork = "Stosar (stospanna) runda och kantiga tom 130cm" }, 
             new ItemModels { ID = 50, TypeOfWork = "M�lning av garnering(lister)" },
             new ItemModels { ID = 51, TypeOfWork = "M�lning av r�r och r�nna" },
             new ItemModels { ID = 52, TypeOfWork = "M�lning p� tak och v�gg" },
             new ItemModels { ID = 53, TypeOfWork = "Isolering" },
             new ItemModels { ID = 54, TypeOfWork = "Reglar och Balk" },
             new ItemModels { ID = 55, TypeOfWork = "Rostfri typ 2B" },
             new ItemModels { ID = 56, TypeOfWork = "Taks�kerhet" },
             new ItemModels { ID = 57, TypeOfWork = "Inv�ndig t�ckning" },
             new ItemModels { ID = 58, TypeOfWork = "Tak och v�ggelement" },
             new ItemModels { ID = 59, TypeOfWork = "Tegeltak" },
             new ItemModels { ID = 60, TypeOfWork = "Takpapp och takduk" },
             new ItemModels { ID = 61, TypeOfWork = "HEA balk/pelare" },
             new ItemModels { ID = 62, TypeOfWork = "UNP balk/pelare" },
             new ItemModels { ID = 63, TypeOfWork = "UNP portomfattning och avv�xling" },
             new ItemModels { ID = 64, TypeOfWork = "VKR balk/pelare " },
             new ItemModels { ID = 65, TypeOfWork = "VKR konsoler portomfattning" },
             new ItemModels { ID = 66, TypeOfWork = "L-vinkelst�ng" },
             new ItemModels { ID = 67, TypeOfWork = "L-konsol & portomfattning" },
             new ItemModels { ID = 68, TypeOfWork = "L-avv�xling" },
             new ItemModels { ID = 69, TypeOfWork = "T-st�ng" },
             new ItemModels { ID = 70, TypeOfWork = "Z-st�ng" },
             new ItemModels { ID = 71, TypeOfWork = "Plattst�ng" },
             new ItemModels { ID = 72, TypeOfWork = "Rundst�ng" },
             new ItemModels { ID = 73, TypeOfWork = "Kvadratst�ng" },
             new ItemModels { ID = 74, TypeOfWork = "U-st�ng" },
             new ItemModels { ID = 75, TypeOfWork = "�mnesr�r" },
             new ItemModels { ID = 76, TypeOfWork = "S�ml�sa r�r" },
             new ItemModels { ID = 77, TypeOfWork = "Pl�t & durk" },
             new ItemModels { ID = 78, TypeOfWork = "St�lfackv�rk" }
           );
        }
    }
}
