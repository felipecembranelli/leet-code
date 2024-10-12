using Xunit;
using MyDataStructure.Hash;
using System.Collections.Generic;

namespace datastructure.tests
{
    public class HashDistributionSampleTest
    {
        [Fact]
        public void Distribute_products_using_default_hash_should_return_distributed_list()
        {
            this.ProcessTest(true);
        }

        [Fact]
        public void Distribute_products_using_custom_hash_should_return_distributed_list()
        {
            this.ProcessTest(false);
        }

        private void ProcessTest(bool defaultHashFunction)
        {

            // arrange
            HashDistributionSample hashSample = new HashDistributionSample();

            var numberOfItems = 10000;

            List<string> products = this.GenerateProductList(numberOfItems);

            // act
            var result = hashSample.Process(products, defaultHashFunction);

            // assert
            System.Console.WriteLine(result);

            var queue1 = int.Parse(result.Split(",")[0]);
            var queue2 = int.Parse(result.Split(",")[1]);
            var queue3 = int.Parse(result.Split(",")[2]);

            Assert.Equal(numberOfItems,queue1+queue2+queue3);
        }

        private List<string> GenerateProductList(int numberOfItems) 
        {
                List<string> products = new List<string>();

                for (int i = 0; i < numberOfItems; i++)
                {
                    products.Add("SKU" + i.ToString());
                }

                return products;

        }
    }
}

