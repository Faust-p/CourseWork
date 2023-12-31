﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolatiomLibrary
{
    public class Interpolation
    {
        public static double[,] Divided(double[] x, double[] y)
        {
            int n = x.Length;
            double[,] A = new double[n, n];

            // Заполнение первого столбца матрицы значениями y
            for (int i = 0; i < n; i++)
            {
                A[i, 0] = y[i];
            }

            // Вычисление разделенных разностей
            for (int j = 1; j < n; j++)
            {
                for (int i = 0; i < n - j; i++)
                {
                    A[i, j] = (A[i + 1, j - 1] - A[i, j - 1]) / (x[i + j] - x[i]);
                }
            }

            return A;
        }
        public static double Newton(double xx, double[] x, double[] y, double[,] A)
        {
            double result = A[0, 0];
            double temp = 1;

            for (int i = 1; i < x.Length; i++)
            {
                temp *= (xx - x[i - 1]);
                result += temp * A[0, i];
            }

            return result;
        }


        public static double Lagrange(double x, double[] X, double[] Y)
        {
            double lagrange = 0;

            for (int i = 0; i < X.Length; i++)
            {
                double Pol = 1;

                for (int j = 0; j < X.Length; j++)
                    if (j != i)
                        Pol *= (x - X[j]) / (X[i] - X[j]);

                lagrange += Pol * Y[i];
            }

            return lagrange;
        }

        public static void CalculateSplineCoefficients(double[] x, double[] y, out double[] a, out double[] b, out double[] c, out double[] d)
        {
            int n = x.Length;
            a = new double[n];
            b = new double[n];
            c = new double[n];
            d = new double[n];

            double[] h = new double[n - 1];
            double[] alpha = new double[n - 1];
            for (int i = 0; i < n - 1; i++)
            {
                h[i] = x[i + 1] - x[i];
                if (i > 0)
                    alpha[i] = (3 / h[i]) * (y[i + 1] - y[i]) - (3 / h[i - 1]) * (y[i] - y[i - 1]);
                else
                    alpha[i] = (3 / h[i]) * (y[i + 1] - y[i]);
            }

            double[] l = new double[n];
            double[] u = new double[n];
            double[] z = new double[n];
            l[0] = 1;
            u[0] = 0;
            z[0] = 0;

            for (int i = 1; i < n - 1; i++)
            {
                l[i] = 2 * (x[i + 1] - x[i - 1]) - h[i - 1] * u[i - 1];
                u[i] = h[i] / l[i];
                z[i] = (alpha[i] - h[i - 1] * z[i - 1]) / l[i];
            }

            l[n - 1] = 1;
            z[n - 1] = 0;
            c[n - 1] = 0;

            for (int j = n - 2; j >= 0; j--)
            {
                c[j] = z[j] - u[j] * c[j + 1];
                b[j] = (y[j + 1] - y[j]) / h[j] - h[j] * (c[j + 1] + 2 * c[j]) / 3;
                d[j] = (c[j + 1] - c[j]) / (3 * h[j]);
                a[j] = y[j];
            }
        }

        public static double Splain(double xx, double[] x, double[] a, double[] b, double[] c, double[] d)
        {
            int i = Array.BinarySearch(x, xx);
            if (i < 0)
                i = ~i - 1;
            double dx = xx - x[i];

            return a[i] + b[i] * dx + c[i] * dx * dx + d[i] * dx * dx * dx;
        }
    }
}
