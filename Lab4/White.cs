namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;
			// code here
						
            for (int i = 0; i < vector.Length; i++)
            {
                length += vector[i] * vector[i];
            }

            double sqrt = 0;
            double step = 0.00001;
            while (sqrt * sqrt < length)
            {
                sqrt += step;
            }
            // end

            return sqrt;
        }

        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;
            // code here

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > P && array[i] < Q)
                {
                    count++;
                }
            }
            // end

            return count;
        }

        public void Task3(int[] array)
        {
            int maxIndex = 0;
            // code here

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            if (maxIndex == array.Length - 1)
            {
                return;
            }

            int minIndex = maxIndex + 1;
            for (int i = maxIndex + 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }
            // end

            int temp = array[maxIndex];
            array[maxIndex] = array[minIndex];
            array[minIndex] = temp;
        }

        public void Task4(int[] array)
        {
            int max = array[0];
            int index = 0;
            // code here

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }
						// end
            array[index] = index;
        }

        public int Task5(int[] array, int P)
        {
            int index = -1;
            // code here

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                {
                    index = i;
                    break;
                }
            }
            // end

            return index;
        }

        public void Task6(int[] array)
        {
            int maxIndex = 0;
            // code here

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            for (int i = 0; i + 1 < maxIndex; i += 2)
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
            // end
        }

        public int[] Task7(int[] array)
        {
            int count = 0;
					  // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    count++;
                }
            }

            int[] answer = new int[count];
            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[k] = array[i];
                    k++;
                }
            }
            // end

            return answer;
        }

        public void Task8(int[] array)
        {
		        // code here
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            // end
        }

        public void Task9(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;
			// code here
            while (left < right)
            {
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;

                left++;
                right--;
            }
            // end
        }

        public int[] Task10(int[] A, int[] B)
        {
		        // code here
            if (A.Length == 0)
            {
                return B;
            }

            if (B.Length == 0)
            {
                return A;
            }

            int[] C = new int[A.Length + B.Length];
            int k = 0;

            for (int i = 0; i < A.Length; i++)
            {
                C[k++] = A[i];
                if (i < B.Length)
                {
                    C[k++] = B[i];
                }
            }

            for (int i = A.Length; i < B.Length; i++)
            {
                C[k++] = B[i];
            }
			// end
            return C;
        }

        public double[] Task11(double a, double b, int n)
        {
		        // code here
            if (n <= 0)
            {
                return null;
            }

            if (a == b)
            {
                return new double[] { a };
            }

            double[] array = new double[n];

            if (a > b)
            {
                for (int i = 0; i < n; i++)
                {
                    array[i] = a - i;
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    array[i] = a + i;
                }
            }
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
		        // code here
            if (raw.Length < 3)
            {
                return null;
            }

            double[] restored = new double[raw.Length];

            for (int i = 0; i < raw.Length; i++)
            {
                restored[i] = raw[i];
            }

            for (int i = 1; i < raw.Length - 1; i++)
            {
                if (restored[i] == -1)
                {
                    if (restored[i - 1] != -1 && restored[i + 1] != -1)
                    {
                        restored[i] = (restored[i - 1] + restored[i + 1]) / 2;
                    }
                }
            }
            // end

            return restored;
        }
    }
}
