 public class TimeMap
 {
            private Dictionary<string, List<ProductHistoryData>> productInfo = new Dictionary<string, List<ProductHistoryData>>();

        public void Set(string product, string price, int year)
        {
            if (!productInfo.ContainsKey(product))
            {
                productInfo.Add(product, new List<ProductHistoryData>());
            }

            productInfo[product].Add(new ProductHistoryData(price, year));
        }

        public string Get(string product, int year)
        {
            string priceStr = "";
            foreach (var existingProduct in productInfo)
            {
                if (existingProduct.Key == product)
                {
                    var productFound = existingProduct.Value;
                    if (productFound != null)
                    {
                        for (int i = 0; i < productFound.Count; i++)
                        {
                            if (productFound[i].year <= year)
                            {
                                priceStr = productFound[i].price;

                            }

                        }
                    }
                }
            }
            return priceStr;
        }
        public class ProductHistoryData
        {
            public ProductHistoryData(string price, int year)
            {
                this.price = price;
                this.year = year;
            }
            public string price { get; set; }
            public int year { get; set; }
        }
 }