using Moq;
using NUnit.Framework;
using System;
using WebApplication_Artur.EfStuff.Model.Interface;
using WebApplication_Artur.EfStuff.Model.UserModel;
using WebApplication_Artur.Services;

namespace WebApplication_ArturTest
{
    public class UserService
    {

        [Test]
        [TestCase(10)]
        public void IsDontAnminMyUser(long id)
        {
            var user = new Mock<IUser>();

            var ususerServiceer = new UserService();

            var answer = true;

            //нерабочая заглушка

            Assert.AreEqual(true, answer);
        }

    }
}
