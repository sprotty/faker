using System.CodeDom.Compiler;

namespace FakerNet
{
    partial class DataGenerator
    {
        partial class DateGenerator
        {
            /// <summary>
            /// Produce a random date in the past (up to N days).
            /// </summary>
            /// <param name="days">
            /// The maximum number of days to go into the past.
            /// (default value "365")
            /// </param>
            /// <example>
            /// <code>Faker::Date.backward(days: 14) #=> #<Date: 2019-09-12></code>
            /// </example>
            [FakerMethod("backward")]
            public DateTime Backward(long days = 365)
            {
                return System.DateTime.Now.AddDays(-days);
            }
            /// <summary>
            /// Produce a random date in the past (up to N days).
            /// </summary>
            /// <param name="days">
            /// The maximum number of days to go into the past.
            /// (default value "365")
            /// </param>
            /// <example>
            /// <code>Faker::Date.backward_date(days: 14) #=> #<Date: 2019-09-12></code>
            /// </example>
            [FakerMethod("backward_date")]
            public DateOnly BackwardDate(long days = 365) => DateOnly.FromDateTime(Backward(days));

            /// <summary>
            /// Produce a random date between two dates.
            /// </summary>
            /// <param name="from">
            /// The start of the usable date range.
            /// (default value "1970-01-01")
            /// </param>
            /// <param name="to">
            /// The end of the usable date range.
            /// (default value "2050-01-01")
            /// </param>
            /// <example>
            /// 
            /// <p>if used with or without Rails (Active Support)</p>
            /// 
            /// <code>Faker::Date.between(from: '2014-09-23', to: '2014-09-25') #=> #<Date: 2014-09-24></code>
            /// </example>
            /// <example>
            /// 
            /// <p>if used with Rails (Active Support)</p>
            /// 
            /// <code>Faker::Date.between(from: 2.days.ago, to: Date.today) #=> #<Date: 2014-09-24></code>
            /// </example>
            [FakerMethod("between")]
            public DateOnly Between(DateOnly? from = null, DateOnly? to = null)
            {
                from ??= new DateOnly(1970, 1, 1);
                to ??= new DateOnly(2050, 1, 1);
                return DateOnly.FromDayNumber(Random.NextInt32(from.Value.DayNumber, to.Value.DayNumber));
            }

            /// <summary>
            /// Produce a random date in the past (up to N days).
            /// </summary>
            /// <param name="minAge">
            /// The minimum age that the birthday would imply.
            /// </param>
            /// <param name="maxAge">
            /// The maximum age that the birthday would imply.
            /// (default value "65")
            /// </param>
            /// <example>
            /// <code>Faker::Date.birthday(min_age: 18, max_age: 65) #=> #<Date: 1986-03-28></code>
            /// </example>
            [FakerMethod("birthday")]
            public DateOnly Birthday(long minAge = 18, long maxAge = 65)
            {
                if (minAge < 0) throw new ArgumentException("Must be greater than or equal to 0", "minAge");
                if (maxAge < 0) throw new ArgumentException("Must be greater than or equal to 0", "maxAge");
                if (minAge > maxAge) throw new ArgumentException("minAge must be less than maxAge", "minAge");
                return Between(DateOnly.FromDateTime(System.DateTime.Now).AddYears((int)minAge), DateOnly.FromDateTime(System.DateTime.Now).AddYears((int)maxAge));
            }

            /// <summary>
            /// A random date/time within the range.
            /// </summary>
            /// <param name="after">
            /// The time generated will be after this value
            /// (default value "1970-01-01")
            /// </param>
            /// <param name="before">
            /// The time generated will be before this value
            /// (default value "2050-01-01")
            /// </param>
            [FakerMethod("date_time")]
            public DateTime DateTime(DateTime? after = null, DateTime? before = null)
            {
                after ??= new DateTime(1970, 1, 1);
                before ??= new DateTime(2050, 1, 1);
                return new System.DateTime(Random.NextInt64(after.Value.Ticks, before.Value.Ticks));
            }



            /// <summary>
            /// A random day of the week
            /// </summary>
            [FakerMethod("day")]
            public string Day()
            {
                return Faker.Locale.DateTimeFormat.GetDayName(Random.NextEnum<DayOfWeek>());
            }

            /// <summary>
            /// Produce a random date in the future (up to N days).
            /// </summary>
            /// <param name="days">
            /// The maximum number of days to go into the future.
            /// (default value "365")
            /// </param>
            /// <example>
            /// 
            /// <p>if used with or without Rails (Active Support)</p>
            /// 
            /// <code>Faker::Date.forward(days: 23) #=> #<Date: 2014-10-03></code>
            /// </example>
            /// <example>
            /// 
            /// <p>if used with Rails (Active Support)</p>
            /// 
            /// <code>Faker::Date.forward(from: Date.current, days: 17) #=> #<Date: 2022-06-22></code>
            /// </example>
            /// <example>
            /// 
            /// <p>if used with or without Rails (Active Support)</p>
            /// 
            /// <code>Faker::Date.forward(from: '2022-06-03', days: 10) #=> #<Date: 2022-10-13></code>
            /// </example>
            [FakerMethod("forward")]
            public DateTime Forward(long days = 365)
            {
                return System.DateTime.Now.AddDays(days);
            }
            /// <summary>
            /// Produce a random date in the future (up to N days).
            /// </summary>
            /// <param name="days">
            /// The maximum number of days to go into the future.
            /// (default value "365")
            /// </param>
            /// <example>
            /// 
            /// <p>if used with or without Rails (Active Support)</p>
            /// 
            /// <code>Faker::Date.forward_date(days: 23) #=> #<Date: 2014-10-03></code>
            /// </example>
            /// <example>
            /// 
            /// <p>if used with Rails (Active Support)</p>
            /// 
            /// <code>Faker::Date.forward_date(from: Date.current, days: 17) #=> #<Date: 2022-06-22></code>
            /// </example>
            /// <example>
            /// 
            /// <p>if used with or without Rails (Active Support)</p>
            /// 
            /// <code>Faker::Date.forward_date(from: '2022-06-03', days: 10) #=> #<Date: 2022-10-13></code>
            /// </example>
            [FakerMethod("forward_date")]
            public DateOnly ForwardDate(long days = 365) => DateOnly.FromDateTime(Forward(days));

            /// <summary>
            /// A random time within the range (if after is greater than before then before is considered to be the following day).
            /// </summary>
            /// <param name="after">
            /// The time generated will be after this value
            /// (default value "nil")
            /// </param>
            /// <param name="before">
            /// The time generated will be before this value
            /// (default value "nil")
            /// </param>
            [FakerMethod("time")]
            public TimeOnly Time(TimeOnly? after = null, TimeOnly? before = null)
            {
                after ??= TimeOnly.MinValue;
                before ??= TimeOnly.MaxValue;
                if (after < before)
                {
                    return new TimeOnly(Random.NextInt64(after.Value.Ticks, before.Value.Ticks));
                }
                else
                {
                    long rndRange = after.Value.Ticks + TimeOnly.MaxValue.Ticks;
                    long rndVal = Random.NextInt64(0, rndRange);
                    return new TimeOnly(rndVal % TimeOnly.MaxValue.Ticks);
                }
            }

            /// <summary>
            /// A random week day (Monday-Friday ) translated into the selected locale
            /// </summary>
            [FakerMethod("week_day")]
            public string WeekDay()
            {
                var rndDay = Random.NextItem(new[] { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday });
                return Faker.Locale.DateTimeFormat.GetDayName(rndDay);
            }
        }

    }
}
