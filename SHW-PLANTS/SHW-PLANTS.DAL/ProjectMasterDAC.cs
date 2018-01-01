using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHW_PLANTS.DAL
{
    public class ProjectMasterDAC
    {
        public int AddProject(ProjectMaster project)
        {
            int projectId = 0;
            try
            {
                using (var db = new PlantsDatabaseEntities())
                {
                    db.ProjectMasters.Add(project);
                    db.SaveChanges();
                    projectId = project.ProjectId;
                }

            }
            catch(Exception ex)
            {
                return projectId;
            }
            return projectId;
        }
        public ProjectMaster GetprojectById(int ProjectId)
        {
            ProjectMaster ProjectDetails = new ProjectMaster();
            using (var db = new PlantsDatabaseEntities())
            {
                ProjectDetails = (from d in db.ProjectMasters
                                  where d.ProjectId==ProjectId

                                  select new ProjectMaster()).FirstOrDefault();
            }
            return ProjectDetails;
            }
    }
}