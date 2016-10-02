
namespace Homework_by_Marin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Homework_by_Marin.VerAttribute;


    [Version(1,2)]

    public class Matrix<T> where T : struct,
                                        IComparable,
                                        IComparable<T>,
                                        IConvertible,
                                        IEquatable<T>,
                                        IFormattable
    {
        private int row;
        private int col;
        private T[,] matriks/* = new T[2,2]*/;

        // Constructor

        public Matrix(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.matriks = new T[this.Row, this.Col];
        }

        // Properties

        public int Row
        {
            get { return this.row; }
            set
            {
                if (this.row < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                this.row = value;
            }
        }

        public int Col
        {
            get { return this.col; }
            set
            {
                if (this.col < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                this.col = value;
            }
        }

        public T[,] Matriks
        {
            get
            {
                return this.matriks;
            }

            set
            {
                this.matriks = value;
            }
        }

        //indexer

        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row >= this.Row) &&
                    (col < 0 || col >= this.Col))
                {
                    throw new IndexOutOfRangeException();
                }
                return this.matriks[row, col];
            }
            set
            {
                if ((row < 0 || row >= this.Row) &&
                    (col < 0 || col >= this.Col))
                {
                    throw new IndexOutOfRangeException();
                }

                this.matriks[row, col] = value;
            }
        }

        // Overloading

        public static Matrix<T> operator +
            (Matrix<T> first, Matrix<T> second)
        {
            if (first.row != second.row &&
                first.col != second.col)
            {
                throw new ArgumentException();
            }

            else
            {
                Matrix<T> result = new Matrix<T>(first.row, first.col);
                for (int i = 0; i < first.row; i++)
                {
                    for (int j = 0; j < first.col; j++)
                    {
                        result[i, j] = (dynamic)first[i, j] + (dynamic)second[i, j];
                    }
                }
                return result;
            }
        }

        public static Matrix<T> operator -
           (Matrix<T> first, Matrix<T> second)
        {
            if (first.row != second.row &&
                first.col != second.col)
            {
                throw new ArgumentException();
            }

            else
            {
                Matrix<T> result = new Matrix<T>(first.row, first.col);
                for (int i = 0; i < first.row; i++)
                {
                    for (int j = 0; j < first.col; j++)
                    {
                        result[i, j] = (dynamic)first[i, j] - (dynamic)second[i, j];
                    }
                }
                return result;
            }
        }

        public static Matrix<T> operator *
           (Matrix<T> first, Matrix<T> second)
        {
            if (first.col != second.row)
            {
                throw new ArgumentException();
            }

            else
            {
                Matrix<T> result = new Matrix<T>(second.row, second.col);
                for (int i = 0; i < first.row; i++)
                {
                    for (int j = 0; j < second.col; j++)
                    {
                        for (int k = 0; k < second.row; k++)
                        {
                            result[i, j] += (dynamic)first[i, k] * (dynamic)second[k, j];
                        }
                    }
                }
                return result;
            }
        }

        public static bool operator true(Matrix<T> matriksBool)
        {
            bool result = true;
            for (int i = 0; i < matriksBool.row; i++)
            {
                for (int j = 0; j < matriksBool.col; j++)
                {
                    if ((dynamic)matriksBool[i, j] == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }

        public static bool operator false(Matrix<T> matriksBool)
        {
            bool result = true;
            for (int i = 0; i < matriksBool.row; i++)
            {
                for (int j = 0; j < matriksBool.col; j++)
                {
                    if ((dynamic)matriksBool[i, j] == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }
    }
}
