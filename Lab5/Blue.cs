using System.Linq;
using System.Runtime.InteropServices;

namespace Lab5
{
    public class Blue
    {
        public double[] Task1(int[,] matrix)
        {
            double[] answer = null;

            // code here
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            
            answer =  new double[rows];

            for (int i = 0; i < rows; i++)
            {
                double sum = 0;
                int count = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sum += matrix[i, j];
                        count++;
                    }
                }
                answer[i] = count > 0 ? sum / count : 0;
            }
            

            // end

            return answer;
        }
        public int[,] Task2(int[,] matrix)
        {
            int[,] answer = null;

            // code here
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int max = matrix[0, 0];
            int maxrows = 0, maxcols = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        maxrows = i;
                        maxcols = j;
                    }
                }
            }
            answer = new int[rows - 1, cols - 1];
            int r = 0;
            for (int i = 0; i < rows; i++)
            {
                if (i == maxrows) continue;
                int c = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (j == maxcols) continue;
                    answer[r, c] = matrix[i, j];
                    c++;
                }
                r++;
            }
            // end

            return answer;
        }
        public void Task3(int[,] matrix)
        {

            // code here
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                int max = matrix[i, 0];
                int maxIndex = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        maxIndex = j;
                    }
                }

                for (int j = maxIndex; j < cols - 1; j++)
                {
                    matrix[i, j] = matrix[i, j + 1];
                }
                matrix[i, cols - 1] = max;
            }
            // end

        }
        public int[,] Task4(int[,] matrix)
        {
            int[,] answer = null;

            // code here
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            answer = new int[rows, cols + 1];
            for (int i = 0; i < rows; i++)
            {
                int max = matrix[i, 0];
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] > max) max = matrix[i, j];
                }

                for (int j = 0; j < cols - 1; j++)
                {
                    answer[i, j] = matrix[i, j];
                }
                answer[i, cols - 1] = max;
                answer[i, cols] = matrix[i, cols - 1];
            }
            // end

            return answer;
        }
        public int[] Task5(int[,] matrix)
        {
            int[] answer = null;

            // code here
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if ((i + j) % 2 == 1) count++;
                }
            }
            answer = new int[count];
            int k = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if ((i + j) % 2 == 1) answer[k++] = matrix[i, j];
                }
            }
            // end

            return answer;
        }
        public void Task6(int[,] matrix, int k)
        {
            
            // code here
            if (matrix.GetLength(0) != matrix.GetLength(1)) return;
            int rows = matrix.GetLength(0);
            int maxDiag = matrix[0, 0];
            int maxRow = 0;
            for (int i = 1; i < rows; i++)
            {
                if (matrix[i, i] > maxDiag && i < rows)
                {
                    maxDiag = matrix[i, i];
                    maxRow = i;
                }
            }

            int neg = -1;
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, k] < 0)
                {
                    neg = i;
                    break;
                }
            }
            if (neg == -1 || maxDiag == neg) return;
            for (int j = 0; j < rows; j++)
            {
                (matrix[maxRow, j], matrix[neg, j]) = (matrix[neg, j], matrix[maxRow, j]);
            }
            // end

        }
        public void Task7(int[,] matrix, int[] array)
        {

            // code here
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            if (cols < 2 || array.Length != cols) return;
            int preCol = cols - 2;
            int max = matrix[0, preCol];
            int maxRow = 0;
            for (int i = 1; i < rows; i++)
            {
                if (matrix[i, preCol] > max)
                {
                    max = matrix[i, preCol];
                    maxRow = i;
                }
            }
            for (int j = 0; j < cols; j++)
            {
                matrix[maxRow, j] = array[j];
            }
            // end

        }
        public void Task8(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task9(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task10(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task11(int[,] matrix)
        {

            // code here

            // end

        }
        public int[][] Task12(int[][] array)
        {
            int[][] answer = null;

            // code here

            // end

            return answer;
        }
    }
}