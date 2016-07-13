using EndavaScrum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndavaScrum.Tests
{
    class TestSessionDbSet : TestDbSet<Session>
    {
        public override Session Find(params object[] keyValues)
        {
            return this.SingleOrDefault(product => product.session_id == (string)keyValues.Single());
        }
    }
}
