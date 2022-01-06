using System;
using SQLite;

public class Class1
{
	public Class1()
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
 public string Description { get; set; }
	public DateTime Date { get; set; }
}
}
