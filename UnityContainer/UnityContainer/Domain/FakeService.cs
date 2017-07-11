using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnityContainer.Domain
{
    public class FakeService : IFakeService
    {
        public void Setup()
        {
            
        }
    }

    public interface IFakeService
    {
        void Setup();
    }
}