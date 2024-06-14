namespace Contacts_Manager_Tests
{
    public class UnitTest1
    {
        // Add Case
        [Fact]
        public void AddCase()
        {
            // Arrange
            string Action = "Add";
            List<string> Contact = new List<string>
        {
            "Ali",
             "Ahmad",
             "Sara"
        };
            string CName = "Yara";
            string Number = "065050500";

            // Act
            List<string> result = Contacts_Manager.Program.ContactsManager(Action, Contact, CName, Number);
            // Assert
            Assert.Equal(4, result.Count);
        }


        [Fact]
        public void AddRejected()
        {
            // Arrange
            string Action = "Add";
            List<string> Contact = new List<string>
        {
            "Ali",
             "Ahmad",
             "Sara"
        };
            string CName = "Ali";
            string Number = "065050500";
            // Act
            List<string> result = Contacts_Manager.Program.ContactsManager(Action, Contact, CName, Number);
            // Assert
            Assert.Equal(3, result.Count);
        }


        // Remove Case 
        [Fact]
        public void RemoveCase()
        {
            // Arrange
            string Action = "Remove";
            List<string> Contact = new List<string>
        {
            "Ali",
             "Ahmad",
             "Sara"
        };
            string CName = "Ali";
           
            // Act
            List<string> result = Contacts_Manager.Program.ContactsManager(Action, Contact, CName);

            // Assert
            Assert.Equal(2, result.Count);
        }


        // ViewAll Case
        [Fact]
        public void ViewAllCase()
        {
            // Arrange
            string Action = "VeiwAll";
            List<string> Contact = new List<string>
        {
            "Ali",
             "Ahmad",
             "Sara"
        };
            // Act
            List<string> result = Contacts_Manager.Program.ContactsManager(Action, Contact);
            // Assert
            Assert.Equal(3, result.Count);
        }
    }
}