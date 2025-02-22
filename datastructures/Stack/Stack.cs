namespace MyDataStructure.Stack
{
    public interface ISimpleStack
    {
        ISimpleStack Push(object value);
        object Pop();
        ISimpleStack Clear();
        int Count();
        int Lenght { get; }
    }
    public class SimpleStack : ISimpleStack
    {
        public int Lenght {get; set;}
        public int Capacity {get; set;}
        object[] _internalBuffer;
        public const int DefaultCapacity = 32;

        public SimpleStack(int capacity)
        {
            Capacity = capacity;
            _internalBuffer = new object[capacity];
            Lenght = 0;
        }

        public SimpleStack() : this(DefaultCapacity) { }

        public ISimpleStack Push(object value)
        {
            InternalEnsureCapacity();

            _internalBuffer[Lenght] = value;
            Lenght++;

            return this;
        }

        public ISimpleStack Clear()
        {
            _internalBuffer = new object[Capacity];
            Lenght = 0;
            return this;
        }

        private void InternalExpandBuffer()
        {
            //double capacity by default
            Capacity *= 2;

            //copy to new array
            var tmpBuffer = new object[Capacity];

            for (int i = 0; i < _internalBuffer.Length; i++)
            {
                object c = _internalBuffer[i];
                tmpBuffer[i] = c;
            }
            _internalBuffer = tmpBuffer;
        }

        private void InternalEnsureCapacity()
        {
            while (Lenght + 1 > Capacity)
            {
                //not enough space in the current buffer    
                //double capacity
                InternalExpandBuffer();
            }
        }

        public object Pop()
        {
            if (Lenght < 0)
                return null;
            else {
                var topElement = _internalBuffer[Lenght];

                Lenght--;

                return topElement;
            }
        }

        public int Count()
        {
            return Lenght;
        }
    }

}