
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MobilePhone { get; set; }
    public string WorkPhone { get; set; }
    public string Address { get; set; }

    public Person(string firstName, string lastName, string mobilePhone, string workPhone, string address)
    {
        FirstName = firstName;
        LastName = lastName;
        MobilePhone = mobilePhone;
        WorkPhone = workPhone;
        Address = address;
    }

    public string ToString()
    {
        return $"{LastName} {FirstName}";
    }
}
