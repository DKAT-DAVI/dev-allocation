using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace dev_allocation
{
    internal class Repository:DbContext
    {
        // Singleton for database connection
        private static MySqlConnection _dbConnection;
        public static MySqlConnection GetConnection()
        {
            if (_dbConnection == null)
            {
                String connectionString = ConfigurationManager.ConnectionStrings["DevAllocation"].ConnectionString;
                _dbConnection = new MySqlConnection(connectionString);
            }
            return _dbConnection;
        }

        public DbSet<Developer> Developers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Allocation> Alocations { get; set; }
        public DbSet<Task> Tasks { get; set; }
        
        public Repository() : base(GetConnection(), false)
        {
            if (Database.CreateIfNotExists())
            {
                Repository dbContext = this;

                //-- Developers
                Developer d1 = new Developer("Davi Kalel", new DateTime(2005, 09, 05), 'S');
                Credential c1 = new Credential("dkatdavi@gmail.com", "dkatdavi", true, true);
                d1.Credential = c1;
                c1.Developer = d1;

                Developer d2 = new Developer("Pedro Isaque", new DateTime(2008, 06, 09), 'P');
                Credential c2 = new Credential("piatpedro@gmail.com", "piatpedro", true, true);
                d2.Credential = c2;
                c2.Developer = d2;

                Developer d3 = new Developer("Sebastião Juares", new DateTime(1969, 01, 10), 'S');
                Credential c3 = new Credential("sjtjuares@gmail.com", "sjtjuares", true, true);
                d3.Credential = c3;
                c3.Developer = d3;

                Developer d4 = new Developer("Giane Aparecida", new DateTime(1978, 09, 22), 'P');
                Credential c4 = new Credential("gaatgiane@gmail.com", "gaatgiane", true, false);
                d4.Credential = c4;
                c4.Developer = d4;

                Developer d5 = new Developer("Matheus Alexander", new DateTime(1995, 09, 05), 'P');
                Credential c5 = new Credential("maatmatheus@gmail.com", "maatmatheus", true, false);
                d5.Credential = c5;
                c5.Developer = d5;

                Developer d6 = new Developer("Ana Gabriela", new DateTime(1999, 01, 19), 'J');
                Credential c6 = new Credential("agatgabriela@gmail.com", "agatgabriela", true, false);
                d6.Credential = c6;
                c6.Developer = d6;
                //--//

                //-- Projects
                //
                // Contructor(Name, StartIn, FinishPlannedIn, FinishIn)
                Project p1 = new Project("Sistema Farmácia", new DateTime(2021, 10, 12), new DateTime(2022, 10, 12), new DateTime(2022, 09, 10));
                
                Project p2 = new Project("Sistema Restaurante", new DateTime(2022, 01, 03), new DateTime(2022, 12, 03), new DateTime(2022, 12, 30));
                //--//

                //-- Alocations
                //
                // Constructor(StartIn, FinishIn, HoursWorkPerWeek, Remuneration)
                Allocation a1 = new Allocation(new DateTime(2021, 10, 12), new DateTime(2022, 10, 12), 30, 5000.00m);
                Allocation a2 = new Allocation(new DateTime(2022, 01, 03), new DateTime(2022, 06, 15), 20, 2000.00m);


                Allocation a3 = new Allocation(new DateTime(2021, 01, 03), new DateTime(2022, 12, 03), 30, 6000.00m);
                Allocation a4 = new Allocation(new DateTime(2021, 01, 05), new DateTime(2022, 09, 05), 20, 3000.00m);

                Allocation a5 = new Allocation(new DateTime(2021, 03, 10), new DateTime(2022, 12, 03), 30, 4000.00m);
                Allocation a6 = new Allocation(new DateTime(2021, 04, 30), new DateTime(2022, 11, 30), 20, 4000.00m);
                //--//

                //-- Taks
                Task t1 = new Task("Trabalhar na construção completa do Sistema", a1);
                Task t2 = new Task("Fazer a modelagem do banco de dados", a1);

                Task t3 = new Task("Fazer a parte gráfica do sistema", a2);
                Task t4 = new Task("Fazer o backend da aplicação", a2);

                Task t5 = new Task("Trabalhar na construção completa do Sistema", a3);
                Task t6 = new Task("Fazer a modelagem do banco de dados", a3);

                Task t7 = new Task("Fazer a parte gráfica do sistema", a4);
                Task t8 = new Task("Fazer o backend da aplicação", a4);
                //--//

                //-- Relationship Alocation - Developer
                a1.Developer = d1;
                d1.Allocations.Add(a1);

                a2.Developer = d2;
                d2.Allocations.Add(a2);

                a3.Developer = d3;
                d3.Allocations.Add(a3);

                a4.Developer = d4;
                d4.Allocations.Add(a4);

                a5.Developer = d5;
                d5.Allocations.Add(a5);

                a6.Developer = d6;
                d6.Allocations.Add(a6);
                //--//

                //-- Relationship Alocation - Project
                a1.Project = p1;
                p1.Allocations.Add(a1);

                a2.Project = p1;
                p1.Allocations.Add(a2);

                a3.Project = p1;
                p1.Allocations.Add(a3);

                a4.Project = p2;
                p2.Allocations.Add(a4);

                a5.Project = p2;
                p2.Allocations.Add(a5);
                
                a6.Project = p2;
                p2.Allocations.Add(a6);
                //--//

                // Saving Developers
                dbContext.Developers.Add(d1);
                dbContext.Developers.Add(d2);
                dbContext.Developers.Add(d3);
                dbContext.Developers.Add(d4);
                dbContext.Developers.Add(d5);
                dbContext.Developers.Add(d6);
                //

                // Saving Projects
                dbContext.Projects.Add(p1);
                dbContext.Projects.Add(p2);
                //

                // Saving Alocations
                dbContext.Alocations.Add(a1);
                dbContext.Alocations.Add(a2);
                dbContext.Alocations.Add(a3);
                dbContext.Alocations.Add(a4);
                dbContext.Alocations.Add(a5);
                dbContext.Alocations.Add(a6);
                //

                // Saving Tasks
                dbContext.Tasks.Add(t1);
                dbContext.Tasks.Add(t2);
                dbContext.Tasks.Add(t3);
                dbContext.Tasks.Add(t4);
                dbContext.Tasks.Add(t5);
                dbContext.Tasks.Add(t6);
                dbContext.Tasks.Add(t7);
                dbContext.Tasks.Add(t8);
                //

                dbContext.SaveChanges();
            }
        }
    }
}

