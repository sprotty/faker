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
            public DayOfWeek Day()
            {
                return Random.NextEnum<DayOfWeek>();
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
        }

    }
}
