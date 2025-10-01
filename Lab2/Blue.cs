using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;
            // code here
            double denom = 1;
            for (int counter = 1; counter <= n; counter++)
            {
                answer += Math.Sin(counter * x) / denom;
                denom *= x;
            }    
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double nomin = 1;
            double denom = 1;
            for (int i = 1; i <= n; i++)
            {
                nomin *= 5;
                denom *= i;
                if (i % 2 != 0)
                {
                    answer -= (nomin / denom);
                } else if (i % 2 == 0)
                {
                    answer += (nomin / denom);
                }
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0, a1 = 0, a2 = 1;
            // code here
            for (int i = 1; i <= n; i++)
            {
                answer += a1;
                long step = a1 + a2;
                a1 = a2;
                a2 = step;
            }

            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0, n = 0;
            int temp = 0;
            // code here
            while (answer <= L)
            {
                answer += (a + n * h);
                temp = n;
                n++;
                
            }
            answer = temp;

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1;
            double elem = ch / zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            } while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            int temp = 0;
            while (S <= L)
            {
                S *= 2;
                temp += h;
                answer = temp;

            }
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;


            // code here
            double tempS = S;
            for (int i = 1; i <= 7; i++)
            {
                a += S;
                S += (S * (I / 100.0));
            }
            S = tempS;
            double total = 0;
            while (total <= 100)
            {
                total += S;
                S += (S * (I / 100));
                b += 1;
            }
            S = tempS;
            while (S <= 42)
            {
                c += 1;
                S += (S * (I / 100));

            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + 1e-9; x += h)
            {
                double s = 0;
                double i = 0;
                double step = 1;
                double fact = 1;
                double pow = 1;
                while (Math.Abs(step) >= E)
                {
                    step = (2 * i + 1) * pow / fact;
                    s += step;
                    i += 1;
                    fact *= i;
                    pow *= x * x;

                }
                double y = (1 + 2 * x * x) * Math.Exp(x * x);
                SS += s;
                SY += y;
            }
            // end

            return (SS, SY);
        }

    }
    
}