using BookTime.Web.Entities;
using System.ComponentModel.DataAnnotations;

namespace Test.Entities
{
    [TestClass]
    public class AuthorTest
    {
        [TestMethod]
        public void TestingAuthorEntity()
        {
            // Arrange
            var author = new Author();

            // Act
            author.Id = 1;
            author.Name = "Stephen";
            author.Slug = "stephen-king";

            //Assert
            Assert.AreEqual(1, author.Id);
            Assert.AreEqual("Stephen", author.Name);
            Assert.AreEqual("stephen-king", author.Slug);
        }

        [TestMethod]
        public void AuthorNameShouldBeRequired()
        {
            var author = new Author();
            author.Slug = "test-slug";

            var validationResults = ValidateModel(author);
            Assert.IsTrue(validationResults.Any(vr => vr.MemberNames.Contains(nameof(author.Name)) && vr.ErrorMessage.Contains("required")));
        }

        [TestMethod]
        public void AuthorNameShouldNotExceedMaxLength()
        {
            // Arrange
            var author = new Author
            {
                Name = new string('A', 121), // Exceeding max length
                Slug = "test-slug"
            };

            // Act & Assert
            var validationResults = ValidateModel(author);
            Assert.IsTrue(validationResults.Any(vr => vr.MemberNames.Contains(nameof(author.Name)) && vr.ErrorMessage.Contains("maximum length")));
        }

        [TestMethod]
        public void Author_Slug_ShouldNotExceedMaxLength()
        {
            // Arrange
            var author = new Author
            {
                Name = "Test Author",
                Slug = new string('S', 101) // Exceeding max length
            };

            // Act & Assert
            var validationResults = ValidateModel(author);
            Assert.IsTrue(validationResults.Any(vr => vr.MemberNames.Contains(nameof(author.Slug)) && vr.ErrorMessage.Contains("maximum length")));
        }

        private static IList<ValidationResult> ValidateModel(object model)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(model, serviceProvider: null, items: null);
            Validator.TryValidateObject(model, validationContext, validationResults, validateAllProperties: true);
            return validationResults;
        }
    }
}
