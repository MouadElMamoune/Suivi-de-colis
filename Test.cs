using System;

public class Class1 : IDisposable
{
	IDriver

	public Class1(string uri, string username, string password)
	{
		driver = GraphDatabase.Driver(uri, AuthToken.Basic(username, password));
	}
}
