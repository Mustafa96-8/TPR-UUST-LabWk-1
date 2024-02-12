namespace tpr_1_Maybe
{

    public class Strategy
    {
        public double[,] R;
        public double[,] P;
        public int N;

        public Strategy(double[,] R, double[,] P, int N)
        {
            this.P = P;
            this.R = R;
            this.N = N;
        }
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}