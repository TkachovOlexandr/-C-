namespace MyArrayNamespace
{
    internal class MyArray
    {
        delegate void MyArrayDelegate();

        private int[] myArr;
        private int arrayLength;

        public int ArrayLength
        {
            get { return arrayLength; }
            set { arrayLength = value; }
        }

        public int this[int i]
        {
            get { return myArr[i]; }
            set {
                if (i == MyArr.Length)
                {
                    Array.Resize(ref myArr, ++ArrayLength);
                    myArr[i] = value;
                }
                else
                    myArr[i] = value;
            }
        }
        public int[] MyArr
        {
            get { return myArr; }
            set { ArrayLength = value.Length; myArr = value; }
        }

        public MyArray()
        {
            this.ArrayLength = 1;
            this.MyArr = new int[ArrayLength];
        }

        public void Show(MyArrayDelegate myDelegate)
        {
            myDelegate?.Invoke();
            for (int i = 0; i < ArrayLength; i++)
                Console.Write($"{this[i]} ");
            Console.WriteLine();
        }
        public void Delete(int index)
        {
            for (int i = index; i < ArrayLength - 1; i++)
                myArr[i] = myArr[i + 1];
            Array.Resize(ref myArr, --ArrayLength);
        }

        void SortArrayUp(int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var temp_var = myArr[leftIndex];
            while (i <= j)
            {
                while (myArr[i] < temp_var)
                    i++;

                while (myArr[j] > temp_var)
                    j--;

                if (i <= j)
                {
                    int temp = myArr[i];
                    myArr[i] = myArr[j];
                    myArr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                SortArrayUp(leftIndex, j);
            if (i < rightIndex)
                SortArrayUp(i, rightIndex);
        }
        public void SortArrayDown(int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var temp_var = myArr[leftIndex];
            while (i <= j)
            {
                while (myArr[i] > temp_var)
                    i++;

                while (myArr[j] < temp_var)
                    j--;

                if (i <= j)
                {
                    int temp = myArr[i];
                    myArr[i] = myArr[j];
                    myArr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                SortArrayDown(leftIndex, j);
            if (i < rightIndex)
                SortArrayDown(i, rightIndex);
        }

    }
}
