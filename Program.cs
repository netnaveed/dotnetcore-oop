using System;
using System.Collections.Generic;

namespace oop_proj
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Promoter> promoters = new List<Promoter>()
            {
              new XyzPromoter( "Jone", "Jones", "1111111111" ),
              new XyzPromoter( "Jim", "Jones", "22222222222" ),
              new AbcPromoter( "Jane", "Jones", "3333333333" ),
            };

            foreach(var promoter in promoters)
            {
                promoter.Promote();
            }

            List<Writer> writers = new List<Writer>()
            {
              new BookWriter( "Jone", "Jones" ),
              new BookWriter( "Jim", "Jones" ),
              new BlogWriter( "Jane", "Jones" ),
            };

            foreach(var writer in writers)
            {
                writer.Write();
            }

            List<IBodyBuilder> bodybuilders = new List<IBodyBuilder>()
            {
              new XyzPromoter( "Jone", "Jones", "1111111111" ),
              new XyzPromoter( "Jim", "Jones", "22222222222" )
            };

            foreach(var bodybuilder in bodybuilders)
            {
                bodybuilder.Workout();
            }

            List<IVlogger> vloggers = new List<IVlogger>()
            {
              new XyzPromoter( "Jone", "Jones", "1111111111" ),
              new BookWriter( "Jim", "Jones" )
            };

            foreach(var vlogger in vloggers)
            {
                vlogger.Vlog();
            }
        }
    }
}
