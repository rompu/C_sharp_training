using System;

namespace Coupling
{
    class Program
    {
        static void Main(string[] args)
        {
            //composition refered to as Has-A relationship (e.g. car has an engine)
            //in this example: boht Installer and DBMigrator have a logger
            var logger = new Logger();

            var installer = new Installer(logger);
            var dbMigrator = new DBMigrator(logger);

            
            installer.Install();
            dbMigrator.Migrate();
        }
    }
    class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Installer
    {


        private readonly Logger _logger; //underline is used for private fields!

        public Installer(Logger logger)
        {
            this._logger = logger;
        }

        public void Install()
        {
            _logger.Log("We are installing application into....");
        }
    }



    class DBMigrator
    {
        private readonly Logger _logger;

        public DBMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating all data into .... ");
        }
    }
}
