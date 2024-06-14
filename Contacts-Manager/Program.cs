namespace Contacts_Manager
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> Contact = new List<string>
        {
            "Ali",
             "Ahmad",
             "Sara"
        };
            List<string> List1 = ContactsManager("VeiwAll", Contact);
            for (int i = 0; i < List1.Count; i++)
            {
                Console.WriteLine(List1[i]);
            }
            Console.WriteLine("");
            
        }

        public static List<string> AddContact(List<string> ContactInfo, string CName, string Number = "")
        {
            for (int i = 0; i < ContactInfo.Count; i++)
            {
                if (CName == ContactInfo[i])
                {
                    return ContactInfo;
                }
            }
            ContactInfo.Add(CName);
            return ContactInfo;
        }
        public static List<string> RemoveContact(string CName, List<string> ContactInfo)
        {
            for (int i = 0; i < ContactInfo.Count; i++)
            {
                if (ContactInfo[i] == CName)
                {
                    ContactInfo.Remove(ContactInfo[i]);
                }
            }
            return ContactInfo;
        }
        public static List<string> ViewAllContacts(List<string> ContactInfo)
        {
            return ContactInfo;
        }
        public static List<string> ContactsManager(string Action, List<string> ContactInfo, string CName = "", string Number = "")
        {
            if (Action == "Add" && CName != "")
            {
                AddContact(ContactInfo, CName, Number);
            }
            if (Action == "Remove")
            {
                RemoveContact(CName, ContactInfo);
            }
            if (Action == "VeiwAll")
            {
                ViewAllContacts(ContactInfo);
            }
            return ContactInfo;
        }
    }
}
