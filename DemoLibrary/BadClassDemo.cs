namespace DemoLibrary;

public class BadClassDemo
{
    public string creditCardNumber;

	// it cannot be everything public because you can leak it
	private string _ssn;

	public string SSN
	{
		get { return "***-**-1234"; }
		set { _ssn = value; }
	}

	public int _age;

	public int Age
	{
		get { return _age; }
		set 
		{ 
			if (value >= 0 && value < 130)
			{
				_age = value;
			}
		}
	}


}
