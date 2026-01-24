namespace Restaurant;

internal static class Program

{

    /// <summary>

    /// By: Pacharachon Gaewpusri ID:569

    /// </summary>

    [STAThread]

    static void Main(string[] args)

    {

        ApplicationConfiguration.Initialize();
        if (args.Length > 0 && args[0].ToLower() == "-k")

            Application.Run(new KitchenForm());

        else

            Application.Run(new WaiterForm());

    }

}