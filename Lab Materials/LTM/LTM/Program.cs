using TextFile;

namespace LTM_namespace
{
    public class LTM_project
    {
        public static double[,] text2mat(string path)
        {


            TextFileReader reader = new TextFileReader(path);

            reader.ReadInt(out int N);

            double[,] data = new double[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    reader.ReadDouble(out double el);
                    data[i, j] = el;
                }
            }

            return data;

        }

        public static void Main()
        {

            double[,] ltm1 = text2mat("/Users/tarlanahadli/Documents/Projects/LTM/LTM/ltm1.txt");
            double[,] ltm2 = text2mat("/Users/tarlanahadli/Documents/Projects/LTM/LTM/ltm2.txt");

            LTM ltm_a = new LTM(ltm1);
            LTM ltm_b = new LTM(ltm2);

            Console.WriteLine(ltm_a*ltm_b);
            Console.WriteLine("\n");
            Console.WriteLine(ltm_a + ltm_b);
        }
    }
}

