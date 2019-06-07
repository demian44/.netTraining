using System;

namespace CodeFirst.Models
{
    /// <summary>
    /// This class was created for the purpose of being registered by autofac.
    /// </summary>
    public class Test : ITest
    {
        public Guid Id { get; set; }

        public Test(Guid id)
        {
            this.Id = id;
        }
    }
}