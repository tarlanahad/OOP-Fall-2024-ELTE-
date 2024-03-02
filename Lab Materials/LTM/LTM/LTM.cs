using System;
namespace LTM_namespace
{
	public class LTM
	{
		private double[] V;
        private int size_V;
        private int size_M;



		public LTM(double[,] M)
		{
			this.size_M = M.GetLength(0);
			this.size_V = (size_M * (size_M + 1)) / 2;
			V = new double[size_V];

			for (int i = 0; i < size_M; i++)
				for (int j = 0; j <= i; j++)
					V[ind(i, j)] = M[i,j];

		}


		public double this[int i, int j]
		{
			get
			{
				if (i >= j) return V[ind(i, j)];
				return 0;
			}
			set
			{
                if (i >= j)  V[ind(i, j)] = value;
				throw new Exception();
            }
		}


		public override string ToString() {

			string s = "";

			for (int i = 0; i < size_M; i++)
			{
				for (int j = 0; j < size_M; j++)
				{
					s += (this[i,j] + " ");
				}
				s += "\n";
			}


			return s;

		}

		public static LTM operator+(LTM a, LTM b)
		{
			double[,] S = new double[a.size_M, a.size_M];

			for (int i = 0; i < a.size_M; i++)
				for (int j = 0; j < a.size_M; j++)	
					S[i, j] = (a[i, j] + b[i, j]);

			return new LTM(S);
		}

        public static LTM operator -(LTM a, LTM b)
        {
            double[,] S = new double[a.size_M, a.size_M];

            for (int i = 0; i < a.size_M; i++)
                for (int j = 0; j < a.size_M; j++)
                    S[i, j] = (a[i, j] - b[i, j]);

            return new LTM(S);
        }

        public static LTM operator *(LTM a, double k)
        {
            double[,] S = new double[a.size_M, a.size_M];

            for (int i = 0; i < a.size_M; i++)
                for (int j = 0; j < a.size_M; j++)
                    S[i, j] = (a[i, j] * k);

            return new LTM(S);
        }

        public static LTM operator*(LTM a, LTM b)
		{
			double[,] M = new double[a.size_M, a.size_M];

			for (int i = 0; i < a.size_M; i++)
			{
				for (int j = 0; j <=i; j++)
				{
					for (int k = 0; k <= i; k++)
					{
						M[i, j] += (a[i, k] * b[k, j]);
					}
				}
			}

			return new LTM(M);
		}

		private int ind(int i, int j)
		{
			return (i * (i + 1)) / 2 + j;
		}


	}
}

