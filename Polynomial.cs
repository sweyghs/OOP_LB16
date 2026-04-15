using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_5_oop
{
    internal class Polynomial
    {
        private double[] coefficients;
        private int degree;

        // Конструктор 1: за масивом коефіцієнтів
        public Polynomial(double[] coeffs)
        {
            if (coeffs == null || coeffs.Length == 0)
                throw new ArgumentException("Коефіцієнти не можуть бути порожніми");

            int lastNonZero = coeffs.Length - 1;
            while (lastNonZero > 0 && Math.Abs(coeffs[lastNonZero]) < 1e-10)
                lastNonZero--;

            coefficients = new double[lastNonZero + 1];
            Array.Copy(coeffs, coefficients, lastNonZero + 1);
            degree = lastNonZero;
        }

        // Конструктор 2: нульовий многочлен
        public Polynomial() : this(new double[] { 0 }) { }

        // Конструктор 3: копіювання
        public Polynomial(Polynomial other) : this(other.coefficients) { }

        // Властивості
        public int Degree => degree;
        public double[] Coefficients => (double[])coefficients.Clone();

        // Індексатор
        public double this[int index]
        {
            get
            {
                if (index < 0 || index > degree) return 0;
                return coefficients[index];
            }
        }

        // Метод Parse
        public static Polynomial Parse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Рядок не може бути порожнім");

            string[] parts = input.Trim().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            double[] coeffs = new double[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                if (!double.TryParse(parts[i], out double value))
                    throw new ArgumentException($"Неправильне число: {parts[i]}");
                coeffs[i] = value;
            }

            return new Polynomial(coeffs);
        }

        // Метод обчислення значення
        public double Evaluate(double x)
        {
            double result = 0;
            double power = 1;
            for (int i = 0; i <= degree; i++)
            {
                result += coefficients[i] * power;
                power *= x;
            }
            return result;
        }

        public double Evaluate(int x) => Evaluate((double)x);

        // Статичні методи для операцій
        public static Polynomial Add(Polynomial a, Polynomial b)
        {
            if (a == null) throw new ArgumentNullException(nameof(a));
            if (b == null) throw new ArgumentNullException(nameof(b));

            int maxDegree = Math.Max(a.degree, b.degree);
            double[] newCoeffs = new double[maxDegree + 1];

            for (int i = 0; i <= maxDegree; i++)
                newCoeffs[i] = a[i] + b[i];

            return new Polynomial(newCoeffs);
        }

        public static Polynomial Subtract(Polynomial a, Polynomial b)
        {
            if (a == null) throw new ArgumentNullException(nameof(a));
            if (b == null) throw new ArgumentNullException(nameof(b));

            int maxDegree = Math.Max(a.degree, b.degree);
            double[] newCoeffs = new double[maxDegree + 1];

            for (int i = 0; i <= maxDegree; i++)
                newCoeffs[i] = a[i] - b[i];

            return new Polynomial(newCoeffs);
        }

        public static Polynomial Multiply(Polynomial a, Polynomial b)
        {
            if (a == null) throw new ArgumentNullException(nameof(a));
            if (b == null) throw new ArgumentNullException(nameof(b));

            int newDegree = a.degree + b.degree;
            double[] newCoeffs = new double[newDegree + 1];

            for (int i = 0; i <= a.degree; i++)
                for (int j = 0; j <= b.degree; j++)
                    newCoeffs[i + j] += a[i] * b[j];

            return new Polynomial(newCoeffs);
        }

        // Перевантаження операторів +, -, *
        public static Polynomial operator +(Polynomial a, Polynomial b) => Add(a, b);
        public static Polynomial operator -(Polynomial a, Polynomial b) => Subtract(a, b);
        public static Polynomial operator *(Polynomial a, Polynomial b) => Multiply(a, b);

        // Перевантаження ToString()
        public override string ToString()
        {
            if (degree == 0) return $"{coefficients[0]}";

            StringBuilder result = new StringBuilder();
            for (int i = degree; i >= 0; i--)
            {
                double coeff = coefficients[i];
                if (Math.Abs(coeff) < 1e-10) continue;

                if (coeff > 0 && result.Length > 0)
                    result.Append("+");

                if (Math.Abs(coeff) != 1 || i == 0)
                    result.Append(coeff.ToString("0.##"));
                else if (coeff == -1)
                    result.Append("-");

                if (i == 1)
                    result.Append("x");
                else if (i > 1)
                    result.Append($"x^{i}");
            }
            return result.Length == 0 ? "0" : result.ToString();
        }

        // ⭐ ПОРІВНЯННЯ (виправлено) ⭐
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Polynomial))
                return false;

            Polynomial other = (Polynomial)obj;
            if (degree != other.degree) return false;

            for (int i = 0; i <= degree; i++)
                if (Math.Abs(coefficients[i] - other.coefficients[i]) > 1e-9)
                    return false;

            return true;
        }

        public override int GetHashCode()
        {
            return coefficients.GetHashCode();
        }

        public static bool operator ==(Polynomial left, Polynomial right)
        {
            if (ReferenceEquals(left, null) && ReferenceEquals(right, null)) return true;
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return false;
            return left.Equals(right);
        }

        public static bool operator !=(Polynomial left, Polynomial right)
        {
            return !(left == right);
        }
    }
}
