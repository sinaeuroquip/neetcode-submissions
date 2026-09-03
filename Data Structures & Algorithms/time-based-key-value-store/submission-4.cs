 public class TimeMap
 {
            private Dictionary<string, List<ProductHistoryData>> productInfo = new Dictionary<string, List<ProductHistoryData>>();

        public void Set(string product, string price, int year)
        {
            if (!productInfo.ContainsKey(product))
                productInfo.Add(product, new List<ProductHistoryData>());


            productInfo[product].Add(new ProductHistoryData(price, year));
        }

        public string Get(string product, int year)
        {
            if (!productInfo.ContainsKey(product))
                return "";

            var productData = productInfo[product];

            return BinarySearch(productData, year);
            //do binary search

        }

        private string BinarySearch(List<ProductHistoryData> productHistory, int year)
        {
            // productHistory=[2020,2021,2022]

            var l = 0;
            var r = productHistory.Count - 1;
            while (l <= r)
            {
                var m = l + (r - l) / 2;
                if (productHistory[m].year <= year)
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }

            return r >= 0 ? productHistory[r].price : "";
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