using System;

namespace Variant10
{
	class DataWork
	{
		public DateTime date;

		public DataWork()
		{
			date = new DateTime(2009, 1, 1);
		}

		public DataWork(DateTime date)
		{
			this.date = date;
		}

		public string LastDay(DateTime date)
		{
			DateTime ldate = date.AddDays(-1);
			return ldate.ToShortDateString();
		}

		public string NextDay(DateTime date)
		{
			DateTime ndate = date.AddDays(1);
			return ndate.ToShortDateString();
		}

		public int DaysLeft(DateTime date)
		{
			int dLeft = DateTime.DaysInMonth(date.Year, date.Month) - date.Day;
			return dLeft;
		}

		public string DateValue
		{
			get
			{
				return date.ToShortDateString();
			}
			set
			{
				date = DateTime.Parse(value);
			}
		}

		public bool LeapYear
		{
			get
			{
				if(date.Year % 4 == 0)
					return true;
				else
					return false;
			}
		}
	}

	class Program
	{
		static void Main()
		{
			try
			{
				Console.WriteLine("1 - Вывод с фиксированнной датой\n" +
								  "2 - Вывод со своей датой");
				int index = Convert.ToInt32(Console.ReadLine());
				switch (index)
				{
					case 1:
						DataWork data = new DataWork();
						Console.WriteLine("Текущая дата: " + data.DateValue);
						Console.WriteLine("Прошлый день текущей даты: " + data.LastDay(data.date));
						Console.WriteLine("Следующий день текущей даты: " + data.NextDay(data.date));
						Console.WriteLine("До конца месяца осталось {0} дней.", data.DaysLeft(data.date));
						if (data.LeapYear)
						{
							Console.WriteLine("Этот год високосный.");
						}
						else
						{
							Console.WriteLine("Этот год не високосный.");
						}
						break;
					case 2:
						Console.Write("Введите дату через точку: ");
						DateTime setDate = DateTime.Parse(Console.ReadLine());
						DataWork data1 = new DataWork(setDate);
						Console.WriteLine("Текущая дата: " + data1.DateValue);
						Console.WriteLine("Прошлый день текущей даты: " + data1.LastDay(data1.date));
						Console.WriteLine("Следующий день текущей даты: " + data1.NextDay(data1.date));
						Console.WriteLine("До конца месяца осталось {0} дней.", data1.DaysLeft(data1.date));
						if (data1.LeapYear)
						{
							Console.WriteLine("Этот год високосный.");
						}
						else
						{
							Console.WriteLine("Этот год не високосный.");
						}
						break;
					default:
						Console.WriteLine("Неверное значение");
						break;
				}
			}
			catch(FormatException)
			{
				Console.WriteLine("Неверный ввод данных");
			}
			catch
			{
				Console.WriteLine("Неизвестная ошибка");
			}
		}
	}
}