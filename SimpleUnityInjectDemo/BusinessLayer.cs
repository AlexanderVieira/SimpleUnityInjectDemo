namespace SimpleUnityInjectDemo
{
    public class BusinessLayer
    {
        private readonly IProduct _product;

        public BusinessLayer(IProduct product)
        {
            _product = product;
        }

        public void Insert()
        {
            _product.InsertData();
        }
    }
}
