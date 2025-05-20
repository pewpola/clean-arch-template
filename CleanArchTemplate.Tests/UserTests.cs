using Xunit;
using CleanArchTemplate.Domain.Entities;
using System;

namespace CleanArchTemplate.Tests
{
    public class UserTests
    {
        [Fact]
        public void Can_Set_And_Get_Properties()
        {
            // Arrange
            var user = new User();
            var email = "usuario@teste.com";
            var name = "Usuário Teste";
            var id = Guid.NewGuid();
            var now = DateTimeOffset.UtcNow;

            // Act
            user.Email = email;
            user.Name = name;
            user.Id = id;
            user.DateCreated = now;
            user.DateUpdated = now.AddMinutes(1);
            user.DateDeleted = now.AddMinutes(2);

            // Assert
            Assert.Equal(email, user.Email);
            Assert.Equal(name, user.Name);
            Assert.Equal(id, user.Id);
            Assert.Equal(now, user.DateCreated);
            Assert.Equal(now.AddMinutes(1), user.DateUpdated);
            Assert.Equal(now.AddMinutes(2), user.DateDeleted);
        }
    }
}