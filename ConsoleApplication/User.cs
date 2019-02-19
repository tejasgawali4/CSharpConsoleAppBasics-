using System;

public class Class1
{
    int UserId;
    String FirstName;
    String LastName;
    int Mobile;

	public Class1()
	{
	}

    public void SetUser(int u, String f, String l, int m)
    {
        UserId = u;
        FirstName = f;
        LastName = l;
        Mobile = m;
    }

    public String GetUser()
    {
        return FirstName;
    }

    static void main(string[] args)
    {

    }
}
