using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace tpr_1_Maybe
{
    public class Legend
    {
        public Color ItemColor { get; set; }
        public string Message { get; set; }
    }
    public class Model
    {
        public List<Strategy> strategies = new List<Strategy>();
        public int stages;
        public double[,] V;
        public double[,] Q;
        public int[,] D;

        public void calculate()
        {
            var N = strategies[0].N;
            
            // доходности
            Q = new double[strategies.Count, N];

            for (int str = 0; str < strategies.Count; str++)
            {
                for (int i = 0; i < N; i++)
                {
                    double q = 0;
                    for (int c = 0; c < N; c++)
                    {
                        q+= strategies[str].P[i,c] * strategies[str].R[i,c];
                    }

                    Q[str,i] = q;
                }
            }

            // полная ожидаемая доходность
            V = new double[N, stages+1];
            D = new int[N, stages+1];

            for (int stage = 0; stage <= stages; stage++)
            {
                for (int state = 0; state < N; state++)
                {
                    var result = profit(state, stage);

                    V[state, stage] = result.Item1;
                    D[state, stage] = result.Item2;
                }
            }


        }

        public (double, int) profit(int state, int stage)
        {
            if (stage == 0)
            {
                return (0, -1);
            }

            var list = new List<double>();
            for (int str = 0; str < strategies.Count; str++)
            {
                double v = Q[str, state];
                // c - перебор состояний
                for (int c = 0; c < strategies[0].N; c++)
                {
                    v += profit(c, stage - 1).Item1 * strategies[str].P[state,c]; 
                }
                list.Add(v);
            }

            double max = list.Max();
            return (max, list.IndexOf(max));
        }
    }
}
