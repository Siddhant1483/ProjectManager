using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using TaskManager.API.Controllers;
using TaskManager.Business;
using TaskManager.Model;

namespace TaskManager.API.Tests
{
    [TestFixture]
    public class TaskControllerTest
    {
        [Test]
        public void GetTaskDetails()
        {
            try
            {
                using (var task = new TaskOperations())
                {
                    var taskList = task.GetTaskDetails();
                    if (taskList != null)
                    {
                        Assert.IsNotNull(taskList);
                    }
                    else
                    {
                        Assert.Fail("Fail No Task Present");

                    }
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [Test]
        public void GetTaskDetailsByProjectId()
        {
            try
            {
                using (var task = new TaskOperations())
                {
                    int projectId = 5;
                    var taskList = task.GetTaskDetailsByProjectId(projectId);
                    if (taskList != null)
                    {
                        Assert.IsNotNull(taskList);
                    }
                    else
                    {
                        Assert.Fail("Fail No Task Present");

                    }
                }
            }
            catch (Exception ex)
            {

                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void GetTaskDetailsByTaskId()
        {
            try
            {
                using (var task = new TaskOperations())
                {
                    int taskId = 55;
                    var taskList = task.GetTaskDetails(taskId);
                    if (taskList != null)
                    {
                        Assert.IsNotNull(taskList);
                    }
                    else
                    {
                        Assert.Fail("Fail No Task Present");

                    }
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void GetTaskDetailsByParent()
        {
            try
            {
                bool isParent = true;
                using (var task = new TaskOperations())
                {

                    var taskList = task.GetTaskDetails(isParent);
                    if (taskList != null)
                    {
                        Assert.IsNotNull(taskList);
                    }
                    else
                    {
                        Assert.Fail("Fail No Task Present");

                    }
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void InsertParentTask()
        {
            try
            {
                using (var task = new TaskOperations())
                {
                    TaskModel record = new TaskModel()
                    {
                        Task = "Current Task",
                        IsParent = true
                    };

                    var tasks = task.InsertTask(record);
                    if (tasks)
                    {
                        Assert.IsTrue(tasks, "Pass");
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
        public void InsertTask()
        {
            try
            {
                using (var task = new TaskOperations())
                {
                    TaskModel record = new TaskModel()
                    {
                        Task = "Current Task",
                        EndDate = DateTime.Now,
                        ParentTaskId = 4,
                        Priority = 5,
                        ProjectId = 1,
                        StartDate = DateTime.Now,
                        Status = "Created",
                        UserId = 2,
                        IsParent = false
                    };

                    var tasks = task.InsertTask(record);
                    if (tasks)
                    {
                        Assert.IsTrue(tasks, "Pass");
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
        public void UpdateTask()
        {
            try
            {
                using (var task = new TaskOperations())
                {
                    TaskModel record = new TaskModel()
                    {
                        Task = "Current Task",
                        EndDate = DateTime.Now,
                        ParentTaskId = 4,
                        Priority = 5,
                        ProjectId = 1,
                        StartDate = DateTime.Now,
                        Status = "Created",
                        UserId = 2,
                        TaskId = 2,
                        IsParent = false
                    };

                    var tasks = task.UpdateTask(record);
                    if (tasks)
                    {
                        Assert.IsTrue(tasks, "Pass");
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
        public void UpdateStatusTask()
        {
            try
            {
                using (var task = new TaskOperations())
                {
                    int TaskId = 2;
                    var tasks = task.UpdateTask(TaskId);
                    if (tasks)
                    {
                        Assert.IsTrue(tasks, "Pass");
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
        public void Delete()
        {
            try
            {
                using (var task = new TaskOperations())
                {
                    int TaskId = 2;
                    var tasks = task.DeleteTaskById(TaskId);
                    if (tasks)
                    {
                        Assert.IsTrue(tasks, "Pass");
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
    }
}
