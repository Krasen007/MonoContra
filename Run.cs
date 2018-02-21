﻿namespace Start
{
    using System;
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Run
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            using (var game = new EntryPoint())
            {
                game.Run();
            }
        }
    }
#endif
}