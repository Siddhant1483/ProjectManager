using NUnit.Framework;
using System;
using TaskManager.Business;
using TaskManager.Model;

namespace TaskManager.API.Tests
{
    [TestFixture]
    public class ProjectControllerTest
    {
        [Test]
        public void GetTaskDetails()
        {
            try
            {
                using (var project = new ProjectsOperations())
                {
                    var projectList = project.GetProjectDetails();
                    if (projectList != null)
                    {
                        Assert.IsNotNull(projectList);
                    }
                    else
                    {
                        Assert.Fail("Fail No Project Present");

                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [Test]
        public void InsertVaildProject()
        {
            try
            {
                using (var project = new ProjectsOperations())
                {
                    ProjectModel record = new ProjectModel()
                    {                
                        ManagerId = 1,
                        Priority = 5,
                        Projects = "Project 55",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now
                    };

                    var projects = project.InsertProjectDetail(record);
                    if (projects)
                    {
                        Assert.IsTrue(projects, "Pass");
                    }
                    else
                    {
                        Assert.Fail("Fail to Insert Data");

                    }

                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [Test]
        public void InsertInVaildProject()
        {
            try
            {
                using (var project = new ProjectsOperations())
                {
                    ProjectModel record = new ProjectModel()
                    {
                        ManagerId = 555,
                        Priority = 5,
                        Projects = "Test Project",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now
                    };

                    var projects = project.InsertProjectDetail(record);
                    if (projects)
                    {
                        Assert.IsTrue(projects, "Pass");
                    }
                    else
                    {
                        Assert.Fail("Fail to Insert Data");

                    }

                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void UpdateVaildProject()
        {           
            try
            {
                using (var project = new ProjectsOperations())
                {
                    ProjectModel record = new ProjectModel()
                    {
                        Priority = 5,                        
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now,
                        ProjectId = 13,
                        ManagerId = 1,                       
                        Projects = "Task Manager1",                       
                    };

                    var projects = project.UpdateProjectDetail(record);
                    if (projects)
                    {
                        Assert.IsTrue(projects, "Pass");
                    }
                    else
                    {
                        Assert.Fail("Fail to Update Data");

                    }

                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void UpdateInVaildProject()
        {
            try
            {
                using (var project = new ProjectsOperations())
                {
                    ProjectModel record = new ProjectModel()
                    {
                        Priority = 5,
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now,
                        ProjectId = 55,
                        ManagerId = 5,
                        Projects = "Task Manager1",
                    };

                    var projects = project.UpdateProjectDetail(record);
                    if (projects)
                    {
                        Assert.IsTrue(projects, "Pass");
                    }
                    else
                    {
                        Assert.Fail("Fail to Update Data");

                    }

                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void DeleteVaildProject()
        {           
            try
            {
                using (var project = new ProjectsOperations())
                {
                    int ProjectId = 11;
                    var projects = project.DeleteProjectById(ProjectId);
                    if (projects)
                    {
                        Assert.IsTrue(projects, "Pass");
                    }
                    else
                    {
                        Assert.Fail("Fail to Delete Data");

                    }

                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void DeleteInVaildProject()
        {
            try
            {
                using (var project = new ProjectsOperations())
                {
                    int ProjectId = 55;
                    var projects = project.DeleteProjectById(ProjectId);
                    if (projects)
                    {
                        Assert.IsTrue(projects, "Pass");
                    }
                    else
                    {
                        Assert.Fail("Fail to Delete Data");

                    }

                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
