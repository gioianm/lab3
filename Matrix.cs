using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Matrix
    {
        private double[,] mass;

        public int N { get; }
        public int M { get; }

        public Matrix(int n, int m)
        {
            N = n;
            M = m;
            mass = new double[n, m];
        }

        public double this[int i, int j]
        {
            get { return mass[i, j]; }
            set { mass[i, j] = value; }
        }

        public static Matrix E(int n)
        {
            Matrix result = new Matrix(n, n);

            for (int i = 0; i < n; ++i)
            {
                result[i, i] = 1;
            }

            return result;
        }

        public static Matrix MulScalar(Matrix a, double sclr)
        {
            Matrix result = new Matrix(a.N, a.M);

            for (int i = 0; i < a.N; ++i)
            {
                for (int j = 0; j < a.M; ++j)
                {
                    result[i, j] = a[i, j] * sclr;
                }
            }

            return result;
        }

        public static Matrix Mul(Matrix a, Matrix b)
        {
            if (a.M != b.N)
            {
                throw new Exception("Wrong size!");
            }

            Matrix result = new Matrix(a.N, b.M);

            for (int i = 0; i < a.N; ++i)
                for (int j = 0; j < b.M; ++j)
                    for (int k = 0; k < b.N; k++)
                        result[i, j] += a[i, k] * b[k, j];

            return result;
        }

        public static Matrix Sum(Matrix a, Matrix b)
        {
            if ((a.N != b.N) || (a.M != b.M))
            {
                throw new Exception("Wrong size!");
            }

            Matrix result = new Matrix(a.N, a.M);

            for (int i = 0; i < a.N; ++i)
            {
                for (int j = 0; j < b.M; ++j)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }

            return result;
        }

        public static Matrix operator * (Matrix a, Matrix b)
        {
            return Mul(a, b);
        }

        public static Matrix operator * (Matrix a, double b)
        {
            return MulScalar(a, b);
        }

        public static Matrix operator + (Matrix a, Matrix b)
        {
            return Sum(a, b);
        }
    }
}
