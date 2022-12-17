using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_allocation.Data.Repositorys
{
    internal class ProjectRepository
    {
        /// Method to save projects in database
        public static void SaveProject(Project project)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (project.Id == 0)
                    {
                        dbContext.Projects.Add(project);
                    }
                    else
                    {
                        dbContext.Entry(project).State = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
