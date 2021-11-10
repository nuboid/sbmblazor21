namespace ServicesLifetimes.Services
{
    public class Service2
    {
        private readonly Service1 _service1;

        public Service2(Service1 service1)
        {
            _service1 = service1;
        }

        public void SetSomething(string data)
        {
            _service1.StoreSomething(data);
        }
        public string GetSomething()
        {
            return _service1.GetSomething();
        }
    }
}