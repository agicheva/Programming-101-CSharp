using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigure
{
    class Vector
    {
        private double[] coordinates;

        public double this[int index]
        {
            get
            {
                return coordinates[index];
            }

            set
            {
                coordinates[index] = value;
            }
        }

        public Vector(params double[] coordinates)
        {
            this.coordinates = coordinates;
        }

        public Vector(Vector previousVector)
        {
            coordinates = new double[previousVector.coordinates.Length];

            for (int i = 0; i < coordinates.Length; i++)
            {
                coordinates[i] = previousVector.coordinates[i];
            }
        }

        public int Dimentionality
        {
            get
            {
                return coordinates.Length;
            }
        }

        public int GetLength()
        {
            double squareSum = 0;
            foreach (var coord in coordinates)
            {
                squareSum += Math.Pow(coord, 2);
            }

            return (int)Math.Sqrt(squareSum);
        }

        public override string ToString()
        {
            string format = string.Format("Vector[{0}]", string.Join(", ", coordinates));
            return format;
        }

        public override bool Equals(object obj)
        {
            Vector vector = (Vector)obj;

            if (coordinates.Length != vector.Dimentionality)
            {
                return false;
            }

            else
            {
                for (int i = 0; i < coordinates.Length; i++)
                {
                    if (coordinates[i] != vector.coordinates[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public static bool operator==(Vector first, Vector second)
        {
            return first.Equals(second);
        }

        public static bool operator!=(Vector first, Vector second)
        {
            return !first.Equals(second);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 9;
                foreach (var coord in coordinates)
                {
                    hash = hash * 5 + coordinates.GetHashCode();
                }

                return hash;
            }
        }

        public static Vector operator+(Vector first, Vector second)
        {
            double[] newVector = new double[first.Dimentionality];
            if (first.Dimentionality != second.Dimentionality)
            {
                throw new ArgumentException("Cannot sum vectors with different dimentions.");
            }

            else
            {
                for (int i = 0; i < first.Dimentionality; i++)
                {
                    newVector[i] = first.coordinates[i] + second.coordinates[i];
                }
                return new Vector(newVector);
            }
        }

        public static Vector operator-(Vector first, Vector second)
        {
            double[] newVector = new double[first.Dimentionality];
            if (first.Dimentionality != second.Dimentionality)
            {
                throw new ArgumentException("Cannot sum vectors with different dimentions.");
            }

            else
            {
                for (int i = 0; i < first.Dimentionality; i++)
                {
                    newVector[i] = first.coordinates[i] - second.coordinates[i];
                }
                return new Vector(newVector);
            }
        }

        public static Vector operator*(Vector first, Vector second)
        {
            double[] newVector = new double[first.Dimentionality];
            if (first.Dimentionality != second.Dimentionality)
            {
                throw new ArgumentException("Cannot sum vectors with different dimentions.");
            }

            else
            {
                for (int i = 0; i < first.Dimentionality; i++)
                {
                    newVector[i] = first.coordinates[i] * second.coordinates[i];
                }
                return new Vector(newVector);
            }
        }

        public static Vector operator /(Vector first, Vector second)
        {
            double[] newVector = new double[first.Dimentionality];
            if (first.Dimentionality != second.Dimentionality)
            {
                throw new ArgumentException("Cannot sum vectors with different dimentions.");
            }

            else
            {
                for (int i = 0; i < first.Dimentionality; i++)
                {
                    newVector[i] = first.coordinates[i] / second.coordinates[i];
                }
                return new Vector(newVector);
            }
        }

        public static Vector operator +(Vector vector, double number)
        {
            double[] newVector = new double[vector.Dimentionality];

            for (int i = 0; i < vector.Dimentionality; i++)
            {
                newVector[i] = vector.coordinates[i] + number;
            }
            return new Vector(newVector);
        }

        public static Vector operator -(Vector vector, double number)
        {
            double[] newVector = new double[vector.Dimentionality];

            for (int i = 0; i < vector.Dimentionality; i++)
            {
                newVector[i] = vector.coordinates[i] - number;
            }
            return new Vector(newVector);
        }

        public static Vector operator *(Vector vector, double number)
        {
            double[] newVector = new double[vector.Dimentionality];

            for (int i = 0; i < vector.Dimentionality; i++)
            {
                newVector[i] = vector.coordinates[i] * number;
            }
            return new Vector(newVector);
        }

        public static Vector operator /(Vector vector, double number)
        {
            double[] newVector = new double[vector.Dimentionality];

            for (int i = 0; i < vector.Dimentionality; i++)
            {
                newVector[i] = vector.coordinates[i] / number;
            }
            return new Vector(newVector);
        }
    }
}
