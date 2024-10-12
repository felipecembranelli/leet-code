using Xunit;
using MyDataStructure.Hash;

namespace datastructure.tests
{
    public class HashTableTest
    {
        [Fact]
        public void Add_Object_Should_Return_Correct_Object_Index()
        {
            // arrange
            Hashtable hashTable = new Hashtable(50);

            // act
            hashTable.Add("ab", 5);
            hashTable.Add("bb", 6);
            hashTable.Add("aB", 7);
            hashTable.Add("Bc", 8);
            hashTable.Add("cA", 9);
            hashTable.Add("CC", 10);

            // assert
            Assert.Equal(6, hashTable.GetValue("bb"));
        }

        [Fact]
        public void Add_Objects_Should_Return_Correct_Object_Indexes()
        {
            Hashtable numberNames = new Hashtable(50);

            numberNames.Add(1,"One"); 
            numberNames.Add(2,"Two");
            numberNames.Add(3,"Three");

            // assert
            Assert.Equal("One", numberNames.GetValue(1));
            Assert.Equal("Two", numberNames.GetValue(2));
            Assert.Equal("Three", numberNames.GetValue(3));
        }

        [Fact]
        public void Compare_hashtable_implementation_Should_Return_Correct_Object_Values()
        {
            // arrange
            Hashtable hashTbl1 = new Hashtable(50);
            System.Collections.Hashtable hashTbl2 = new System.Collections.Hashtable(50);

            // act
            hashTbl1.Add(1,"One"); 
            hashTbl1.Add(2,"Two");
            hashTbl1.Add(3,"Three");

            hashTbl2.Add(1,"One"); 
            hashTbl2.Add(2,"Two");
            hashTbl2.Add(3,"Three");

            // assert
            Assert.Equal("One", hashTbl1.GetValue(1));
            Assert.Equal("Two", hashTbl1.GetValue(2));
            Assert.Equal("Three", hashTbl1.GetValue(3));

            Assert.Equal("One", hashTbl2[1]);
            Assert.Equal("Two", hashTbl2[2]);
            Assert.Equal("Three", hashTbl2[3]);

            Assert.Equal(hashTbl1.GetValue(1), hashTbl2[1]);
            Assert.Equal(hashTbl1.GetValue(2), hashTbl2[2]);
            Assert.Equal(hashTbl1.GetValue(3), hashTbl2[3]);

        }

        [Fact]
        public void Compare_hashtable_implementation_Should_Return_Correct_Object_Values_2()
        {
            // arrange
            Hashtable hashTbl1 = new Hashtable(50);
            System.Collections.Hashtable hashTbl2 = new System.Collections.Hashtable(50);

            // act
            
            hashTbl1.Add("UK", "London, Manchester, Birmingham"); 
            hashTbl1.Add("USA", "Chicago, New York, Washington");
            hashTbl1.Add("India", "Mumbai, New Delhi, Pune");

            hashTbl2.Add("UK", "London, Manchester, Birmingham"); 
            hashTbl2.Add("USA", "Chicago, New York, Washington");
            hashTbl2.Add("India", "Mumbai, New Delhi, Pune");

            // assert
            Assert.Equal(hashTbl1.GetValue("UK"), hashTbl2["UK"]);
            Assert.Equal(hashTbl1.GetValue("USA"), hashTbl2["USA"]);
            Assert.Equal(hashTbl1.GetValue("India"), hashTbl2["India"]);

        }
        
    }
    
}