public class Member
{
    private int memberId;
    private string name;

    public int MemberId
    {
        get { return memberId; }
        private set { memberId = value; }
    }

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    public Member(int memberId, string name)
    {
        MemberId = memberId;
        Name = name;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Student ID: {MemberId}, Name: {Name}");
    }
}

