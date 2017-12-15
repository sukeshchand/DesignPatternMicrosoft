using System;

namespace BridgeTechWhizz
{
    public class Logger : ILogger
    {
        private static object mLock = new object();
        private static Logger mLogger;

        // the constructor. usually public, this time it is private to ensure 
        // no one except this class can use it.
        private Logger() {}

        // the public Instance property everyone uses to access the Logger
        public static Logger Instance
        {
            get
            {
                // If this is the first time we're referring to the
                // singleton object, the private variable will be null.
                if (mLogger == null)
                {
                    // for thread safety, lock an object when
                    // instantiating the new Logger object. This prevents
                    // other threads from performing the same block at the
                    // same time.
                    lock (mLock)
                    {
                        // Two or more threads might have found a null
                        // mLogger and are therefore trying to create a 
                        // new one. One thread will get to lock first, and
                        // the other one will wait until mLock is released.
                        // Once the second thread can get through, mLogger
                        // will have already been instantiated by the first
                        // thread so test the variable again. 
                        if (mLogger == null)
                        {
                            mLogger = new Logger();
                        }
                    }
                }
                return mLogger;
            }
        }
  

        public void LogEntry(string logData)
        {
            Console.WriteLine("Log Added at " + DateTime.Now.ToString("dd-MM-yyyy hh:mm ss tt") + " - " + logData );
        }
    }
}
