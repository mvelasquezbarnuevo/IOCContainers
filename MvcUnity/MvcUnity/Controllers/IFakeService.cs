using System;

namespace MvcUnity.Controllers
{
    public interface IFakeService
    {
        void Setup();
    }

    public class FakeService : IFakeService
    {
        public void Setup()
        {
            
        }
    }
}