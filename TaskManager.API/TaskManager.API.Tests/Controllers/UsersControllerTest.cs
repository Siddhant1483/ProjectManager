using NUnit.Framework;
using System;
using TaskManager.Business;
using TaskManager.Model;

namespace TaskManager.API.Tests
{
    [TestFixture]
    public class UsersControllerTest
    {
        [Test]
        public void GetTaskDetails()
        {           
            try
            {
                using (var userOperation = new UsersOperations())
                {

                    var userList = userOperation.GetUserDetails();
                    if (userList != null)
                    {
                        Assert.IsNotNull(userList);
                       // Assert.AreEqual(1, userList.Count());                       
                    }
                    else
                    {
                        Assert.Fail("Fail No User Present");

                    }

                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void InsertVaildUser()
        {
            try
            {
                using (var userOperation = new UsersOperations())
                {
                    UsersModel record = new UsersModel()
                    {
                        FirstName = "John",
                        LastName = "trump",
                        EmployeeId = 3212,
                    };

                    var user = userOperation.InsertUserDetail(record);
                    if (user)
                    {
                        Assert.IsTrue(user, "Pass");
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
        public void UpdateVaildUser()
        {            
            try
            {
                using (var userOperation = new UsersOperations())
                {
                    UsersModel record = new UsersModel()
                    {
                        FirstName = "John Test",
                        LastName = "trump",
                        EmployeeId = 321,
                        UserId = 5
                    };

                    var user = userOperation.UpdateUserDetail(record);
                    if (user)
                    {
                        Assert.IsTrue(user, "Pass");
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
        public void UpdateInVaildUser()
        {
            try
            {
                using (var userOperation = new UsersOperations())
                {
                    UsersModel record = new UsersModel()
                    {
                        FirstName = "John Test",
                        LastName = "trump",
                        EmployeeId = 32,
                        UserId = 55
                    };

                    var user = userOperation.UpdateUserDetail(record);
                    if (user)
                    {
                        Assert.IsTrue(user, "Pass");
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
        public void DeleteVaildUser()
        {           
            try
            {
                using (var userOperation = new UsersOperations())
                {

                    int userId = 7;
                    var userList = userOperation.DeleteUserById(userId);
                    if (userList)
                    {
                        Assert.IsTrue(userList, "Pass");
                    }
                    else
                    {
                        Assert.Fail("Fail to Delete User Data");

                    }

                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void DeleteInVaildUser()
        {
            try
            {
                using (var userOperation = new UsersOperations())
                {

                    int userId = 32;
                    var userList = userOperation.DeleteUserById(userId);
                    if (userList)
                    {
                        Assert.Pass("Pass");
                    }
                    else
                    {
                        Assert.Fail("Fail to Delete User Data");

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
